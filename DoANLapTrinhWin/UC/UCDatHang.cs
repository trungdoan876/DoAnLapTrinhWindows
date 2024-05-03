using DoANLapTrinhWin.Class;
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

namespace DoANLapTrinhWin
{
    public partial class UCDatHang : UserControl
    {
        SanPham sp;
        ChiTietDonHang ct;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        Image ByteArrayToImage(byte[] a)
        {
            MemoryStream ms = new MemoryStream(a);
            return Image.FromStream(ms);
        }
        public UCDatHang(SanPham sp)
        {
            InitializeComponent();
            this.sp = sp;
            this.lblTenSP.Text = sp.TenSP;
            this.lblGiaTien.Text = sp.GiaBan;
            this.lblsoluong.Text = sp.SoLuong;
            this.lblthanhtien.Text = TinhTienMoiSanPham(lblsoluong.Text, lblGiaTien.Text);
            this.picHinh.Image = ByteArrayToImage(sp.Hinh);
        }
        public UCDatHang(ChiTietDonHang ct)
        {
            InitializeComponent();
            this.ct = ct;
            this.lblTenSP.Text = ct.TenSP;
            this.lblGiaTien.Text = ct.GiaTien;
            this.lblsoluong.Text = ct.SoLuong;
            this.picHinh.Image = ByteArrayToImage(ct.Hinh);
            this.lblthanhtien.Text = TinhTienMoiSanPham(lblsoluong.Text, lblGiaTien.Text);  
        }
        public string TinhTienMoiSanPham(string soLuong, string giaTien)
        {
            int sl = int.Parse(soLuong);
            decimal giatien = decimal.Parse(giaTien.Substring(1));
            decimal thanhTien = giatien * sl;
            return thanhTien.ToString();
        }
    }
}
