namespace DataAnalysisSoftware
{
    partial class Dashbord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFiles = new System.Windows.Forms.OpenFileDialog();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.time_interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heart_rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speeds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadences = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Power_watt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGraph = new System.Windows.Forms.Button();
            this.groupHeading = new System.Windows.Forms.GroupBox();
            this.lblInterval = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblSmode = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblMonitor = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.gropSumData = new System.Windows.Forms.GroupBox();
            this.lblAverageAltidude = new System.Windows.Forms.Label();
            this.lblMinAltitude = new System.Windows.Forms.Label();
            this.lblMaxAltitude = new System.Windows.Forms.Label();
            this.lblAvgPower = new System.Windows.Forms.Label();
            this.lblMinPower = new System.Windows.Forms.Label();
            this.lblMaxPower = new System.Windows.Forms.Label();
            this.lblAvgSpeed = new System.Windows.Forms.Label();
            this.lblMinSpeed = new System.Windows.Forms.Label();
            this.lblMaxSpeed = new System.Windows.Forms.Label();
            this.lblAvgHeartRate = new System.Windows.Forms.Label();
            this.lblMinHeartRate = new System.Windows.Forms.Label();
            this.lblMaxHeartRate = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.FileNameList = new System.Windows.Forms.ListBox();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUS = new System.Windows.Forms.Label();
            this.lblAir = new System.Windows.Forms.Label();
            this.lblHR = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblPowerPedal = new System.Windows.Forms.Label();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.lblPowerLR = new System.Windows.Forms.Label();
            this.lblCandence = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.btnSelectedData = new System.Windows.Forms.Button();
            this.grpBoxAdvMetrics = new System.Windows.Forms.GroupBox();
            this.lblPadelIndex = new System.Windows.Forms.Label();
            this.PILabel = new System.Windows.Forms.Label();
            this.lblPowerBalanceRight = new System.Windows.Forms.Label();
            this.PBRight = new System.Windows.Forms.Label();
            this.lblPowerBalanceLeft = new System.Windows.Forms.Label();
            this.PBLeft = new System.Windows.Forms.Label();
            this.lblheading = new System.Windows.Forms.Label();
            this.lblTSS = new System.Windows.Forms.Label();
            this.txtFTPBox = new System.Windows.Forms.TextBox();
            this.btnCalculateTSS = new System.Windows.Forms.Button();
            this.labeltss = new System.Windows.Forms.Label();
            this.lblNormalizedPwr = new System.Windows.Forms.Label();
            this.lblIntFactor = new System.Windows.Forms.Label();
            this.labelif = new System.Windows.Forms.Label();
            this.labelnp = new System.Windows.Forms.Label();
            this.btnFileCompare = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.groupHeading.SuspendLayout();
            this.gropSumData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpBoxAdvMetrics.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 27);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(656, 27);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1179, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem2});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem2
            // 
            this.aboutToolStripMenuItem2.Name = "aboutToolStripMenuItem2";
            this.aboutToolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem2.Text = "About";
            this.aboutToolStripMenuItem2.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time_interval,
            this.heart_rate,
            this.speeds,
            this.cadences,
            this.altitude,
            this.Power_watt});
            this.dataView.Location = new System.Drawing.Point(12, 236);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(719, 381);
            this.dataView.TabIndex = 5;
            // 
            // time_interval
            // 
            this.time_interval.HeaderText = "Time Interval";
            this.time_interval.Name = "time_interval";
            // 
            // heart_rate
            // 
            this.heart_rate.HeaderText = "Heart Rate (BPM)";
            this.heart_rate.Name = "heart_rate";
            // 
            // speeds
            // 
            this.speeds.HeaderText = "Speed (KM/Hr)";
            this.speeds.Name = "speeds";
            // 
            // cadences
            // 
            this.cadences.HeaderText = "Cadence (RPM)";
            this.cadences.Name = "cadences";
            // 
            // altitude
            // 
            this.altitude.HeaderText = "Altitude (Meters)";
            this.altitude.Name = "altitude";
            // 
            // Power_watt
            // 
            this.Power_watt.HeaderText = "Power(Watts)";
            this.Power_watt.Name = "Power_watt";
            // 
            // btnGraph
            // 
            this.btnGraph.Location = new System.Drawing.Point(93, 27);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(75, 23);
            this.btnGraph.TabIndex = 6;
            this.btnGraph.Text = "Graph";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // groupHeading
            // 
            this.groupHeading.Controls.Add(this.lblInterval);
            this.groupHeading.Controls.Add(this.lblVersion);
            this.groupHeading.Controls.Add(this.lblSmode);
            this.groupHeading.Controls.Add(this.lblStartDate);
            this.groupHeading.Controls.Add(this.lblDate);
            this.groupHeading.Controls.Add(this.lblMonitor);
            this.groupHeading.Controls.Add(this.lblLength);
            this.groupHeading.Location = new System.Drawing.Point(541, 68);
            this.groupHeading.Name = "groupHeading";
            this.groupHeading.Size = new System.Drawing.Size(190, 162);
            this.groupHeading.TabIndex = 7;
            this.groupHeading.TabStop = false;
            this.groupHeading.Text = "Header";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(13, 133);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(48, 13);
            this.lblInterval.TabIndex = 6;
            this.lblInterval.Text = "Internval";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(13, 25);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(42, 13);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "Version";
            // 
            // lblSmode
            // 
            this.lblSmode.AutoSize = true;
            this.lblSmode.Location = new System.Drawing.Point(13, 115);
            this.lblSmode.Name = "lblSmode";
            this.lblSmode.Size = new System.Drawing.Size(40, 13);
            this.lblSmode.TabIndex = 5;
            this.lblSmode.Text = "Smode";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(13, 58);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(13, 95);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            // 
            // lblMonitor
            // 
            this.lblMonitor.AutoSize = true;
            this.lblMonitor.Location = new System.Drawing.Point(13, 42);
            this.lblMonitor.Name = "lblMonitor";
            this.lblMonitor.Size = new System.Drawing.Size(42, 13);
            this.lblMonitor.TabIndex = 1;
            this.lblMonitor.Text = "Monitor";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(13, 77);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(40, 13);
            this.lblLength.TabIndex = 3;
            this.lblLength.Text = "Length";
            // 
            // gropSumData
            // 
            this.gropSumData.Controls.Add(this.lblAverageAltidude);
            this.gropSumData.Controls.Add(this.lblMinAltitude);
            this.gropSumData.Controls.Add(this.lblMaxAltitude);
            this.gropSumData.Controls.Add(this.lblAvgPower);
            this.gropSumData.Controls.Add(this.lblMinPower);
            this.gropSumData.Controls.Add(this.lblMaxPower);
            this.gropSumData.Controls.Add(this.lblAvgSpeed);
            this.gropSumData.Controls.Add(this.lblMinSpeed);
            this.gropSumData.Controls.Add(this.lblMaxSpeed);
            this.gropSumData.Controls.Add(this.lblAvgHeartRate);
            this.gropSumData.Controls.Add(this.lblMinHeartRate);
            this.gropSumData.Controls.Add(this.lblMaxHeartRate);
            this.gropSumData.Location = new System.Drawing.Point(737, 283);
            this.gropSumData.Name = "gropSumData";
            this.gropSumData.Size = new System.Drawing.Size(438, 334);
            this.gropSumData.TabIndex = 8;
            this.gropSumData.TabStop = false;
            this.gropSumData.Text = "Sumary Data";
            // 
            // lblAverageAltidude
            // 
            this.lblAverageAltidude.AutoSize = true;
            this.lblAverageAltidude.Location = new System.Drawing.Point(13, 311);
            this.lblAverageAltidude.Name = "lblAverageAltidude";
            this.lblAverageAltidude.Size = new System.Drawing.Size(85, 13);
            this.lblAverageAltidude.TabIndex = 12;
            this.lblAverageAltidude.Text = "Average Altitude";
            // 
            // lblMinAltitude
            // 
            this.lblMinAltitude.AutoSize = true;
            this.lblMinAltitude.Location = new System.Drawing.Point(13, 288);
            this.lblMinAltitude.Name = "lblMinAltitude";
            this.lblMinAltitude.Size = new System.Drawing.Size(86, 13);
            this.lblMinAltitude.TabIndex = 11;
            this.lblMinAltitude.Text = "Minimum Altitude";
            // 
            // lblMaxAltitude
            // 
            this.lblMaxAltitude.AutoSize = true;
            this.lblMaxAltitude.Location = new System.Drawing.Point(13, 264);
            this.lblMaxAltitude.Name = "lblMaxAltitude";
            this.lblMaxAltitude.Size = new System.Drawing.Size(89, 13);
            this.lblMaxAltitude.TabIndex = 10;
            this.lblMaxAltitude.Text = "Maximum Altitude";
            // 
            // lblAvgPower
            // 
            this.lblAvgPower.AutoSize = true;
            this.lblAvgPower.Location = new System.Drawing.Point(13, 238);
            this.lblAvgPower.Name = "lblAvgPower";
            this.lblAvgPower.Size = new System.Drawing.Size(80, 13);
            this.lblAvgPower.TabIndex = 9;
            this.lblAvgPower.Text = "Average Power";
            // 
            // lblMinPower
            // 
            this.lblMinPower.AutoSize = true;
            this.lblMinPower.Location = new System.Drawing.Point(13, 213);
            this.lblMinPower.Name = "lblMinPower";
            this.lblMinPower.Size = new System.Drawing.Size(81, 13);
            this.lblMinPower.TabIndex = 8;
            this.lblMinPower.Text = "Minimum Power";
            // 
            // lblMaxPower
            // 
            this.lblMaxPower.AutoSize = true;
            this.lblMaxPower.Location = new System.Drawing.Point(13, 186);
            this.lblMaxPower.Name = "lblMaxPower";
            this.lblMaxPower.Size = new System.Drawing.Size(84, 13);
            this.lblMaxPower.TabIndex = 7;
            this.lblMaxPower.Text = "Maximum Power";
            // 
            // lblAvgSpeed
            // 
            this.lblAvgSpeed.AutoSize = true;
            this.lblAvgSpeed.Location = new System.Drawing.Point(10, 158);
            this.lblAvgSpeed.Name = "lblAvgSpeed";
            this.lblAvgSpeed.Size = new System.Drawing.Size(81, 13);
            this.lblAvgSpeed.TabIndex = 6;
            this.lblAvgSpeed.Text = "Average Speed";
            // 
            // lblMinSpeed
            // 
            this.lblMinSpeed.AutoSize = true;
            this.lblMinSpeed.Location = new System.Drawing.Point(10, 130);
            this.lblMinSpeed.Name = "lblMinSpeed";
            this.lblMinSpeed.Size = new System.Drawing.Size(82, 13);
            this.lblMinSpeed.TabIndex = 5;
            this.lblMinSpeed.Text = "Minimum Speed";
            // 
            // lblMaxSpeed
            // 
            this.lblMaxSpeed.AutoSize = true;
            this.lblMaxSpeed.Location = new System.Drawing.Point(10, 103);
            this.lblMaxSpeed.Name = "lblMaxSpeed";
            this.lblMaxSpeed.Size = new System.Drawing.Size(85, 13);
            this.lblMaxSpeed.TabIndex = 4;
            this.lblMaxSpeed.Text = "Maximum Speed";
            // 
            // lblAvgHeartRate
            // 
            this.lblAvgHeartRate.AutoSize = true;
            this.lblAvgHeartRate.Location = new System.Drawing.Point(10, 76);
            this.lblAvgHeartRate.Name = "lblAvgHeartRate";
            this.lblAvgHeartRate.Size = new System.Drawing.Size(102, 13);
            this.lblAvgHeartRate.TabIndex = 3;
            this.lblAvgHeartRate.Text = "Average Heart Rate";
            // 
            // lblMinHeartRate
            // 
            this.lblMinHeartRate.AutoSize = true;
            this.lblMinHeartRate.Location = new System.Drawing.Point(10, 49);
            this.lblMinHeartRate.Name = "lblMinHeartRate";
            this.lblMinHeartRate.Size = new System.Drawing.Size(103, 13);
            this.lblMinHeartRate.TabIndex = 2;
            this.lblMinHeartRate.Text = "Minimum Heart Rate";
            // 
            // lblMaxHeartRate
            // 
            this.lblMaxHeartRate.AutoSize = true;
            this.lblMaxHeartRate.Location = new System.Drawing.Point(10, 25);
            this.lblMaxHeartRate.Name = "lblMaxHeartRate";
            this.lblMaxHeartRate.Size = new System.Drawing.Size(106, 13);
            this.lblMaxHeartRate.TabIndex = 1;
            this.lblMaxHeartRate.Text = "Maximum Heart Rate";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Maiandra GD", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(138, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(397, 160);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "Polar Cycle  Computer\n\nData Analysis";
            // 
            // FileNameList
            // 
            this.FileNameList.FormattingEnabled = true;
            this.FileNameList.Location = new System.Drawing.Point(12, 68);
            this.FileNameList.Name = "FileNameList";
            this.FileNameList.Size = new System.Drawing.Size(120, 160);
            this.FileNameList.TabIndex = 11;
            this.FileNameList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FileNameList_MouseClick);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUS);
            this.groupBox1.Controls.Add(this.lblAir);
            this.groupBox1.Controls.Add(this.lblHR);
            this.groupBox1.Controls.Add(this.lblSpeed);
            this.groupBox1.Controls.Add(this.lblPowerPedal);
            this.groupBox1.Controls.Add(this.lblAltitude);
            this.groupBox1.Controls.Add(this.lblPowerLR);
            this.groupBox1.Controls.Add(this.lblCandence);
            this.groupBox1.Controls.Add(this.lblPower);
            this.groupBox1.Location = new System.Drawing.Point(737, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 236);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Smode";
            // 
            // lblUS
            // 
            this.lblUS.Location = new System.Drawing.Point(13, 154);
            this.lblUS.Name = "lblUS";
            this.lblUS.Size = new System.Drawing.Size(83, 13);
            this.lblUS.TabIndex = 0;
            this.lblUS.Text = "US/Euro unit";
            // 
            // lblAir
            // 
            this.lblAir.Location = new System.Drawing.Point(13, 178);
            this.lblAir.Name = "lblAir";
            this.lblAir.Size = new System.Drawing.Size(128, 13);
            this.lblAir.TabIndex = 0;
            this.lblAir.Text = "Air Pressure";
            // 
            // lblHR
            // 
            this.lblHR.AutoSize = true;
            this.lblHR.Location = new System.Drawing.Point(13, 133);
            this.lblHR.Name = "lblHR";
            this.lblHR.Size = new System.Drawing.Size(42, 13);
            this.lblHR.TabIndex = 6;
            this.lblHR.Text = "HR/CC";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(13, 25);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(38, 13);
            this.lblSpeed.TabIndex = 0;
            this.lblSpeed.Text = "Speed";
            // 
            // lblPowerPedal
            // 
            this.lblPowerPedal.AutoSize = true;
            this.lblPowerPedal.Location = new System.Drawing.Point(13, 115);
            this.lblPowerPedal.Name = "lblPowerPedal";
            this.lblPowerPedal.Size = new System.Drawing.Size(112, 13);
            this.lblPowerPedal.TabIndex = 5;
            this.lblPowerPedal.Text = "Power Pedalling Index";
            // 
            // lblAltitude
            // 
            this.lblAltitude.AutoSize = true;
            this.lblAltitude.Location = new System.Drawing.Point(13, 58);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(42, 13);
            this.lblAltitude.TabIndex = 2;
            this.lblAltitude.Text = "Altitude";
            // 
            // lblPowerLR
            // 
            this.lblPowerLR.AutoSize = true;
            this.lblPowerLR.Location = new System.Drawing.Point(13, 95);
            this.lblPowerLR.Name = "lblPowerLR";
            this.lblPowerLR.Size = new System.Drawing.Size(128, 13);
            this.lblPowerLR.TabIndex = 4;
            this.lblPowerLR.Text = "Power Left Right Balance";
            // 
            // lblCandence
            // 
            this.lblCandence.AutoSize = true;
            this.lblCandence.Location = new System.Drawing.Point(13, 42);
            this.lblCandence.Name = "lblCandence";
            this.lblCandence.Size = new System.Drawing.Size(50, 13);
            this.lblCandence.TabIndex = 1;
            this.lblCandence.Text = "Cadence";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Location = new System.Drawing.Point(13, 77);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(37, 13);
            this.lblPower.TabIndex = 3;
            this.lblPower.Text = "Power";
            // 
            // btnSelectedData
            // 
            this.btnSelectedData.Location = new System.Drawing.Point(174, 27);
            this.btnSelectedData.Name = "btnSelectedData";
            this.btnSelectedData.Size = new System.Drawing.Size(159, 23);
            this.btnSelectedData.TabIndex = 13;
            this.btnSelectedData.Text = "Calculate Selected Data.";
            this.btnSelectedData.UseVisualStyleBackColor = true;
            this.btnSelectedData.Click += new System.EventHandler(this.btnSelectedData_Click);
            // 
            // grpBoxAdvMetrics
            // 
            this.grpBoxAdvMetrics.Controls.Add(this.lblPadelIndex);
            this.grpBoxAdvMetrics.Controls.Add(this.PILabel);
            this.grpBoxAdvMetrics.Controls.Add(this.lblPowerBalanceRight);
            this.grpBoxAdvMetrics.Controls.Add(this.PBRight);
            this.grpBoxAdvMetrics.Controls.Add(this.lblPowerBalanceLeft);
            this.grpBoxAdvMetrics.Controls.Add(this.PBLeft);
            this.grpBoxAdvMetrics.Controls.Add(this.lblheading);
            this.grpBoxAdvMetrics.Controls.Add(this.lblTSS);
            this.grpBoxAdvMetrics.Controls.Add(this.txtFTPBox);
            this.grpBoxAdvMetrics.Controls.Add(this.btnCalculateTSS);
            this.grpBoxAdvMetrics.Controls.Add(this.labeltss);
            this.grpBoxAdvMetrics.Controls.Add(this.lblNormalizedPwr);
            this.grpBoxAdvMetrics.Controls.Add(this.lblIntFactor);
            this.grpBoxAdvMetrics.Controls.Add(this.labelif);
            this.grpBoxAdvMetrics.Controls.Add(this.labelnp);
            this.grpBoxAdvMetrics.Location = new System.Drawing.Point(919, 27);
            this.grpBoxAdvMetrics.Name = "grpBoxAdvMetrics";
            this.grpBoxAdvMetrics.Size = new System.Drawing.Size(256, 236);
            this.grpBoxAdvMetrics.TabIndex = 62;
            this.grpBoxAdvMetrics.TabStop = false;
            this.grpBoxAdvMetrics.Text = "Advanced Metrics:";
            // 
            // lblPadelIndex
            // 
            this.lblPadelIndex.AutoSize = true;
            this.lblPadelIndex.Location = new System.Drawing.Point(6, 215);
            this.lblPadelIndex.Name = "lblPadelIndex";
            this.lblPadelIndex.Size = new System.Drawing.Size(66, 13);
            this.lblPadelIndex.TabIndex = 67;
            this.lblPadelIndex.Text = "Pedal Index:";
            // 
            // PILabel
            // 
            this.PILabel.AutoSize = true;
            this.PILabel.Location = new System.Drawing.Point(196, 215);
            this.PILabel.Name = "PILabel";
            this.PILabel.Size = new System.Drawing.Size(28, 13);
            this.PILabel.TabIndex = 68;
            this.PILabel.Text = "0.00";
            // 
            // lblPowerBalanceRight
            // 
            this.lblPowerBalanceRight.AutoSize = true;
            this.lblPowerBalanceRight.Location = new System.Drawing.Point(6, 191);
            this.lblPowerBalanceRight.Name = "lblPowerBalanceRight";
            this.lblPowerBalanceRight.Size = new System.Drawing.Size(116, 13);
            this.lblPowerBalanceRight.TabIndex = 65;
            this.lblPowerBalanceRight.Text = "Power Balance (Right):";
            // 
            // PBRight
            // 
            this.PBRight.AutoSize = true;
            this.PBRight.Location = new System.Drawing.Point(196, 191);
            this.PBRight.Name = "PBRight";
            this.PBRight.Size = new System.Drawing.Size(28, 13);
            this.PBRight.TabIndex = 66;
            this.PBRight.Text = "0.00";
            // 
            // lblPowerBalanceLeft
            // 
            this.lblPowerBalanceLeft.AutoSize = true;
            this.lblPowerBalanceLeft.Location = new System.Drawing.Point(6, 166);
            this.lblPowerBalanceLeft.Name = "lblPowerBalanceLeft";
            this.lblPowerBalanceLeft.Size = new System.Drawing.Size(109, 13);
            this.lblPowerBalanceLeft.TabIndex = 63;
            this.lblPowerBalanceLeft.Text = "Power Balance (Left):";
            // 
            // PBLeft
            // 
            this.PBLeft.AutoSize = true;
            this.PBLeft.Location = new System.Drawing.Point(196, 166);
            this.PBLeft.Name = "PBLeft";
            this.PBLeft.Size = new System.Drawing.Size(28, 13);
            this.PBLeft.TabIndex = 64;
            this.PBLeft.Text = "0.00";
            // 
            // lblheading
            // 
            this.lblheading.AutoSize = true;
            this.lblheading.Location = new System.Drawing.Point(6, 20);
            this.lblheading.Name = "lblheading";
            this.lblheading.Size = new System.Drawing.Size(181, 13);
            this.lblheading.TabIndex = 62;
            this.lblheading.Text = "Functional Threshold Power in Watts";
            // 
            // lblTSS
            // 
            this.lblTSS.AutoSize = true;
            this.lblTSS.Location = new System.Drawing.Point(6, 80);
            this.lblTSS.Name = "lblTSS";
            this.lblTSS.Size = new System.Drawing.Size(111, 13);
            this.lblTSS.TabIndex = 61;
            this.lblTSS.Text = "Training Stress Score:";
            // 
            // txtFTPBox
            // 
            this.txtFTPBox.Location = new System.Drawing.Point(6, 46);
            this.txtFTPBox.Name = "txtFTPBox";
            this.txtFTPBox.Size = new System.Drawing.Size(144, 20);
            this.txtFTPBox.TabIndex = 53;
            // 
            // btnCalculateTSS
            // 
            this.btnCalculateTSS.Location = new System.Drawing.Point(156, 44);
            this.btnCalculateTSS.Name = "btnCalculateTSS";
            this.btnCalculateTSS.Size = new System.Drawing.Size(92, 23);
            this.btnCalculateTSS.TabIndex = 54;
            this.btnCalculateTSS.Text = "Calculate";
            this.btnCalculateTSS.UseVisualStyleBackColor = true;
            this.btnCalculateTSS.Click += new System.EventHandler(this.btnCalculateTSS_Click);
            // 
            // labeltss
            // 
            this.labeltss.AutoSize = true;
            this.labeltss.Location = new System.Drawing.Point(196, 80);
            this.labeltss.Name = "labeltss";
            this.labeltss.Size = new System.Drawing.Size(28, 13);
            this.labeltss.TabIndex = 60;
            this.labeltss.Text = "0.00";
            // 
            // lblNormalizedPwr
            // 
            this.lblNormalizedPwr.AutoSize = true;
            this.lblNormalizedPwr.Location = new System.Drawing.Point(6, 137);
            this.lblNormalizedPwr.Name = "lblNormalizedPwr";
            this.lblNormalizedPwr.Size = new System.Drawing.Size(95, 13);
            this.lblNormalizedPwr.TabIndex = 55;
            this.lblNormalizedPwr.Text = "Normalized Power:";
            // 
            // lblIntFactor
            // 
            this.lblIntFactor.AutoSize = true;
            this.lblIntFactor.Location = new System.Drawing.Point(6, 110);
            this.lblIntFactor.Name = "lblIntFactor";
            this.lblIntFactor.Size = new System.Drawing.Size(82, 13);
            this.lblIntFactor.TabIndex = 56;
            this.lblIntFactor.Text = "Intensity Factor:";
            // 
            // labelif
            // 
            this.labelif.AutoSize = true;
            this.labelif.Location = new System.Drawing.Point(196, 110);
            this.labelif.Name = "labelif";
            this.labelif.Size = new System.Drawing.Size(28, 13);
            this.labelif.TabIndex = 58;
            this.labelif.Text = "0.00";
            // 
            // labelnp
            // 
            this.labelnp.AutoSize = true;
            this.labelnp.Location = new System.Drawing.Point(196, 136);
            this.labelnp.Name = "labelnp";
            this.labelnp.Size = new System.Drawing.Size(28, 13);
            this.labelnp.TabIndex = 57;
            this.labelnp.Text = "0.00";
            // 
            // btnFileCompare
            // 
            this.btnFileCompare.Location = new System.Drawing.Point(339, 27);
            this.btnFileCompare.Name = "btnFileCompare";
            this.btnFileCompare.Size = new System.Drawing.Size(159, 23);
            this.btnFileCompare.TabIndex = 63;
            this.btnFileCompare.Text = "File Comparison";
            this.btnFileCompare.UseVisualStyleBackColor = true;
            this.btnFileCompare.Click += new System.EventHandler(this.btnFileCompare_Click);
            // 
            // Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 629);
            this.Controls.Add(this.btnFileCompare);
            this.Controls.Add(this.grpBoxAdvMetrics);
            this.Controls.Add(this.btnSelectedData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FileNameList);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.gropSumData);
            this.Controls.Add(this.groupHeading);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashbord";
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.groupHeading.ResumeLayout(false);
            this.groupHeading.PerformLayout();
            this.gropSumData.ResumeLayout(false);
            this.gropSumData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBoxAdvMetrics.ResumeLayout(false);
            this.grpBoxAdvMetrics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.OpenFileDialog openFiles;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.GroupBox groupHeading;
        private System.Windows.Forms.GroupBox gropSumData;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblMonitor;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblAverageAltidude;
        private System.Windows.Forms.Label lblMinAltitude;
        private System.Windows.Forms.Label lblMaxAltitude;
        private System.Windows.Forms.Label lblAvgPower;
        private System.Windows.Forms.Label lblMinPower;
        private System.Windows.Forms.Label lblMaxPower;
        private System.Windows.Forms.Label lblAvgSpeed;
        private System.Windows.Forms.Label lblMinSpeed;
        private System.Windows.Forms.Label lblMaxSpeed;
        private System.Windows.Forms.Label lblAvgHeartRate;
        private System.Windows.Forms.Label lblMinHeartRate;
        private System.Windows.Forms.Label lblMaxHeartRate;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox FileNameList;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblSmode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUS;
        private System.Windows.Forms.Label lblHR;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblPowerPedal;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.Label lblPowerLR;
        private System.Windows.Forms.Label lblCandence;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Label lblAir;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_interval;
        private System.Windows.Forms.DataGridViewTextBoxColumn heart_rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn speeds;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadences;
        private System.Windows.Forms.DataGridViewTextBoxColumn altitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Power_watt;
        private System.Windows.Forms.Button btnSelectedData;
        private System.Windows.Forms.GroupBox grpBoxAdvMetrics;
        private System.Windows.Forms.Label lblPadelIndex;
        private System.Windows.Forms.Label PILabel;
        private System.Windows.Forms.Label lblPowerBalanceRight;
        private System.Windows.Forms.Label PBRight;
        private System.Windows.Forms.Label lblPowerBalanceLeft;
        private System.Windows.Forms.Label PBLeft;
        private System.Windows.Forms.Label lblheading;
        private System.Windows.Forms.Label lblTSS;
        private System.Windows.Forms.TextBox txtFTPBox;
        private System.Windows.Forms.Button btnCalculateTSS;
        private System.Windows.Forms.Label labeltss;
        private System.Windows.Forms.Label lblNormalizedPwr;
        private System.Windows.Forms.Label lblIntFactor;
        private System.Windows.Forms.Label labelif;
        private System.Windows.Forms.Label labelnp;
        private System.Windows.Forms.Button btnFileCompare;
    }
}

