using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoANLapTrinhWin
{
    public partial class FCTSP : Form
    {
        public FCTSP()
        {
            InitializeComponent();
        }
        int count = -1;

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (count >0)
            {
               // MessageBox.Show("huhu");
                count--;
            }
            pictureBox2.Image = imageList1.Images[count];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(count <2) { 
                count++;
            }
            pictureBox2.Image = imageList1.Images[count];
           
        }
        private void FCTSP_Load(object sender, EventArgs e)
        {

        }
    }
}
