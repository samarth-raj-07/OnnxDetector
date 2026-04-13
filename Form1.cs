using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;

namespace OnnxDetectorApp
{
    public partial class Form1 : Form
    {
        // ── State ──────────────────────────────────────────────────────────
        private string _modelPath = "";
        private string _imagePath = "";
        private string _saveFolder = "";
        private string _position = "Left";
        private float _scoreThreshold = 0.5f;

        // ── Constructor ────────────────────────────────────────────────────
        public Form1()
        {
            InitializeComponent();
            WireEvents();
        }

        // ──────────────────────────────────────────────────────────────────
        // Wire up all event handlers after Designer init
        // ──────────────────────────────────────────────────────────────────
        private void WireEvents()
        {
            // Header buttons
            btnClose.Click += (s, e) => Application.Exit();
            btnClearView.Click += BtnClearView_Click;

            // Settings buttons
            btnModel.Click += BtnModel_Click;
            btnPosition.Click += BtnPosition_Click;
            btnTestImage.Click += BtnTestImage_Click;
            btnSaveFolder.Click += BtnSaveFolder_Click;
            txtPosition.TextChanged += (s, e) => _position = txtPosition.Text.Trim();

            // Threshold slider
            trkThreshold.ValueChanged += (s, e) =>
            {
                _scoreThreshold = trkThreshold.Value / 100f;
                lblThresholdValue.Text = _scoreThreshold.ToString("F2");
            };

            // Run buttons
            btnRun.Click += BtnRun_Click;
            btnAiExec.Click += BtnRun_Click;

            // Align mark preview paint
            picAlignPreview.Paint += PicAlignPreview_Paint;

            // Image panel watermarks
            picLeftFull.Paint += (s, e) => DrawWatermark(picLeftFull, e.Graphics);
            picRightFull.Paint += (s, e) => DrawWatermark(picRightFull, e.Graphics);
            picLeftCrop.Paint += (s, e) => DrawWatermark(picLeftCrop, e.Graphics);
            picRightCrop.Paint += (s, e) => DrawWatermark(picRightCrop, e.Graphics);

            // Settings panel border
            pnlSettingsBorder.Paint += (s, e) =>
            {
                using var pen = new Pen(Color.FromArgb(200, 200, 200), 1);
                e.Graphics.DrawRectangle(pen, 0, 0,
                    pnlSettingsBorder.Width - 1, pnlSettingsBorder.Height - 1);
            };

            // Clock timer
            timerClock.Tick += (s, e) =>
                lblTimestamp.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy  HH:mm:ss");
            timerClock.Start();
            lblTimestamp.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy  HH:mm:ss");
        }

        // ──────────────────────────────────────────────────────────────────
        // Paint handlers
        // ──────────────────────────────────────────────────────────────────
        private void PicAlignPreview_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillEllipse(Brushes.Red, 46, 31, 8, 8);
            g.DrawString("(Xc, Yc)", new Font("Segoe UI", 6f), Brushes.DarkRed, 18, 41);
            g.DrawString("(Xmin,Ymin)", new Font("Segoe UI", 5.5f), Brushes.Black, 1, 1);
            g.DrawString("(Xmax,Ymax)", new Font("Segoe UI", 5.5f), Brushes.Black, 46, 62);
        }

        private void DrawWatermark(PictureBox pic, Graphics g)
        {
            if (pic.Image != null) return;
            using var fnt = new Font("Segoe UI", 22f, FontStyle.Bold);
            using var brush = new SolidBrush(Color.FromArgb(45, 0, 0, 0));
            var sz = g.MeasureString("No Image", fnt);
            g.DrawString("No Image", fnt, brush,
                (pic.Width - sz.Width) / 2f,
                (pic.Height - sz.Height) / 2f);
        }

