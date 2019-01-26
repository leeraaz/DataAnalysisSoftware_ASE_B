namespace DataAnalysisSoftware
{
    partial class IntervalList
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
            this.Interval_Detected = new System.Windows.Forms.ListBox();
            this.gridIntervalList = new System.Windows.Forms.DataGridView();
            this.Interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblThresHold = new System.Windows.Forms.Label();
            this.lbAvgPwr = new System.Windows.Forms.Label();
            this.lblTSPwr = new System.Windows.Forms.Label();
            this.lblAvgPwr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridIntervalList)).BeginInit();
            this.SuspendLayout();
            // 
            // Interval_Detected
            // 
            this.Interval_Detected.FormattingEnabled = true;
            this.Interval_Detected.Location = new System.Drawing.Point(11, 23);
            this.Interval_Detected.Name = "Interval_Detected";
            this.Interval_Detected.Size = new System.Drawing.Size(174, 238);
            this.Interval_Detected.TabIndex = 0;
            // 
            // gridIntervalList
            // 
            this.gridIntervalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridIntervalList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Interval,
            this.Power});
            this.gridIntervalList.Location = new System.Drawing.Point(191, 23);
            this.gridIntervalList.Name = "gridIntervalList";
            this.gridIntervalList.Size = new System.Drawing.Size(323, 238);
            this.gridIntervalList.TabIndex = 1;
            // 
            // Interval
            // 
            this.Interval.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Interval.HeaderText = "Interval";
            this.Interval.Name = "Interval";
            // 
            // Power
            // 
            this.Power.HeaderText = "Power";
            this.Power.Name = "Power";
            // 
            // lblThresHold
            // 
            this.lblThresHold.AutoSize = true;
            this.lblThresHold.Location = new System.Drawing.Point(613, 51);
            this.lblThresHold.Name = "lblThresHold";
            this.lblThresHold.Size = new System.Drawing.Size(28, 13);
            this.lblThresHold.TabIndex = 2;
            this.lblThresHold.Text = "0.00";
            // 
            // lbAvgPwr
            // 
            this.lbAvgPwr.AutoSize = true;
            this.lbAvgPwr.Location = new System.Drawing.Point(520, 78);
            this.lbAvgPwr.Name = "lbAvgPwr";
            this.lbAvgPwr.Size = new System.Drawing.Size(80, 13);
            this.lbAvgPwr.TabIndex = 3;
            this.lbAvgPwr.Text = "Average Power";
            // 
            // lblTSPwr
            // 
            this.lblTSPwr.AutoSize = true;
            this.lblTSPwr.Location = new System.Drawing.Point(520, 51);
            this.lblTSPwr.Name = "lblTSPwr";
            this.lblTSPwr.Size = new System.Drawing.Size(87, 13);
            this.lblTSPwr.TabIndex = 4;
            this.lblTSPwr.Text = "Threshold Power";
            // 
            // lblAvgPwr
            // 
            this.lblAvgPwr.AutoSize = true;
            this.lblAvgPwr.Location = new System.Drawing.Point(613, 78);
            this.lblAvgPwr.Name = "lblAvgPwr";
            this.lblAvgPwr.Size = new System.Drawing.Size(28, 13);
            this.lblAvgPwr.TabIndex = 5;
            this.lblAvgPwr.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Interval Summary Data";
            // 
            // IntervalList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 267);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAvgPwr);
            this.Controls.Add(this.lblTSPwr);
            this.Controls.Add(this.lbAvgPwr);
            this.Controls.Add(this.lblThresHold);
            this.Controls.Add(this.gridIntervalList);
            this.Controls.Add(this.Interval_Detected);
            this.Name = "IntervalList";
            this.Text = "IntervalList";
            this.Load += new System.EventHandler(this.IntervalList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridIntervalList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Interval_Detected;
        private System.Windows.Forms.DataGridView gridIntervalList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interval;
        private System.Windows.Forms.DataGridViewTextBoxColumn Power;
        private System.Windows.Forms.Label lblThresHold;
        private System.Windows.Forms.Label lbAvgPwr;
        private System.Windows.Forms.Label lblTSPwr;
        private System.Windows.Forms.Label lblAvgPwr;
        private System.Windows.Forms.Label label1;
    }
}