using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DoANLapTrinhWin
{
    public partial class FThongTinDangKy : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        string loainguoi;
        string sdt;
        public FThongTinDangKy(string loainguoi, string sdt)
        {
            InitializeComponent();
            this.loainguoi = loainguoi;
            this.sdt = sdt;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (loainguoi == "Bán hàng")
                {
                    string maNB = Global.TaoMaNB();
                    string sql = string.Format("INSERT INTO NguoiBan(Ma,MatKhau,Ten,SDT,NgaySinh,GioiTinh,CCCD, DiaChi) " +
                        "VALUES('{0}','{1}',N'{2}','{3}','{4}',N'{5}','{6}',N'{7}')",
                        maNB,txtMK.Text,txtHoTen.Text,sdt,dtpNgSinh.Value,txtGioiTinh.Text,txtCCCD.Text,txtDiaChi.Text);
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Tao tai khoan thanh cong");
                    this.Close();
                }
                else if (loainguoi == "Mua hàng")
                {
                    string maNM = Global.TaoMaNM();
                    string sql = string.Format("INSERT INTO NguoiMua(Ma,MatKhau,Ten,SDT,NgaySinh,GioiTinh,CCCD, DiaChi) " +
                        "VALUES('{0}','{1}',N'{2}','{3}','{4}',N'{5}','{6}',N'{7}')",
                        maNM, txtMK.Text, txtHoTen.Text, sdt, dtpNgSinh.Value, txtGioiTinh.Text, txtCCCD.Text, txtDiaChi.Text);
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Tao tai khoan thanh cong");
                    this.Close();
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