        // ──────────────────────────────────────────────────────────────────
        // Button Handlers
        // ──────────────────────────────────────────────────────────────────
        private void BtnModel_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog
            {
                Title = "Select ONNX Model",
                Filter = "ONNX Model (*.onnx)|*.onnx|All Files (*.*)|*.*"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _modelPath = dlg.FileName;
                txtModel.Text = Path.GetFileName(_modelPath);
                SetStatus($"Model loaded: {txtModel.Text}", Color.LightGreen);
            }
        }

        private void BtnPosition_Click(object sender, EventArgs e)
        {
            _position = _position == "Left" ? "Right" : "Left";
            txtPosition.Text = _position;
        }

        private void BtnTestImage_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog
            {
                Title = "Select Test Image",
                Filter = "Images (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp|All Files (*.*)|*.*"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _imagePath = dlg.FileName;
                txtTestImage.Text = Path.GetFileName(_imagePath);
                LoadImageToPanel();
            }
        }

        private void BtnSaveFolder_Click(object sender, EventArgs e)
        {
            using var dlg = new FolderBrowserDialog
            {
                Description = "Select Save / Log Folder"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _saveFolder = dlg.SelectedPath;
                txtSaveFolder.Text = _saveFolder;
            }
        }

        private void BtnClearView_Click(object sender, EventArgs e)
        {
            picLeftFull.Image = null;  picLeftFull.Invalidate();
            picRightFull.Image = null; picRightFull.Invalidate();
            picLeftCrop.Image = null;  picLeftCrop.Invalidate();
            picRightCrop.Image = null; picRightCrop.Invalidate();
            lblLeftXY.Text  = "Left X Position\r\nLeft Y Position";
            lblRightXY.Text = "Right X Position\r\nRight Y Position";
            dgvEvents.Rows.Clear();
            SetStatus("View cleared.", Color.Silver);
        }

        private async void BtnRun_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_modelPath)) { Warn("Please select an ONNX model first."); return; }
            if (string.IsNullOrEmpty(_imagePath)) { Warn("Please select a test image first."); return; }

            SetStatus("Running inference…", Color.Yellow);
            btnRun.Enabled = false;
            btnAiExec.Enabled = false;

            try
            {
                var sw = System.Diagnostics.Stopwatch.StartNew();

                var (results, annotated, crop) = await System.Threading.Tasks.Task.Run(() =>
                    RunInference(_imagePath, _modelPath, _scoreThreshold));

                sw.Stop();
                string runTime = $"{sw.ElapsedMilliseconds} ms";

                var targetPic  = _position == "Left" ? picLeftFull  : picRightFull;
                var targetCrop = _position == "Left" ? picLeftCrop   : picRightCrop;
                var targetXY   = _position == "Left" ? lblLeftXY     : lblRightXY;

                targetPic.Image?.Dispose();
                targetPic.Image = annotated;
                targetCrop.Image?.Dispose();
                targetCrop.Image = crop;

                if (results.Count > 0)
                {
                    // Read a/b from UI — which side's values to use
                    float a = TryParseAB(_position == "Left" ? txtLeftA.Text : txtRightA.Text);
                    float b = TryParseAB(_position == "Left" ? txtLeftB.Text : txtRightB.Text);

                    var r = results[0];
                    float xc = r.ComputeXc(a);
                    float yc = r.ComputeYc(b);
                    targetXY.Text = $"{_position} X: {xc:F1}\r\n{_position} Y: {yc:F1}";

                    foreach (var det in results)
                    {
                        float detXc = det.ComputeXc(a);
                        float detYc = det.ComputeYc(b);

                        string savePath = "";
                        if (!string.IsNullOrEmpty(_saveFolder))
                        {
                            savePath = Path.Combine(_saveFolder,
                                $"det_{_position}_{DateTime.Now:yyyyMMdd_HHmmss}.jpg");
                            annotated.Save(savePath,
                                System.Drawing.Imaging.ImageFormat.Jpeg);
                        }

                        dgvEvents.Rows.Add(
                            Path.GetFileName(_imagePath),
                            DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                            runTime,
                            _position,
                            $"{det.Xmin:F0}", $"{det.Ymin:F0}",
                            $"{det.Xmax:F0}", $"{det.Ymax:F0}",
                            $"{detXc:F1}",   $"{detYc:F1}",
                            $"{det.Score:F3}",
                            savePath
                        );
                    }

                    SetStatus(
                        $"Detected {results.Count} mark(s)  |  Score: {results[0].Score:F3}  |  Time: {runTime}",
                        Color.LightGreen);
                }
                else
                {
                    targetXY.Text = $"{_position} X: —\r\n{_position} Y: —";
                    SetStatus("No marks detected above threshold.", Color.Orange);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Inference error:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetStatus("Error during inference.", Color.OrangeRed);
            }
            finally
            {
                btnRun.Enabled    = true;
                btnAiExec.Enabled = true;
            }
        }

        // ──────────────────────────────────────────────────────────────────
        // ONNX Inference  (YOLOv5 standard export)
        // ──────────────────────────────────────────────────────────────────
        private (List<DetectionResult> results, Bitmap annotated, Bitmap crop)
            RunInference(string imagePath, string modelPath, float threshold)
        {
            const int inputW = 640;
            const int inputH = 640;

            using var origBmp = new Bitmap(imagePath);
            int origW = origBmp.Width, origH = origBmp.Height;

            // Resize to model input size
            using var resized = new Bitmap(inputW, inputH);
            using (var g = Graphics.FromImage(resized))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(origBmp, 0, 0, inputW, inputH);
            }

            // Build float tensor [1, 3, H, W]  RGB 0-1
            var tensor = new DenseTensor<float>(new[] { 1, 3, inputH, inputW });
            for (int y = 0; y < inputH; y++)
                for (int x = 0; x < inputW; x++)
                {
                    var px = resized.GetPixel(x, y);
                    tensor[0, 0, y, x] = px.R / 255f;
                    tensor[0, 1, y, x] = px.G / 255f;
                    tensor[0, 2, y, x] = px.B / 255f;
                }

            var inputs = new List<NamedOnnxValue>
            {
                NamedOnnxValue.CreateFromTensor("images", tensor)
            };

            using var session = new InferenceSession(modelPath);
            using var outputs = session.Run(inputs);

            // YOLOv5 output: [1, num_boxes, 85]
            var output   = outputs.First().AsTensor<float>();
            int numBoxes = output.Dimensions[1];
            int stride   = output.Dimensions[2];

            var results = new List<DetectionResult>();

            for (int i = 0; i < numBoxes; i++)
            {
                float objConf = output[0, i, 4];
                if (objConf < threshold) continue;

                float maxClassScore = 0f;
                for (int c = 5; c < stride; c++)
                    if (output[0, i, c] > maxClassScore)
                        maxClassScore = output[0, i, c];

                float score = objConf * maxClassScore;
                if (score < threshold) continue;

                float cx = output[0, i, 0];
                float cy = output[0, i, 1];
                float bw = output[0, i, 2];
                float bh = output[0, i, 3];

                // Scale back to original resolution
                float xmin = (cx - bw / 2f) / inputW * origW;
                float ymin = (cy - bh / 2f) / inputH * origH;
                float xmax = (cx + bw / 2f) / inputW * origW;
                float ymax = (cy + bh / 2f) / inputH * origH;

                results.Add(new DetectionResult
                {
                    Xmin = xmin, Ymin = ymin,
                    Xmax = xmax, Ymax = ymax,
                    Score = score
                });
            }

            results = NonMaxSuppression(results, iouThreshold: 0.45f);

            // Draw detections on a copy of the original
            var annotated = new Bitmap(origBmp);
            using (var g = Graphics.FromImage(annotated))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                foreach (var r in results)
                {
                    using var boxPen = new Pen(Color.FromArgb(0, 210, 100), 2);
                    g.DrawRectangle(boxPen,
                        r.Xmin, r.Ymin,
                        r.Xmax - r.Xmin, r.Ymax - r.Ymin);

                    // Centre dot
                    g.FillEllipse(Brushes.Red, r.Xc - 5, r.Yc - 5, 10, 10);

                    // Score label
                    using var fnt = new Font("Segoe UI", 9f, FontStyle.Bold);
                    using var bg  = new SolidBrush(Color.FromArgb(160, 0, 0, 0));
                    var labelRect = new RectangleF(r.Xmin, r.Ymin - 18, 60, 18);
                    g.FillRectangle(bg, labelRect);
                    g.DrawString($"{r.Score:F2}", fnt, Brushes.Yellow, r.Xmin + 2, r.Ymin - 17);
                }
            }

            // Crop around first detection
            Bitmap crop;
            if (results.Count > 0)
            {
                var r0  = results[0];
                int pad = 20;
                int rx  = Math.Max(0, (int)r0.Xmin - pad);
                int ry  = Math.Max(0, (int)r0.Ymin - pad);
                int rw  = Math.Min(origW - rx, (int)(r0.Xmax - r0.Xmin) + pad * 2);
                int rh  = Math.Min(origH - ry, (int)(r0.Ymax - r0.Ymin) + pad * 2);
                crop = origBmp.Clone(new Rectangle(rx, ry, rw, rh), origBmp.PixelFormat);
            }
            else
            {
                crop = new Bitmap(200, 200);
                using var g = Graphics.FromImage(crop);
                g.Clear(Color.FromArgb(200, 200, 200));
            }

            return (results, annotated, crop);
        }

        // ──────────────────────────────────────────────────────────────────
        // NMS
        // ──────────────────────────────────────────────────────────────────
        private static List<DetectionResult> NonMaxSuppression(
            List<DetectionResult> boxes, float iouThreshold)
        {
            var sorted = boxes.OrderByDescending(b => b.Score).ToList();
            var kept   = new List<DetectionResult>();
            while (sorted.Count > 0)
            {
                var best = sorted[0];
                kept.Add(best);
                sorted.RemoveAt(0);
                sorted = sorted.Where(b => IoU(best, b) < iouThreshold).ToList();
            }
            return kept;
        }

        private static float IoU(DetectionResult a, DetectionResult b)
        {
            float ix    = Math.Max(0, Math.Min(a.Xmax, b.Xmax) - Math.Max(a.Xmin, b.Xmin));
            float iy    = Math.Max(0, Math.Min(a.Ymax, b.Ymax) - Math.Max(a.Ymin, b.Ymin));
            float inter = ix * iy;
            float aArea = (a.Xmax - a.Xmin) * (a.Ymax - a.Ymin);
            float bArea = (b.Xmax - b.Xmin) * (b.Ymax - b.Ymin);
            return inter / (aArea + bArea - inter + 1e-6f);
        }

        // ──────────────────────────────────────────────────────────────────
        // Helpers
        // ──────────────────────────────────────────────────────────────────
        private void LoadImageToPanel()
        {
            try
            {
                var bmp = new Bitmap(_imagePath);
                if (_position == "Left")
                {
                    picLeftFull.Image?.Dispose();
                    picLeftFull.Image = bmp;
                }
                else
                {
                    picRightFull.Image?.Dispose();
                    picRightFull.Image = bmp;
                }
            }
            catch { Warn("Could not load image."); }
        }

        // Safely parse a/b — clamp to [0,1], default 0.5
        private static float TryParseAB(string text)
        {
            if (float.TryParse(text, System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture, out float v))
                return Math.Clamp(v, 0f, 1f);
            return 0.5f;
        }

        private void SetStatus(string msg, Color color)
        {
            lblStatus.Text      = msg;
            lblStatus.ForeColor = color;
        }

        private void Warn(string msg) =>
            MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    // ──────────────────────────────────────────────────────────────────────
    // Detection result model
    // ──────────────────────────────────────────────────────────────────────
    public class DetectionResult
    {
        public float Xmin, Ymin, Xmax, Ymax, Score;

        // a=0.5 → centre X,  a=0 → left edge,  a=1 → right edge
        // b=0.5 → centre Y,  b=0 → top edge,   b=1 → bottom edge
        public float ComputeXc(float a) => (1f - a) * Xmin + a * Xmax;
        public float ComputeYc(float b) => (1f - b) * Ymin + b * Ymax;

        // Default centre (used for drawing the dot on the image)
        public float Xc => ComputeXc(0.5f);
        public float Yc => ComputeYc(0.5f);
    }
}
