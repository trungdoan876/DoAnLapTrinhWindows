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
    public partial class FDangNhap : Form
    {
        private Button btnOK;
        private string selctecOption = null;
        public FDangNhap()
        {
            InitializeComponent();
            btnBanHang.BackColor = Color.SeaGreen;
            btnMuaHang.BackColor = Color.DimGray;
        }
        private void TaoButton(object button)
        {
            var btn = (Button)button;
            
            btn.BackColor = Color.SeaGreen;
            btn.ForeColor = Color.White;
            if(btnOK != null && btnOK !=btn)
            {
                btnOK.BackColor = Color.DimGray;
                btnOK.ForeColor = Color.White;
            }
            btnOK = btn;
        }
        private void FDangNhap_Load(object sender, EventArgs e)
        {

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnBanHang_Click(object sender, EventArgs e)
        {
            selctecOption = "Bán hàng";
            btnBanHang.BackColor = Color.SeaGreen;
            btnMuaHang.BackColor = Color.DimGray;
            // TaoButton(sender);
        }
        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            // TaoButton(sender);
            selctecOption = "Mua hàng";
            btnMuaHang.BackColor = Color.SeaGreen;
            btnBanHang.BackColor = Color.DimGray;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (selctecOption == "Mua hàng")
            {
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
                try
                {
                    conn.Open();
                    string tenTK = ucDangNhap.textBox.Text; //tenTK = ma
                    string matKhau = ucMatKhau.textBox.Text;
                    string sql = "Select * from NguoiMua WHERE MaNguoiMua='" + tenTK + "' and MatKhau='" + matKhau + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dta = cmd.ExecuteReader();
                    if (dta.Read() == true)
                    {
                        this.Hide(); //an form 1
                        FNguoiMua form2 = new FNguoiMua(); 
                        form2.ShowDialog(); 
                        form2 = null; 
                        this.Show();
                        ucDangNhap.textBox.Text = null;
                        ucMatKhau.textBox.Text = null;
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
                    string tenTK = ucDangNhap.textBox.Text;
                    string matKhau = ucMatKhau.textBox.Text;
                    string sql = "Select * from NguoiBan where MaNguoiBan='" + tenTK + "' and MatKhau='" + matKhau + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dta = cmd.ExecuteReader();
                    if (dta.Read() == true)
                    {
                        this.Hide(); 
                        FNguoiBan form2 = new FNguoiBan(tenTK); 
                        form2.ShowDialog(); 
                        form2 = null; 
                        this.Show();
                        ucDangNhap.textBox.Text = null;
                        ucMatKhau.textBox.Text = null;
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
    }
}
