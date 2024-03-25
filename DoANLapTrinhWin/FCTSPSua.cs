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

namespace DoANLapTrinhWin
{
    public partial class FCTSPSua : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        SanPhamDAO spDao= new SanPhamDAO();
        public FCTSPSua(string maSanPham)
        {
            InitializeComponent();
        }
        public FCTSPSua(SanPham sp)
        {
            InitializeComponent();
            ucMaSP.textBox.Text = sp.MaSP;
            ucTenSP.textBox.Text = sp.TenSP;
            ucGiaSP.textBox.Text = sp.GiaBan.ToString();
            ucGiaGoc.textBox.Text = sp.GiaGoc.ToString();
            ucXuatXu.textBox.Text = sp.XuatXu;
            ucNganhHang.textBox.Text = sp.NganhHang;
            ucMoTa.textBox.Text = sp.MoTaSanPham;
            ucThoiGian.textBox.Text = sp.ThoiGianDaSuDung;
            cbTinhTrang.Text = sp.TinhTrang;
        }
        private void FCTSPSua_Load(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham(ucMaSP.textBox.Text, ucTenSP.textBox.Text, ucGiaSP.textBox.Text, ucGiaGoc.textBox.Text,
                    ucXuatXu.textBox.Text, ucThoiGian.textBox.Text, dtpNgayDang.Value, ucMoTa.textBox.Text, ucNganhHang.textBox.Text,
                    cbTinhTrang.Text,ucMaNB.textBox.Text,ucDC.textBox.Text);
            spDao.CapNhatSanPham(sp);
        }
    }
}
