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
    public partial class UCSPBan : UserControl
    {
        //public string maSanPham;
        SanPham sp;
        public UCSPBan()
        {
            InitializeComponent();
        }
        public UCSPBan(SanPham sp)
        {
            this.sp = sp;
            InitializeComponent();


            this.lblMaSP.Text = sp.ma;
            this.lblTenSP.Text = sp.ten;
            this.lblGiaTien.Text = sp.giaBan.ToString() + "VND";
        }
        private void UCSPBan_Click(object sender, EventArgs e)
        {
            UCSPBan uCSPBan = new UCSPBan();
            this.Hide(); //an form 1
            FCTSPSua formCTSP = new FCTSPSua(sp);
            formCTSP.ShowDialog();
            formCTSP = null;
            this.Show();
        }
        private void UCSPBan_Load(object sender, EventArgs e)
        {

        }
    }
}
