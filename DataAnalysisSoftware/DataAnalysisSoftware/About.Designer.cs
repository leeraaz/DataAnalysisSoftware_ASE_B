namespace DataAnalysisSoftware
{
    partial class About
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDataAnalysis = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackgroundImage = global::DataAnalysisSoftware.Properties.Resources.icon_mda;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 254);
            this.panel1.TabIndex = 0;
            // 
            // lblDataAnalysis
            // 
            this.lblDataAnalysis.AutoSize = true;
            this.lblDataAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAnalysis.Location = new System.Drawing.Point(307, 24);
            this.lblDataAnalysis.Name = "lblDataAnalysis";
            this.lblDataAnalysis.Size = new System.Drawing.Size(256, 25);
            this.lblDataAnalysis.TabIndex = 1;
            this.lblDataAnalysis.Text = "Data Analysis Software";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(515, 257);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(87, 13);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Version 1.1.5001";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(300, 71);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(263, 163);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Data Analysis Software\n\nAll Rights Preserved\n\nDesigned and developed by:\nLiraj Ma" +
    "harjan\n2019\n";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 279);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblDataAnalysis);
            this.Controls.Add(this.panel1);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDataAnalysis;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}