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
    public partial class FChuyenKhoan : Form
    {
        SanPham sp;
        string maNM,ten,diachi;
        decimal tongtien;
        public FChuyenKhoan()
        {
            InitializeComponent();
        }
        public FChuyenKhoan(string maNM, SanPham sp, decimal tongtien, string ten, string diachi)
        {
            this.sp = sp;
            this.maNM = maNM;
            this.tongtien = tongtien;
            this.ten = ten;
            this.diachi = diachi;
            InitializeComponent();
            lblTongTien.Text = "đ" + tongtien.ToString();
            txtTen.Text = ten;
            lblDiaChi.Text = diachi;
        }
        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnThanhToan_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công \r\n Cảm ơn quý khách đã tin tưởng PandaShop");
        }
    }
}
