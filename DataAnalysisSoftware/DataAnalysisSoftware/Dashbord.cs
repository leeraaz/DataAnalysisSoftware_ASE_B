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

        public static double averageSpeed { get; set; }
        public static double maxSpeed { get; set; }
        public static double averageSpeedMiles { get; set; }
        public static double maxSpeedMiles { get; set; }
        public static double avereageHeartRate { get; set; }
        public static double maxHeartRate { get; set; }
        public static double minHeartRate { get; set; }
        public static double averagePower { get; set; }
        public static double maxPower { get; set; }
        public static double averageAltitude { get; set; }
        public static double maxAltitude { get; set; }
        public static double averaAltitudeMile { get; set; }
        public static double maxAltitudeMile { get; set; }
        public static double totalDistance { get; set; }
        public static string smode { get; set; }
        public DateTime SelectionStart { get; set; }
        string file_name, path;
        string file, getfilename;
        string dateCalc;
        string[] fdata;
        string fileDatas;
        string fileData, filename;
        string lengthValue, startTimeValue, intervalValue;
        string dateStart = "11/14/2018";
        string finalDate;
        string data = "";
        int count = 0;
        int rows = 0;
        int a = 0, b = 0;

        OpenFileDialog filedia = new OpenFileDialog();
        public void btnLoad_Click(object sender, EventArgs e)
        {
            //selection of file
            // bool flag = this.openFiles.ShowDialog() != DialogResult.Cancel;
           // OpenFileDialog filedia = new OpenFileDialog();
            if (filedia.ShowDialog() == DialogResult.OK)
            {
                fdata = filedia.FileNames;
                DateTime timeValue;
                string valueTwo = fdata[0];

                StreamReader streamReader = new StreamReader(valueTwo);
                while (!streamReader.EndOfStream)
                {
                    fileData = streamReader.ReadLine();
                    if (fileData.Contains("Date"))
                    {
                        string startTime = fileData;
                        string arraStratTime = startTime.Split('=').Last();
                        var dt = DateTime.ParseExact(arraStratTime, "yyyyMMdd", CultureInfo.InvariantCulture);
                        dateStart = dt.ToString();
                    }
                }

                foreach (string itemData in fdata)
                {
                    string value = itemData;
                    StreamReader fileReaderFolder = new StreamReader(value);
                    while (!fileReaderFolder.EndOfStream)
                    {
                        fileData = fileReaderFolder.ReadLine();
                        if (fileData.Contains("Date"))
                        {
                            string startTime = fileData;
                            string arraysStartTime = startTime.Split('=').Last();
                            //var date = "11252017";
                            var date = DateTime.ParseExact(arraysStartTime, "yyyyMMdd", CultureInfo.InvariantCulture);
                            timeValue = date;

                            monthlyCalender.AddBoldedDate(date);
                            monthlyCalender.UpdateBoldedDates();

                            monthlyCalender.SelectionStart = DateTime.Parse(dateStart);
                        }
                    }
                    fileReading(data);
                    SummaryCalculation();
                }
                richTextBox1.Text = data;
            }
        }
                //fileReading.Text = b + data;

                //loading data into grid view.
                //dataView.AllowUserToAddRows = false;
                //dataView.ColumnCount = 6;
                //dataView.Columns[0].Name = "Heart Rates";
                //dataView.Columns[1].Name = "Speed";
                //dataView.Columns[2].Name = "Cadence";
                //dataView.Columns[3].Name = "Altitude";
                //dataView.Columns[4].Name = "Power";
                //dataView.Columns[5].Name = "Power Balance and Pedaling Index";

                //if (rows != 0)
                //{
                //    foreach (string line in filelines)
                //    {
                //        if (rows < b)
                //        {
                //            data += line + "\r\n";
                //            //MessageBox.Show(data, "Messagae");
                //            string text = line;
                //            // string[] text = line.Split('\t');
                //            try
                //            {
                //                for (int x = 0; x < text.Length; x++)
                //                {
                //                    string[] array = text.Split(new char[] { '\t' });
                //                    dataView.Rows.Add(array);
                //                }
                //            }
                //            catch (Exception)
                //            {
                //                MessageBox.Show("Error occured.", "Error");
                //            }
                //        }
                //        else b++;
                //    }
                //}
              //  fileReading.Text = data;
           // }
        

        private void SummaryCalculation()
        {

        }

        public void fileReading(String data)
        {

           // fileDatas = Path.GetFileName(filedia.FileName);
            //DateTime timeValue;
          //  string val = fileDatas;

         // StreamReader streamReader = new StreamReader(fileDatas);
            // while (!streamReader.EndOfStream)
            StreamReader streamReader = new StreamReader(filedia.FileName);
            
            string[] filelines = File.ReadAllLines(filedia.FileName);

            foreach (string line in filelines)
            {
                if (line.Equals("[HRData]"))
                {
                    MessageBox.Show(line.ToString(), "File");
                    rows = a;
                }
                a++;
                MessageBox.Show(a.ToString(), "MEssage");
            }
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
                    string smode = fileData;
                    string[] arraySmode = smode.Split('=');
                    foreach (String itemSmode in arraySmode)
                    {
                        smode = itemSmode;
                        lblSmode.Text = "Smode: " + smode;
                    }
                }
            }

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
            double interval = double.Parse(intervalValue);
            intervalTwo = intervalTwo + interval;

            if (rows != 0)
            {
                MessageBox.Show(rows.ToString(), "Message");
                foreach (string line in filelines)
                {
                    if (rows < b)
                    {

                        data += line + "\r\n";
                        MessageBox.Show(line.ToString(), "Message");
                        string text = line;
                        for (int i = 0; i < text.Length; i++)
                        {
                            string[] array = text.Split(new char[] { '\t' });
                            MessageBox.Show(array.ToString(), "Message");
                            //dataView.Rows.Add(array);
                            //dataView.Rows.Add(i);
                            DateTime timer = DateTime.ParseExact(startTimeValue, "HH:mm:ss.FFF", CultureInfo.InvariantCulture);
                            dataView.Rows[i].Cells[0].Value = finalDate + " | " + timer.AddSeconds(intervalTwo).TimeOfDay;

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
                                dataView.Rows[i].Cells[1].Value = array[i][0];
                            }
                            else if (hrcc == '0')
                            {
                                dataView.Rows[i].Cells[1].Value = 0;
                            }
                            if (speed == '1')
                            {
                                dataView.Rows[i].Cells[2].Value = array[i][1];
                            }
                            else if (speed == '0')
                            {
                                dataView.Rows[i].Cells[2].Value = 0;
                            }
                            if (cadence == '1')
                            {
                                dataView.Rows[i].Cells[3].Value = array[i][2];
                            }
                            else if (cadence == '0')
                            {
                                dataView.Rows[i].Cells[3].Value = 0;
                            }

                            if (altitude == '1')
                            {
                                dataView.Rows[i].Cells[4].Value = array[i][3];
                            }
                            else if (altitude == '0')
                            {
                                dataView.Rows[i].Cells[4].Value = 0;
                            }
                            if (power == '1')
                            {
                                dataView.Rows[i].Cells[5].Value = array[i][4];
                                //calculation of moving average
                                //    int value = hrData[i][4].Count();
                                //for (int x = 0; x < value; x++)
                                //{
                                //    double movingAverage30 = 0;
                                //    for (int j = 0; j < 30; j++)
                                //    {
                                //        int index = x + j;
                                //        index %= value;
                                //        movingAverage30 += Convert.ToDouble(hrData[i][index]);

                                //    }
                                //    movingAverage30 /= 30;

                                //    MessageBox.Show(movingAverage30.ToString());
                                //    dgvMovingAverage.Rows.Add(movingAverage30);

                                //    normalized power calculation

                                //   TimeSpan time = timer.AddSeconds(intervalTwo).TimeOfDay;
                                //    double timeParse = time.Hours * 60 + time.Minutes + time.Seconds / 60;
                                //    double powerValue = Math.Pow(movingAverage30, 4);
                                //    double np = Math.Sqrt(Math.Sqrt(timeParse * powerValue));
                                //    dataView.Rows[i].Cells[9].Value = np;


                                //}
                            }

                            else if (power == '0')
                            {
                                dataView.Rows[i].Cells[5].Value = 0;
                            }
                            if (powerLRBalance == '1')
                            {
                                dataView.Rows[i].Cells[6].Value = array[i][5];
                                double value = Convert.ToDouble(array[i][5]); // calculation of PI and LRB
                                double pi = value / 256;
                                double lrb = value % 256;
                                double rb = 100 - lrb;
                                dataView.Rows[i].Cells[7].Value = Math.Round(pi, 0);
                                dataView.Rows[i].Cells[8].Value = "L" + lrb + "- R" + rb;
                            }
                            else if (powerLRBalance == '0')
                            {
                                dataView.Rows[i].Cells[6].Value = 0;





                            }
                            if (speed == '1')
                            {

                                // cadence

                                //arrayCadence[i] = int.Parse(hrData[i][2]);


                                // average speed

                                // speedTotal = speedTotal + int.Parse(hrData[i][1]);
                                // averageSpeed = (speedTotal / count) * 0.1;
                                // averageSpeedMiles = averageSpeed / 1.6;



                                // maximum speed

                                // arraySpeed[i] = int.Parse(hrData[i][1]);
                            }
                            else
                            {
                                averageSpeed = 0;
                                averageSpeedMiles = 0;
                                arraySpeed[i] = 0;

                            }

                            if (hrcc == '1')
                            {
                                // average heart rate
                                //heartRateTotal = heartRateTotal + int.Parse(hrData[i][0]);
                                // averageHeartRate = heartRateTotal / count;
                                // maximum heart rate
                                //arrayHeartRate[i] = int.Parse(hrData[i][0]);
                            }
                            else
                            {
                                //averageHeartRate = 0;
                                //arrayHeartRate[i] = 0;
                            }
                            if (power == '1')
                            {
                                //average power
                                //    powerTotal = powerTotal + int.Parse(hrData[i][4]);
                                //averagePower = powerTotal / count;

                                //maximum power
                                //    arrayPower[i] = int.Parse(hrData[i][4]);
                            }
                            else
                            {
                                averagePower = 0;
                                arrayPower[i] = 0;
                            }
                            if (altitude == '1')
                            {
                                //average altitude
                                //    altitudeTotal = altitudeTotal + int.Parse(hrData[i][3]);
                                //averageAltitude = altitudeTotal / count;
                                //averageAltitudeMile = averageAltitude / 0.3048;
                                //maximum altitude
                                //    arrayAltitude[i] = int.Parse(hrData[i][3]);
                            }
                            else
                            {
                                //averageAltitude = 0;
                                //averageAltitudeMile = 0;
                                //arrayAltitude[i] = 0;
                            }
                        }
                    }
                        richTextBox1.Text = a.ToString() + data;
                        count = a.ToString().Count();
                        // MessageBox.Show(count.ToString(), "Milyo");
                    }
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
