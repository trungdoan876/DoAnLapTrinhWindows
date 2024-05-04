using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoANLapTrinhWin
{
    public partial class UCDonHangNB : UserControl
    {
        DonHang dh;
        SanPham sp;
        public UCDonHangNB(DonHang dh, SanPham sp)
        {
            InitializeComponent();
            this.dh = dh;
            this.sp = sp;
            this.lblMaDH.Text = dh.MaDonHang.ToString();
            this.lblTenSP.Text = sp.TenSP.ToString();
            //this.lblNgayDatHang.Text = dh.NgayDatHang.ToString();
            this.lblTongTien.Text = dh.TongTien.ToString();
            this.lblTrangThai.Text = dh.TrangThaiDonHangNM.ToString();
            this.pictureBox1.Image = Global.ByteArrayToImage(sp.Hinh);
        }

        private void UCDonHangNB_Click(object sender, EventArgs e)
        {
            FCTDonHangNB fdh = new FCTDonHangNB(dh);
            fdh.ShowDialog();
        }
    }
}
