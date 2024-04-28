using Guna.UI2.WinForms;
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
    public partial class FDangKy : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        Global gl = new Global();
        private Guna2GradientButton btnOK;
        private string selctecOption = null;
        public FDangKy()
        {
            InitializeComponent();
            this.Size = new Size(1005, 500);
        }
        private void TaoButton(object button)
        {
            var btn = (Guna2GradientButton)button;

            btn.FillColor = Color.DeepSkyBlue;
            btn.FillColor2 = Color.Violet;

            if (btnOK != null && btnOK != btn)
            {
                btnOK.FillColor = Color.FromArgb(255, 128, 128);
                btnOK.FillColor2 = Color.Gray;
            }

            btnOK = btn;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (selctecOption == "Bán hàng")
                {
                    string sql = string.Format("Select count(*) from NguoiBan WHERE SDT='{0}'",txtDK.Text);
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                        MessageBox.Show("Số điện thoại đã được đăng ký!");
                    else
                        Global.MoFormCon(new FThongTinDangKy(selctecOption,txtDK.Text), panelDK);
                }
                else if (selctecOption == "Mua hàng")
                {
                    string sql = string.Format("Select count(*) from NguoiMua WHERE SDT='{0}'", txtDK.Text);
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                        MessageBox.Show("Số điện thoại đã được đăng ký!");
                    else
                        Global.MoFormCon(new FThongTinDangKy(selctecOption, txtDK.Text), panelDK);
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

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            TaoButton(btnBanHang);
            selctecOption = "Bán hàng";
            btnBanHang.FillColor = Color.DeepSkyBlue;
            btnBanHang.FillColor2 = Color.Violet;
        }

        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            TaoButton(sender);
            selctecOption = "Mua hàng";
            btnMuaHang.FillColor = Color.DeepSkyBlue;
            btnMuaHang.FillColor2 = Color.Violet;
            btnBanHang.FillColor = Color.Coral;
            btnBanHang.FillColor2 = Color.LightCoral;
        }

        private void btnQuayLaiDangNhap_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
