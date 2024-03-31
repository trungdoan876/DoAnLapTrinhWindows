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
    public partial class UCSPGioHang : UserControl
    {
        SanPham sp;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public UCSPGioHang(SanPham sp)
        {
            InitializeComponent();
            this.sp = sp;
            this.lblTenSP.Text = sp.TenSP;
            this.lblGiaTien.Text = "đ" + sp.GiaBan;
            this.lblTinhTrang.Text = sp.TinhTrang;
            this.lblSoLuong.Text = sp.SoLuong+" san pham san co";
        }

        private void btnXoaKhoiGioHang_Click(object sender, EventArgs e)
        {
            try
            {
                // Ket noi
                conn.Open();
                string sqlStr = string.Format("DELETE FROM GioHang WHERE MaSanPham = '{0}'", sp.MaSP);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("xoa thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("xoa that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
