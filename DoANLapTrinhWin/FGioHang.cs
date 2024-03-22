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
    public partial class FGioHang : Form
    {
        public FGioHang()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

  

        private void chuyenKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); //an form 1
            FThanhToan form2 = new FThanhToan(); // tao doi tuong form 2
            form2.ShowDialog(); //show la thao tac dong thoi 2 form
                                //ShowDialog thi khi tat form2 thi moi tro lai thao tac tren form1
            form2 = null; //tat form2, tuc la form 2 tro ve null
            this.Show();
        }

        private void dropdownMenu1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void buttonTuyChinh1_Click(object sender, EventArgs e)
        {

        }

      
    }
}
