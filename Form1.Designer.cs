namespace OnnxDetectorApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ── Header ────────────────────────────────────────────────────
            this.pnlHeader      = new System.Windows.Forms.Panel();
            this.lblTitle       = new System.Windows.Forms.Label();
            this.lblTimestamp   = new System.Windows.Forms.Label();
            this.btnClearView   = new System.Windows.Forms.Button();
            this.btnClose       = new System.Windows.Forms.Button();

            // ── Main table ────────────────────────────────────────────────
            this.tblMain        = new System.Windows.Forms.TableLayoutPanel();

            // ── Settings ─────────────────────────────────────────────────
            this.pnlSettingsOuter  = new System.Windows.Forms.Panel();
            this.pnlSettingsBorder = new System.Windows.Forms.Panel();
            this.lblSettingsTitle  = new System.Windows.Forms.Label();

            this.lblModel    = new System.Windows.Forms.Label();
            this.btnModel    = new System.Windows.Forms.Button();
            this.txtModel    = new System.Windows.Forms.TextBox();

            this.lblPosition = new System.Windows.Forms.Label();
            this.btnPosition = new System.Windows.Forms.Button();
            this.txtPosition = new System.Windows.Forms.TextBox();

            this.lblTestImage  = new System.Windows.Forms.Label();
            this.btnTestImage  = new System.Windows.Forms.Button();
            this.txtTestImage  = new System.Windows.Forms.TextBox();

            this.lblSaveFolder = new System.Windows.Forms.Label();
            this.btnSaveFolder = new System.Windows.Forms.Button();
            this.txtSaveFolder = new System.Windows.Forms.TextBox();

            this.lblScoreThresholdLabel = new System.Windows.Forms.Label();
            this.trkThreshold           = new System.Windows.Forms.TrackBar();
            this.lblThresholdValue      = new System.Windows.Forms.Label();

            this.btnRun = new System.Windows.Forms.Button();

            // ── Align mark group ─────────────────────────────────────────
            this.grpAlignMark   = new System.Windows.Forms.GroupBox();
            this.tblAlignMark   = new System.Windows.Forms.TableLayoutPanel();
            this.picAlignPreview = new System.Windows.Forms.Panel();
            this.lblFormula     = new System.Windows.Forms.Label();

            this.pnlABGrid  = new System.Windows.Forms.TableLayoutPanel();
            this.lblLeftA   = new System.Windows.Forms.Label();
            this.txtLeftA   = new System.Windows.Forms.TextBox();
            this.lblLeftB   = new System.Windows.Forms.Label();
            this.txtLeftB   = new System.Windows.Forms.TextBox();
            this.lblRightA  = new System.Windows.Forms.Label();
            this.txtRightA  = new System.Windows.Forms.TextBox();
            this.lblRightB  = new System.Windows.Forms.Label();
            this.txtRightB  = new System.Windows.Forms.TextBox();

            this.btnAiExec  = new System.Windows.Forms.Button();

            // ── Image panels ─────────────────────────────────────────────
            this.tblImages      = new System.Windows.Forms.TableLayoutPanel();

            this.pnlLeftFull    = new System.Windows.Forms.Panel();
            this.lblLeftTitle   = new System.Windows.Forms.Label();
            this.pnlLeftXY      = new System.Windows.Forms.Panel();
            this.lblLeftXY      = new System.Windows.Forms.Label();
            this.picLeftFull    = new System.Windows.Forms.PictureBox();

            this.pnlRightFull   = new System.Windows.Forms.Panel();
            this.lblRightTitle  = new System.Windows.Forms.Label();
            this.pnlRightXY     = new System.Windows.Forms.Panel();
            this.lblRightXY     = new System.Windows.Forms.Label();
            this.picRightFull   = new System.Windows.Forms.PictureBox();

            this.tblCrops       = new System.Windows.Forms.TableLayoutPanel();

            this.pnlLeftCrop    = new System.Windows.Forms.Panel();
            this.lblLeftCropTitle = new System.Windows.Forms.Label();
            this.picLeftCrop    = new System.Windows.Forms.PictureBox();

            this.pnlRightCrop   = new System.Windows.Forms.Panel();
            this.lblRightCropTitle = new System.Windows.Forms.Label();
            this.picRightCrop   = new System.Windows.Forms.PictureBox();

            // ── Event log ────────────────────────────────────────────────
            this.pnlEvent       = new System.Windows.Forms.Panel();
            this.lblEventTitle  = new System.Windows.Forms.Label();
            this.dgvEvents      = new System.Windows.Forms.DataGridView();
            this.colImageFileName  = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEventTime      = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRunTime        = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosition       = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXmin           = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYmin           = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXmax           = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYmax           = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXc             = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYc             = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore          = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetImagePath   = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // ── Status + Timer ────────────────────────────────────────────
            this.statusStrip  = new System.Windows.Forms.StatusStrip();
            this.lblStatus    = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerClock   = new System.Windows.Forms.Timer(this.components);

            // ==============================================================
            // SuspendLayout
            // ==============================================================
            this.pnlHeader.SuspendLayout();
            this.tblMain.SuspendLayout();
            this.pnlSettingsOuter.SuspendLayout();
            this.pnlSettingsBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.trkThreshold).BeginInit();
            this.grpAlignMark.SuspendLayout();
            this.tblAlignMark.SuspendLayout();
            this.pnlABGrid.SuspendLayout();
            this.tblImages.SuspendLayout();
            this.pnlLeftFull.SuspendLayout();
            this.pnlLeftXY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.picLeftFull).BeginInit();
            this.pnlRightFull.SuspendLayout();
            this.pnlRightXY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.picRightFull).BeginInit();
            this.tblCrops.SuspendLayout();
            this.pnlLeftCrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.picLeftCrop).BeginInit();
            this.pnlRightCrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.picRightCrop).BeginInit();
            this.pnlEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvEvents).BeginInit();
            this.SuspendLayout();

            // ==============================================================
            // pnlHeader
            // ==============================================================
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 44;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblTimestamp);
            this.pnlHeader.Controls.Add(this.btnClearView);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Name = "pnlHeader";

            this.lblTitle.Text = "ONNX AI  —  Align Mark Detection";
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 174, 239);
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13f, System.Drawing.FontStyle.Bold);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 10);
            this.lblTitle.Name = "lblTitle";

            this.lblTimestamp.ForeColor = System.Drawing.Color.Silver;
            this.lblTimestamp.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblTimestamp.AutoSize = true;
            this.lblTimestamp.Location = new System.Drawing.Point(420, 14);
            this.lblTimestamp.Name = "lblTimestamp";

            this.btnClearView.Text = "Clear View";
            this.btnClearView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearView.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnClearView.ForeColor = System.Drawing.Color.White;
            this.btnClearView.Size = new System.Drawing.Size(90, 26);
            this.btnClearView.Location = new System.Drawing.Point(1100, 9);
            this.btnClearView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnClearView.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnClearView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearView.Name = "btnClearView";

            this.btnClose.Text = "Close";
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(180, 40, 40);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Size = new System.Drawing.Size(75, 26);
            this.btnClose.Location = new System.Drawing.Point(1200, 9);
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Name = "btnClose";

            // ==============================================================
            // tblMain
            // ==============================================================
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.ColumnCount = 1;
            this.tblMain.RowCount = 3;
            this.tblMain.Padding = new System.Windows.Forms.Padding(6, 4, 6, 2);
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.tblMain.Controls.Add(this.pnlSettingsOuter, 0, 0);
            this.tblMain.Controls.Add(this.tblImages, 0, 1);
            this.tblMain.Controls.Add(this.pnlEvent, 0, 2);
            this.tblMain.Name = "tblMain";

            // ==============================================================
            // Settings panel
            // ==============================================================
            this.pnlSettingsOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSettingsOuter.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.pnlSettingsOuter.Controls.Add(this.pnlSettingsBorder);
            this.pnlSettingsOuter.Name = "pnlSettingsOuter";

            this.pnlSettingsBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSettingsBorder.BackColor = System.Drawing.Color.White;
            this.pnlSettingsBorder.Padding = new System.Windows.Forms.Padding(8);
            this.pnlSettingsBorder.Controls.Add(this.lblSettingsTitle);
            this.pnlSettingsBorder.Controls.Add(this.lblModel);
            this.pnlSettingsBorder.Controls.Add(this.btnModel);
            this.pnlSettingsBorder.Controls.Add(this.txtModel);
            this.pnlSettingsBorder.Controls.Add(this.lblPosition);
            this.pnlSettingsBorder.Controls.Add(this.btnPosition);
            this.pnlSettingsBorder.Controls.Add(this.txtPosition);
            this.pnlSettingsBorder.Controls.Add(this.lblTestImage);
            this.pnlSettingsBorder.Controls.Add(this.btnTestImage);
            this.pnlSettingsBorder.Controls.Add(this.txtTestImage);
            this.pnlSettingsBorder.Controls.Add(this.lblSaveFolder);
            this.pnlSettingsBorder.Controls.Add(this.btnSaveFolder);
            this.pnlSettingsBorder.Controls.Add(this.txtSaveFolder);
            this.pnlSettingsBorder.Controls.Add(this.lblScoreThresholdLabel);
            this.pnlSettingsBorder.Controls.Add(this.trkThreshold);
            this.pnlSettingsBorder.Controls.Add(this.lblThresholdValue);
            this.pnlSettingsBorder.Controls.Add(this.btnRun);
            this.pnlSettingsBorder.Controls.Add(this.grpAlignMark);
            this.pnlSettingsBorder.Name = "pnlSettingsBorder";

            // Section title
            this.lblSettingsTitle.Text = "1. AI Model / Position / Image Path Settings";
            this.lblSettingsTitle.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblSettingsTitle.Location = new System.Drawing.Point(8, 6);
            this.lblSettingsTitle.AutoSize = true;
            this.lblSettingsTitle.Name = "lblSettingsTitle";

            // Row 0 — AI Model
            this.lblModel.Text = "AI Model";
            this.lblModel.Location = new System.Drawing.Point(10, 31);
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblModel.Name = "lblModel";

            this.btnModel.Text = "Select Model (.onnx)";
            this.btnModel.Location = new System.Drawing.Point(145, 28);
            this.btnModel.Size = new System.Drawing.Size(130, 22);
            this.btnModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModel.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnModel.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.btnModel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModel.Name = "btnModel";

            this.txtModel.Location = new System.Drawing.Point(285, 29);
            this.txtModel.Size = new System.Drawing.Size(230, 22);
            this.txtModel.ReadOnly = true;
            this.txtModel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtModel.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.txtModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModel.Name = "txtModel";

            // Row 1 — Image Position
            this.lblPosition.Text = "Image Position";
            this.lblPosition.Location = new System.Drawing.Point(10, 55);
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblPosition.Name = "lblPosition";

            this.btnPosition.Text = "Toggle Left / Right";
            this.btnPosition.Location = new System.Drawing.Point(145, 52);
            this.btnPosition.Size = new System.Drawing.Size(130, 22);
            this.btnPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosition.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnPosition.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.btnPosition.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPosition.Name = "btnPosition";

            this.txtPosition.Text = "Left";
            this.txtPosition.Location = new System.Drawing.Point(285, 53);
            this.txtPosition.Size = new System.Drawing.Size(80, 22);
            this.txtPosition.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPosition.Name = "txtPosition";

            // Row 2 — Test Image
            this.lblTestImage.Text = "Test Image";
            this.lblTestImage.Location = new System.Drawing.Point(10, 79);
            this.lblTestImage.AutoSize = true;
            this.lblTestImage.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblTestImage.Name = "lblTestImage";

            this.btnTestImage.Text = "Select Test Image";
            this.btnTestImage.Location = new System.Drawing.Point(145, 76);
            this.btnTestImage.Size = new System.Drawing.Size(130, 22);
            this.btnTestImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestImage.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnTestImage.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.btnTestImage.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnTestImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestImage.Name = "btnTestImage";

            this.txtTestImage.Location = new System.Drawing.Point(285, 77);
            this.txtTestImage.Size = new System.Drawing.Size(230, 22);
            this.txtTestImage.ReadOnly = true;
            this.txtTestImage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTestImage.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.txtTestImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTestImage.Name = "txtTestImage";

            // Row 3 — Save Folder
            this.lblSaveFolder.Text = "Save Img / Log Folder";
            this.lblSaveFolder.Location = new System.Drawing.Point(10, 103);
            this.lblSaveFolder.AutoSize = true;
            this.lblSaveFolder.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblSaveFolder.Name = "lblSaveFolder";

            this.btnSaveFolder.Text = "Select Folder";
            this.btnSaveFolder.Location = new System.Drawing.Point(145, 100);
            this.btnSaveFolder.Size = new System.Drawing.Size(130, 22);
            this.btnSaveFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFolder.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnSaveFolder.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.btnSaveFolder.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSaveFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveFolder.Name = "btnSaveFolder";

            this.txtSaveFolder.Location = new System.Drawing.Point(285, 101);
            this.txtSaveFolder.Size = new System.Drawing.Size(230, 22);
            this.txtSaveFolder.ReadOnly = true;
            this.txtSaveFolder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSaveFolder.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.txtSaveFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaveFolder.Name = "txtSaveFolder";

            // Row 4 — Score Threshold
            this.lblScoreThresholdLabel.Text = "Score Threshold";
            this.lblScoreThresholdLabel.Location = new System.Drawing.Point(10, 127);
            this.lblScoreThresholdLabel.AutoSize = true;
            this.lblScoreThresholdLabel.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblScoreThresholdLabel.Name = "lblScoreThresholdLabel";

            this.trkThreshold.Location = new System.Drawing.Point(145, 124);
            this.trkThreshold.Size = new System.Drawing.Size(180, 24);
            this.trkThreshold.Minimum = 1;
            this.trkThreshold.Maximum = 100;
            this.trkThreshold.Value = 50;
            this.trkThreshold.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkThreshold.Name = "trkThreshold";

            this.lblThresholdValue.Text = "0.50";
            this.lblThresholdValue.Location = new System.Drawing.Point(335, 127);
            this.lblThresholdValue.AutoSize = true;
            this.lblThresholdValue.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblThresholdValue.ForeColor = System.Drawing.Color.FromArgb(0, 100, 200);
            this.lblThresholdValue.Name = "lblThresholdValue";

            // Run button
            this.btnRun.Text = "▶  Run\r\nDetection";
            this.btnRun.Location = new System.Drawing.Point(540, 28);
            this.btnRun.Size = new System.Drawing.Size(110, 118);
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnRun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 90, 160);
            this.btnRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRun.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.btnRun.Name = "btnRun";

            // ==============================================================
            // grpAlignMark  — anchored so it stretches with form width
            // ==============================================================
            this.grpAlignMark.Text = "§ Align Mark Position Settings §";
            this.grpAlignMark.Location = new System.Drawing.Point(665, 16);
            this.grpAlignMark.Size = new System.Drawing.Size(500, 148);
            this.grpAlignMark.Anchor = System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Left
                | System.Windows.Forms.AnchorStyles.Right;
            this.grpAlignMark.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            this.grpAlignMark.Name = "grpAlignMark";
            this.grpAlignMark.Controls.Add(this.tblAlignMark);

            // ==============================================================
            // tblAlignMark  — fills the GroupBox, 3 columns
            // Col0=preview | Col1=formula | Col2=a/b grid+exec button
            // ==============================================================
            this.tblAlignMark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblAlignMark.ColumnCount = 3;
            this.tblAlignMark.RowCount = 1;
            this.tblAlignMark.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120));
            this.tblAlignMark.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.tblAlignMark.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200));
            this.tblAlignMark.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.tblAlignMark.Padding = new System.Windows.Forms.Padding(4);
            this.tblAlignMark.Controls.Add(this.picAlignPreview, 0, 0);
            this.tblAlignMark.Controls.Add(this.lblFormula, 1, 0);
            this.tblAlignMark.Controls.Add(this.pnlABGrid, 2, 0);
            this.tblAlignMark.Name = "tblAlignMark";

            // Preview box
            this.picAlignPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAlignPreview.Margin = new System.Windows.Forms.Padding(4);
            this.picAlignPreview.BackColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.picAlignPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAlignPreview.Name = "picAlignPreview";

            // Formula label
            this.lblFormula.Text = "Xc = (1 - a) · Xmin  +  a · Xmax\r\nYc = (1 - b) · Ymin  +  b · Ymax";
            this.lblFormula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFormula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFormula.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblFormula.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblFormula.Name = "lblFormula";

            // ==============================================================
            // pnlABGrid — 3 rows x 2 cols: labels | Left | Right
            //                              a row
            //                              b row
            //                              exec button
            // ==============================================================
            this.pnlABGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlABGrid.ColumnCount = 3;
            this.pnlABGrid.RowCount = 4;
            this.pnlABGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30f));
            this.pnlABGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35f));
            this.pnlABGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35f));
            this.pnlABGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25f));
            this.pnlABGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25f));
            this.pnlABGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25f));
            this.pnlABGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25f));
            this.pnlABGrid.Padding = new System.Windows.Forms.Padding(2);
            this.pnlABGrid.Name = "pnlABGrid";

            // Header row (row 0): blank | "Left" | "Right"
            var lblColLeft = new System.Windows.Forms.Label
            {
                Text = "Left",
                Dock = System.Windows.Forms.DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold)
            };
            var lblColRight = new System.Windows.Forms.Label
            {
                Text = "Right",
                Dock = System.Windows.Forms.DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold)
            };
            this.pnlABGrid.Controls.Add(new System.Windows.Forms.Label(), 0, 0);
            this.pnlABGrid.Controls.Add(lblColLeft, 1, 0);
            this.pnlABGrid.Controls.Add(lblColRight, 2, 0);

            // Row 1: a | txtLeftA | txtRightA
            this.lblLeftA.Text = "a";
            this.lblLeftA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLeftA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLeftA.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblLeftA.Name = "lblLeftA";

            this.txtLeftA.Text = "0.5";
            this.txtLeftA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLeftA.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.txtLeftA.Margin = new System.Windows.Forms.Padding(2);
            this.txtLeftA.Name = "txtLeftA";

            this.txtRightA.Text = "0.5";
            this.txtRightA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRightA.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.txtRightA.Margin = new System.Windows.Forms.Padding(2);
            this.txtRightA.Name = "txtRightA";

            this.pnlABGrid.Controls.Add(this.lblLeftA, 0, 1);
            this.pnlABGrid.Controls.Add(this.txtLeftA, 1, 1);
            this.pnlABGrid.Controls.Add(this.txtRightA, 2, 1);

            // Row 2: b | txtLeftB | txtRightB
            this.lblLeftB.Text = "b";
            this.lblLeftB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLeftB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLeftB.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblLeftB.Name = "lblLeftB";

            this.txtLeftB.Text = "0.5";
            this.txtLeftB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLeftB.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.txtLeftB.Margin = new System.Windows.Forms.Padding(2);
            this.txtLeftB.Name = "txtLeftB";

            this.txtRightB.Text = "0.5";
            this.txtRightB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRightB.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.txtRightB.Margin = new System.Windows.Forms.Padding(2);
            this.txtRightB.Name = "txtRightB";

            this.pnlABGrid.Controls.Add(this.lblLeftB, 0, 2);
            this.pnlABGrid.Controls.Add(this.txtLeftB, 1, 2);
            this.pnlABGrid.Controls.Add(this.txtRightB, 2, 2);

            // Row 3: AI Exec button spanning all cols
            this.btnAiExec.Text = "AI Exec.";
            this.btnAiExec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAiExec.Margin = new System.Windows.Forms.Padding(2);
            this.btnAiExec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAiExec.BackColor = System.Drawing.Color.FromArgb(80, 160, 80);
            this.btnAiExec.ForeColor = System.Drawing.Color.White;
            this.btnAiExec.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            this.btnAiExec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAiExec.Name = "btnAiExec";
            this.pnlABGrid.Controls.Add(this.btnAiExec, 0, 3);
            this.pnlABGrid.SetColumnSpan(this.btnAiExec, 3);

            // unused label declarations needed for field references
            this.lblRightA.Name = "lblRightA";
            this.lblRightB.Name = "lblRightB";

            // ==============================================================
            // tblImages
            // ==============================================================
            this.tblImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblImages.ColumnCount = 3;
            this.tblImages.RowCount = 1;
            this.tblImages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42f));
            this.tblImages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42f));
            this.tblImages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16f));
            this.tblImages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.tblImages.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tblImages.Controls.Add(this.pnlLeftFull, 0, 0);
            this.tblImages.Controls.Add(this.pnlRightFull, 1, 0);
            this.tblImages.Controls.Add(this.tblCrops, 2, 0);
            this.tblImages.Name = "tblImages";

            // ── Left Full ─────────────────────────────────────────────────
            this.pnlLeftFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftFull.Padding = new System.Windows.Forms.Padding(2);
            this.pnlLeftFull.Controls.Add(this.picLeftFull);
            this.pnlLeftFull.Controls.Add(this.pnlLeftXY);
            this.pnlLeftFull.Controls.Add(this.lblLeftTitle);
            this.pnlLeftFull.Name = "pnlLeftFull";

            this.lblLeftTitle.Text = "► C-IC Pre-Align Left (Full) ◄";
            this.lblLeftTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLeftTitle.Height = 22;
            this.lblLeftTitle.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblLeftTitle.ForeColor = System.Drawing.Color.White;
            this.lblLeftTitle.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            this.lblLeftTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLeftTitle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.lblLeftTitle.Name = "lblLeftTitle";

            this.pnlLeftXY.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftXY.Width = 140;
            this.pnlLeftXY.BackColor = System.Drawing.Color.FromArgb(245, 245, 252);
            this.pnlLeftXY.Controls.Add(this.lblLeftXY);
            this.pnlLeftXY.Name = "pnlLeftXY";

            this.lblLeftXY.Text = "Left X Position\r\nLeft Y Position";
            this.lblLeftXY.Location = new System.Drawing.Point(8, 10);
            this.lblLeftXY.AutoSize = true;
            this.lblLeftXY.ForeColor = System.Drawing.Color.FromArgb(0, 100, 200);
            this.lblLeftXY.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblLeftXY.Name = "lblLeftXY";

            this.picLeftFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLeftFull.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLeftFull.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.picLeftFull.Name = "picLeftFull";

            // ── Right Full ────────────────────────────────────────────────
            this.pnlRightFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightFull.Padding = new System.Windows.Forms.Padding(2);
            this.pnlRightFull.Controls.Add(this.picRightFull);
            this.pnlRightFull.Controls.Add(this.pnlRightXY);
            this.pnlRightFull.Controls.Add(this.lblRightTitle);
            this.pnlRightFull.Name = "pnlRightFull";

            this.lblRightTitle.Text = "► C-IC Pre-Align Right (Full) ◄";
            this.lblRightTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRightTitle.Height = 22;
            this.lblRightTitle.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblRightTitle.ForeColor = System.Drawing.Color.White;
            this.lblRightTitle.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            this.lblRightTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRightTitle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.lblRightTitle.Name = "lblRightTitle";

            this.pnlRightXY.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRightXY.Width = 140;
            this.pnlRightXY.BackColor = System.Drawing.Color.FromArgb(245, 245, 252);
            this.pnlRightXY.Controls.Add(this.lblRightXY);
            this.pnlRightXY.Name = "pnlRightXY";

            this.lblRightXY.Text = "Right X Position\r\nRight Y Position";
            this.lblRightXY.Location = new System.Drawing.Point(8, 10);
            this.lblRightXY.AutoSize = true;
            this.lblRightXY.ForeColor = System.Drawing.Color.FromArgb(0, 100, 200);
            this.lblRightXY.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblRightXY.Name = "lblRightXY";

            this.picRightFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picRightFull.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRightFull.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.picRightFull.Name = "picRightFull";

            // ── Crops ─────────────────────────────────────────────────────
            this.tblCrops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCrops.ColumnCount = 1;
            this.tblCrops.RowCount = 2;
            this.tblCrops.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
            this.tblCrops.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
            this.tblCrops.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.tblCrops.Controls.Add(this.pnlLeftCrop, 0, 0);
            this.tblCrops.Controls.Add(this.pnlRightCrop, 0, 1);
            this.tblCrops.Name = "tblCrops";

            this.pnlLeftCrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftCrop.Padding = new System.Windows.Forms.Padding(2);
            this.pnlLeftCrop.Controls.Add(this.picLeftCrop);
            this.pnlLeftCrop.Controls.Add(this.lblLeftCropTitle);
            this.pnlLeftCrop.Name = "pnlLeftCrop";

            this.lblLeftCropTitle.Text = "► C-IC Pre-Align Left ◄";
            this.lblLeftCropTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLeftCropTitle.Height = 20;
            this.lblLeftCropTitle.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblLeftCropTitle.ForeColor = System.Drawing.Color.Cyan;
            this.lblLeftCropTitle.Font = new System.Drawing.Font("Segoe UI", 7.5f, System.Drawing.FontStyle.Bold);
            this.lblLeftCropTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLeftCropTitle.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.lblLeftCropTitle.Name = "lblLeftCropTitle";

            this.picLeftCrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLeftCrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLeftCrop.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.picLeftCrop.Name = "picLeftCrop";

            this.pnlRightCrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightCrop.Padding = new System.Windows.Forms.Padding(2);
            this.pnlRightCrop.Controls.Add(this.picRightCrop);
            this.pnlRightCrop.Controls.Add(this.lblRightCropTitle);
            this.pnlRightCrop.Name = "pnlRightCrop";

            this.lblRightCropTitle.Text = "► C-IC Pre-Align Right ◄";
            this.lblRightCropTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRightCropTitle.Height = 20;
            this.lblRightCropTitle.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblRightCropTitle.ForeColor = System.Drawing.Color.Cyan;
            this.lblRightCropTitle.Font = new System.Drawing.Font("Segoe UI", 7.5f, System.Drawing.FontStyle.Bold);
            this.lblRightCropTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRightCropTitle.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.lblRightCropTitle.Name = "lblRightCropTitle";

            this.picRightCrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picRightCrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRightCrop.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.picRightCrop.Name = "picRightCrop";

            // ==============================================================
            // Event log
            // ==============================================================
            this.pnlEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEvent.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pnlEvent.Controls.Add(this.dgvEvents);
            this.pnlEvent.Controls.Add(this.lblEventTitle);
            this.pnlEvent.Name = "pnlEvent";

            this.lblEventTitle.Text = "2. Event";
            this.lblEventTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEventTitle.Height = 20;
            this.lblEventTitle.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblEventTitle.Name = "lblEventTitle";

            this.dgvEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEvents.BackgroundColor = System.Drawing.Color.White;
            this.dgvEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEvents.RowHeadersVisible = false;
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.ReadOnly = true;
            this.dgvEvents.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.dgvEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvents.EnableHeadersVisualStyles = false;
            this.dgvEvents.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.dgvEvents.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEvents.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            this.dgvEvents.Name = "dgvEvents";

            this.colImageFileName.HeaderText = "Image_File_Name";  this.colImageFileName.Name = "colImageFileName";
            this.colEventTime.HeaderText     = "Event_Time";       this.colEventTime.Name = "colEventTime";
            this.colRunTime.HeaderText       = "Run_Time";         this.colRunTime.Name = "colRunTime";
            this.colPosition.HeaderText      = "Position";         this.colPosition.Name = "colPosition";
            this.colXmin.HeaderText          = "Xmin";             this.colXmin.Name = "colXmin";
            this.colYmin.HeaderText          = "Ymin";             this.colYmin.Name = "colYmin";
            this.colXmax.HeaderText          = "Xmax";             this.colXmax.Name = "colXmax";
            this.colYmax.HeaderText          = "Ymax";             this.colYmax.Name = "colYmax";
            this.colXc.HeaderText            = "Xc";               this.colXc.Name = "colXc";
            this.colYc.HeaderText            = "Yc";               this.colYc.Name = "colYc";
            this.colScore.HeaderText         = "Score";            this.colScore.Name = "colScore";
            this.colDetImagePath.HeaderText  = "Det_Image_Path";   this.colDetImagePath.Name = "colDetImagePath";

            this.dgvEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                colImageFileName, colEventTime, colRunTime, colPosition,
                colXmin, colYmin, colXmax, colYmax,
                colXc, colYc, colScore, colDetImagePath
            });

            // ==============================================================
            // Status strip
            // ==============================================================
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.statusStrip.Items.Add(this.lblStatus);
            this.lblStatus.Text = "Ready";
            this.lblStatus.ForeColor = System.Drawing.Color.LightGreen;
            this.lblStatus.Spring = true;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatus.Name = "lblStatus";

            // ==============================================================
            // Timer
            // ==============================================================
            this.timerClock.Interval = 1000;

            // ==============================================================
            // Form1
            // ==============================================================
            this.Text = "ONNX AI Align Mark Detection";
            this.Size = new System.Drawing.Size(1400, 900);
            this.MinimumSize = new System.Drawing.Size(1100, 750);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.Controls.Add(this.tblMain);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.statusStrip);
            this.Name = "Form1";

            // ==============================================================
            // ResumeLayout
            // ==============================================================
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tblMain.ResumeLayout(false);
            this.pnlSettingsOuter.ResumeLayout(false);
            this.pnlSettingsBorder.ResumeLayout(false);
            this.pnlSettingsBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.trkThreshold).EndInit();
            this.grpAlignMark.ResumeLayout(false);
            this.tblAlignMark.ResumeLayout(false);
            this.pnlABGrid.ResumeLayout(false);
            this.pnlABGrid.PerformLayout();
            this.tblImages.ResumeLayout(false);
            this.pnlLeftFull.ResumeLayout(false);
            this.pnlLeftXY.ResumeLayout(false);
            this.pnlLeftXY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.picLeftFull).EndInit();
            this.pnlRightFull.ResumeLayout(false);
            this.pnlRightXY.ResumeLayout(false);
            this.pnlRightXY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.picRightFull).EndInit();
            this.tblCrops.ResumeLayout(false);
            this.pnlLeftCrop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.picLeftCrop).EndInit();
            this.pnlRightCrop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.picRightCrop).EndInit();
            this.pnlEvent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.dgvEvents).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // ── Control declarations ──────────────────────────────────────────
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTimestamp;
        private System.Windows.Forms.Button btnClearView;
        private System.Windows.Forms.Button btnClose;

        private System.Windows.Forms.TableLayoutPanel tblMain;

        private System.Windows.Forms.Panel pnlSettingsOuter;
        private System.Windows.Forms.Panel pnlSettingsBorder;
        private System.Windows.Forms.Label lblSettingsTitle;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Button btnModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblTestImage;
        private System.Windows.Forms.Button btnTestImage;
        private System.Windows.Forms.TextBox txtTestImage;
        private System.Windows.Forms.Label lblSaveFolder;
        private System.Windows.Forms.Button btnSaveFolder;
        private System.Windows.Forms.TextBox txtSaveFolder;
        private System.Windows.Forms.Label lblScoreThresholdLabel;
        private System.Windows.Forms.TrackBar trkThreshold;
        private System.Windows.Forms.Label lblThresholdValue;
        private System.Windows.Forms.Button btnRun;

        private System.Windows.Forms.GroupBox grpAlignMark;
        private System.Windows.Forms.TableLayoutPanel tblAlignMark;
        private System.Windows.Forms.Panel picAlignPreview;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.TableLayoutPanel pnlABGrid;
        private System.Windows.Forms.Label lblLeftA;
        private System.Windows.Forms.TextBox txtLeftA;
        private System.Windows.Forms.Label lblLeftB;
        private System.Windows.Forms.TextBox txtLeftB;
        private System.Windows.Forms.Label lblRightA;
        private System.Windows.Forms.TextBox txtRightA;
        private System.Windows.Forms.Label lblRightB;
        private System.Windows.Forms.TextBox txtRightB;
        private System.Windows.Forms.Button btnAiExec;

        private System.Windows.Forms.TableLayoutPanel tblImages;
        private System.Windows.Forms.Panel pnlLeftFull;
        private System.Windows.Forms.Label lblLeftTitle;
        private System.Windows.Forms.Panel pnlLeftXY;
        private System.Windows.Forms.Label lblLeftXY;
        private System.Windows.Forms.PictureBox picLeftFull;
        private System.Windows.Forms.Panel pnlRightFull;
        private System.Windows.Forms.Label lblRightTitle;
        private System.Windows.Forms.Panel pnlRightXY;
        private System.Windows.Forms.Label lblRightXY;
        private System.Windows.Forms.PictureBox picRightFull;
        private System.Windows.Forms.TableLayoutPanel tblCrops;
        private System.Windows.Forms.Panel pnlLeftCrop;
        private System.Windows.Forms.Label lblLeftCropTitle;
        private System.Windows.Forms.PictureBox picLeftCrop;
        private System.Windows.Forms.Panel pnlRightCrop;
        private System.Windows.Forms.Label lblRightCropTitle;
        private System.Windows.Forms.PictureBox picRightCrop;

        private System.Windows.Forms.Panel pnlEvent;
        private System.Windows.Forms.Label lblEventTitle;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImageFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEventTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRunTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXmax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYmax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetImagePath;

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Timer timerClock;
    }
}
