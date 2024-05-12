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
        decimal tongtien;
        SanPham sp;
        NguoiMua ng;
        public FChuyenKhoan()
        {
            InitializeComponent();
        }
        public FChuyenKhoan(NguoiMua ngmua, SanPham sp, decimal tongtien)
        {
            InitializeComponent();
            this.sp = sp;
            this.ng = ngmua;
            this.tongtien = tongtien;
            lblTongTien.Text = "đ" + tongtien.ToString();
            txtTen.Text = ngmua.Ten1;
            lblDiaChi.Text = ngmua.DiaChi;
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
