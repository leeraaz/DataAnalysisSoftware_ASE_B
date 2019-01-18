namespace DataAnalysisSoftware
{
    partial class SelectedData
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
            this.grpPWPI = new System.Windows.Forms.GroupBox();
            this.np2 = new System.Windows.Forms.Label();
            this.lblPedalInxed = new System.Windows.Forms.Label();
            this.PILabel2 = new System.Windows.Forms.Label();
            this.lblNormalised = new System.Windows.Forms.Label();
            this.lblPowerRight = new System.Windows.Forms.Label();
            this.PBRight2 = new System.Windows.Forms.Label();
            this.lblPwrBalance = new System.Windows.Forms.Label();
            this.PBLeft2 = new System.Windows.Forms.Label();
            this.selectedZedGraph = new ZedGraph.ZedGraphControl();
            this.gropBoxALT = new System.Windows.Forms.GroupBox();
            this.lblAltMin = new System.Windows.Forms.Label();
            this.lblAltAvg = new System.Windows.Forms.Label();
            this.lblAltMax = new System.Windows.Forms.Label();
            this.grpBoxSpd = new System.Windows.Forms.GroupBox();
            this.lblSpdMin = new System.Windows.Forms.Label();
            this.lblSpdAvg = new System.Windows.Forms.Label();
            this.lblSpdMax = new System.Windows.Forms.Label();
            this.gropHR = new System.Windows.Forms.GroupBox();
            this.lblHRMin = new System.Windows.Forms.Label();
            this.lblHRAvg = new System.Windows.Forms.Label();
            this.lblHRMax = new System.Windows.Forms.Label();
            this.grpBoxPwr = new System.Windows.Forms.GroupBox();
            this.lblPwrMin = new System.Windows.Forms.Label();
            this.lblPwrAvg = new System.Windows.Forms.Label();
            this.lblPwrMax = new System.Windows.Forms.Label();
            this.grpPWPI.SuspendLayout();
            this.gropBoxALT.SuspendLayout();
            this.grpBoxSpd.SuspendLayout();
            this.gropHR.SuspendLayout();
            this.grpBoxPwr.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPWPI
            // 
            this.grpPWPI.Controls.Add(this.np2);
            this.grpPWPI.Controls.Add(this.lblPedalInxed);
            this.grpPWPI.Controls.Add(this.PILabel2);
            this.grpPWPI.Controls.Add(this.lblNormalised);
            this.grpPWPI.Controls.Add(this.lblPowerRight);
            this.grpPWPI.Controls.Add(this.PBRight2);
            this.grpPWPI.Controls.Add(this.lblPwrBalance);
            this.grpPWPI.Controls.Add(this.PBLeft2);
            this.grpPWPI.Location = new System.Drawing.Point(783, 171);
            this.grpPWPI.Name = "grpPWPI";
            this.grpPWPI.Size = new System.Drawing.Size(197, 123);
            this.grpPWPI.TabIndex = 68;
            this.grpPWPI.TabStop = false;
            this.grpPWPI.Text = "Power Balance and Pedal Index:";
            // 
            // np2
            // 
            this.np2.AutoSize = true;
            this.np2.Location = new System.Drawing.Point(106, 25);
            this.np2.Name = "np2";
            this.np2.Size = new System.Drawing.Size(28, 13);
            this.np2.TabIndex = 69;
            this.np2.Text = "0.00";
            this.np2.Visible = false;
            // 
            // lblPedalInxed
            // 
            this.lblPedalInxed.AutoSize = true;
            this.lblPedalInxed.Location = new System.Drawing.Point(6, 97);
            this.lblPedalInxed.Name = "lblPedalInxed";
            this.lblPedalInxed.Size = new System.Drawing.Size(66, 13);
            this.lblPedalInxed.TabIndex = 67;
            this.lblPedalInxed.Text = "Pedal Index:";
            // 
            // PILabel2
            // 
            this.PILabel2.AutoSize = true;
            this.PILabel2.Location = new System.Drawing.Point(70, 97);
            this.PILabel2.Name = "PILabel2";
            this.PILabel2.Size = new System.Drawing.Size(28, 13);
            this.PILabel2.TabIndex = 68;
            this.PILabel2.Text = "0.00";
            // 
            // lblNormalised
            // 
            this.lblNormalised.AutoSize = true;
            this.lblNormalised.Location = new System.Drawing.Point(6, 25);
            this.lblNormalised.Name = "lblNormalised";
            this.lblNormalised.Size = new System.Drawing.Size(95, 13);
            this.lblNormalised.TabIndex = 52;
            this.lblNormalised.Text = "Normalised Power:";
            // 
            // lblPowerRight
            // 
            this.lblPowerRight.AutoSize = true;
            this.lblPowerRight.Location = new System.Drawing.Point(6, 73);
            this.lblPowerRight.Name = "lblPowerRight";
            this.lblPowerRight.Size = new System.Drawing.Size(116, 13);
            this.lblPowerRight.TabIndex = 65;
            this.lblPowerRight.Text = "Power Balance (Right):";
            // 
            // PBRight2
            // 
            this.PBRight2.AutoSize = true;
            this.PBRight2.Location = new System.Drawing.Point(119, 73);
            this.PBRight2.Name = "PBRight2";
            this.PBRight2.Size = new System.Drawing.Size(28, 13);
            this.PBRight2.TabIndex = 66;
            this.PBRight2.Text = "0.00";
            // 
            // lblPwrBalance
            // 
            this.lblPwrBalance.AutoSize = true;
            this.lblPwrBalance.Location = new System.Drawing.Point(6, 48);
            this.lblPwrBalance.Name = "lblPwrBalance";
            this.lblPwrBalance.Size = new System.Drawing.Size(109, 13);
            this.lblPwrBalance.TabIndex = 63;
            this.lblPwrBalance.Text = "Power Balance (Left):";
            // 
            // PBLeft2
            // 
            this.PBLeft2.AutoSize = true;
            this.PBLeft2.Location = new System.Drawing.Point(119, 48);
            this.PBLeft2.Name = "PBLeft2";
            this.PBLeft2.Size = new System.Drawing.Size(28, 13);
            this.PBLeft2.TabIndex = 64;
            this.PBLeft2.Text = "0.00";
            // 
            // selectedZedGraph
            // 
            this.selectedZedGraph.Location = new System.Drawing.Point(11, 30);
            this.selectedZedGraph.Name = "selectedZedGraph";
            this.selectedZedGraph.ScrollGrace = 0D;
            this.selectedZedGraph.ScrollMaxX = 0D;
            this.selectedZedGraph.ScrollMaxY = 0D;
            this.selectedZedGraph.ScrollMaxY2 = 0D;
            this.selectedZedGraph.ScrollMinX = 0D;
            this.selectedZedGraph.ScrollMinY = 0D;
            this.selectedZedGraph.ScrollMinY2 = 0D;
            this.selectedZedGraph.Size = new System.Drawing.Size(710, 420);
            this.selectedZedGraph.TabIndex = 63;
            // 
            // gropBoxALT
            // 
            this.gropBoxALT.Controls.Add(this.lblAltMin);
            this.gropBoxALT.Controls.Add(this.lblAltAvg);
            this.gropBoxALT.Controls.Add(this.lblAltMax);
            this.gropBoxALT.Location = new System.Drawing.Point(739, 381);
            this.gropBoxALT.Name = "gropBoxALT";
            this.gropBoxALT.Size = new System.Drawing.Size(128, 69);
            this.gropBoxALT.TabIndex = 67;
            this.gropBoxALT.TabStop = false;
            this.gropBoxALT.Text = "Altitude:";
            // 
            // lblAltMin
            // 
            this.lblAltMin.AutoSize = true;
            this.lblAltMin.Location = new System.Drawing.Point(6, 51);
            this.lblAltMin.Name = "lblAltMin";
            this.lblAltMin.Size = new System.Drawing.Size(27, 13);
            this.lblAltMin.TabIndex = 18;
            this.lblAltMin.Text = "Min:";
            // 
            // lblAltAvg
            // 
            this.lblAltAvg.AutoSize = true;
            this.lblAltAvg.Location = new System.Drawing.Point(6, 16);
            this.lblAltAvg.Name = "lblAltAvg";
            this.lblAltAvg.Size = new System.Drawing.Size(29, 13);
            this.lblAltAvg.TabIndex = 15;
            this.lblAltAvg.Text = "Avg:";
            // 
            // lblAltMax
            // 
            this.lblAltMax.AutoSize = true;
            this.lblAltMax.Location = new System.Drawing.Point(6, 34);
            this.lblAltMax.Name = "lblAltMax";
            this.lblAltMax.Size = new System.Drawing.Size(30, 13);
            this.lblAltMax.TabIndex = 16;
            this.lblAltMax.Text = "Max:";
            // 
            // grpBoxSpd
            // 
            this.grpBoxSpd.Controls.Add(this.lblSpdMin);
            this.grpBoxSpd.Controls.Add(this.lblSpdAvg);
            this.grpBoxSpd.Controls.Add(this.lblSpdMax);
            this.grpBoxSpd.Location = new System.Drawing.Point(885, 31);
            this.grpBoxSpd.Name = "grpBoxSpd";
            this.grpBoxSpd.Size = new System.Drawing.Size(128, 70);
            this.grpBoxSpd.TabIndex = 65;
            this.grpBoxSpd.TabStop = false;
            this.grpBoxSpd.Text = "Speed:";
            // 
            // lblSpdMin
            // 
            this.lblSpdMin.AutoSize = true;
            this.lblSpdMin.Location = new System.Drawing.Point(6, 52);
            this.lblSpdMin.Name = "lblSpdMin";
            this.lblSpdMin.Size = new System.Drawing.Size(27, 13);
            this.lblSpdMin.TabIndex = 18;
            this.lblSpdMin.Text = "Min:";
            // 
            // lblSpdAvg
            // 
            this.lblSpdAvg.AutoSize = true;
            this.lblSpdAvg.Location = new System.Drawing.Point(7, 16);
            this.lblSpdAvg.Name = "lblSpdAvg";
            this.lblSpdAvg.Size = new System.Drawing.Size(29, 13);
            this.lblSpdAvg.TabIndex = 15;
            this.lblSpdAvg.Text = "Avg:";
            // 
            // lblSpdMax
            // 
            this.lblSpdMax.AutoSize = true;
            this.lblSpdMax.Location = new System.Drawing.Point(6, 34);
            this.lblSpdMax.Name = "lblSpdMax";
            this.lblSpdMax.Size = new System.Drawing.Size(30, 13);
            this.lblSpdMax.TabIndex = 16;
            this.lblSpdMax.Text = "Max:";
            // 
            // gropHR
            // 
            this.gropHR.Controls.Add(this.lblHRMin);
            this.gropHR.Controls.Add(this.lblHRAvg);
            this.gropHR.Controls.Add(this.lblHRMax);
            this.gropHR.Location = new System.Drawing.Point(739, 30);
            this.gropHR.Name = "gropHR";
            this.gropHR.Size = new System.Drawing.Size(128, 71);
            this.gropHR.TabIndex = 66;
            this.gropHR.TabStop = false;
            this.gropHR.Text = "Heart Rate";
            // 
            // lblHRMin
            // 
            this.lblHRMin.AutoSize = true;
            this.lblHRMin.Location = new System.Drawing.Point(6, 52);
            this.lblHRMin.Name = "lblHRMin";
            this.lblHRMin.Size = new System.Drawing.Size(27, 13);
            this.lblHRMin.TabIndex = 17;
            this.lblHRMin.Text = "Min:";
            // 
            // lblHRAvg
            // 
            this.lblHRAvg.AutoSize = true;
            this.lblHRAvg.Location = new System.Drawing.Point(6, 16);
            this.lblHRAvg.Name = "lblHRAvg";
            this.lblHRAvg.Size = new System.Drawing.Size(29, 13);
            this.lblHRAvg.TabIndex = 15;
            this.lblHRAvg.Text = "Avg:";
            // 
            // lblHRMax
            // 
            this.lblHRMax.AutoSize = true;
            this.lblHRMax.Location = new System.Drawing.Point(6, 34);
            this.lblHRMax.Name = "lblHRMax";
            this.lblHRMax.Size = new System.Drawing.Size(30, 13);
            this.lblHRMax.TabIndex = 16;
            this.lblHRMax.Text = "Max:";
            // 
            // grpBoxPwr
            // 
            this.grpBoxPwr.Controls.Add(this.lblPwrMin);
            this.grpBoxPwr.Controls.Add(this.lblPwrAvg);
            this.grpBoxPwr.Controls.Add(this.lblPwrMax);
            this.grpBoxPwr.Location = new System.Drawing.Point(900, 381);
            this.grpBoxPwr.Name = "grpBoxPwr";
            this.grpBoxPwr.Size = new System.Drawing.Size(128, 69);
            this.grpBoxPwr.TabIndex = 64;
            this.grpBoxPwr.TabStop = false;
            this.grpBoxPwr.Text = "Power";
            // 
            // lblPwrMin
            // 
            this.lblPwrMin.AutoSize = true;
            this.lblPwrMin.Location = new System.Drawing.Point(7, 51);
            this.lblPwrMin.Name = "lblPwrMin";
            this.lblPwrMin.Size = new System.Drawing.Size(27, 13);
            this.lblPwrMin.TabIndex = 19;
            this.lblPwrMin.Text = "Min:";
            // 
            // lblPwrAvg
            // 
            this.lblPwrAvg.AutoSize = true;
            this.lblPwrAvg.Location = new System.Drawing.Point(6, 16);
            this.lblPwrAvg.Name = "lblPwrAvg";
            this.lblPwrAvg.Size = new System.Drawing.Size(29, 13);
            this.lblPwrAvg.TabIndex = 15;
            this.lblPwrAvg.Text = "Avg:";
            // 
            // lblPwrMax
            // 
            this.lblPwrMax.AutoSize = true;
            this.lblPwrMax.Location = new System.Drawing.Point(6, 34);
            this.lblPwrMax.Name = "lblPwrMax";
            this.lblPwrMax.Size = new System.Drawing.Size(30, 13);
            this.lblPwrMax.TabIndex = 16;
            this.lblPwrMax.Text = "Max:";
            // 
            // SelectedData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 476);
            this.Controls.Add(this.grpPWPI);
            this.Controls.Add(this.selectedZedGraph);
            this.Controls.Add(this.gropBoxALT);
            this.Controls.Add(this.grpBoxSpd);
            this.Controls.Add(this.gropHR);
            this.Controls.Add(this.grpBoxPwr);
            this.Name = "SelectedData";
            this.Text = "SelectedData";
            this.grpPWPI.ResumeLayout(false);
            this.grpPWPI.PerformLayout();
            this.gropBoxALT.ResumeLayout(false);
            this.gropBoxALT.PerformLayout();
            this.grpBoxSpd.ResumeLayout(false);
            this.grpBoxSpd.PerformLayout();
            this.gropHR.ResumeLayout(false);
            this.gropHR.PerformLayout();
            this.grpBoxPwr.ResumeLayout(false);
            this.grpBoxPwr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox grpPWPI;
        public System.Windows.Forms.Label np2;
        private System.Windows.Forms.Label lblPedalInxed;
        public System.Windows.Forms.Label PILabel2;
        public System.Windows.Forms.Label lblNormalised;
        private System.Windows.Forms.Label lblPowerRight;
        public System.Windows.Forms.Label PBRight2;
        private System.Windows.Forms.Label lblPwrBalance;
        public System.Windows.Forms.Label PBLeft2;
        public ZedGraph.ZedGraphControl selectedZedGraph;
        public System.Windows.Forms.GroupBox gropBoxALT;
        public System.Windows.Forms.Label lblAltMin;
        public System.Windows.Forms.Label lblAltAvg;
        public System.Windows.Forms.Label lblAltMax;
        public System.Windows.Forms.GroupBox grpBoxSpd;
        public System.Windows.Forms.Label lblSpdMin;
        public System.Windows.Forms.Label lblSpdAvg;
        public System.Windows.Forms.Label lblSpdMax;
        public System.Windows.Forms.GroupBox gropHR;
        public System.Windows.Forms.Label lblHRMin;
        public System.Windows.Forms.Label lblHRAvg;
        public System.Windows.Forms.Label lblHRMax;
        public System.Windows.Forms.GroupBox grpBoxPwr;
        public System.Windows.Forms.Label lblPwrMin;
        public System.Windows.Forms.Label lblPwrAvg;
        public System.Windows.Forms.Label lblPwrMax;
    }
}