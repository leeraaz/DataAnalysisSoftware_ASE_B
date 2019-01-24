using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAnalysisSoftware
{
    public partial class FileComparison : Form
    {
        string fn1, fn2;
        List<string> filenames = new List<string>();

        public FileComparison()
        {
            InitializeComponent();
        }

        private void btnFileTwo_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "hrm|*.hrm|All|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                fn2 = open.FileName; // name of the browsed file 

            }
            if (fn2.Equals(fn1))
            {
                MessageBox.Show("Cannot insert two files of same name try again.");
            }
            else
            {
                filenames.Add(fn2);
                fname2.Text = Path.GetFileName(fn2);
                fname2.Visible = true;
                btnCompare.Enabled = true;
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            try
            {
                ComparedData cd = new ComparedData(filenames);
                cd.Show();
            }
            catch (Exception) { }
        }

        private void btnFileOne_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "hrm|*.hrm|All|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                fn1 = open.FileName; // name of the browsed file 

            }
            filenames.Add(fn1);
            fname1.Text = Path.GetFileName(fn1);
            fname1.Visible = true;
        }
    }
}
