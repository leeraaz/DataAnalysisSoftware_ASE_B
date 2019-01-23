namespace DataAnalysisSoftware
{
    partial class FileComparison
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
            this.fname2 = new MetroFramework.Controls.MetroLabel();
            this.fname1 = new MetroFramework.Controls.MetroLabel();
            this.btnCompare = new MetroFramework.Controls.MetroButton();
            this.btnFileTwo = new MetroFramework.Controls.MetroButton();
            this.btnFileOne = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // fname2
            // 
            this.fname2.AutoSize = true;
            this.fname2.Location = new System.Drawing.Point(553, 177);
            this.fname2.Name = "fname2";
            this.fname2.Size = new System.Drawing.Size(54, 19);
            this.fname2.TabIndex = 5;
            this.fname2.Text = "File two";
            // 
            // fname1
            // 
            this.fname1.AutoSize = true;
            this.fname1.Location = new System.Drawing.Point(111, 177);
            this.fname1.Name = "fname1";
            this.fname1.Size = new System.Drawing.Size(58, 19);
            this.fname1.TabIndex = 6;
            this.fname1.Text = "File One";
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(269, 229);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(174, 39);
            this.btnCompare.TabIndex = 2;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseSelectable = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnFileTwo
            // 
            this.btnFileTwo.Location = new System.Drawing.Point(507, 108);
            this.btnFileTwo.Name = "btnFileTwo";
            this.btnFileTwo.Size = new System.Drawing.Size(174, 39);
            this.btnFileTwo.TabIndex = 3;
            this.btnFileTwo.Text = "Upload File two";
            this.btnFileTwo.UseSelectable = true;
            this.btnFileTwo.Click += new System.EventHandler(this.btnFileTwo_Click);
            // 
            // btnFileOne
            // 
            this.btnFileOne.Location = new System.Drawing.Point(68, 108);
            this.btnFileOne.Name = "btnFileOne";
            this.btnFileOne.Size = new System.Drawing.Size(174, 39);
            this.btnFileOne.TabIndex = 4;
            this.btnFileOne.Text = "upload File one";
            this.btnFileOne.UseSelectable = true;
            this.btnFileOne.Click += new System.EventHandler(this.btnFileOne_Click);
            // 
            // FileComparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 377);
            this.Controls.Add(this.fname2);
            this.Controls.Add(this.fname1);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnFileTwo);
            this.Controls.Add(this.btnFileOne);
            this.Name = "FileComparison";
            this.Text = "FileComparison";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel fname2;
        private MetroFramework.Controls.MetroLabel fname1;
        private MetroFramework.Controls.MetroButton btnCompare;
        private MetroFramework.Controls.MetroButton btnFileTwo;
        private MetroFramework.Controls.MetroButton btnFileOne;
    }
}