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
        }
        private void LoadDuLieu()
        {
            NguoiBan nguoiban = new NguoiBan(ucMaNBan.textBox.Text, ucHoTenNB.textBox.Text, ucSDT.textBox.Text, dtpNgSinh.Value, ucGioiTinh.textBox.Text, ucCCCD.textBox.Text, ucDiaChi.textBox.Text, ucEmail.textBox.Text, ucMoTaShop.textBox.Text);
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM NguoiBan WHERE MaNguoiBan = '{0}'", maTK);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader docDuLieu = cmd.ExecuteReader();
                if (docDuLieu.Read())
                {
                    // Đưa dữ liệu vào TextBox
                    ucMaNBan.textBox.Text = docDuLieu["MaNguoiBan"].ToString();
                    ucHoTenNB.textBox.Text = docDuLieu["Ten"].ToString();
                    ucGioiTinh.textBox.Text = docDuLieu["GioiTinh"].ToString();
                    dtpNgSinh.Text = docDuLieu["NgaySinh"].ToString();
                    //ucNgSinh.textBox.Text = docDuLieu["NgaySinh"].ToString();
                    ucCCCD.textBox.Text = docDuLieu["CCCD"].ToString();
                    ucSDT.textBox.Text = docDuLieu["SDT"].ToString();
                    ucDiaChi.textBox.Text = docDuLieu["DiaChi"].ToString();
                    ucEmail.textBox.Text = docDuLieu["Email"].ToString();
                    ucMoTaShop.textBox.Text = docDuLieu["MoTaShop"].ToString();
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
        }
    }
}
