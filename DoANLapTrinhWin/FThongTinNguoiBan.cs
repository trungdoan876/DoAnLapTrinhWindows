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
    public partial class FThongTinNguoiBan : Form
    {
        string maTK;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        NguoiBanDAO nguoiDao = new NguoiBanDAO();
        public FThongTinNguoiBan(string tenTaiKhoan)
        {
            InitializeComponent();
            this.maTK = tenTaiKhoan;
            this.WindowState = FormWindowState.Maximized;
        }
        private void LoadDuLieu()
        {
            //NguoiBan nguoiban = new NguoiBan(txtMaTaiKhoan.Text, txtHoTen.Text, ucSDT.textBox.Text, dtpNgSinh.Value, ucGioiTinh.textBox.Text, ucCCCD.textBox.Text, ucDiaChi.textBox.Text, ucEmail.textBox.Text, ucMoTaShop.textBox.Text);
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM NguoiBan WHERE MaNguoiBan = '{0}'", maTK);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader docDuLieu = cmd.ExecuteReader();
                if (docDuLieu.Read())
                {
                    // Đưa dữ liệu vào TextBox
                    txtMaTaiKhoan.Text = docDuLieu["MaNguoiBan"].ToString();
                    txtHoTen.Text = docDuLieu["Ten"].ToString();
                    txtGioiTinh.Text = docDuLieu["GioiTinh"].ToString();
                    dtpNgSinh.Text = docDuLieu["NgaySinh"].ToString();
                    //ucNgSinh.textBox.Text = docDuLieu["NgaySinh"].ToString();
                    txtCCCD.Text = docDuLieu["CCCD"].ToString();
                    txtSDT.Text = docDuLieu["SDT"].ToString();
                    txtDiaChi.Text = docDuLieu["DiaChi"].ToString();
                    txtEmail.Text = docDuLieu["Email"].ToString();
                    txtMoTa.Text = docDuLieu["MoTaShop"].ToString();
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
        private void FThongTinNguoiBan_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            lblGioiThieu.Text = "Xin chào người bán,  " + txtHoTen.Text;
        }
    }
}
