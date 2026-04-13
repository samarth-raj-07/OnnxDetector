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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            pnlHeader = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();
            lblTimestamp = new System.Windows.Forms.Label();
            btnClearView = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            tblMain = new System.Windows.Forms.TableLayoutPanel();
            pnlSettingsOuter = new System.Windows.Forms.Panel();
            pnlSettingsBorder = new System.Windows.Forms.Panel();
            lblSettingsTitle = new System.Windows.Forms.Label();
            lblModel = new System.Windows.Forms.Label();
            btnModel = new System.Windows.Forms.Button();
            txtModel = new System.Windows.Forms.TextBox();
            lblPosition = new System.Windows.Forms.Label();
            btnPosition = new System.Windows.Forms.Button();
            txtPosition = new System.Windows.Forms.TextBox();
            lblTestImage = new System.Windows.Forms.Label();
            btnTestImage = new System.Windows.Forms.Button();
            txtTestImage = new System.Windows.Forms.TextBox();
            lblSaveFolder = new System.Windows.Forms.Label();
            btnSaveFolder = new System.Windows.Forms.Button();
            txtSaveFolder = new System.Windows.Forms.TextBox();
            lblScoreThresholdLabel = new System.Windows.Forms.Label();
            trkThreshold = new System.Windows.Forms.TrackBar();
            lblThresholdValue = new System.Windows.Forms.Label();
            btnRun = new System.Windows.Forms.Button();
            grpAlignMark = new System.Windows.Forms.GroupBox();
            tblAlignMark = new System.Windows.Forms.TableLayoutPanel();
            picAlignPreview = new System.Windows.Forms.Panel();
            lblFormula = new System.Windows.Forms.Label();
            pnlABGrid = new System.Windows.Forms.TableLayoutPanel();
            lblColLeft = new System.Windows.Forms.Label();
            lblColRight = new System.Windows.Forms.Label();
            lblLeftA = new System.Windows.Forms.Label();
            txtLeftA = new System.Windows.Forms.TextBox();
            txtRightA = new System.Windows.Forms.TextBox();
            lblLeftB = new System.Windows.Forms.Label();
            txtLeftB = new System.Windows.Forms.TextBox();
            txtRightB = new System.Windows.Forms.TextBox();
            btnAiExec = new System.Windows.Forms.Button();
            tblImages = new System.Windows.Forms.TableLayoutPanel();
            pnlLeftFull = new System.Windows.Forms.Panel();
            picLeftFull = new System.Windows.Forms.PictureBox();
            pnlLeftXY = new System.Windows.Forms.Panel();
            lblLeftXY = new System.Windows.Forms.Label();
            lblLeftTitle = new System.Windows.Forms.Label();
            pnlRightFull = new System.Windows.Forms.Panel();
            picRightFull = new System.Windows.Forms.PictureBox();
            pnlRightXY = new System.Windows.Forms.Panel();
            lblRightXY = new System.Windows.Forms.Label();
            lblRightTitle = new System.Windows.Forms.Label();
            tblCrops = new System.Windows.Forms.TableLayoutPanel();
            pnlLeftCrop = new System.Windows.Forms.Panel();
            picLeftCrop = new System.Windows.Forms.PictureBox();
            lblLeftCropTitle = new System.Windows.Forms.Label();
            pnlRightCrop = new System.Windows.Forms.Panel();
            picRightCrop = new System.Windows.Forms.PictureBox();
            lblRightCropTitle = new System.Windows.Forms.Label();
            pnlEvent = new System.Windows.Forms.Panel();
            dgvEvents = new System.Windows.Forms.DataGridView();
            colImageFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEventTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colRunTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colXmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colYmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colXmax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colYmax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colXc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colYc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDetImagePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblEventTitle = new System.Windows.Forms.Label();
            lblRightA = new System.Windows.Forms.Label();
            lblRightB = new System.Windows.Forms.Label();
            statusStrip = new System.Windows.Forms.StatusStrip();
            lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            timerClock = new System.Windows.Forms.Timer(components);
            pnlHeader.SuspendLayout();
            tblMain.SuspendLayout();
            pnlSettingsOuter.SuspendLayout();
            pnlSettingsBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trkThreshold).BeginInit();
            grpAlignMark.SuspendLayout();
            tblAlignMark.SuspendLayout();
            pnlABGrid.SuspendLayout();
            tblImages.SuspendLayout();
            pnlLeftFull.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLeftFull).BeginInit();
            pnlLeftXY.SuspendLayout();
            pnlRightFull.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRightFull).BeginInit();
            pnlRightXY.SuspendLayout();
            tblCrops.SuspendLayout();
            pnlLeftCrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLeftCrop).BeginInit();
            pnlRightCrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRightCrop).BeginInit();
            pnlEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEvents).BeginInit();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblTimestamp);
            pnlHeader.Controls.Add(btnClearView);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(1382, 44);
            pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 174, 239);
            lblTitle.Location = new System.Drawing.Point(12, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(373, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ONNX AI  —  Align Mark Detection";
            // 
            // lblTimestamp
            // 
            lblTimestamp.AutoSize = true;
            lblTimestamp.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblTimestamp.ForeColor = System.Drawing.Color.Silver;
            lblTimestamp.Location = new System.Drawing.Point(420, 14);
            lblTimestamp.Name = "lblTimestamp";
            lblTimestamp.Size = new System.Drawing.Size(0, 20);
            lblTimestamp.TabIndex = 1;
            // 
            // btnClearView
            // 
            btnClearView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnClearView.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            btnClearView.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClearView.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            btnClearView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClearView.ForeColor = System.Drawing.Color.White;
            btnClearView.Location = new System.Drawing.Point(2282, 9);
            btnClearView.Name = "btnClearView";
            btnClearView.Size = new System.Drawing.Size(90, 26);
            btnClearView.TabIndex = 2;
            btnClearView.Text = "Clear View";
            btnClearView.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnClose.BackColor = System.Drawing.Color.FromArgb(180, 40, 40);
            btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClose.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.ForeColor = System.Drawing.Color.White;
            btnClose.Location = new System.Drawing.Point(2382, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(75, 26);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tblMain.Controls.Add(pnlSettingsOuter, 0, 0);
            tblMain.Controls.Add(tblImages, 0, 1);
            tblMain.Controls.Add(pnlEvent, 0, 2);
            tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            tblMain.Location = new System.Drawing.Point(0, 44);
            tblMain.Name = "tblMain";
            tblMain.Padding = new System.Windows.Forms.Padding(6, 4, 6, 2);
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            tblMain.Size = new System.Drawing.Size(1382, 783);
            tblMain.TabIndex = 0;
            // 
            // pnlSettingsOuter
            // 
            pnlSettingsOuter.Controls.Add(pnlSettingsBorder);
            pnlSettingsOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlSettingsOuter.Location = new System.Drawing.Point(9, 7);
            pnlSettingsOuter.Name = "pnlSettingsOuter";
            pnlSettingsOuter.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            pnlSettingsOuter.Size = new System.Drawing.Size(1364, 164);
            pnlSettingsOuter.TabIndex = 0;
            // 
            // pnlSettingsBorder
            // 
            pnlSettingsBorder.BackColor = System.Drawing.Color.White;
            pnlSettingsBorder.Controls.Add(lblSettingsTitle);
            pnlSettingsBorder.Controls.Add(lblModel);
            pnlSettingsBorder.Controls.Add(btnModel);
            pnlSettingsBorder.Controls.Add(txtModel);
            pnlSettingsBorder.Controls.Add(lblPosition);
            pnlSettingsBorder.Controls.Add(btnPosition);
            pnlSettingsBorder.Controls.Add(txtPosition);
            pnlSettingsBorder.Controls.Add(lblTestImage);
            pnlSettingsBorder.Controls.Add(btnTestImage);
            pnlSettingsBorder.Controls.Add(txtTestImage);
            pnlSettingsBorder.Controls.Add(lblSaveFolder);
            pnlSettingsBorder.Controls.Add(btnSaveFolder);
            pnlSettingsBorder.Controls.Add(txtSaveFolder);
            pnlSettingsBorder.Controls.Add(lblScoreThresholdLabel);
            pnlSettingsBorder.Controls.Add(trkThreshold);
            pnlSettingsBorder.Controls.Add(lblThresholdValue);
            pnlSettingsBorder.Controls.Add(btnRun);
            pnlSettingsBorder.Controls.Add(grpAlignMark);
            pnlSettingsBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlSettingsBorder.Location = new System.Drawing.Point(0, 2);
            pnlSettingsBorder.Name = "pnlSettingsBorder";
            pnlSettingsBorder.Padding = new System.Windows.Forms.Padding(8);
            pnlSettingsBorder.Size = new System.Drawing.Size(1364, 160);
            pnlSettingsBorder.TabIndex = 0;
            // 
            // lblSettingsTitle
            // 
            lblSettingsTitle.AutoSize = true;
            lblSettingsTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblSettingsTitle.Location = new System.Drawing.Point(8, 6);
            lblSettingsTitle.Name = "lblSettingsTitle";
            lblSettingsTitle.Size = new System.Drawing.Size(318, 20);
            lblSettingsTitle.TabIndex = 0;
            lblSettingsTitle.Text = "1. AI Model / Position / Image Path Settings";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblModel.Location = new System.Drawing.Point(10, 31);
            lblModel.Name = "lblModel";
            lblModel.Size = new System.Drawing.Size(70, 20);
            lblModel.TabIndex = 1;
            lblModel.Text = "AI Model";
            // 
            // btnModel
            // 
            btnModel.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            btnModel.Cursor = System.Windows.Forms.Cursors.Hand;
            btnModel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btnModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnModel.Font = new System.Drawing.Font("Segoe UI", 8F);
            btnModel.Location = new System.Drawing.Point(145, 28);
            btnModel.Name = "btnModel";
            btnModel.Size = new System.Drawing.Size(130, 22);
            btnModel.TabIndex = 2;
            btnModel.Text = "Select Model (.onnx)";
            btnModel.UseVisualStyleBackColor = false;
            // 
            // txtModel
            // 
            txtModel.BackColor = System.Drawing.Color.WhiteSmoke;
            txtModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtModel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            txtModel.Location = new System.Drawing.Point(285, 29);
            txtModel.Name = "txtModel";
            txtModel.ReadOnly = true;
            txtModel.Size = new System.Drawing.Size(230, 26);
            txtModel.TabIndex = 3;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblPosition.Location = new System.Drawing.Point(10, 55);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new System.Drawing.Size(107, 20);
            lblPosition.TabIndex = 4;
            lblPosition.Text = "Image Position";
            // 
            // btnPosition
            // 
            btnPosition.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            btnPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPosition.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btnPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPosition.Font = new System.Drawing.Font("Segoe UI", 8F);
            btnPosition.Location = new System.Drawing.Point(145, 52);
            btnPosition.Name = "btnPosition";
            btnPosition.Size = new System.Drawing.Size(130, 22);
            btnPosition.TabIndex = 5;
            btnPosition.Text = "Toggle Left / Right";
            btnPosition.UseVisualStyleBackColor = false;
            // 
            // txtPosition
            // 
            txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPosition.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            txtPosition.Location = new System.Drawing.Point(285, 53);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new System.Drawing.Size(80, 26);
            txtPosition.TabIndex = 6;
            txtPosition.Text = "Left";
            // 
            // lblTestImage
            // 
            lblTestImage.AutoSize = true;
            lblTestImage.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblTestImage.Location = new System.Drawing.Point(10, 79);
            lblTestImage.Name = "lblTestImage";
            lblTestImage.Size = new System.Drawing.Size(81, 20);
            lblTestImage.TabIndex = 7;
            lblTestImage.Text = "Test Image";
            // 
            // btnTestImage
            // 
            btnTestImage.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            btnTestImage.Cursor = System.Windows.Forms.Cursors.Hand;
            btnTestImage.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btnTestImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTestImage.Font = new System.Drawing.Font("Segoe UI", 8F);
            btnTestImage.Location = new System.Drawing.Point(145, 76);
            btnTestImage.Name = "btnTestImage";
            btnTestImage.Size = new System.Drawing.Size(130, 22);
            btnTestImage.TabIndex = 8;
            btnTestImage.Text = "Select Test Image";
            btnTestImage.UseVisualStyleBackColor = false;
            // 
            // txtTestImage
            // 
            txtTestImage.BackColor = System.Drawing.Color.WhiteSmoke;
            txtTestImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTestImage.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            txtTestImage.Location = new System.Drawing.Point(285, 77);
            txtTestImage.Name = "txtTestImage";
            txtTestImage.ReadOnly = true;
            txtTestImage.Size = new System.Drawing.Size(230, 26);
            txtTestImage.TabIndex = 9;
            // 
            // lblSaveFolder
            // 
            lblSaveFolder.AutoSize = true;
            lblSaveFolder.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblSaveFolder.Location = new System.Drawing.Point(10, 103);
            lblSaveFolder.Name = "lblSaveFolder";
            lblSaveFolder.Size = new System.Drawing.Size(155, 20);
            lblSaveFolder.TabIndex = 10;
            lblSaveFolder.Text = "Save Img / Log Folder";
            // 
            // btnSaveFolder
            // 
            btnSaveFolder.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            btnSaveFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSaveFolder.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            btnSaveFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSaveFolder.Font = new System.Drawing.Font("Segoe UI", 8F);
            btnSaveFolder.Location = new System.Drawing.Point(145, 100);
            btnSaveFolder.Name = "btnSaveFolder";
            btnSaveFolder.Size = new System.Drawing.Size(130, 22);
            btnSaveFolder.TabIndex = 11;
            btnSaveFolder.Text = "Select Folder";
            btnSaveFolder.UseVisualStyleBackColor = false;
            // 
            // txtSaveFolder
            // 
            txtSaveFolder.BackColor = System.Drawing.Color.WhiteSmoke;
            txtSaveFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSaveFolder.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            txtSaveFolder.Location = new System.Drawing.Point(285, 101);
            txtSaveFolder.Name = "txtSaveFolder";
            txtSaveFolder.ReadOnly = true;
            txtSaveFolder.Size = new System.Drawing.Size(230, 26);
            txtSaveFolder.TabIndex = 12;
            // 
            // lblScoreThresholdLabel
            // 
            lblScoreThresholdLabel.AutoSize = true;
            lblScoreThresholdLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblScoreThresholdLabel.Location = new System.Drawing.Point(10, 127);
            lblScoreThresholdLabel.Name = "lblScoreThresholdLabel";
            lblScoreThresholdLabel.Size = new System.Drawing.Size(115, 20);
            lblScoreThresholdLabel.TabIndex = 13;
            lblScoreThresholdLabel.Text = "Score Threshold";
            // 
            // trkThreshold
            // 
            trkThreshold.Location = new System.Drawing.Point(145, 124);
            trkThreshold.Maximum = 100;
            trkThreshold.Minimum = 1;
            trkThreshold.Name = "trkThreshold";
            trkThreshold.Size = new System.Drawing.Size(180, 56);
            trkThreshold.TabIndex = 14;
            trkThreshold.TickStyle = System.Windows.Forms.TickStyle.None;
            trkThreshold.Value = 50;
            // 
            // lblThresholdValue
            // 
            lblThresholdValue.AutoSize = true;
            lblThresholdValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblThresholdValue.ForeColor = System.Drawing.Color.FromArgb(0, 100, 200);
            lblThresholdValue.Location = new System.Drawing.Point(335, 127);
            lblThresholdValue.Name = "lblThresholdValue";
            lblThresholdValue.Size = new System.Drawing.Size(40, 20);
            lblThresholdValue.TabIndex = 15;
            lblThresholdValue.Text = "0.50";
            // 
            // btnRun
            // 
            btnRun.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            btnRun.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 90, 160);
            btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRun.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnRun.ForeColor = System.Drawing.Color.White;
            btnRun.Location = new System.Drawing.Point(540, 28);
            btnRun.Name = "btnRun";
            btnRun.Size = new System.Drawing.Size(110, 118);
            btnRun.TabIndex = 16;
            btnRun.Text = "▶  Run\r\nDetection";
            btnRun.UseVisualStyleBackColor = false;
            // 
            // grpAlignMark
            // 
            grpAlignMark.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpAlignMark.Controls.Add(tblAlignMark);
            grpAlignMark.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            grpAlignMark.Location = new System.Drawing.Point(665, 16);
            grpAlignMark.Name = "grpAlignMark";
            grpAlignMark.Size = new System.Drawing.Size(1664, 148);
            grpAlignMark.TabIndex = 17;
            grpAlignMark.TabStop = false;
            grpAlignMark.Text = "§ Align Mark Position Settings §";
            // 
            // tblAlignMark
            // 
            tblAlignMark.ColumnCount = 3;
            tblAlignMark.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            tblAlignMark.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tblAlignMark.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            tblAlignMark.Controls.Add(picAlignPreview, 0, 0);
            tblAlignMark.Controls.Add(lblFormula, 1, 0);
            tblAlignMark.Controls.Add(pnlABGrid, 2, 0);
            tblAlignMark.Dock = System.Windows.Forms.DockStyle.Fill;
            tblAlignMark.Location = new System.Drawing.Point(3, 22);
            tblAlignMark.Name = "tblAlignMark";
            tblAlignMark.Padding = new System.Windows.Forms.Padding(4);
            tblAlignMark.RowCount = 1;
            tblAlignMark.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tblAlignMark.Size = new System.Drawing.Size(1658, 123);
            tblAlignMark.TabIndex = 0;
            // 
            // picAlignPreview
            // 
            picAlignPreview.BackColor = System.Drawing.Color.FromArgb(180, 180, 180);
            picAlignPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picAlignPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            picAlignPreview.Location = new System.Drawing.Point(8, 8);
            picAlignPreview.Margin = new System.Windows.Forms.Padding(4);
            picAlignPreview.Name = "picAlignPreview";
            picAlignPreview.Size = new System.Drawing.Size(112, 107);
            picAlignPreview.TabIndex = 0;
            // 
            // lblFormula
            // 
            lblFormula.Dock = System.Windows.Forms.DockStyle.Fill;
            lblFormula.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblFormula.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            lblFormula.Location = new System.Drawing.Point(127, 4);
            lblFormula.Name = "lblFormula";
            lblFormula.Size = new System.Drawing.Size(1324, 115);
            lblFormula.TabIndex = 1;
            lblFormula.Text = "Xc = (1 - a) · Xmin  +  a · Xmax\r\nYc = (1 - b) · Ymin  +  b · Ymax";
            lblFormula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlABGrid
            // 
            pnlABGrid.ColumnCount = 3;
            pnlABGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            pnlABGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            pnlABGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            pnlABGrid.Controls.Add(lblColLeft, 1, 0);
            pnlABGrid.Controls.Add(lblColRight, 2, 0);
            pnlABGrid.Controls.Add(lblLeftA, 0, 1);
            pnlABGrid.Controls.Add(txtLeftA, 1, 1);
            pnlABGrid.Controls.Add(txtRightA, 2, 1);
            pnlABGrid.Controls.Add(lblLeftB, 0, 2);
            pnlABGrid.Controls.Add(txtLeftB, 1, 2);
            pnlABGrid.Controls.Add(txtRightB, 2, 2);
            pnlABGrid.Controls.Add(btnAiExec, 0, 3);
            pnlABGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlABGrid.Location = new System.Drawing.Point(1457, 7);
            pnlABGrid.Name = "pnlABGrid";
            pnlABGrid.Padding = new System.Windows.Forms.Padding(2);
            pnlABGrid.RowCount = 4;
            pnlABGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            pnlABGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            pnlABGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            pnlABGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            pnlABGrid.Size = new System.Drawing.Size(194, 109);
            pnlABGrid.TabIndex = 2;
            // 
            // lblColLeft
            // 
            lblColLeft.Location = new System.Drawing.Point(62, 2);
            lblColLeft.Name = "lblColLeft";
            lblColLeft.Size = new System.Drawing.Size(60, 23);
            lblColLeft.TabIndex = 1;
            // 
            // lblColRight
            // 
            lblColRight.Location = new System.Drawing.Point(128, 2);
            lblColRight.Name = "lblColRight";
            lblColRight.Size = new System.Drawing.Size(61, 23);
            lblColRight.TabIndex = 2;
            // 
            // lblLeftA
            // 
            lblLeftA.Dock = System.Windows.Forms.DockStyle.Fill;
            lblLeftA.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblLeftA.Location = new System.Drawing.Point(5, 28);
            lblLeftA.Name = "lblLeftA";
            lblLeftA.Size = new System.Drawing.Size(51, 26);
            lblLeftA.TabIndex = 3;
            lblLeftA.Text = "a";
            lblLeftA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLeftA
            // 
            txtLeftA.Dock = System.Windows.Forms.DockStyle.Fill;
            txtLeftA.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            txtLeftA.Location = new System.Drawing.Point(61, 30);
            txtLeftA.Margin = new System.Windows.Forms.Padding(2);
            txtLeftA.Name = "txtLeftA";
            txtLeftA.Size = new System.Drawing.Size(62, 26);
            txtLeftA.TabIndex = 4;
            txtLeftA.Text = "0.5";
            // 
            // txtRightA
            // 
            txtRightA.Dock = System.Windows.Forms.DockStyle.Fill;
            txtRightA.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            txtRightA.Location = new System.Drawing.Point(127, 30);
            txtRightA.Margin = new System.Windows.Forms.Padding(2);
            txtRightA.Name = "txtRightA";
            txtRightA.Size = new System.Drawing.Size(63, 26);
            txtRightA.TabIndex = 5;
            txtRightA.Text = "0.5";
            // 
            // lblLeftB
            // 
            lblLeftB.Dock = System.Windows.Forms.DockStyle.Fill;
            lblLeftB.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblLeftB.Location = new System.Drawing.Point(5, 54);
            lblLeftB.Name = "lblLeftB";
            lblLeftB.Size = new System.Drawing.Size(51, 26);
            lblLeftB.TabIndex = 6;
            lblLeftB.Text = "b";
            lblLeftB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLeftB
            // 
            txtLeftB.Dock = System.Windows.Forms.DockStyle.Fill;
            txtLeftB.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            txtLeftB.Location = new System.Drawing.Point(61, 56);
            txtLeftB.Margin = new System.Windows.Forms.Padding(2);
            txtLeftB.Name = "txtLeftB";
            txtLeftB.Size = new System.Drawing.Size(62, 26);
            txtLeftB.TabIndex = 7;
            txtLeftB.Text = "0.5";
            // 
            // txtRightB
            // 
            txtRightB.Dock = System.Windows.Forms.DockStyle.Fill;
            txtRightB.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            txtRightB.Location = new System.Drawing.Point(127, 56);
            txtRightB.Margin = new System.Windows.Forms.Padding(2);
            txtRightB.Name = "txtRightB";
            txtRightB.Size = new System.Drawing.Size(63, 26);
            txtRightB.TabIndex = 8;
            txtRightB.Text = "0.5";
            // 
            // btnAiExec
            // 
            btnAiExec.BackColor = System.Drawing.Color.FromArgb(80, 160, 80);
            pnlABGrid.SetColumnSpan(btnAiExec, 3);
            btnAiExec.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAiExec.Dock = System.Windows.Forms.DockStyle.Fill;
            btnAiExec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAiExec.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            btnAiExec.ForeColor = System.Drawing.Color.White;
            btnAiExec.Location = new System.Drawing.Point(4, 82);
            btnAiExec.Margin = new System.Windows.Forms.Padding(2);
            btnAiExec.Name = "btnAiExec";
            btnAiExec.Size = new System.Drawing.Size(186, 23);
            btnAiExec.TabIndex = 9;
            btnAiExec.Text = "AI Exec.";
            btnAiExec.UseVisualStyleBackColor = false;
            // 
            // tblImages
            // 
            tblImages.ColumnCount = 3;
            tblImages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            tblImages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            tblImages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            tblImages.Controls.Add(pnlLeftFull, 0, 0);
            tblImages.Controls.Add(pnlRightFull, 1, 0);
            tblImages.Controls.Add(tblCrops, 2, 0);
            tblImages.Dock = System.Windows.Forms.DockStyle.Fill;
            tblImages.Location = new System.Drawing.Point(9, 177);
            tblImages.Name = "tblImages";
            tblImages.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            tblImages.RowCount = 1;
            tblImages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tblImages.Size = new System.Drawing.Size(1364, 436);
            tblImages.TabIndex = 1;
            // 
            // pnlLeftFull
            // 
            pnlLeftFull.Controls.Add(picLeftFull);
            pnlLeftFull.Controls.Add(pnlLeftXY);
            pnlLeftFull.Controls.Add(lblLeftTitle);
            pnlLeftFull.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlLeftFull.Location = new System.Drawing.Point(3, 5);
            pnlLeftFull.Name = "pnlLeftFull";
            pnlLeftFull.Padding = new System.Windows.Forms.Padding(2);
            pnlLeftFull.Size = new System.Drawing.Size(566, 426);
            pnlLeftFull.TabIndex = 0;
            // 
            // picLeftFull
            // 
            picLeftFull.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
            picLeftFull.Dock = System.Windows.Forms.DockStyle.Fill;
            picLeftFull.Location = new System.Drawing.Point(142, 24);
            picLeftFull.Name = "picLeftFull";
            picLeftFull.Size = new System.Drawing.Size(422, 400);
            picLeftFull.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picLeftFull.TabIndex = 0;
            picLeftFull.TabStop = false;
            // 
            // pnlLeftXY
            // 
            pnlLeftXY.BackColor = System.Drawing.Color.FromArgb(245, 245, 252);
            pnlLeftXY.Controls.Add(lblLeftXY);
            pnlLeftXY.Dock = System.Windows.Forms.DockStyle.Left;
            pnlLeftXY.Location = new System.Drawing.Point(2, 24);
            pnlLeftXY.Name = "pnlLeftXY";
            pnlLeftXY.Size = new System.Drawing.Size(140, 400);
            pnlLeftXY.TabIndex = 1;
            // 
            // lblLeftXY
            // 
            lblLeftXY.AutoSize = true;
            lblLeftXY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblLeftXY.ForeColor = System.Drawing.Color.FromArgb(0, 100, 200);
            lblLeftXY.Location = new System.Drawing.Point(8, 10);
            lblLeftXY.Name = "lblLeftXY";
            lblLeftXY.Size = new System.Drawing.Size(112, 40);
            lblLeftXY.TabIndex = 0;
            lblLeftXY.Text = "Left X Position\r\nLeft Y Position";
            // 
            // lblLeftTitle
            // 
            lblLeftTitle.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            lblLeftTitle.Dock = System.Windows.Forms.DockStyle.Top;
            lblLeftTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblLeftTitle.ForeColor = System.Drawing.Color.White;
            lblLeftTitle.Location = new System.Drawing.Point(2, 2);
            lblLeftTitle.Name = "lblLeftTitle";
            lblLeftTitle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            lblLeftTitle.Size = new System.Drawing.Size(562, 22);
            lblLeftTitle.TabIndex = 2;
            lblLeftTitle.Text = "► C-IC Pre-Align Left (Full) ◄";
            lblLeftTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlRightFull
            // 
            pnlRightFull.Controls.Add(picRightFull);
            pnlRightFull.Controls.Add(pnlRightXY);
            pnlRightFull.Controls.Add(lblRightTitle);
            pnlRightFull.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlRightFull.Location = new System.Drawing.Point(575, 5);
            pnlRightFull.Name = "pnlRightFull";
            pnlRightFull.Padding = new System.Windows.Forms.Padding(2);
            pnlRightFull.Size = new System.Drawing.Size(566, 426);
            pnlRightFull.TabIndex = 1;
            // 
            // picRightFull
            // 
            picRightFull.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
            picRightFull.Dock = System.Windows.Forms.DockStyle.Fill;
            picRightFull.Location = new System.Drawing.Point(142, 24);
            picRightFull.Name = "picRightFull";
            picRightFull.Size = new System.Drawing.Size(422, 400);
            picRightFull.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picRightFull.TabIndex = 0;
            picRightFull.TabStop = false;
            // 
            // pnlRightXY
            // 
            pnlRightXY.BackColor = System.Drawing.Color.FromArgb(245, 245, 252);
            pnlRightXY.Controls.Add(lblRightXY);
            pnlRightXY.Dock = System.Windows.Forms.DockStyle.Left;
            pnlRightXY.Location = new System.Drawing.Point(2, 24);
            pnlRightXY.Name = "pnlRightXY";
            pnlRightXY.Size = new System.Drawing.Size(140, 400);
            pnlRightXY.TabIndex = 1;
            // 
            // lblRightXY
            // 
            lblRightXY.AutoSize = true;
            lblRightXY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblRightXY.ForeColor = System.Drawing.Color.FromArgb(0, 100, 200);
            lblRightXY.Location = new System.Drawing.Point(8, 10);
            lblRightXY.Name = "lblRightXY";
            lblRightXY.Size = new System.Drawing.Size(122, 40);
            lblRightXY.TabIndex = 0;
            lblRightXY.Text = "Right X Position\r\nRight Y Position";
            // 
            // lblRightTitle
            // 
            lblRightTitle.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            lblRightTitle.Dock = System.Windows.Forms.DockStyle.Top;
            lblRightTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblRightTitle.ForeColor = System.Drawing.Color.White;
            lblRightTitle.Location = new System.Drawing.Point(2, 2);
            lblRightTitle.Name = "lblRightTitle";
            lblRightTitle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            lblRightTitle.Size = new System.Drawing.Size(562, 22);
            lblRightTitle.TabIndex = 2;
            lblRightTitle.Text = "► C-IC Pre-Align Right (Full) ◄";
            lblRightTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tblCrops
            // 
            tblCrops.ColumnCount = 1;
            tblCrops.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tblCrops.Controls.Add(pnlLeftCrop, 0, 0);
            tblCrops.Controls.Add(pnlRightCrop, 0, 1);
            tblCrops.Dock = System.Windows.Forms.DockStyle.Fill;
            tblCrops.Location = new System.Drawing.Point(1147, 5);
            tblCrops.Name = "tblCrops";
            tblCrops.RowCount = 2;
            tblCrops.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tblCrops.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tblCrops.Size = new System.Drawing.Size(214, 426);
            tblCrops.TabIndex = 2;
            // 
            // pnlLeftCrop
            // 
            pnlLeftCrop.Controls.Add(picLeftCrop);
            pnlLeftCrop.Controls.Add(lblLeftCropTitle);
            pnlLeftCrop.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlLeftCrop.Location = new System.Drawing.Point(3, 3);
            pnlLeftCrop.Name = "pnlLeftCrop";
            pnlLeftCrop.Padding = new System.Windows.Forms.Padding(2);
            pnlLeftCrop.Size = new System.Drawing.Size(208, 207);
            pnlLeftCrop.TabIndex = 0;
            // 
            // picLeftCrop
            // 
            picLeftCrop.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
            picLeftCrop.Dock = System.Windows.Forms.DockStyle.Fill;
            picLeftCrop.Location = new System.Drawing.Point(2, 22);
            picLeftCrop.Name = "picLeftCrop";
            picLeftCrop.Size = new System.Drawing.Size(204, 183);
            picLeftCrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picLeftCrop.TabIndex = 0;
            picLeftCrop.TabStop = false;
            // 
            // lblLeftCropTitle
            // 
            lblLeftCropTitle.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            lblLeftCropTitle.Dock = System.Windows.Forms.DockStyle.Top;
            lblLeftCropTitle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            lblLeftCropTitle.ForeColor = System.Drawing.Color.Cyan;
            lblLeftCropTitle.Location = new System.Drawing.Point(2, 2);
            lblLeftCropTitle.Name = "lblLeftCropTitle";
            lblLeftCropTitle.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            lblLeftCropTitle.Size = new System.Drawing.Size(204, 20);
            lblLeftCropTitle.TabIndex = 1;
            lblLeftCropTitle.Text = "► C-IC Pre-Align Left ◄";
            lblLeftCropTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlRightCrop
            // 
            pnlRightCrop.Controls.Add(picRightCrop);
            pnlRightCrop.Controls.Add(lblRightCropTitle);
            pnlRightCrop.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlRightCrop.Location = new System.Drawing.Point(3, 216);
            pnlRightCrop.Name = "pnlRightCrop";
            pnlRightCrop.Padding = new System.Windows.Forms.Padding(2);
            pnlRightCrop.Size = new System.Drawing.Size(208, 207);
            pnlRightCrop.TabIndex = 1;
            // 
            // picRightCrop
            // 
            picRightCrop.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
            picRightCrop.Dock = System.Windows.Forms.DockStyle.Fill;
            picRightCrop.Location = new System.Drawing.Point(2, 22);
            picRightCrop.Name = "picRightCrop";
            picRightCrop.Size = new System.Drawing.Size(204, 183);
            picRightCrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picRightCrop.TabIndex = 0;
            picRightCrop.TabStop = false;
            // 
            // lblRightCropTitle
            // 
            lblRightCropTitle.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            lblRightCropTitle.Dock = System.Windows.Forms.DockStyle.Top;
            lblRightCropTitle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            lblRightCropTitle.ForeColor = System.Drawing.Color.Cyan;
            lblRightCropTitle.Location = new System.Drawing.Point(2, 2);
            lblRightCropTitle.Name = "lblRightCropTitle";
            lblRightCropTitle.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            lblRightCropTitle.Size = new System.Drawing.Size(204, 20);
            lblRightCropTitle.TabIndex = 1;
            lblRightCropTitle.Text = "► C-IC Pre-Align Right ◄";
            lblRightCropTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlEvent
            // 
            pnlEvent.Controls.Add(dgvEvents);
            pnlEvent.Controls.Add(lblEventTitle);
            pnlEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlEvent.Location = new System.Drawing.Point(9, 619);
            pnlEvent.Name = "pnlEvent";
            pnlEvent.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            pnlEvent.Size = new System.Drawing.Size(1364, 159);
            pnlEvent.TabIndex = 2;
            // 
            // dgvEvents
            // 
            dgvEvents.AllowUserToAddRows = false;
            dgvEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvEvents.BackgroundColor = System.Drawing.Color.White;
            dgvEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEvents.ColumnHeadersHeight = 29;
            dgvEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colImageFileName, colEventTime, colRunTime, colPosition, colXmin, colYmin, colXmax, colYmax, colXc, colYc, colScore, colDetImagePath });
            dgvEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvEvents.EnableHeadersVisualStyles = false;
            dgvEvents.Font = new System.Drawing.Font("Segoe UI", 8F);
            dgvEvents.Location = new System.Drawing.Point(0, 22);
            dgvEvents.Name = "dgvEvents";
            dgvEvents.ReadOnly = true;
            dgvEvents.RowHeadersVisible = false;
            dgvEvents.RowHeadersWidth = 51;
            dgvEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvEvents.Size = new System.Drawing.Size(1364, 137);
            dgvEvents.TabIndex = 0;
            // 
            // colImageFileName
            // 
            colImageFileName.HeaderText = "Image_File_Name";
            colImageFileName.MinimumWidth = 6;
            colImageFileName.Name = "colImageFileName";
            colImageFileName.ReadOnly = true;
            // 
            // colEventTime
            // 
            colEventTime.HeaderText = "Event_Time";
            colEventTime.MinimumWidth = 6;
            colEventTime.Name = "colEventTime";
            colEventTime.ReadOnly = true;
            // 
            // colRunTime
            // 
            colRunTime.HeaderText = "Run_Time";
            colRunTime.MinimumWidth = 6;
            colRunTime.Name = "colRunTime";
            colRunTime.ReadOnly = true;
            // 
            // colPosition
            // 
            colPosition.HeaderText = "Position";
            colPosition.MinimumWidth = 6;
            colPosition.Name = "colPosition";
            colPosition.ReadOnly = true;
            // 
            // colXmin
            // 
            colXmin.HeaderText = "Xmin";
            colXmin.MinimumWidth = 6;
            colXmin.Name = "colXmin";
            colXmin.ReadOnly = true;
            // 
            // colYmin
            // 
            colYmin.HeaderText = "Ymin";
            colYmin.MinimumWidth = 6;
            colYmin.Name = "colYmin";
            colYmin.ReadOnly = true;
            // 
            // colXmax
            // 
            colXmax.HeaderText = "Xmax";
            colXmax.MinimumWidth = 6;
            colXmax.Name = "colXmax";
            colXmax.ReadOnly = true;
            // 
            // colYmax
            // 
            colYmax.HeaderText = "Ymax";
            colYmax.MinimumWidth = 6;
            colYmax.Name = "colYmax";
            colYmax.ReadOnly = true;
            // 
            // colXc
            // 
            colXc.HeaderText = "Xc";
            colXc.MinimumWidth = 6;
            colXc.Name = "colXc";
            colXc.ReadOnly = true;
            // 
            // colYc
            // 
            colYc.HeaderText = "Yc";
            colYc.MinimumWidth = 6;
            colYc.Name = "colYc";
            colYc.ReadOnly = true;
            // 
            // colScore
            // 
            colScore.HeaderText = "Score";
            colScore.MinimumWidth = 6;
            colScore.Name = "colScore";
            colScore.ReadOnly = true;
            // 
            // colDetImagePath
            // 
            colDetImagePath.HeaderText = "Det_Image_Path";
            colDetImagePath.MinimumWidth = 6;
            colDetImagePath.Name = "colDetImagePath";
            colDetImagePath.ReadOnly = true;
            // 
            // lblEventTitle
            // 
            lblEventTitle.Dock = System.Windows.Forms.DockStyle.Top;
            lblEventTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblEventTitle.Location = new System.Drawing.Point(0, 2);
            lblEventTitle.Name = "lblEventTitle";
            lblEventTitle.Size = new System.Drawing.Size(1364, 20);
            lblEventTitle.TabIndex = 1;
            lblEventTitle.Text = "2. Event";
            // 
            // lblRightA
            // 
            lblRightA.Location = new System.Drawing.Point(0, 0);
            lblRightA.Name = "lblRightA";
            lblRightA.Size = new System.Drawing.Size(100, 23);
            lblRightA.TabIndex = 0;
            // 
            // lblRightB
            // 
            lblRightB.Location = new System.Drawing.Point(0, 0);
            lblRightB.Name = "lblRightB";
            lblRightB.Size = new System.Drawing.Size(100, 23);
            lblRightB.TabIndex = 0;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lblStatus });
            statusStrip.Location = new System.Drawing.Point(0, 827);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new System.Drawing.Size(1382, 26);
            statusStrip.TabIndex = 2;
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = System.Drawing.Color.LightGreen;
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(1367, 20);
            lblStatus.Spring = true;
            lblStatus.Text = "Ready";
            lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerClock
            // 
            timerClock.Interval = 1000;
            // 
            // Form1
            // 
            BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            ClientSize = new System.Drawing.Size(1382, 853);
            Controls.Add(tblMain);
            Controls.Add(pnlHeader);
            Controls.Add(statusStrip);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            MinimumSize = new System.Drawing.Size(1100, 750);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ONNX AI Align Mark Detection";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tblMain.ResumeLayout(false);
            pnlSettingsOuter.ResumeLayout(false);
            pnlSettingsBorder.ResumeLayout(false);
            pnlSettingsBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trkThreshold).EndInit();
            grpAlignMark.ResumeLayout(false);
            tblAlignMark.ResumeLayout(false);
            pnlABGrid.ResumeLayout(false);
            pnlABGrid.PerformLayout();
            tblImages.ResumeLayout(false);
            pnlLeftFull.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLeftFull).EndInit();
            pnlLeftXY.ResumeLayout(false);
            pnlLeftXY.PerformLayout();
            pnlRightFull.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picRightFull).EndInit();
            pnlRightXY.ResumeLayout(false);
            pnlRightXY.PerformLayout();
            tblCrops.ResumeLayout(false);
            pnlLeftCrop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLeftCrop).EndInit();
            pnlRightCrop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picRightCrop).EndInit();
            pnlEvent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEvents).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Label lblColLeft;
        private System.Windows.Forms.Label lblColRight;
    }
}
