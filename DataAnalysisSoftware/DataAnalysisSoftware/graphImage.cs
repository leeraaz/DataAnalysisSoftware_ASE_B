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

        private void plotGraph()
        {
            GraphPane myPane = zedGraphControl1.GraphPane;

            // Set the Titles
            myPane.Title.Text = "Polar Cycle Computer";
            myPane.XAxis.Title.Text = "Year";
            myPane.YAxis.Title.Text = "Times";
            myPane.Title.FontSpec.FontColor = Color.BlueViolet;

            if (lblCombo.SelectedItem.ToString() == "Speed")
            {
                PointPairList speed = new PointPairList(); 

                myPane.XAxis.Scale.Min = 1;
                myPane.XAxis.Scale.Max = 4000;

                myPane.YAxis.Scale.Min = 1;
                myPane.YAxis.Scale.Max = 650;
                
                double[] sp = Dashbord.graphSpeed;
            
                for (int i = 0; i < sp.Length; i++)
                {
                    speed.Add(i, sp[i]);
                }
                LineItem spCurve = myPane.AddCurve("Speed",
                      speed, Color.Crimson, SymbolType.Circle);

                this.Refresh();
            }
            else if (lblCombo.SelectedItem.ToString() == "Cadence")
            {
                this.Refresh();
                zedGraphControl1.Refresh();
                PointPairList cadence = new PointPairList();

                myPane.XAxis.Scale.Min = 1;
                myPane.XAxis.Scale.Max = 4000;

                myPane.YAxis.Scale.Min = 1;
                myPane.YAxis.Scale.Max = 650;
                
                double[] cad = Dashbord.graphCadence;

                for (int i = 0; i < cad.Length; i++)
                {
                    cadence.Add(i, cad[i]);
                }
                LineItem cdCurve = myPane.AddCurve("Cadence",
                      cadence, Color.DarkBlue, SymbolType.Star);

                zedGraphControl1.Refresh();
            }
            else if (lblCombo.SelectedItem.ToString() == "Altitude")
            {
                zedGraphControl1.Refresh();
                PointPairList altitude = new PointPairList();

                myPane.XAxis.Scale.Min = 1;
                myPane.XAxis.Scale.Max = 4000;

                myPane.YAxis.Scale.Min = 1;
                myPane.YAxis.Scale.Max = 650;
                
                double[] alt = Dashbord.graphAltitude;

                for (int i = 0; i < alt.Length; i++)
                {
                    altitude.Add(i, alt[i]);
                }
                LineItem altCurve = myPane.AddCurve("Altitude",
                    altitude, Color.Yellow, SymbolType.Triangle);

                zedGraphControl1.Refresh();
            }
            else if (lblCombo.SelectedItem.ToString() == "Heart Rate")
            {
                zedGraphControl1.Refresh();
                PointPairList heart_rate = new PointPairList();

                myPane.XAxis.Scale.Min = 1;
                myPane.XAxis.Scale.Max = 4000;

                myPane.YAxis.Scale.Min = 1;
                myPane.YAxis.Scale.Max = 650;

                double[] hr = Dashbord.graphHeartRate;

                for (int i = 0; i < hr.Length; i++)
                {
                    heart_rate.Add(i, hr[i]);
                }
                LineItem hrCurve = myPane.AddCurve("Heart Rate",
                      heart_rate, Color.Black, SymbolType.Square);
            }
            else if (lblCombo.SelectedItem.ToString() == "Power")
            {
                zedGraphControl1.Refresh();
                PointPairList power = new PointPairList();

                myPane.XAxis.Scale.Min = 1;
                myPane.XAxis.Scale.Max = 4000;

                myPane.YAxis.Scale.Min = 1;
                myPane.YAxis.Scale.Max = 650;
                
                double[] pwr = Dashbord.graphPower;

                for (int i = 0; i < pwr.Length; i++)
                {
                    power.Add(i, pwr[i]);
                }
                LineItem pwCurve = myPane.AddCurve("Power",
                      power, Color.DarkOrchid, SymbolType.None);
            }
            else
            {
                zedGraphControl1.Refresh();
                PointPairList speed = new PointPairList();
                PointPairList cadence = new PointPairList();
                PointPairList altitude = new PointPairList();
                PointPairList heart_rate = new PointPairList();
                PointPairList power = new PointPairList();

                myPane.XAxis.Scale.Min = 1;
                myPane.XAxis.Scale.Max = 4000;

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

                LineItem hrCurve = myPane.AddCurve("Heart Rate",
                      heart_rate, Color.Red, SymbolType.Square);

                LineItem spCurve = myPane.AddCurve("Speed",
                      speed, Color.Crimson, SymbolType.Circle);

                LineItem cdCurve = myPane.AddCurve("Cadence",
                      cadence, Color.DarkBlue, SymbolType.Star);

                LineItem altCurve = myPane.AddCurve("Altitude",
                    altitude, Color.Yellow, SymbolType.Triangle);

                LineItem pwCurve = myPane.AddCurve("Power",
                      power, Color.DarkOrchid, SymbolType.None);
            }
                zedGraphControl1.AxisChange();
            
        }
    }
}
