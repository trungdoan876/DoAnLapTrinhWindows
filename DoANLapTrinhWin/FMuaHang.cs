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
    public partial class FMuaHang : Form
    {
        public FMuaHang()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide(); //an form 1
            FCTSP form2 = new FCTSP(); // tao doi tuong form 2
            form2.ShowDialog(); //show la thao tac dong thoi 2 form
                                //ShowDialog thi khi tat form2 thi moi tro lai thao tac tren form1
            form2 = null; //tat form2, tuc la form 2 tro ve null
            this.Show();
        }
    }
    
}
