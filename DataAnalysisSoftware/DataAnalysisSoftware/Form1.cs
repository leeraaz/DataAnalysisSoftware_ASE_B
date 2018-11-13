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
                int totalRows = 0;
                int rows = 0;

                dataView.ColumnCount = 6;
                dataView.Columns[0].Name = "Heart Rates";
                dataView.Columns[1].Name = "Speed";
                dataView.Columns[2].Name = "Cadence";
                dataView.Columns[3].Name = "Altitude";
                dataView.Columns[4].Name = "Power";
                dataView.Columns[5].Name = "Power Balance and Pedaling Index";

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
                    dataView.AllowUserToAddRows = false;
                    string text = "";
                    for (text = streamReader.ReadLine(); text != null; text = streamReader.ReadLine())
                    {
                        string[] array = text.Split('\t');
                        dataView.Rows.Add(array);
                    }
                    //fileReading.Text = b + data;

                    //int s = totalRows - rows;
                    //string[] arrayData = new string[s];

                    //string heart = "";
                    //string speed = "";
                    //string cadence = "";
                    //string altitude = "";
                    //string power = "";
                    //string pbpi = "";
                    //if (rows != 0)
                    //{
                    //    foreach (string line in filelines)
                    //    {
                    //        if (rows < b)
                    //        {
                    //            data += line + "\r\n";
                    //            string[] words = line.Split('\t');
                    //            for (int x = 0; x < words.Length; x++)
                    //            {
                    //                if (x == 0) heart = words[x];
                    //                else if (x == 1) speed = words[x];
                    //                else if (x == 2) cadence = words[x];
                    //                else if (x == 3) altitude = words[x];
                    //                else if (x == 4) power = words[x];
                    //                else pbpi = words[x];
                    //            }
                    //            string[] row_val = new string[] { heart, speed, cadence, altitude, power, pbpi };
                    //            dataView.Rows.Add(row_val);
                    //        }
                    //        else b++;
                    //    }
                    //}
                    fileReading.Text = data;
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
