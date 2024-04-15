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
    public partial class FThongTinChiTietNguoiMua : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FThongTinChiTietNguoiMua()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM NguoiMua");
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader docDuLieu = cmd.ExecuteReader();
                if (docDuLieu.Read())
                {
                    // Đưa dữ liệu vào TextBox
                    txtMaTaiKhoan.Text = docDuLieu["MaNguoiMua"].ToString();
                    txtHoTen.Text = docDuLieu["TenNguoiMua"].ToString();
                    txtGioiTinh.Text = docDuLieu["GioiTinh"].ToString();
                    dtpNgSinh.Text = docDuLieu["NgaySinh"].ToString();
                    txtCCCD.Text = docDuLieu["CCCD"].ToString();
                    txtSDT.Text = docDuLieu["SDT"].ToString();
                    txtDiaChi.Text = docDuLieu["Diachi"].ToString();
                    txtEmail.Text = docDuLieu["Email"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        private void FThongTinChiTiet_Load(object sender, EventArgs e)
        {
            LoadData();
            lblGioiThieu.Text = "Xin chào khách hàng,   " + txtHoTen.Text;
        }
    }
}
