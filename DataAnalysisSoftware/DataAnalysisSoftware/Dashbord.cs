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
using ZedGraph;

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

        int MaxHR; //Max Heart Rate
        int MinHR; //Min Heart Rate
        double AvgHR; //Average Heart Rate

        int MaxPW; //Max Power
        double AvgPW; //Average power
        int MinPW; //Min Power

        int MaxALT; //Max Altitude
        double AvgALT; //Average Altitude

        double MaxSP; //Max Speed
        public double AvgSP; //Average Speed

        int intervalVal;
        int NP;
        double IF;
        int Versionval;
        double Distance;
        string filetext;
        double FTP;
        int NP1;
        double timesec;

        public double[] Larray, Rarray, PIarray;
        public string result;
        long PowerB, leftMask, PedIndMask;
        string PBbinary, leftBin, PiBin;
        public double lvalue, pvalue, rvalue;
        double left, pedindex, right;
        public double rows;
        

        //public GraphPane GraphPane;
        public GraphPane GraphPane2;

        int[] intervals = new int[20] { 0, 3800, 0, 3800, 0, 3800, 0, 3800, 0, 3800, 0, 3800, 0, 3800, 0, 3800, 0, 3800, 0, 3800 };
        int intcounter = 0;

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
                    advanceMatrics();
                }
            }
        }

        public static double[] graphPower { get; set; }

        private void btnCalculateTSS_Click(object sender, EventArgs e)
        {
            CalculateIntensityFactory();
            calculateTSS();
        }

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
            try
            {
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
            catch (Exception msg)
            {
                MessageBox.Show("An error occured: " + msg.Message);
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
                if (fileData.Contains("Length"))
                {
                    string length = fileData;
                    string[] arrayLength = length.Split('=');
                    foreach (string itemLength in arrayLength)
                    {
                        //lblLength.Text = "Length: " + itemLength;
                        int LengthHR = 0;
                        Int32.TryParse(itemLength, out LengthHR);
                        int LengthMin = 0;
                        Int32.TryParse(itemLength, out LengthMin);
                        double LengthSec = 0;
                        Double.TryParse(itemLength, out LengthSec);
                        lblLength.Text = "Length: " + LengthHR + ":" + LengthMin + ":" + LengthSec;
                        timesec = ((LengthHR * 3600) + (LengthMin * 60) + LengthSec);
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
                        //monitor = itemMonitor;
                        //lblMonitor.Text = "Monitor: " + itemMonitor;
                        int Monitorval = 0;
                        Int32.TryParse(itemMonitor, out Monitorval);
                        if (Monitorval == 1) { lblMonitor.Text = "Model: " + "Polar Sport Tester / Vantage XL"; }
                        if (Monitorval == 2) { lblMonitor.Text = "Model: " + "Polar Vantage NV (VNV)"; }
                        if (Monitorval == 3) { lblMonitor.Text = "Model: " + "Polar Accurex Plus"; }
                        if (Monitorval == 4) { lblMonitor.Text = "Model: " + "Polar XTrainer Plus"; }
                        if (Monitorval == 6) { lblMonitor.Text = "Model: " + "Polar S520"; }
                        if (Monitorval == 7) { lblMonitor.Text = "Model: " + "Polar Coach"; }
                        if (Monitorval == 8) { lblMonitor.Text = "Model: " + "Polar S210"; }
                        if (Monitorval == 9) { lblMonitor.Text = "Model: " + "Polar S410"; }
                        if (Monitorval == 10) { lblMonitor.Text = "Model: " + "Polar S610 / S610i"; }
                        if (Monitorval == 12) { lblMonitor.Text = "Model: " + "Polar S710 / S710i / S720i"; }
                        if (Monitorval == 13) { lblMonitor.Text = "Model: " + "Polar S810 / S810i"; }
                        if (Monitorval == 15) { lblMonitor.Text = "Model: " + "Polar E600"; }
                        if (Monitorval == 20) { lblMonitor.Text = "Model: " + "Polar AXN500"; }
                        if (Monitorval == 21) { lblMonitor.Text = "Model: " + "Polar AXN700"; }
                        if (Monitorval == 22) { lblMonitor.Text = "Model: " + "Polar S625X / S725X"; }
                        if (Monitorval == 23) { lblMonitor.Text = "Model: " + "Polar S725"; }
                        if (Monitorval == 33) { lblMonitor.Text = "Model: " + "Polar CS400"; }
                        if (Monitorval == 34) { lblMonitor.Text = "Model: " + "Polar CS600X"; }
                        if (Monitorval == 35) { lblMonitor.Text = "Model: " + "Polar CS600"; }
                        if (Monitorval == 36) { lblMonitor.Text = "Model: " + "Polar RS400"; }
                        if (Monitorval == 37) { lblMonitor.Text = "Model: " + "Polar RS800"; }
                        if (Monitorval == 38) { lblMonitor.Text = "Model: " + "Polar RS800X"; }
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
            dataView.Columns.Add("Column", "Power Balance & Pedalling Index");

            for (int x = 0; x < count; x++)
            {
                double interval = double.Parse(intervalValue);
                intervalTwo = intervalTwo + interval;
                //dataView.Rows.Add(array);
                dataView.Rows.Add();
                DateTime timer = DateTime.ParseExact(startTimeValue, "HH:mm:ss.FFF", CultureInfo.InvariantCulture);
                dataView.Rows[x].Cells[0].Value = timer.AddSeconds(intervalTwo).TimeOfDay;

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
                    arrayCadence[x] = int.Parse(filter[x][2]);
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
                    }
                }

                else if (power == '0')
                {
                    dataView.Rows[x].Cells[5].Value = 0;
                }

                if (powerLRBalance == '1')
                {
                    dataView.Rows[x].Cells[6].Value = filter[x][5];
                }
                else if (powerLRBalance == '0')
                {
                    dataView.Rows[x].Cells[5].Value = 0;
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

                if (speed == '1')
                {
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
                }

                if (power == '1')
                {
                    //average power
                    powerTotal += Convert.ToInt32(filter[x][5]);
                    //powerTotal = powerTotal + int.Parse(filter[x][5]);
                    averagePower = powerTotal / count;

                    //maximum power
                    arrayPower[x] = int.Parse(filter[x][5]);
                }
                else
                {
                    averagePower = 0;
                    arrayPower[5] = 0;
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
        }

        private void advanceMatrics()
        {
            List<int> initialPower = new List<int>();
            List<double> list = new List<double>();
            double total = 1;
            double average;

            try
            {
                for (int i = 1; i < dataView.Rows.Count; i++)
                {
                    for (int n = 0; n < i + 30; n++)
                    {
                        initialPower.Add(Convert.ToInt32(dataView.Rows[i + n].Cells[5].Value));
                    }
                    average = initialPower.Average();
                    total = Math.Pow(average, 4);
                    list.Add(total);
                    initialPower.Clear();
                }

            }
            catch (Exception)
            {
                average = list.Average();
                NP = Convert.ToInt32(Math.Pow(average, 1.0 / 4.00));
                labelnp.Text = NP.ToString("0 watts");
                labelnp.Visible = true;
            }
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

        private void btnSelectedData_Click(object sender, EventArgs e)
        {
            dataSelectCalculation();
        }
        public void dataSelectCalculation()
        {
            SelectedData selectData = new SelectedData();

            Int32 selectedRowCount = dataView.Rows.GetRowCount(DataGridViewElementStates.Selected);

            Double AvgHR1 = 0;
            for (int i = 0; i < selectedRowCount; ++i)
            {
                AvgHR1 += Convert.ToInt32(dataView.SelectedRows[i].Cells[1].Value);
            }
            AvgHR1 = AvgHR1 / selectedRowCount;

            /////////////////////
            Double MaxHR1 = dataView.SelectedRows.Cast<DataGridViewRow>()
                        .Max(r => Convert.ToInt32(r.Cells[1].Value));

            Double MinHR1 = dataView.SelectedRows.Cast<DataGridViewRow>()
                        .Min(r => Convert.ToInt32(r.Cells[1].Value));

            selectData.gropHR.Visible = true;
            selectData.lblHRMax.Text = "Maximum: " + MaxHR1.ToString("0");
            selectData.lblHRAvg.Text = "Average: " + AvgHR1.ToString("0");
            selectData.lblHRMin.Text = "Minimum: " + MinHR1.ToString("0");

            Double AvgSP1 = 0;
            for (int i = 0; i < selectedRowCount; ++i)
            {
                AvgSP1 += Convert.ToDouble(dataView.Rows[i].Cells[2].Value);
            }
            AvgSP1 = AvgSP1 / selectedRowCount;

            Double MaxSP1 = dataView.SelectedRows.Cast<DataGridViewRow>()
                        .Max(r => Convert.ToDouble(r.Cells[2].Value));

            Double MinSP1 = dataView.SelectedRows.Cast<DataGridViewRow>()
                        .Min(r => Convert.ToDouble(r.Cells[2].Value));
            selectData.grpBoxSpd.Visible = true;
            selectData.lblSpdMax.Text = "Maximum: " + MaxSP1.ToString("0.0");
            selectData.lblSpdAvg.Text = "Average: " + AvgSP1.ToString("0.0");
            selectData.lblSpdMin.Text = "Minimum: " + MinSP1.ToString("0.0");

            Double avgAlt = 0;
            for (int i = 0; i < selectedRowCount; ++i)
            {
                avgAlt += Convert.ToInt32(dataView.SelectedRows[i].Cells[4].Value);
            }
            avgAlt = avgAlt / selectedRowCount;

            /////////////////////
            Double MaxAvg = dataView.SelectedRows.Cast<DataGridViewRow>()
                        .Max(r => Convert.ToInt32(r.Cells[4].Value));

            Double MinAvg = dataView.SelectedRows.Cast<DataGridViewRow>()
                        .Min(r => Convert.ToInt32(r.Cells[4].Value));

            selectData.gropHR.Visible = true;
            selectData.lblAltMax.Text = "Maximum: " + MaxAvg.ToString("0");
            selectData.lblAltAvg.Text = "Average: " + avgAlt.ToString("0");
            selectData.lblAltMin.Text = "Minimum: " + MinAvg.ToString("0");


            Double AvgPwr = 0;
            for (int i = 0; i < selectedRowCount; ++i)
            {
                AvgPwr += Convert.ToInt32(dataView.SelectedRows[i].Cells[5].Value);
            }
            AvgPwr = AvgPwr / selectedRowCount;

            /////////////////////
            Double MaxPwr = dataView.SelectedRows.Cast<DataGridViewRow>()
                        .Max(r => Convert.ToInt32(r.Cells[5].Value));

            Double MinPwr = dataView.SelectedRows.Cast<DataGridViewRow>()
                        .Min(r => Convert.ToInt32(r.Cells[5].Value));

            selectData.grpBoxPwr.Visible = true;
            selectData.lblPwrMax.Text = "Maximum: " + MaxPwr.ToString("0");
            selectData.lblPwrAvg.Text = "Average: " + AvgPwr.ToString("0");
            selectData.lblPwrMin.Text = "Minimum: " + MinPwr.ToString("0");

            ///// Calculating normalized power for new graph        
            List<int> initialPower1 = new List<int>();
            List<double> list1 = new List<double>();
            double total1 = 1;
            double average1;

            try
            {
                for (int ii = 1; ii < dataView.SelectedRows.Count; ii++)
                {
                    for (int n = 0; n < ii + 30; n++)
                    {
                        initialPower1.Add(Convert.ToInt32(dataView.Rows[ii + n].Cells[5].Value));
                    }
                    average1 = initialPower1.Average();
                    total1 = Math.Pow(average1, 4.00);
                    list1.Add(total1);
                    initialPower1.Clear();
                }

            }
            catch (Exception)
            {
                average1 = list1.Average();
                NP1 = Convert.ToInt32(Math.Pow(average1, 1.0 / 4.00));
                selectData.np2.Text = NP1.ToString("0 watts");
                selectData.np2.Visible = true;
            }


            //////////////////////Selectable Data - Pedal index/////////////////////////////////////
            left = pedindex = right = 0;
            Larray = new double[dataView.SelectedRows.Count];
            Rarray = new double[dataView.SelectedRows.Count];
            PIarray = new double[dataView.SelectedRows.Count];
            for (int i = 0; i < dataView.SelectedRows.Count; ++i)
            {
                if (dataView.Rows[i].Cells[6].Value != null)
                {
                    PowerB = Convert.ToInt64(dataView.SelectedRows[i].Cells[6].Value);
                    pedalBal(PowerB);
                    Larray[i] = lvalue;
                    left += lvalue;
                    Rarray[i] = rvalue;
                    right += rvalue;
                    PIarray[i] = pvalue;
                    pedindex += pvalue;
                }
            }

            rows = dataView.SelectedRows.Count;
            left = Math.Round(left, 2);
            double averLeft = left / rows;
            averLeft = Math.Round(averLeft, 2);
            selectData.PBLeft2.Text = averLeft.ToString();

            right = Math.Round(right, 2);
            double averRight = right / rows;
            averRight = Math.Round(averRight, 2);
            selectData.PBRight2.Text = averRight.ToString();

            pedindex = Math.Round(pedindex, 2);
            double averpedInd = pedindex / rows;
            averpedInd = Math.Round(averpedInd, 2);
            selectData.PILabel2.Text = averpedInd.ToString();

            CreateGraph2(selectData.selectedZedGraph);
            selectData.Show();
        }

        private void CreateGraph2(ZedGraphControl graph2)
        {
            graph2.GraphPane.CurveList.Clear();
            // get a reference to the GraphPane
            GraphPane2 = graph2.GraphPane;
            // Set the Titles
            //GraphPane2.Title.Text = "Cycle Data Graph";
            //GraphPane2.YAxis.Title.Text = "Value";
            GraphPane2.Title.Text = "Polar Cycle Computer";
            GraphPane2.XAxis.Title.Text = "Year";
            GraphPane2.YAxis.Title.Text = "Times";
            GraphPane2.Title.FontSpec.FontColor = Color.BlueViolet;

            double x, y1, y2, y3, y4, y5;
            PointPairList list1 = new PointPairList();
            PointPairList list2 = new PointPairList();
            PointPairList list3 = new PointPairList();
            PointPairList list4 = new PointPairList();
            PointPairList list5 = new PointPairList();

            x = 0;

            for (int i = 0; i < dataView.SelectedRows.Count; i++)
            {

                x = i + intervalVal;
                GraphPane2.XAxis.Title.Text = "Time In Seconds";
                y1 = Convert.ToDouble(dataView.SelectedRows[i].Cells[1].Value);
                y2 = Convert.ToDouble(dataView.SelectedRows[i].Cells[2].Value);
                y3 = Convert.ToDouble(dataView.SelectedRows[i].Cells[3].Value);
                y4 = Convert.ToDouble(dataView.SelectedRows[i].Cells[4].Value);
                y5 = Convert.ToDouble(dataView.SelectedRows[i].Cells[5].Value);

                list1.Add(x, y1);
                list2.Add(x, y2);
                list3.Add(x, y3);
                list4.Add(x, y4);
                list5.Add(x, y5);
            }


            LineItem curve;
            curve = GraphPane2.AddCurve("Heart Rate", list1, Color.Blue, SymbolType.None);
            curve.Line.Width = 0.1F;
            curve.Symbol.Fill = new Fill(Color.White);
            curve.Symbol.Size = 1;
            //Smoothes the cardinal spline
            curve.Line.IsSmooth = true;
            curve.Line.SmoothTension = 1F;

            LineItem curve1;
            curve1 = GraphPane2.AddCurve("Speed", list2, Color.Red, SymbolType.None);
            curve1.Line.Width = 0.1F;
            curve1.Symbol.Fill = new Fill(Color.White);
            curve1.Symbol.Size = 1;
            //Smoothes the cardinal spline
            curve1.Line.IsSmooth = true;
            curve1.Line.SmoothTension = 1F;


            /*
                        //if the version is over 1.06 then run the extened Graph Method
                        if (Versionval >= 106)
                        {

                            for (int ii = 0; ii < dataView.SelectedRows.Count; ii++)
                            {*/
            //x = ii + intervalVal;

            // }

            LineItem curve2;
            curve2 = GraphPane2.AddCurve("Cadence", list3, Color.Green, SymbolType.None);
            curve2.Line.Width = 0.1F;
            curve2.Symbol.Fill = new Fill(Color.White);
            curve2.Symbol.Size = 1;
            //Smoothes the cardinal spline
            curve2.Line.IsSmooth = true;
            curve2.Line.SmoothTension = 1F;

            LineItem curve3;
            curve3 = GraphPane2.AddCurve("Altitude", list4, Color.SkyBlue, SymbolType.None);
            curve3.Line.Width = 0.1F;
            curve3.Symbol.Fill = new Fill(Color.White);
            curve3.Symbol.Size = 1;
            //Smoothes the cardinal spline
            curve3.Line.IsSmooth = true;
            curve3.Line.SmoothTension = 1F;

            LineItem curve4;
            curve4 = GraphPane2.AddCurve("Power", list5, Color.DarkOrange, SymbolType.None);
            curve4.Line.Width = 0.1F;
            curve4.Symbol.Fill = new Fill(Color.White);
            curve4.Symbol.Size = 1;
            //Smoothes the cardinal spline
            curve4.Line.IsSmooth = true;
            curve4.Line.SmoothTension = 1F;

            graph2.AxisChange();
            graph2.Invalidate();
        }
        
        public void pedalBal(long value)
        {
            PBbinary = Convert.ToString(value, 2).PadLeft(16, '0');
            leftMask = PowerB & 255;
            leftBin = Convert.ToString(leftMask, 2).PadLeft(16, '0');
            lvalue = Convert.ToInt32(leftBin, 2);
            rvalue = 100 - lvalue;
            PedIndMask = value & 65280;
            PedIndMask = PedIndMask >> 8;
            PiBin = Convert.ToString(PedIndMask, 2).PadLeft(16, '0');
            pvalue = Convert.ToInt32(PiBin, 2);
        }

        public void CalculateIntensityFactory()
        {
            FTP = Convert.ToInt32(txtFTPBox.Text);
            IF = NP / FTP;
            labelif.Text = IF.ToString("0.00");
            labelif.Visible = true;
            //label
        }

        public void calculateTSS()
        {
            double TSS;
            TSS = (timesec * NP * IF) / (FTP * 3600) * 100;
            labeltss.Text = TSS.ToString("0.00");
            labeltss.Visible = true;
        }
    }
}