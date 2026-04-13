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
        private string _leftImagePath = "";
        private string _rightImagePath = "";
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
        // Wire Events
        // ──────────────────────────────────────────────────────────────────
        private void WireEvents()
        {
            btnClose.Click += (s, e) => Application.Exit();
            btnClearView.Click += BtnClearView_Click;
            btnModel.Click += BtnModel_Click;
            btnPosition.Click += BtnPosition_Click;
            btnTestImage.Click += BtnTestImage_Click;
            btnSaveFolder.Click += BtnSaveFolder_Click;

            txtPosition.TextChanged += (s, e) => _position = txtPosition.Text.Trim();

            trkThreshold.ValueChanged += (s, e) =>
            {
                _scoreThreshold = trkThreshold.Value / 100f;
                lblThresholdValue.Text = _scoreThreshold.ToString("F2");
            };

            // Run Detection = active position only
            btnRun.Click += BtnRun_Click;
            // AI Exec = both Left then Right, sequentially
            btnAiExec.Click += BtnAiExec_Click;

            picAlignPreview.Paint += PicAlignPreview_Paint;
            picLeftFull.Paint += (s, e) => DrawWatermark(picLeftFull, e.Graphics);
            picRightFull.Paint += (s, e) => DrawWatermark(picRightFull, e.Graphics);
            picLeftCrop.Paint += (s, e) => DrawWatermark(picLeftCrop, e.Graphics);
            picRightCrop.Paint += (s, e) => DrawWatermark(picRightCrop, e.Graphics);

            pnlSettingsBorder.Paint += (s, e) =>
            {
                using var pen = new Pen(Color.FromArgb(200, 200, 200), 1);
                e.Graphics.DrawRectangle(pen, 0, 0,
                    pnlSettingsBorder.Width - 1, pnlSettingsBorder.Height - 1);
            };

            timerClock.Tick += (s, e) =>
                lblTimestamp.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy  HH:mm:ss");
            timerClock.Start();
            lblTimestamp.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy  HH:mm:ss");
        }

        // ──────────────────────────────────────────────────────────────────
        // Paint
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
            using var fnt = new Font("Segoe UI", 18f, FontStyle.Bold);
            using var brush = new SolidBrush(Color.FromArgb(50, 0, 0, 0));
            var sz = g.MeasureString("No Image", fnt);
            g.DrawString("No Image", fnt, brush,
                (pic.Width - sz.Width) / 2f,
                (pic.Height - sz.Height) / 2f);
        }

        // ──────────────────────────────────────────────────────────────────
        // Settings
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
            // Show the stored filename for the active side
            txtTestImage.Text = Path.GetFileName(
                _position == "Left" ? _leftImagePath : _rightImagePath);
        }

        private void BtnTestImage_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog
            {
                Title = "Select Test Image",
                Filter = "Images (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp|All Files (*.*)|*.*"
            };
            if (dlg.ShowDialog() != DialogResult.OK) return;

            string path = dlg.FileName;

            // Store to the correct side
            if (_position == "Left") _leftImagePath = path;
            else _rightImagePath = path;

            txtTestImage.Text = Path.GetFileName(path);
            LoadRawImageToPanel(_position, path);
            SetStatus($"{_position} image loaded: {Path.GetFileName(path)}", Color.LightGreen);
        }

        private void BtnSaveFolder_Click(object sender, EventArgs e)
        {
            using var dlg = new FolderBrowserDialog
            { Description = "Select Save / Log Folder" };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _saveFolder = dlg.SelectedPath;
                txtSaveFolder.Text = _saveFolder;
            }
        }

        private void BtnClearView_Click(object sender, EventArgs e)
        {
            ClearPictureBox(picLeftFull);
            ClearPictureBox(picRightFull);
            ClearPictureBox(picLeftCrop);
            ClearPictureBox(picRightCrop);

            _leftImagePath = "";
            _rightImagePath = "";
            txtTestImage.Text = "";

            lblLeftXY.Text = "Left X Position\r\nLeft Y Position";
            lblRightXY.Text = "Right X Position\r\nRight Y Position";
            dgvEvents.Rows.Clear();
            SetStatus("View cleared.", Color.Silver);
        }

        // ──────────────────────────────────────────────────────────────────
        // Run Detection — active position only
        // ──────────────────────────────────────────────────────────────────
        private async void BtnRun_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_modelPath))
            { Warn("Please select an ONNX model first."); return; }

            string imgPath = _position == "Left" ? _leftImagePath : _rightImagePath;
            if (string.IsNullOrEmpty(imgPath))
            { Warn($"Please load a {_position} image first."); return; }

            float a = TryParseAB(_position == "Left" ? txtLeftA.Text : txtRightA.Text);
            float b = TryParseAB(_position == "Left" ? txtLeftB.Text : txtRightB.Text);

            SetStatus($"Running [{_position}]  a={a:F2}  b={b:F2}…", Color.Yellow);
            SetButtonsEnabled(false);

            try
            {
                var sw = System.Diagnostics.Stopwatch.StartNew();

                DetectionResult[] results = null;
                Bitmap annotated = null, crop = null;

                await System.Threading.Tasks.Task.Run(() =>
                {
                    (var r, var ann, var cr) = RunInference(imgPath, _modelPath, _scoreThreshold, a, b);
                    results = r.ToArray();
                    annotated = ann;
                    crop = cr;
                });

                sw.Stop();
                string runTime = $"{sw.ElapsedMilliseconds} ms";

                ApplyResultsToUI(_position, results.ToList(), annotated, crop,
                    a, b, imgPath, runTime);

                SetStatus(results.Length > 0
                    ? $"[{_position}] {results.Length} mark(s)  Xc={results[0].ComputeXc(a):F1}  " +
                      $"Yc={results[0].ComputeYc(b):F1}  Score={results[0].Score:F3}  {runTime}"
                    : $"[{_position}] No marks detected above threshold.",
                    results.Length > 0 ? Color.LightGreen : Color.Orange);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Inference error:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetStatus("Error during inference.", Color.OrangeRed);
            }
            finally { SetButtonsEnabled(true); }
        }

        // ──────────────────────────────────────────────────────────────────
        // AI Exec — Left THEN Right, sequentially (avoids ONNX race conditions)
        // ──────────────────────────────────────────────────────────────────
        private async void BtnAiExec_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_modelPath))
            { Warn("Please select an ONNX model first."); return; }

            bool hasLeft = !string.IsNullOrEmpty(_leftImagePath);
            bool hasRight = !string.IsNullOrEmpty(_rightImagePath);

            if (!hasLeft && !hasRight)
            { Warn("Please load at least one image (Left or Right) first."); return; }

            float aL = TryParseAB(txtLeftA.Text);
            float bL = TryParseAB(txtLeftB.Text);
            float aR = TryParseAB(txtRightA.Text);
            float bR = TryParseAB(txtRightB.Text);

            SetStatus("AI Exec — processing both sides…", Color.Yellow);
            SetButtonsEnabled(false);

            int totalDetections = 0;
            var sw = System.Diagnostics.Stopwatch.StartNew();

            try
            {
                // ── Step 1: Left ─────────────────────────────────────────
                if (hasLeft)
                {
                    SetStatus($"AI Exec — running Left  (a={aL:F2}, b={bL:F2})…", Color.Yellow);

                    DetectionResult[] rL = null;
                    Bitmap annL = null, cropL = null;

                    await System.Threading.Tasks.Task.Run(() =>
                    {
                        (var r, var a2, var c) = RunInference(
                            _leftImagePath, _modelPath, _scoreThreshold, aL, bL);
                        rL = r.ToArray();
                        annL = a2;
                        cropL = c;
                    });

                    // Apply Left results — UI thread
                    ApplyResultsToUI("Left", rL.ToList(), annL, cropL,
                        aL, bL, _leftImagePath, $"{sw.ElapsedMilliseconds} ms");
                    totalDetections += rL.Length;
                }

                // ── Step 2: Right ────────────────────────────────────────
                if (hasRight)
                {
                    SetStatus($"AI Exec — running Right  (a={aR:F2}, b={bR:F2})…", Color.Yellow);

                    DetectionResult[] rR = null;
                    Bitmap annR = null, cropR = null;

                    await System.Threading.Tasks.Task.Run(() =>
                    {
                        (var r, var a2, var c) = RunInference(
                            _rightImagePath, _modelPath, _scoreThreshold, aR, bR);
                        rR = r.ToArray();
                        annR = a2;
                        cropR = c;
                    });

                    // Apply Right results — UI thread
                    ApplyResultsToUI("Right", rR.ToList(), annR, cropR,
                        aR, bR, _rightImagePath, $"{sw.ElapsedMilliseconds} ms");
                    totalDetections += rR.Length;
                }

                sw.Stop();
                SetStatus(
                    $"AI Exec complete — {totalDetections} total detection(s) | {sw.ElapsedMilliseconds} ms",
                    Color.LightGreen);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"AI Exec error:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetStatus("AI Exec error.", Color.OrangeRed);
            }
            finally { SetButtonsEnabled(true); }
        }

        // ──────────────────────────────────────────────────────────────────
        // Apply results to the correct panels
        // Clear image first, then assign — prevents ghost/superimposition
        // ──────────────────────────────────────────────────────────────────
        private void ApplyResultsToUI(string position,
            List<DetectionResult> results,
            Bitmap annotated, Bitmap crop,
            float a, float b,
            string imagePath, string runTime)
        {
            bool isLeft = position == "Left";
            var targetFull = isLeft ? picLeftFull : picRightFull;
            var targetCrop = isLeft ? picLeftCrop : picRightCrop;
            var targetXY = isLeft ? lblLeftXY : lblRightXY;

            // Clear old images completely before setting new ones
            ClearPictureBox(targetFull);
            ClearPictureBox(targetCrop);

            // Now assign the new bitmaps
            targetFull.Image = annotated;
            targetCrop.Image = crop;

            if (results.Count > 0)
            {
                float xc = results[0].ComputeXc(a);
                float yc = results[0].ComputeYc(b);
                targetXY.Text = $"{position} X: {xc:F1}\r\n{position} Y: {yc:F1}";

                foreach (var det in results)
                {
                    string savePath = "";
                    if (!string.IsNullOrEmpty(_saveFolder))
                    {
                        savePath = Path.Combine(_saveFolder,
                            $"det_{position}_{DateTime.Now:yyyyMMdd_HHmmss_fff}.jpg");
                        annotated.Save(savePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }

                    dgvEvents.Rows.Add(
                        Path.GetFileName(imagePath),
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        runTime, position,
                        $"{det.Xmin:F0}", $"{det.Ymin:F0}",
                        $"{det.Xmax:F0}", $"{det.Ymax:F0}",
                        $"{det.ComputeXc(a):F1}", $"{det.ComputeYc(b):F1}",
                        $"{det.Score:F3}", savePath);
                }
            }
            else
            {
                targetXY.Text = $"{position} X: —\r\n{position} Y: —";
            }
        }

        // ──────────────────────────────────────────────────────────────────
        // Clear a PictureBox safely — null first, force repaint, then dispose
        // ──────────────────────────────────────────────────────────────────
        private static void ClearPictureBox(PictureBox pic)
        {
            var old = pic.Image;
            pic.Image = null;
            pic.Invalidate();
            pic.Update();          // force immediate repaint with no image
            old?.Dispose();
        }

        // ──────────────────────────────────────────────────────────────────
        // ONNX Inference
        // ──────────────────────────────────────────────────────────────────
        private (List<DetectionResult> results, Bitmap annotated, Bitmap crop)
            RunInference(string imagePath, string modelPath,
                         float threshold, float a, float b)
        {
            const int inputW = 640, inputH = 640;

            // Load original — keep alive until annotated is fully drawn
            var origBmp = new Bitmap(imagePath);
            int origW = origBmp.Width;
            int origH = origBmp.Height;

            // Resize to model input
            using var resized = new Bitmap(inputW, inputH);
            using (var g = Graphics.FromImage(resized))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(origBmp, 0, 0, inputW, inputH);
            }

            // Build float tensor [1, 3, H, W]
            var tensor = new DenseTensor<float>(new[] { 1, 3, inputH, inputW });
            for (int y = 0; y < inputH; y++)
                for (int x = 0; x < inputW; x++)
                {
                    var px = resized.GetPixel(x, y);
                    tensor[0, 0, y, x] = px.R / 255f;
                    tensor[0, 1, y, x] = px.G / 255f;
                    tensor[0, 2, y, x] = px.B / 255f;
                }

            // Run ONNX
            using var session = new InferenceSession(modelPath);
            using var outputs = session.Run(new List<NamedOnnxValue>
            {
                NamedOnnxValue.CreateFromTensor("images", tensor)
            });

            var output = outputs.First().AsTensor<float>();
            int numBoxes = output.Dimensions[1];
            int stride = output.Dimensions[2];
            var results = new List<DetectionResult>();

            for (int i = 0; i < numBoxes; i++)
            {
                float conf = output[0, i, 4];
                if (conf < threshold) continue;

                float maxCls = 0f;
                for (int c = 5; c < stride; c++)
                    if (output[0, i, c] > maxCls) maxCls = output[0, i, c];

                float score = conf * maxCls;
                if (score < threshold) continue;

                float cx = output[0, i, 0], cy = output[0, i, 1];
                float bw = output[0, i, 2], bh = output[0, i, 3];

                results.Add(new DetectionResult
                {
                    Xmin = (cx - bw / 2f) / inputW * origW,
                    Ymin = (cy - bh / 2f) / inputH * origH,
                    Xmax = (cx + bw / 2f) / inputW * origW,
                    Ymax = (cy + bh / 2f) / inputH * origH,
                    Score = score
                });
            }

            results = NonMaxSuppression(results, 0.45f);

            // ── Draw annotations ──────────────────────────────────────────
            // Create annotated INDEPENDENTLY from origBmp
            var annotated = new Bitmap(origBmp);
            origBmp.Dispose(); // safe to dispose now — annotated is a separate copy

            using (var g = Graphics.FromImage(annotated))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                foreach (var r in results)
                {
                    // Green bounding box
                    using var boxPen = new Pen(Color.FromArgb(0, 220, 80), 2);
                    g.DrawRectangle(boxPen, r.Xmin, r.Ymin,
                        r.Xmax - r.Xmin, r.Ymax - r.Ymin);

                    // Red dot at computed Xc, Yc using a/b values
                    float xc = r.ComputeXc(a);
                    float yc = r.ComputeYc(b);
                    g.FillEllipse(Brushes.Red, xc - 6, yc - 6, 12, 12);
                    g.DrawEllipse(Pens.White, xc - 6, yc - 6, 12, 12);

                    // Score label
                    using var sf = new Font("Segoe UI", 9f, FontStyle.Bold);
                    using var bg = new SolidBrush(Color.FromArgb(170, 0, 0, 0));
                    g.FillRectangle(bg, new RectangleF(r.Xmin, r.Ymin - 20, 72, 20));
                    g.DrawString($"{r.Score:F3}", sf, Brushes.Yellow, r.Xmin + 2, r.Ymin - 19);

                    // Coordinate label
                    using var cf = new Font("Segoe UI", 8f);
                    g.DrawString($"({xc:F0},{yc:F0})", cf, Brushes.Cyan, xc + 9, yc - 9);
                }
            }

            // ── Crop from annotated image (box + dot visible in crop) ─────
            Bitmap crop;
            if (results.Count > 0)
            {
                var r0 = results[0];
                int pad = 30;
                int rx = Math.Max(0, (int)r0.Xmin - pad);
                int ry = Math.Max(0, (int)r0.Ymin - pad);
                int rw = Math.Min(annotated.Width - rx, (int)(r0.Xmax - r0.Xmin) + pad * 2);
                int rh = Math.Min(annotated.Height - ry, (int)(r0.Ymax - r0.Ymin) + pad * 2);

                // Clone a sub-region of the annotated image
                crop = annotated.Clone(
                    new Rectangle(rx, ry, rw, rh),
                    annotated.PixelFormat);
            }
            else
            {
                crop = new Bitmap(200, 200);
                using var g = Graphics.FromImage(crop);
                using var fnt = new Font("Segoe UI", 10f);
                g.Clear(Color.FromArgb(50, 50, 50));
                g.DrawString("No Detection", fnt, Brushes.Gray, 20, 85);
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
            var kept = new List<DetectionResult>();
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
            float ix = Math.Max(0, Math.Min(a.Xmax, b.Xmax) - Math.Max(a.Xmin, b.Xmin));
            float iy = Math.Max(0, Math.Min(a.Ymax, b.Ymax) - Math.Max(a.Ymin, b.Ymin));
            float inter = ix * iy;
            float aA = (a.Xmax - a.Xmin) * (a.Ymax - a.Ymin);
            float bA = (b.Xmax - b.Xmin) * (b.Ymax - b.Ymin);
            return inter / (aA + bA - inter + 1e-6f);
        }

        // ──────────────────────────────────────────────────────────────────
        // Helpers
        // ──────────────────────────────────────────────────────────────────
        private void LoadRawImageToPanel(string position, string imagePath)
        {
            try
            {
                var bmp = new Bitmap(imagePath);
                if (position == "Left")
                {
                    ClearPictureBox(picLeftFull);
                    picLeftFull.Image = bmp;
                }
                else
                {
                    ClearPictureBox(picRightFull);
                    picRightFull.Image = bmp;
                }
            }
            catch { Warn("Could not load image."); }
        }

        // Accepts "0.5" or "0,5" — clamps [0,1] — defaults to 0.5
        private static float TryParseAB(string text)
        {
            text = (text ?? "0.5").Trim().Replace(',', '.');
            return float.TryParse(text,
                System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture,
                out float v)
                ? Math.Clamp(v, 0f, 1f)
                : 0.5f;
        }

        private void SetButtonsEnabled(bool enabled)
        {
            btnRun.Enabled = enabled;
            btnAiExec.Enabled = enabled;
        }

        private void SetStatus(string msg, Color color)
        {
            lblStatus.Text = msg;
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

        // a=0 → left edge   a=0.5 → centre   a=1 → right edge
        // b=0 → top edge    b=0.5 → centre   b=1 → bottom edge
        public float ComputeXc(float a) => (1f - a) * Xmin + a * Xmax;
        public float ComputeYc(float b) => (1f - b) * Ymin + b * Ymax;

        public float Xc => ComputeXc(0.5f);
        public float Yc => ComputeYc(0.5f);
    }
}