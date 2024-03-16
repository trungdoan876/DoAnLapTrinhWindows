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
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
        }

        private void FDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void circularPCB1_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonTuyChinh2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonTuyChinh1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonTuyChinh1_Click(object sender, EventArgs e)
        {
            
                this.Hide(); //an form 1
                FNguoiBan form2 = new FNguoiBan(); // tao doi tuong form 2
                form2.ShowDialog(); //show la thao tac dong thoi 2 form
                                    //ShowDialog thi khi tat form2 thi moi tro lai thao tac tren form1
                form2 = null; //tat form2, tuc la form 2 tro ve null
                this.Show(); //hien lai form 1
         
           
                /*this.Hide();
                FNguoiMua form = new FNguoiMua();
                form.ShowDialog();
                form = null;
                this.Show();*/
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void buttonTuyChinh3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FNguoiMua form = new FNguoiMua();
            form.ShowDialog();
            form = null;
            this.Show();
        }
    }
}
