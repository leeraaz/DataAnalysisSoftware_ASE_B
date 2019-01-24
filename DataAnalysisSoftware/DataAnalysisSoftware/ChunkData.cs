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
    public partial class ChunkData : Form
    {
        double[] hr, sp, cd, al, po;

        private void ChunkData_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages[2].Visible = false;
            tabControl1.TabPages[3].Visible = false;
            selectedDataSummary();
        }

        int count;
        int ChunkDivision;

        private void Chunk1_Click(object sender, EventArgs e)
        {

        }

        int chunkNumber = 0;
     
        public ChunkData(int chunkNumber, double[] hr, double[] sp, double[] cd, double[] al, double[] po)
        {
            InitializeComponent();
            this.hr = hr;
            this.sp = sp;
            this.cd = cd;
            this.al = al;
            this.po = po;
            count = hr.Length;
            this.chunkNumber = chunkNumber;
            ChunkDivision = count / chunkNumber;
        }

        public void selectedDataSummary()
        {
            int chunkStart = 0;
            int countVal = 0;
            int countHR = 0;
            try
            {
                while (chunkStart < chunkNumber)
                {
                    double[] heartChunkValue = new double[ChunkDivision];
                    double[] sp1 = new double[ChunkDivision];
                    double[] cd1 = new double[ChunkDivision];
                    double[] al1 = new double[ChunkDivision];
                    double[] po1 = new double[ChunkDivision];
                    int i = 0;
                    for (int k = countVal; k < ChunkDivision + countVal; k++)
                    {
                        heartChunkValue[i] = hr[k];
                        sp1[i] = sp[k];
                        cd1[i] = cd[k];
                        al1[i] = al[k];
                        po1[i] = po[k];
                        countHR++;
                        i++;

                    }
                    countVal = countHR;
                    chunkStart++;
                    //  if(heartChunkValue.Length<ChunkDivison)
                    dataCalculation(chunkStart, heartChunkValue, sp1, cd1, al1, po1);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void dataCalculation(int chunkNo, double[] hr, double[] sp, double[] cd, double[] al, double[] po)
        {
            double maxHR = hr.Max();
            double avgHR = hr.Sum() / ChunkDivision;
            double minHR= hr.Min();

            double maxSpd = sp.Max();
            double avgSpd = sp.Sum() / ChunkDivision;
            double minSpd = sp.Min();

            double maxAlt = al.Max();
            double avgAlt = al.Sum() / ChunkDivision;
            double minAlt = al.Min();

            double maxPwr = po.Max();
            double avgPwr = po.Sum() / ChunkDivision;
            double minPwr = po.Min();

            switch (chunkNo)
            {
                case 1:
                    {
                        maxHR1.Text = maxHR.ToString();
                        avgHR1.Text = avgHR.ToString();
                        minHR1.Text = minHR.ToString();

                        maxSpd1.Text = maxSpd.ToString();
                        avgSpd1.Text = avgSpd.ToString();
                        minSpd1.Text = minSpd.ToString();

                        maxPwr1.Text = maxPwr.ToString();
                        avgPwr1.Text = avgPwr.ToString();
                        minPwr1.Text = minPwr.ToString();

                        maxAlt1.Text = maxAlt.ToString();
                        avgAlt1.Text = avgAlt.ToString();
                        minAlt1.Text = minAlt.ToString();
                        break;
                    }
                case 2:
                    {
                        maxHR2.Text = maxHR.ToString();
                        avgHR2.Text = avgHR.ToString();
                        minHR2.Text = minHR.ToString();

                        maxSpd2.Text = maxSpd.ToString();
                        avgSpd2.Text = avgSpd.ToString();
                        minSpd2.Text = minSpd.ToString();

                        maxPwr2.Text = maxPwr.ToString();
                        avgPwr2.Text = avgPwr.ToString();
                        minPwr2.Text = minPwr.ToString();

                        maxAlt2.Text = maxAlt.ToString();
                        avgAlt2.Text = avgAlt.ToString();
                        minAlt2.Text = minAlt.ToString();
                        break;
                    }
                case 3:
                    {
                        tabControl1.TabPages[2].Visible = true;
                        maxHR3.Text = maxHR.ToString();
                        avgHR3.Text = avgHR.ToString();
                        minHR3.Text = minHR.ToString();

                        maxSpd3.Text = maxSpd.ToString();
                        avgSpd3.Text = avgSpd.ToString();
                        minSpd3.Text = minSpd.ToString();

                        maxPwr3.Text = maxPwr.ToString();
                        avgPwr3.Text = avgPwr.ToString();
                        minPwr3.Text = minPwr.ToString();

                        maxAlt3.Text = maxAlt.ToString();
                        avgAlt3.Text = avgAlt.ToString();
                        minAlt3.Text = minAlt.ToString();
                        break;
                    }
                case 4:
                    {
                        tabControl1.TabPages[3].Visible = true;
                        maxHR4.Text = maxHR.ToString();
                        avgHR4.Text = avgHR.ToString();
                        minHR4.Text = minHR.ToString();

                        maxSpd4.Text = maxSpd.ToString();
                        avgSpd4.Text = avgSpd.ToString();
                        minSpd4.Text = minSpd.ToString();

                        maxPwr4.Text = maxPwr.ToString();
                        avgPwr4.Text = avgPwr.ToString();
                        minPwr4.Text = minPwr.ToString();

                        maxAlt4.Text = maxAlt.ToString();
                        avgAlt4.Text = avgAlt.ToString();
                        minAlt4.Text = minAlt.ToString();
                        break;

                    }
            }
        }
    }
}
