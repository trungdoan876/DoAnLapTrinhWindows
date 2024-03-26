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
        public FChuyenKhoan()
        {
            InitializeComponent();
        }
        public FChuyenKhoan(SanPham sp)
        {
            this.sp = sp;
            InitializeComponent();
            lblTongTien.Text = sp.GiaBan;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công");
        }
    }
}
