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
    public partial class UCDonHang : UserControl
    {
        DonHang dh;
        SanPham sp;
        public UCDonHang()
        {
            InitializeComponent();
        }
        public UCDonHang(DonHang dhh, SanPham spp)
        {
            InitializeComponent();
            this.dh = dhh;
            this.sp = spp;
            this.lblMaDH.Text = dh.MaDonHang.ToString();
            this.lblTenSP.Text = sp.TenSP.ToString();
            //this.lblNgayDatHang.Text = dh.NgayDatHang.ToString();
            this.lblTongTien.Text = dh.TongTien.ToString();
            this.lblTrangThai.Text = dh.TrangThaiDonHang.ToString();
            this.pictureBox1.Image = ByteArrayToImage(sp.Hinh);
        }
        Image ByteArrayToImage(byte[] a)
        {
            MemoryStream ms = new MemoryStream(a);
            return Image.FromStream(ms);
        }
    }
}
