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
using System.Globalization;

namespace DataAnalysisSoftware
{
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }
        public DateTime selectionStart { get; set; }
        public static double averageSpeed { get; set; }
        public static double maxSpeed { get; set; }
        public static double averageSpeedMiles { get; set; }
        public static double maxSpeedMiles { get; set; }
        public static double averageHeartRate { get; set; }
        public static double maxHeartRate { get; set; }
        public static double minHeartRate { get; set; }
        public static double averagePower { get; set; }
        public static double maxPower { get; set; }
        public static double averageAltitude { get; set; }
        public static double maxAltitude { get; set; }
        public static double averageAltitudeMile { get; set; }
        public static double maxAltitudeMile { get; set; }
        public static double totalDistance { get; set; }
        public static double totalDistanceMiles { get; set; }
        public static string smode { get; set; }
        public DateTime SelectionStart { get; set; }

        string file_name, path;
        //string file, getfilename;
        string dateCalc;
        string[] fdata;

        string fileData, filename;
        string lengthValue, startTimeValue, intervalValue;
        string dateStart = "11/14/2018";
        string finalDate;
        string data = "";
        int count = 0;

        //for graph uses
        public static double[] graphHeartRate { get; set; }
        public static double[] graphSpeed { get; set; }
        public static double[] graphCadence { get; set; }
        public static double[] graphAltitude { get; set; }

        private void FileNameList_MouseClick(object sender, MouseEventArgs e)
        {
            string fileName = FileNameList.SelectedItem.ToString();
            string location = path;

            foreach (string item in fdata)
            {
                string data = item.Split('\\').Last();
                if (data == fileName)
                {
                    fileReading(item);
                    SummaryCalculation();
                }
            }
        }

        public static double[] graphPower { get; set; }

        private void monthlyCalender_DateChanged(object sender, DateRangeEventArgs e)
        {
            //FileNameList.Items.Clear();
            //FileNameList.Items.Add(monthlyCalender.SelectionStart.ToString());
            //dateCalc = monthlyCalender.SelectionStart.ToString();

            //// file value start 



            //foreach (string itemData in fdata)
            //{
            //    string value = itemData;


            //    StreamReader fileReaderFolder = new StreamReader(value);


            //    while (!fileReaderFolder.EndOfStream)
            //    {
            //        fileData = fileReaderFolder.ReadLine();
            //        if (fileData.Contains("Date"))
            //        {
            //            string startTime = fileData;
            //            string arraStartTime = startTime.Split('=').Last();
            //            string one = "";
            //            //var date = "11252017";
            //            var date = DateTime.ParseExact(arraStartTime, "yyyyMMdd", CultureInfo.InvariantCulture);

            //            if (date == DateTime.Parse(dateCalc))
            //            {
            //                FileNameList.ClearSelected();
            //                FileNameList.Items.Add(itemData.Split('\\').Last());

            //                path = itemData;

            //                FileNameList.Update();
            //            }
            //        }
            //    }
            //}
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //selection of file
            //bool flag = this.openFiles.ShowDialog() != DialogResult.Cancel;
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                fdata = Directory.GetFiles(folder.SelectedPath);
                //DateTime timeValue;
                string valueTwo = fdata[0];
                StreamReader streamReader = new StreamReader(valueTwo);

                foreach (string itemData in fdata)
                {
                    string value = itemData;


                    StreamReader fileReaderFolder = new StreamReader(value);


                    while (!fileReaderFolder.EndOfStream)
                    {
                        fileData = fileReaderFolder.ReadLine();
                        if (fileData.Contains("[HRData]"))
                        {
                                FileNameList.ClearSelected();
                                FileNameList.Items.Add(itemData.Split('\\').Last());

                                path = itemData;

                                FileNameList.Update();
                        }
                    }
                }
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            graphImage gi = new graphImage();
            gi.Show();
        }

        public void fileReading(String data)
        {

            StreamReader streamReader = new StreamReader(data);

            // richTextBox1.Text = a + "\r\n";
            while (!streamReader.EndOfStream)
            {
                fileData = streamReader.ReadLine();
                if (fileData.Contains("StartTime"))
                {
                    string startTime = fileData;
                    string[] arrayStartTime = startTime.Split('=');
                    foreach (string item in arrayStartTime)
                    {
                        lblStartDate.Text = "Start time: " + item;
                        startTimeValue = item;
                    }
                }
                if (fileData.Contains("Interval"))
                {
                    string intervals = fileData;
                    string[] arrayInterval = intervals.Split('=');
                    foreach (string itemInterval in arrayInterval)
                    {
                        intervals = itemInterval;
                        //lblInterval.Text = "Interval: " + itemInterval;
                    }
                }
                if (fileData.Contains("Weight"))
                {
                    string weight = fileData;
                    string[] arrayWeight = weight.Split('=');
                    foreach (string itemWeight in arrayWeight)
                    {
                        weight = itemWeight;
                    }
                }
                if (fileData.Contains("Lenght"))
                {
                    string length = fileData;
                    string[] arrayLength = length.Split('=');
                    foreach (string itemLength in arrayLength)
                    {
                        length = itemLength;
                        lblLength.Text = "Length: " + lengthValue;
                    }
                }
                if (fileData.Contains("Interval"))
                {
                    string insterval = fileData;
                    string[] arrayLength = insterval.Split('=');
                    foreach (string itemIntervalss in arrayLength)
                    {
                        intervalValue = itemIntervalss;
                        lblInterval.Text = "Interval: " + itemIntervalss;
                    }
                }
                if (fileData.Contains("Version"))
                {
                    string version = fileData;
                    string[] arrayVersion = version.Split('=');
                    foreach (string itemVersion in arrayVersion)
                    {
                        version = itemVersion;
                        lblVersion.Text = "Version: " + itemVersion;
                    }
                }
                if (fileData.Contains("Monitor"))
                {
                    string monitor = fileData;
                    string[] arrayMonitor = monitor.Split('=');
                    foreach (string itemMonitor in arrayMonitor)
                    {
                        monitor = itemMonitor;
                        lblMonitor.Text = "Monitor: " + itemMonitor;
                    }
                }
                if (fileData.Contains("ActiveLimit"))
                {
                    string active = fileData;
                    string[] arrayActive = active.Split('=');
                    foreach (string itemActive in arrayActive)
                    {
                        active = itemActive;
                    }
                }
                if (fileData.Contains("MaxHR"))
                {
                    string maxHR = fileData;
                    string[] arrayMax = maxHR.Split('=');
                    foreach (string itemMax in arrayMax)
                    {
                        maxHR = itemMax;
                    }
                }
                if (fileData.Contains("RestHR"))
                {
                    string resetHr = fileData;
                    string[] arrayResetHr = resetHr.Split('=');
                    foreach (String itemResetHr in arrayResetHr)
                    {

                        // txtRestHr.Text = itemResetHr;
                    }
                }
                if (fileData.Contains("StartDelay"))
                {
                    string startDelay = fileData;
                    string[] arrayStartDelay = startDelay.Split('=');
                    foreach (String itemStartDelay in arrayStartDelay)
                    {

                        //txtStartDelay.Text = itemStartDelay;
                    }
                }
                if (fileData.Contains("VO2max"))
                {
                    string VO2max = fileData;
                    string[] arrayVO2max = VO2max.Split('=');
                    foreach (String itemVO2max in arrayVO2max)
                    {

                        //lblVersion.Text = itemVO2max;
                    }
                }
                if (fileData.Contains("Date"))
                {
                    string dates = fileData;
                    string[] arrayDate = dates.Split('=');
                    char[] different = arrayDate[1].ToCharArray();
                    foreach (string itemDate in arrayDate)
                    {
                        finalDate = different[0].ToString() + different[1].ToString() + different[2].ToString() + different[3].ToString() + "/" + different[4].ToString() + different[5].ToString() + "/" + different[6].ToString() + different[7].ToString();
                        lblDate.Text = "Date: " + finalDate;
                    }
                }
                if (fileData.Contains("SMode"))
                {
                    string smodeValue = fileData;
                    string[] arraySmode = smodeValue.Split('=');
                    foreach (String itemSmode in arraySmode)
                    {
                        smode = itemSmode;
                        lblSmode.Text = "Smode: " + smode;
                    }
                    char[] sm = smode.ToCharArray();
                    if (sm[0] == '1')
                    {
                        lblSpeed.Text = "Speed : ON "; 
                    }
                    else lblSpeed.Text = "Speed : OFF ";
                    if (sm[1] == '1')
                    {
                        lblCandence.Text = "Cadence : ON";
                    }
                    else lblCandence.Text = "Cadence : OFF";
                    if (sm[2] == '1')
                    {
                        lblAltitude.Text = "Altitude : ON ";
                    }
                    else lblAltitude.Text = "Altitude : OFF ";
                    if (sm[3] == '1')
                    {
                        lblPower.Text = "Power : ON";
                    }
                    else lblPower.Text = "Power : OFF";
                    if (sm[4] == '1')
                    {
                        lblPowerLR.Text = "Power Balance : ON ";
                    }
                    else lblPowerLR.Text = "Power Balance : OFF ";
                    if (sm[5] == '1')
                    {
                        lblPowerPedal.Text = "Power Index : ON";
                    }
                    else lblPowerPedal.Text = "Power Index : OFF";
                    if (sm[6] == '1')
                    {
                        lblHR.Text = "HR data only";
                    }
                    else lblHR.Text = "HR + cycling data";
                    if (sm[7] == '1')
                    {
                        lblUS.Text = "Euro (km/h)";
                    }
                    else lblUS.Text = "US (mph)";
                    if (sm[8] == '1')
                    {
                        lblAir.Text = "Air Pressure : ON";
                    }
                    else lblAir.Text = "Air Pressure : OFF";
                }
            }

            List<List<string>> filter = File.ReadLines(data).SkipWhile(line => line != "[HRData]").Skip(1).Select(line => line.Split().ToList()).ToList();

            count = filter.Count();

            double speedTotal = 0;
            double heartRateTotal = 0;
            double powerTotal = 0;
            double altitudeTotal = 0;
            double[] arraySpeed = new double[100000];
            double[] arrayHeartRate = new double[100000];
            double[] arrayPower = new double[100000];
            double[] arrayAltitude = new double[100000];
            double[] arrayCadence = new double[100000];
            string[] arrayLengths = new string[100000];
            string[] arrayStartTimes = new string[100000];

            arrayStartTimes = startTimeValue.Split(':');
            string hour = arrayStartTimes[0];
            string minute = arrayStartTimes[1];
            double sec = double.Parse(arrayStartTimes[2]);
            double min = double.Parse(arrayStartTimes[0]);
            double hrs = double.Parse(arrayStartTimes[1]);
            double intervalTwo = 0;

            for (int x = 0; x < count; x++)
            {
                double interval = double.Parse(intervalValue);
                intervalTwo = intervalTwo + interval;
                //dataView.Rows.Add(array);
                dataView.Rows.Add();
                DateTime timer = DateTime.ParseExact(startTimeValue, "HH:mm:ss.FFF", CultureInfo.InvariantCulture);
                dataView.Rows[x].Cells[0].Value = finalDate + " | " + timer.AddSeconds(intervalTwo).TimeOfDay;

                char[] smodeData = smode.ToCharArray();
                char speed = smodeData[0];
                char cadence = smodeData[1];
                char altitude = smodeData[2];
                char power = smodeData[3];
                char powerLRBalance = smodeData[4];
                char PowerPIndex = smodeData[5];
                char hrcc = smodeData[6];
                char usEuroUnit = smodeData[7];
                char airPressure = smodeData[8];

                if (hrcc == '1')
                {
                    dataView.Rows[x].Cells[1].Value = filter[x][0];
                }
                else if (hrcc == '0')
                {
                    dataView.Rows[x].Cells[1].Value = 0;
                }
                if (speed == '1')
                {
                    dataView.Rows[x].Cells[2].Value = filter[x][1];
                }
                else if (speed == '0')
                {
                    dataView.Rows[x].Cells[2].Value = 0;
                }
                if (cadence == '1')
                {
                    dataView.Rows[x].Cells[3].Value = filter[x][2];
                }
                else if (cadence == '0')
                {
                    dataView.Rows[x].Cells[3].Value = 0;
                }

                if (altitude == '1')
                {
                    dataView.Rows[x].Cells[4].Value = filter[x][3];
                }
                else if (altitude == '0')
                {
                    dataView.Rows[x].Cells[4].Value = 0;
                }
                if (power == '1')
                {
                    dataView.Rows[x].Cells[5].Value = filter[x][4];
                    //calculation of moving average
                    int value = filter[x][4].Count();
                    for (int a = 0; x < value; x++)
                    {
                        double movingAverage30 = 0;
                        for (int j = 0; j < 30; j++)
                        {
                            int index = a + j;
                            index %= value;
                            movingAverage30 += Convert.ToDouble(filter[x][index]);

                        }
                        movingAverage30 /= 30;

                        //MessageBox.Show(movingAverage30.ToString());
                        //dgvMovingAverage.Rows.Add(movingAverage30);

                        //    normalized power calculation

                        TimeSpan time = timer.AddSeconds(intervalTwo).TimeOfDay;
                        double timeParse = time.Hours * 60 + time.Minutes + time.Seconds / 60;
                        double powerValue = Math.Pow(movingAverage30, 4);
                        double np = Math.Sqrt(Math.Sqrt(timeParse * powerValue));
                        //dataView.Rows[x].Cells[9].Value = np;


                    }
                }

                else if (power == '0')
                {
                    dataView.Rows[x].Cells[5].Value = 0;
                }
                /*
                if (powerLRBalance == '1')
                {
                    dataView.Rows[x].Cells[6].Value = filter[x][5];
                    double value = Convert.ToDouble(filter[x][5]); // calculation of PI and LRB
                    double pi = value / 256;
                    double lrb = value % 256;
                    double rb = 100 - lrb;
                    dataView.Rows[x].Cells[7].Value = Math.Round(pi, 0);
                    dataView.Rows[x].Cells[8].Value = "L" + lrb + "- R" + rb;
                }
                else if (powerLRBalance == '0')
                {
                    dataView.Rows[x].Cells[6].Value = 0;
                }
                */
                if (speed == '1')
                {

                    // cadence

                    arrayCadence[x] = int.Parse(filter[x][2]);


                    // average speed

                    speedTotal = speedTotal + int.Parse(filter[x][1]);
                    averageSpeed = (speedTotal / count) * 0.1;
                    averageSpeedMiles = averageSpeed / 1.6;



                    // maximum speed

                    arraySpeed[x] = int.Parse(filter[x][1]);
                }
                else
                {
                    averageSpeed = 0;
                    averageSpeedMiles = 0;
                    arraySpeed[6] = 0;

                }

                if (hrcc == '1')
                {
                    //average heart rate
                    heartRateTotal = heartRateTotal + int.Parse(filter[x][0]);
                    averageHeartRate = heartRateTotal / count;
                    // maximum heart rate
                    arrayHeartRate[x] = int.Parse(filter[x][0]);
                }
                else
                {
                    averageHeartRate = 0;
                    arrayHeartRate[x] = 0;
                }
                if (power == '1')
                {
                    //average power
                    powerTotal = powerTotal + int.Parse(filter[x][4]);
                    averagePower = powerTotal / count;

                    //maximum power
                    arrayPower[x] = int.Parse(filter[x][4]);
                }
                else
                {
                    averagePower = 0;
                    arrayPower[6] = 0;
                }
                if (altitude == '1')
                {
                    //average altitude
                    altitudeTotal = altitudeTotal + int.Parse(filter[x][3]);
                    averageAltitude = altitudeTotal / count;
                    averageAltitudeMile = averageAltitude / 0.3048;
                    //maximum altitude
                    arrayAltitude[x] = int.Parse(filter[x][3]);
                }
                else
                {
                    averageAltitude = 0;
                    averageAltitudeMile = 0;
                    arrayAltitude[x] = 0;
                }
            }

            maxSpeed = arraySpeed.Max() * 0.1;
            maxSpeedMiles = (maxSpeed) / 1.6;

            //maximum heart rate
            maxHeartRate = arrayHeartRate.Max();

            //minium heart rate
            minHeartRate = double.MaxValue;

            foreach (double valueHR in arrayHeartRate)
            {
                double num = valueHR;
                if (num < minHeartRate)
                {
                    minHeartRate = num;
                }
            }

            //max power
            maxPower = arrayPower.Max();
            maxAltitude = arrayAltitude.Max();
            maxAltitudeMile = maxAltitudeMile / 0.3048;
            

            graphHeartRate = arrayHeartRate;
            graphSpeed = arrayHeartRate;
            graphPower = arrayPower;
            graphAltitude = arrayAltitude;
            graphCadence = arrayCadence;
        }

        private void SummaryCalculation()
        {
            #region Filling up the summary data
            //fetching all speed column data into array
            double[] coloumnDataofSpeed = (from DataGridViewRow row in dataView.Rows
                                           where row.Cells["speeds"].FormattedValue.ToString() != string.Empty
                                           select Convert.ToDouble(row.Cells["speeds"].FormattedValue)).ToArray();
            //fetching all heart rate column data into array
            double[] coloumnDataofHeartRate = (from DataGridViewRow row in dataView.Rows
                                               where row.Cells["heart_rate"].FormattedValue.ToString() != string.Empty
                                               select Convert.ToDouble(row.Cells["heart_rate"].FormattedValue)).ToArray();
            //fetching all power column data into array
            double[] coloumnDataofPower = (from DataGridViewRow row in dataView.Rows
                                           where row.Cells["Power_watt"].FormattedValue.ToString() != string.Empty
                                           select Convert.ToDouble(row.Cells["Power_watt"].FormattedValue)).ToArray();
            //fetching all altitude column data into array
            double[] coloumnDataofAltitude = (from DataGridViewRow row in dataView.Rows
                                              where row.Cells["altitude"].FormattedValue.ToString() != string.Empty
                                              select Convert.ToDouble(row.Cells["altitude"].FormattedValue)).ToArray();
            //for speed
            lblMaxSpeed.Text = "Maximum Speed: " + coloumnDataofSpeed.Max().ToString() + " " + "km/hr";
            lblMinSpeed.Text = "Minimum Speed: " + coloumnDataofSpeed.Min().ToString() + " " + "km/hr";

            double averageSpeed = coloumnDataofSpeed.Average();
            lblAvgSpeed.Text = "Average Speed: " + Math.Round(averageSpeed, 3).ToString() + " " + "km/hr";

            //for heart rate
            lblMaxHeartRate.Text = "Maximum Heart Rate: " + coloumnDataofHeartRate.Max().ToString() + " " + "bpm";
            lblMinHeartRate.Text = "Minimum Heart Rate: " + coloumnDataofHeartRate.Min().ToString() + " " + "bpm";

            double averageHeartRate = coloumnDataofSpeed.Average();
            lblAvgHeartRate.Text = "Average Heart Rate: " + Math.Round(averageHeartRate, 3).ToString() + " " + "bpm";

            //for power
            lblMaxPower.Text = "Maximum Power: " + coloumnDataofPower.Max().ToString() + " " + "watts";
            lblMinPower.Text = "Minimum Power: " + coloumnDataofPower.Min().ToString() + " " + "watts";

            double averagePower = coloumnDataofPower.Average();
            lblAvgPower.Text = "Average Power: " + Math.Round(averagePower, 3).ToString() + " " + "watts";

            //for altitude
            lblMaxAltitude.Text = "Maximum Altitude: " + coloumnDataofAltitude.Max().ToString() + " " + "meter";
            lblMinAltitude.Text = "Minimum Altitude: " + coloumnDataofAltitude.Min().ToString() + " " + "meter";

            double averageAltitude = coloumnDataofAltitude.Average();
            lblAverageAltidude.Text = "Average Altitude: " + Math.Round(averageAltitude, 3).ToString() + " " + "meter";
            #endregion
        }
    }
}