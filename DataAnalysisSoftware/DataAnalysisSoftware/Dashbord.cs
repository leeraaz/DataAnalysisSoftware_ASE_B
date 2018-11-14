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
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //selection of file
            bool flag = this.openFiles.ShowDialog() != DialogResult.Cancel;
            if (flag)
            {
                string data = "";
                int rows = 0;
                int a = 0;
                int b = 0;

                StreamReader streamReader = new StreamReader(openFiles.FileName);
                string[] filelines = File.ReadAllLines(openFiles.FileName);// reading text file line by lines

                //filtering data to get only HRData
                foreach (string line in filelines)
                {
                    if (line.Equals("[HRData]"))
                    {
                        rows = a;
                    }
                    a++;
                }
                //fileReading.Text = b + data;

                //loading data into grid view.
                dataView.AllowUserToAddRows = false;
                dataView.ColumnCount = 6;
                dataView.Columns[0].Name = "Heart Rates";
                dataView.Columns[1].Name = "Speed";
                dataView.Columns[2].Name = "Cadence";
                dataView.Columns[3].Name = "Altitude";
                dataView.Columns[4].Name = "Power";
                dataView.Columns[5].Name = "Power Balance and Pedaling Index";

                if (rows != 0)
                {
                    foreach (string line in filelines)
                    {
                        if (rows < b)
                        {
                            data += line + "\r\n";
                            //MessageBox.Show(data, "Messagae");
                            string text = line;
                            // string[] text = line.Split('\t');
                            try
                            {
                                for (int x = 0; x < text.Length; x++)
                                {
                                    string[] array = text.Split(new char[] { '\t' });
                                    dataView.Rows.Add(array);
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Error occured.", "Error");
                            }
                        }
                        else b++;
                    }
                }
                fileReading.Text = data;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            graphImage gi = new graphImage();
            gi.Show();
            gi.graphDataView.AllowUserToAddRows = false;
            gi.graphDataView.ColumnCount = 6;
            gi.graphDataView.Columns[0].Name = "Heart Rates";
            gi.graphDataView.Columns[1].Name = "Speed";
            gi.graphDataView.Columns[2].Name = "Cadence";
            gi.graphDataView.Columns[3].Name = "Altitude";
            gi.graphDataView.Columns[4].Name = "Power";
            gi.graphDataView.Columns[5].Name = "Power Balance and Pedaling Index";
            foreach (DataGridViewRow row in dataView.Rows)
            {
                
                int n = gi.graphDataView.Rows.Add();

                gi.graphDataView.Rows[n].Cells[0].Value = row.Cells[0].Value;
                gi.graphDataView.Rows[n].Cells[1].Value = row.Cells[1].Value;
                gi.graphDataView.Rows[n].Cells[2].Value = row.Cells[2].Value;
                gi.graphDataView.Rows[n].Cells[3].Value = row.Cells[3].Value;
                gi.graphDataView.Rows[n].Cells[4].Value = row.Cells[4].Value;
                gi.graphDataView.Rows[n].Cells[5].Value = row.Cells[5].Value;
            }
        }
    }
}
