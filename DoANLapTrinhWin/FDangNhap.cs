using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using static System.Net.Mime.MediaTypeNames;

namespace DoANLapTrinhWin
{
    public partial class FDangNhap : Form
    {
        private string selctecOption = null;
        Global gl = new Global();
        NguoiBanDAO ngbandao = new NguoiBanDAO();
        NguoiMuaDAO ngmuadao = new NguoiMuaDAO();
        
        public FDangNhap()
        {
            InitializeComponent();
            this.Size = new Size(1005, 500);
            btnBanHang.FillColor = Color.DeepSkyBlue;
            btnBanHang.FillColor2 = Color.Violet;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            Global.TaoButtonDangNhap(btnBanHang,ref gl.btncheck);
            selctecOption = "Bán hàng";
            btnBanHang.FillColor = Color.DeepSkyBlue;
            btnBanHang.FillColor2 = Color.Violet;
        }

        private void btnMuaHang_Click_1(object sender, EventArgs e)
        {
            Global.TaoButtonDangNhap(btnMuaHang,ref gl.btncheck);
            selctecOption = "Mua hàng";
            btnMuaHang.FillColor = Color.DeepSkyBlue;
            btnMuaHang.FillColor2 = Color.Violet;
            btnBanHang.FillColor = Color.FromArgb(255, 128, 128);
            btnBanHang.FillColor2 = Color.Gray;
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            string tenTK = txtDangNhap.Text; //tenTK = ma
            string matKhau = txtMatKhau.Text;
            if (selctecOption == "Mua hàng")
            {
                NguoiMua ngmua = new NguoiMua(tenTK,matKhau);
                DataTable dt =  ngmuadao.DangNhap(ngmua);
                if (dt.Rows.Count > 0)
                {
                    this.Hide(); //an form 1
                    FLoading load = new FLoading(ngmua,selctecOption);
                    load.Show();
                    txtDangNhap.Text = null;
                    txtMatKhau.Text = null;
                }
                else
                {
                    MessageBox.Show("Không thể đăng nhập!");
                }
            }
            else
            {
                NguoiBan ngBan = new NguoiBan(tenTK,matKhau);
                DataTable dt = ngbandao.DangNhap(ngBan);
                if (dt.Rows.Count > 0)
                {
                    this.Hide(); //an form 1
                    FLoading load = new FLoading(ngBan,selctecOption);
                    load.Show();
                    txtDangNhap.Text = null;
                    txtMatKhau.Text = null;
                }
                else
                {
                    MessageBox.Show("Không thể đăng nhập!");
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
