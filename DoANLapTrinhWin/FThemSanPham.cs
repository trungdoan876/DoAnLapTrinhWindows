using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoANLapTrinhWin
{
    public partial class FThemSanPham : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        SanPhamDAO spDAO = new SanPhamDAO();
        public FThemSanPham(string maNB)
        {
            InitializeComponent();
            this.lblMaNB.Text = maNB;
        }

        private void FSanPhamNguoiBan_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham(ucMaSP.textBox.Text,ucTenSP.textBox.Text, ucGiaBan.textBox.Text, ucGiaGoc.textBox.Text,
    ucXuatXu.textBox.Text, ucTGDSD.textBox.Text,dtpNgayDang.Value, ucMoTaSP.textBox.Text, ucNganhHang.textBox.Text,
    cbbTinhTrang.Text,ucDC.textBox.Text,lblMaNB.Text,ucSoLuong.textBox.Text);
            spDAO.ThemSanPham(sp);
        }
    }
}
