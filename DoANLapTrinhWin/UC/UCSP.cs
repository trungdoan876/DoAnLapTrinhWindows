using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DoANLapTrinhWin
{
    public partial class UCSP : UserControl
    {
        SanPham sanPham;
        SanPhamDAO spDAO = new SanPhamDAO();
        private void UCSP_Load(object sender, EventArgs e)
        {

        }
        public UCSP()
        {
               InitializeComponent();
        }
        public UCSP(SanPham sp)
        {
            this.sanPham = sp;
            InitializeComponent();
            this.lblMaSP.Text = sp.MaSP;
            this.lblTenSP.Text = sp.TenSP;
            this.lblGiaBan.Text = "đ" + sp.GiaBan ;
            this.lblGiaGoc.Text = "đ" + sp.GiaGoc ;
            this.lblDiaChi.Text = sp.DiaChi;
        }
        private void UCSP_Click(object sender, EventArgs e)
        {
            this.Hide(); //an form 1
            FCTSP formCTSP = new FCTSP(sanPham);
            formCTSP.ShowDialog();
            formCTSP = null;
            this.Show();
        }
    }
}
