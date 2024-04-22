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
        string trangthai;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        byte[] hinh;
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
            this.picHinh.Image = ByteArrayToImage(sp.Hinh);
        }

    }
}
