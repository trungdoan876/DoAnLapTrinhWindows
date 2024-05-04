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

namespace DoANLapTrinhWin.UC
{
    public partial class UCDaGiaoNM : UserControl
    {
        SanPham sp;
        DonHang dh;
        public UCDaGiaoNM(SanPham sp, DonHang dh)
        {
            InitializeComponent();
            this.sp = sp;
            this.dh = dh;
            this.lblMaDH.Text = dh.MaDonHang.ToString();
            this.lblTenSP.Text = sp.TenSP.ToString();
            this.lblTongTien.Text = dh.TongTien.ToString();
            this.lblTrangThai.Text = dh.TrangThaiDonHangNM.ToString();
            this.pictureBox1.Image = Global.ByteArrayToImage(sp.Hinh);
        }

        private void btnDaNhanHang_Click(object sender, EventArgs e)
        {
            FDanhGia fdh = new FDanhGia(dh.MaDonHang.ToString(),dh);
            fdh.ShowDialog();
        }

    }
}
