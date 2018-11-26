namespace DataAnalysisSoftware
{
    partial class graphImage
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
            this.btnClose = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.lblCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(682, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(24, 12);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(652, 343);
            this.zedGraphControl1.TabIndex = 9;
            this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // lblCombo
            // 
            this.lblCombo.FormattingEnabled = true;
            this.lblCombo.Items.AddRange(new object[] {
            "None",
            "Heart Rate",
            "Altitude",
            "Speed",
            "Cadence",
            "Power"});
            this.lblCombo.Location = new System.Drawing.Point(682, 41);
            this.lblCombo.Name = "lblCombo";
            this.lblCombo.Size = new System.Drawing.Size(121, 21);
            this.lblCombo.TabIndex = 10;
            this.lblCombo.Text = "None";
            // 
            // graphImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 367);
            this.Controls.Add(this.lblCombo);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.btnClose);
            this.Name = "graphImage";
            this.Text = "graphImage";
            this.Load += new System.EventHandler(this.graphImage_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btnClose;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.ComboBox lblCombo;
    }
}