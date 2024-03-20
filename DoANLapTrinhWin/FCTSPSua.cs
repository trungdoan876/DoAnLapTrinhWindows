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
        public FCTSPSua(string maSanPham)
        {
            InitializeComponent();
        }
        public FCTSPSua(SanPham sp)
        {
            InitializeComponent();
            uctxtMaSP.textBox.Text = sp.MaSP;
            uctxtTenSP.textBox.Text = sp.TenSP;
            uctxtGiaSP.textBox.Text = sp.GiaBan.ToString();
            uctxtGiaGoc.textBox.Text = sp.GiaGoc.ToString();
            uctxtXuatXu.textBox.Text = sp.XuatXu;
            uctxtNganhHang.textBox.Text = sp.NganhHang;
            uctxtMoTa.textBox.Text = sp.MoTaSanPham;
            uctxtThoiGian.textBox.Text = sp.ThoiGianDaSuDung;
            cbboxTinhTrang.Text = sp.TinhTrang;
        }
        private void FCTSPSua_Load(object sender, EventArgs e)
        {

        }
    }
}
