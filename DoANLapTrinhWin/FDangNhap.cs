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
using Guna.UI2.WinForms;
using static System.Net.Mime.MediaTypeNames;

namespace DoANLapTrinhWin
{
    public partial class FDangNhap : Form
    {
        private Guna2GradientButton btnOK;
        private string selctecOption = null;
        public FDangNhap()
        {
            InitializeComponent();
            this.Size = new Size(1005, 500);
            btnBanHang.FillColor = Color.DeepSkyBlue;
            btnBanHang.FillColor2 = Color.Violet;
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
        private void FDangNhap_Load(object sender, EventArgs e)
        {
         
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            TaoButton(btnBanHang);
            selctecOption = "Bán hàng";
            btnBanHang.FillColor = Color.DeepSkyBlue;
            btnBanHang.FillColor2 = Color.Violet;
        }

        private void btnMuaHang_Click_1(object sender, EventArgs e)
        {
            TaoButton(sender);
            selctecOption = "Mua hàng";
            btnMuaHang.FillColor = Color.DeepSkyBlue;
            btnMuaHang.FillColor2 = Color.Violet;
            btnBanHang.FillColor = Color.FromArgb(255, 128, 128);
            btnBanHang.FillColor2 = Color.Gray;
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            if (selctecOption == "Mua hàng")
            {
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
                try
                {
                    conn.Open();
                    string tenTK = txtDangNhap.Text; //tenTK = ma
                    string matKhau = txtMatKhau.Text;
                    string sql = "Select * from NguoiMua WHERE Ma='" + tenTK + "' and MatKhau='" + matKhau + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dta = cmd.ExecuteReader();
                    if (dta.Read() == true)
                    {
                        this.Hide(); //an form 1
                        FNguoiMua form2 = new FNguoiMua(tenTK);
                        form2.ShowDialog();
                        form2 = null;
                        this.Show();
                        txtDangNhap.Text = null;
                        txtMatKhau.Text = null;
                    }
                    else
                    {
                        MessageBox.Show("Khong the dang nhap!");
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
                try
                {
                    conn.Open();
                    string tenTK = txtDangNhap.Text; //tenTK = ma
                    string matKhau = txtMatKhau.Text;
                    string sql = "Select * from NguoiBan where Ma='" + tenTK + "' and MatKhau='" + matKhau + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dta = cmd.ExecuteReader();
                    if (dta.Read() == true)
                    {
                        this.Hide();
                        FNguoiBan form2 = new FNguoiBan(tenTK);
                        form2.ShowDialog();
                        form2 = null;
                        this.Show();
                        txtDangNhap.Text = null;
                        txtMatKhau.Text = null;
                    }
                    else
                    {
                        MessageBox.Show("Khong the dang nhap!");
                    }

                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void lblDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            FDangKy form2 = new FDangKy();
            form2.ShowDialog();
            form2 = null;
            this.Show();
        }
    }
}
