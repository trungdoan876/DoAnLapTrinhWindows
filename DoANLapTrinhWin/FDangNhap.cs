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
        public FDangNhap()
        {
            InitializeComponent();
        }

        private void FDangNhap_Load(object sender, EventArgs e)
        {

        }



        private void btnBanHang_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            try
            {
                conn.Open();
                string tenTK = ucTextBox1.textBox.Text;
                string matKhau = ucTextBox2.textBox.Text;
                string sql = "Select * from Nguoiban where Tentaikhoan='"+tenTK+"' and Matkhau='"+matKhau+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if(dta.Read()==true)
                {
                    this.Hide(); //an form 1
                    FNguoiBan form2 = new FNguoiBan(); // tao doi tuong form 2
                    form2.ShowDialog(); //show la thao tac dong thoi 2 form
                                        //ShowDialog thi khi tat form2 thi moi tro lai thao tac tren form1
                    form2 = null; //tat form2, tuc la form 2 tro ve null
                    this.Show(); //hien lai form 1
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
        //KH001 -123456
        private void buttonTuyChinh3_Click(object sender, EventArgs e)
        { 
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            try
            {
                conn.Open();
                string tenTK = ucTextBox1.textBox.Text;
                string matKhau = ucTextBox2.textBox.Text;
                string sql = "Select * from KhachHang where TenTaiKhoan='" + tenTK + "' and MatKhau='" + matKhau + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    this.Hide(); //an form 1
                    FNguoiMua form2 = new FNguoiMua(); // tao doi tuong form 2
                    form2.ShowDialog(); //show la thao tac dong thoi 2 form
                                        //ShowDialog thi khi tat form2 thi moi tro lai thao tac tren form1
                    form2 = null; //tat form2, tuc la form 2 tro ve null
                    this.Show(); //hien lai form 1
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
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBanHang_Click_1(object sender, EventArgs e)
        {

        }
    }
}
