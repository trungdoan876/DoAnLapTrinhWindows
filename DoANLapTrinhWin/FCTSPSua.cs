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
    public partial class FCTSPSua : Form
    {
        public string maSanPham;
        public FCTSPSua(string maSanPham)
        {
            InitializeComponent();
            this.maSanPham = maSanPham;
            ucTextBox4.textBox.Text = maSanPham;
        }

        private void buttonTuyChinh1_Click(object sender, EventArgs e)
        {

        }
    }
}
