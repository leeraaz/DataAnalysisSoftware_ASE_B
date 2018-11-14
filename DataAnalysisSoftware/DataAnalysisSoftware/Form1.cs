using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DataAnalysisSoftware
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            bool flag = this.openFiles.ShowDialog() != DialogResult.Cancel;
            if (flag)
            {
                string data = "";
                int a = 0;
                int b = 0;

                StreamReader streamReader = new StreamReader(openFiles.FileName);
                string[] filelines = File.ReadAllLines(openFiles.FileName);
                foreach (string line in filelines)
                {
                    if (line.Equals("[HRData]"))
                    {
                        a = b;
                    }
                    if (a > 0)
                    {
                        data += line + "\r\n";
                    }
                    b++;
                }
                    fileReading.Text = b + data;

                    dataView.ColumnCount = 6;
                    dataView.Columns[0].Name = "Heart Rates";
                    dataView.Columns[1].Name = "Speed";
                    dataView.Columns[2].Name = "Cadence";
                    dataView.Columns[3].Name = "Altitude";
                    dataView.Columns[4].Name = "Power";
                    dataView.Columns[5].Name = "Power Balance and Pedaling Index";

                dataView.AllowUserToAddRows = false;
                foreach (string line in filelines)
                {
                    data += line + "\r\n";
                    string[] text = line.Split('\t');
                    try
                    {
                        for (int x = 0; x < text.Length; x++)
                        {
                            string[] row_val = new string[] { text[0], text[1], text[2], text[3], text[4], text[5] };
                            dataView.Rows.Add(row_val);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error occured", "Error");
                    }
                    
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
