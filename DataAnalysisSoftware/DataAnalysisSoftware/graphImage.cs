using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace DataAnalysisSoftware
{
    public partial class graphImage : Form
    {
        //setting value for intervals detections.
        int[] intervals = new int[20] { 0, 150, 0, 300, 0, 450, 0, 600, 0, 750, 0, 900, 0, 1050, 0, 1200, 0, 1450, 0, 1600 };
        int intcounter = 0;
        public graphImage()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }

        private void graphImage_Load(object sender, EventArgs e)
        {
            plotGraph();
        }

        //ploting data into graph.
        private void plotGraph()
        {
            GraphPane myPane = zedGraphControl1.GraphPane;

            // Set the Titles
            myPane.Title.Text = "Polar Cycle Computer";
            myPane.XAxis.Title.Text = "Year";
            myPane.YAxis.Title.Text = "Times";
            myPane.Title.FontSpec.FontColor = Color.BlueViolet;

            PointPairList speed = new PointPairList();
            PointPairList cadence = new PointPairList();
            PointPairList altitude = new PointPairList();
            PointPairList heart_rate = new PointPairList();
            PointPairList power = new PointPairList();

            myPane.XAxis.Scale.Min = 1;
            myPane.XAxis.Scale.Max = 2000;

            myPane.YAxis.Scale.Min = 1;
            myPane.YAxis.Scale.Max = 650;

            double[] hr = Dashbord.graphHeartRate;
            double[] sp = Dashbord.graphSpeed;
            double[] cd = Dashbord.graphCadence;
            double[] alt = Dashbord.graphAltitude;
            double[] pwr = Dashbord.graphPower;

            for (int i = 0; i < hr.Length; i++)
            {
                heart_rate.Add(i, hr[i]);
                speed.Add(i, sp[i]);
                cadence.Add(i, cd[i]);
                altitude.Add(i, alt[i]);
                power.Add(i, pwr[i]);
            }

            LineItem hrCurve = myPane.AddCurve("Heart Rate", heart_rate, Color.Black, SymbolType.None);
            hrCurve.Line.IsSmooth = true;
            hrCurve.Line.SmoothTension = 1f;

            LineItem spCurve = myPane.AddCurve("Speed", speed, Color.Pink, SymbolType.None);
            spCurve.Line.IsSmooth = true;
            spCurve.Line.SmoothTension = 1f;

            LineItem cdCurve = myPane.AddCurve("Cadence", cadence, Color.DarkBlue, SymbolType.None);
            cdCurve.Line.IsSmooth = true;
            cdCurve.Line.SmoothTension = 1f;

            LineItem altCurve = myPane.AddCurve("Altitude", altitude, Color.Yellow, SymbolType.Star);
            altCurve.Line.IsSmooth = true;
            altCurve.Line.SmoothTension = 1f;

            LineItem pwCurve = myPane.AddCurve("Power", power, Color.DarkOrchid, SymbolType.None);
            pwCurve.Line.IsSmooth = true;
            pwCurve.Line.SmoothTension = 1f;

            zedGraphControl1.AxisChange();
        }

        private void lblCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GraphPane myPane = zedGraphControl1.GraphPane;

            // Set the Titles
            myPane.Title.Text = "Polar Cycle Computer";
            myPane.XAxis.Title.Text = "Year";
            myPane.YAxis.Title.Text = "Times";
            myPane.Title.FontSpec.FontColor = Color.BlueViolet;

            if (lblCombo.SelectedItem.ToString() == "Speed")
            {
                zedGraphControl1.GraphPane.CurveList.Clear();
                PointPairList speed = new PointPairList();

                myPane.XAxis.Scale.Min = 1;
                myPane.XAxis.Scale.Max = 2000;

                myPane.YAxis.Scale.Min = 1;
                myPane.YAxis.Scale.Max = 650;

                double[] sp = Dashbord.graphSpeed;

                for (int i = 0; i < sp.Length; i++)
                {
                    speed.Add(i, sp[i]);
                }
                LineItem spCurve = myPane.AddCurve("Speed",
                      speed, Color.Crimson, SymbolType.None);
                
                zedGraphControl1.Refresh();
            }
            else if (lblCombo.SelectedItem.ToString() == "Cadence")
            {
                zedGraphControl1.GraphPane.CurveList.Clear();
                PointPairList cadence = new PointPairList();

                myPane.XAxis.Scale.Min = 1;
                myPane.XAxis.Scale.Max = 2000;

                myPane.YAxis.Scale.Min = 1;
                myPane.YAxis.Scale.Max = 650;

                double[] cad = Dashbord.graphCadence;

                for (int i = 0; i < cad.Length; i++)
                {
                    cadence.Add(i, cad[i]);
                }
                LineItem cdCurve = myPane.AddCurve("Cadence",
                      cadence, Color.DarkBlue, SymbolType.None);

                zedGraphControl1.Refresh();
            }
            else if (lblCombo.SelectedItem.ToString() == "Altitude")
            {
                zedGraphControl1.GraphPane.CurveList.Clear();
                PointPairList altitude = new PointPairList();

                myPane.XAxis.Scale.Min = 1;
                myPane.XAxis.Scale.Max = 2000;

                myPane.YAxis.Scale.Min = 1;
                myPane.YAxis.Scale.Max = 650;

                double[] alt = Dashbord.graphAltitude;

                for (int i = 0; i < alt.Length; i++)
                {
                    altitude.Add(i, alt[i]);
                }
                LineItem altCurve = myPane.AddCurve("Altitude",
                    altitude, Color.Yellow, SymbolType.Star);

                zedGraphControl1.Refresh();
            }
            else if (lblCombo.SelectedItem.ToString() == "Heart Rate")
            {
                zedGraphControl1.GraphPane.CurveList.Clear();
                PointPairList heart_rate = new PointPairList();

                myPane.XAxis.Scale.Min = 1;
                myPane.XAxis.Scale.Max = 2000;

                myPane.YAxis.Scale.Min = 1;
                myPane.YAxis.Scale.Max = 650;

                double[] hr = Dashbord.graphHeartRate;

                for (int i = 0; i < hr.Length; i++)
                {
                    heart_rate.Add(i, hr[i]);
                }
                LineItem hrCurve = myPane.AddCurve("Heart Rate",
                      heart_rate, Color.Black, SymbolType.None);

                zedGraphControl1.Refresh();
            }
            else if(lblCombo.SelectedItem.ToString() == "Power")
            {
                zedGraphControl1.GraphPane.CurveList.Clear();
                PointPairList power = new PointPairList();

                myPane.XAxis.Scale.Min = 1;
                myPane.XAxis.Scale.Max = 2000;

                myPane.YAxis.Scale.Min = 1;
                myPane.YAxis.Scale.Max = 650;

                double[] pwr = Dashbord.graphPower;

                for (int i = 0; i < pwr.Length; i++)
                {
                    power.Add(i, pwr[i]);
                }
                LineItem pwCurve = myPane.AddCurve("Power",
                      power, Color.DarkOrchid, SymbolType.None);

                zedGraphControl1.Refresh();
            }
            else if(lblCombo.SelectedItem.ToString() == "None")
            {
                zedGraphControl1.GraphPane.CurveList.Clear();
                myPane.Title.Text = "Polar Cycle Computer";
                myPane.XAxis.Title.Text = "Year";
                myPane.YAxis.Title.Text = "Times";
                myPane.Title.FontSpec.FontColor = Color.BlueViolet;

                PointPairList speed = new PointPairList();
                PointPairList cadence = new PointPairList();
                PointPairList altitude = new PointPairList();
                PointPairList heart_rate = new PointPairList();
                PointPairList power = new PointPairList();

                myPane.XAxis.Scale.Min = 1;
                myPane.XAxis.Scale.Max = 2000;

                myPane.YAxis.Scale.Min = 1;
                myPane.YAxis.Scale.Max = 650;

                double[] hr = Dashbord.graphHeartRate;
                double[] sp = Dashbord.graphSpeed;
                double[] cd = Dashbord.graphCadence;
                double[] alt = Dashbord.graphAltitude;
                double[] pwr = Dashbord.graphPower;

                for (int i = 0; i < hr.Length; i++)
                {
                    heart_rate.Add(i, hr[i]);
                    speed.Add(i, sp[i]);
                    cadence.Add(i, cd[i]);
                    altitude.Add(i, alt[i]);
                    power.Add(i, pwr[i]);
                }

                LineItem hrCurve = myPane.AddCurve("Heart Rate", heart_rate, Color.Black, SymbolType.None);
                hrCurve.Line.IsSmooth = true;
                hrCurve.Line.SmoothTension = 1f;

                LineItem spCurve = myPane.AddCurve("Speed", speed, Color.Pink, SymbolType.None);
                spCurve.Line.IsSmooth = true;
                spCurve.Line.SmoothTension = 1f;

                LineItem cdCurve = myPane.AddCurve("Cadence", cadence, Color.DarkBlue, SymbolType.None);
                cdCurve.Line.IsSmooth = true;
                cdCurve.Line.SmoothTension = 1f;

                LineItem altCurve = myPane.AddCurve("Altitude", altitude, Color.Yellow, SymbolType.Star);
                altCurve.Line.IsSmooth = true;
                altCurve.Line.SmoothTension = 1f;

                LineItem pwCurve = myPane.AddCurve("Power", power, Color.DarkOrchid, SymbolType.None);
                pwCurve.Line.IsSmooth = true;
                pwCurve.Line.SmoothTension = 1f;

                zedGraphControl1.Refresh();
                zedGraphControl1.AxisChange();
            }
            else
            {
                MessageBox.Show("Please select the appropriate value.");
            }
        }

        //interval picker for the data.
        public void intervalPicker()
        {
            int high = 0;
            int low = 0;
            switch (intcounter)
            {
                case 1:
                    low = intervals[0];
                    high = intervals[1];
                    break;
                case 2:
                    low = intervals[2];
                    high = intervals[3];

                    break;
                case 3:
                    low = intervals[4];
                    high = intervals[5];
                    break;
                case 4:
                    low = intervals[6];
                    high = intervals[7];
                    break;
                case 5:
                    low = intervals[8];
                    high = intervals[9];
                    break;

                case 6:
                    low = intervals[10];
                    high = intervals[11];
                    break;
                case 7:
                    low = intervals[12];
                    high = intervals[13];
                    break;
                case 8:
                    low = intervals[14];
                    high = intervals[15];
                    break;
                case 9:
                    low = intervals[16];
                    high = intervals[17];
                    break;
                case 10:
                    low = intervals[18];
                    high = intervals[19];

                    break;
                default:
                    break;
            }
            zedGraphControl1.GraphPane.XAxis.Scale.Min = Convert.ToDouble(low);
            zedGraphControl1.GraphPane.XAxis.Scale.Max = Convert.ToDouble(high);
            zedGraphControl1.Refresh();

            txtInterval.Text = Convert.ToString(intcounter);

        }

        //formula to increasing interval
        private void btnPlus_Click(object sender, EventArgs e)
        {
            intcounter++;
            if (intcounter > 10)
            {
                intcounter = 10;
            }
            intervalPicker();
        }

        //formula to decreasing interval
        private void btnMinus_Click(object sender, EventArgs e)
        {
            intcounter--;
            if (intcounter == 0 || intcounter < 0)
            {
                intcounter = 1;
            }
            intervalPicker();
        }
    }
}
