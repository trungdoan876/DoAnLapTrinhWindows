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
            //this.lblNgayDatHang.Text = dh.NgayDatHang.ToString();
            this.lblTongTien.Text = dh.TongTien.ToString();
            this.lblTrangThai.Text = dh.TrangThaiDonHangNM.ToString();
            this.pictureBox1.Image = ByteArrayToImage(sp.Hinh);
        }
        Image ByteArrayToImage(byte[] a)
        {
            MemoryStream ms = new MemoryStream(a);
            return Image.FromStream(ms);
        }
    }
}
