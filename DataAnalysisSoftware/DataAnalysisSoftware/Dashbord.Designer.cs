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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFiles = new System.Windows.Forms.OpenFileDialog();
            this.dataView = new System.Windows.Forms.DataGridView();
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
            this.monthlyCalender = new System.Windows.Forms.MonthCalendar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.groupHeading.SuspendLayout();
            this.gropSumData.SuspendLayout();
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
            this.btnCancel.Location = new System.Drawing.Point(601, 27);
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
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(12, 236);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(664, 381);
            this.dataView.TabIndex = 5;
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
            this.groupHeading.Location = new System.Drawing.Point(257, 62);
            this.groupHeading.Name = "groupHeading";
            this.groupHeading.Size = new System.Drawing.Size(198, 162);
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
            this.gropSumData.Location = new System.Drawing.Point(682, 236);
            this.gropSumData.Name = "gropSumData";
            this.gropSumData.Size = new System.Drawing.Size(200, 381);
            this.gropSumData.TabIndex = 8;
            this.gropSumData.TabStop = false;
            this.gropSumData.Text = "Sumary Data";
            // 
            // lblAverageAltidude
            // 
            this.lblAverageAltidude.AutoSize = true;
            this.lblAverageAltidude.Location = new System.Drawing.Point(6, 297);
            this.lblAverageAltidude.Name = "lblAverageAltidude";
            this.lblAverageAltidude.Size = new System.Drawing.Size(85, 13);
            this.lblAverageAltidude.TabIndex = 12;
            this.lblAverageAltidude.Text = "Average Altitude";
            // 
            // lblMinAltitude
            // 
            this.lblMinAltitude.AutoSize = true;
            this.lblMinAltitude.Location = new System.Drawing.Point(6, 275);
            this.lblMinAltitude.Name = "lblMinAltitude";
            this.lblMinAltitude.Size = new System.Drawing.Size(86, 13);
            this.lblMinAltitude.TabIndex = 11;
            this.lblMinAltitude.Text = "Minimum Altitude";
            // 
            // lblMaxAltitude
            // 
            this.lblMaxAltitude.AutoSize = true;
            this.lblMaxAltitude.Location = new System.Drawing.Point(6, 257);
            this.lblMaxAltitude.Name = "lblMaxAltitude";
            this.lblMaxAltitude.Size = new System.Drawing.Size(89, 13);
            this.lblMaxAltitude.TabIndex = 10;
            this.lblMaxAltitude.Text = "Maximum Altitude";
            // 
            // lblAvgPower
            // 
            this.lblAvgPower.AutoSize = true;
            this.lblAvgPower.Location = new System.Drawing.Point(6, 233);
            this.lblAvgPower.Name = "lblAvgPower";
            this.lblAvgPower.Size = new System.Drawing.Size(80, 13);
            this.lblAvgPower.TabIndex = 9;
            this.lblAvgPower.Text = "Average Power";
            // 
            // lblMinPower
            // 
            this.lblMinPower.AutoSize = true;
            this.lblMinPower.Location = new System.Drawing.Point(6, 207);
            this.lblMinPower.Name = "lblMinPower";
            this.lblMinPower.Size = new System.Drawing.Size(81, 13);
            this.lblMinPower.TabIndex = 8;
            this.lblMinPower.Text = "Minimum Power";
            // 
            // lblMaxPower
            // 
            this.lblMaxPower.AutoSize = true;
            this.lblMaxPower.Location = new System.Drawing.Point(6, 183);
            this.lblMaxPower.Name = "lblMaxPower";
            this.lblMaxPower.Size = new System.Drawing.Size(84, 13);
            this.lblMaxPower.TabIndex = 7;
            this.lblMaxPower.Text = "Maximum Power";
            // 
            // lblAvgSpeed
            // 
            this.lblAvgSpeed.AutoSize = true;
            this.lblAvgSpeed.Location = new System.Drawing.Point(6, 151);
            this.lblAvgSpeed.Name = "lblAvgSpeed";
            this.lblAvgSpeed.Size = new System.Drawing.Size(81, 13);
            this.lblAvgSpeed.TabIndex = 6;
            this.lblAvgSpeed.Text = "Average Speed";
            // 
            // lblMinSpeed
            // 
            this.lblMinSpeed.AutoSize = true;
            this.lblMinSpeed.Location = new System.Drawing.Point(6, 124);
            this.lblMinSpeed.Name = "lblMinSpeed";
            this.lblMinSpeed.Size = new System.Drawing.Size(82, 13);
            this.lblMinSpeed.TabIndex = 5;
            this.lblMinSpeed.Text = "Minimum Speed";
            // 
            // lblMaxSpeed
            // 
            this.lblMaxSpeed.AutoSize = true;
            this.lblMaxSpeed.Location = new System.Drawing.Point(6, 95);
            this.lblMaxSpeed.Name = "lblMaxSpeed";
            this.lblMaxSpeed.Size = new System.Drawing.Size(85, 13);
            this.lblMaxSpeed.TabIndex = 4;
            this.lblMaxSpeed.Text = "Maximum Speed";
            // 
            // lblAvgHeartRate
            // 
            this.lblAvgHeartRate.AutoSize = true;
            this.lblAvgHeartRate.Location = new System.Drawing.Point(6, 73);
            this.lblAvgHeartRate.Name = "lblAvgHeartRate";
            this.lblAvgHeartRate.Size = new System.Drawing.Size(102, 13);
            this.lblAvgHeartRate.TabIndex = 3;
            this.lblAvgHeartRate.Text = "Average Heart Rate";
            // 
            // lblMinHeartRate
            // 
            this.lblMinHeartRate.AutoSize = true;
            this.lblMinHeartRate.Location = new System.Drawing.Point(6, 47);
            this.lblMinHeartRate.Name = "lblMinHeartRate";
            this.lblMinHeartRate.Size = new System.Drawing.Size(103, 13);
            this.lblMinHeartRate.TabIndex = 2;
            this.lblMinHeartRate.Text = "Minimum Heart Rate";
            // 
            // lblMaxHeartRate
            // 
            this.lblMaxHeartRate.AutoSize = true;
            this.lblMaxHeartRate.Location = new System.Drawing.Point(6, 16);
            this.lblMaxHeartRate.Name = "lblMaxHeartRate";
            this.lblMaxHeartRate.Size = new System.Drawing.Size(106, 13);
            this.lblMaxHeartRate.TabIndex = 1;
            this.lblMaxHeartRate.Text = "Maximum Heart Rate";
            // 
            // monthlyCalender
            // 
            this.monthlyCalender.Location = new System.Drawing.Point(18, 62);
            this.monthlyCalender.Name = "monthlyCalender";
            this.monthlyCalender.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(461, 62);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(385, 146);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 629);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.monthlyCalender);
            this.Controls.Add(this.gropSumData);
            this.Controls.Add(this.groupHeading);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashbord";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.groupHeading.ResumeLayout(false);
            this.groupHeading.PerformLayout();
            this.gropSumData.ResumeLayout(false);
            this.gropSumData.PerformLayout();
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
        private System.Windows.Forms.Label lblSmode;
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
        private System.Windows.Forms.MonthCalendar monthlyCalender;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

