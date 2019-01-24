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
    public partial class ChunkSelection : Form
    {
        int ChunkNo;
        public int chunkGet { get; set; }
        string i;
        public ChunkSelection()
        {
            InitializeComponent();
        }

        private void ChunkSelection_Load(object sender, EventArgs e)
        {
            btnDivide.DialogResult = DialogResult.OK;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                this.chunkGet = Convert.ToInt32(cmbValue.Text);
                this.Hide();
            }
            catch(Exception)
            {
                
            }
        }

        private void cmbValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                i = cmbValue.SelectedValue.ToString();
                ChunkNo = Convert.ToInt32(i);
            }
            catch (Exception)
            {

            }
        }
    }
}
