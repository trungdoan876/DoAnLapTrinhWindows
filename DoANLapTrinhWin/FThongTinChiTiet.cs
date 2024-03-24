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
    public partial class FThongTinChiTiet : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        //NguoiMua nguoiMua = new NguoiMua();
        public FThongTinChiTiet()
        {
            InitializeComponent();
        }

        private void FThongTinChiTiet_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open(); //
                string sqlStr = string.Format("SELECT *FROM NguoiMua");
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader docDuLieu = cmd.ExecuteReader();
                if (docDuLieu.Read())
                {
                    // Đưa dữ liệu vào TextBox
                    ucMaTaiKhoan.textBox.Text = docDuLieu["MaNguoiMua"].ToString();
                    ucHoTen.textBox.Text = docDuLieu["TenNguoiMua"].ToString();
                    ucGioiTinh.textBox.Text = docDuLieu["GioiTinh"].ToString();
                    ucNgaySinh.textBox.Text = docDuLieu["NgaySinh"].ToString();
                    ucCCCD.textBox.Text = docDuLieu["CCCD"].ToString();
                    ucSDT.textBox.Text = docDuLieu["SDT"].ToString();
                    //ucDiaChi.textBox.Text = docDuLieu["Diachi"].ToString();
                    ucEmail.textBox.Text = docDuLieu["Email"].ToString();
                    ucTenTaiKhoan.textBox.Text = docDuLieu["TenTaiKhoan"].ToString();
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


    }
}
