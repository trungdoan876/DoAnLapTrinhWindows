using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoANLapTrinhWin.UC
{
    public partial class UCDonHangNM : UserControl
    {
        DonHang dh;
        SanPham sp;
        DonHangDAO dhDao=new DonHangDAO();
        public UCDonHangNM()
        {
            InitializeComponent();
        }
        public UCDonHangNM(DonHang dhd, SanPham sps)
        {
            InitializeComponent();
            this.dh = dhd;
            this.sp = sps;
            this.lblMaDH.Text = dh.MaDonHang.ToString();
            this.lblTenSP.Text = sp.TenSP.ToString();
            this.lblTongTien.Text = dh.TongTien.ToString();
            this.lblTrangThai.Text = dh.TrangThaiDonHangNM.ToString();
            this.pictureBox1.Image = Global.ByteArrayToImage(sp.Hinh);
        }

        private void UCDonHang_Click(object sender, EventArgs e)
        {
            FCTDonHangNM fdh = new FCTDonHangNM(dh);
            fdh.ShowDialog();
        }

        private void btnDaNhanHang_Click(object sender, EventArgs e)
        {
            DonHang dh = new DonHang(lblMaDH.Text);
            dhDao.CapNhatNhanHang(dh);
        }
    }
}
