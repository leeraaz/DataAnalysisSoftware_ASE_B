using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAnalysisSoftware
{
    public partial class IntervalList : Form
    {
        public IntervalList()
        {
            InitializeComponent();
        }

        //loading intervalas thata are detected in the file into grid view
        private void IntervalList_Load(object sender, EventArgs e)
        {
            try
            {
                lblThresHold.Text = Dashbord.threholdValueGlobal.ToString();

                //MessageBox.Show(mainDashboard.intervalDetectionData.Count().ToString()+" "+ mainDashboard.powerData.Count.ToString());

                for (int i = 0; i < Dashbord.intervalDetectionData.Count(); i++)
                {
                    this.gridIntervalList.ClearSelection();
                    this.gridIntervalList.Rows.Add();
                    this.gridIntervalList.Rows[i].Cells[0].Value = "Interval " + Dashbord.intervalDetectionData[i];

                    this.gridIntervalList.Rows[i].Cells[1].Value = Dashbord.powerData[i];

                    Interval_Detected.Items.Add("Interval : " + i);

                }
                Detection();
            }
            catch(Exception ex)
            {

            }
        }

        //listing the intervals.
        public void Detection()
        {
            List<double> powerAverage = new List<double>();

            foreach(DataGridViewRow row in gridIntervalList.Rows)
            {
                powerAverage.Add(Convert.ToDouble(row.Cells[1].Value));
                double intervalAvg = powerAverage.Average();
                lblAvgPwr.Text = intervalAvg.ToString();
            }
        }
    }
}
