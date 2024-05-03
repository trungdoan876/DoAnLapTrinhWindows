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
        Global gl = new Global();
        private Guna2GradientButton btnOK;
        private string selctecOption = null;
        NguoiBanDAO ngbandao = new NguoiBanDAO();
        NguoiMuaDAO ngmuadao = new NguoiMuaDAO();
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
            if (selctecOption == "Bán hàng")
            {
                NguoiBan ngban = new NguoiBan(txtDK.Text);
                int kt = ngbandao.KiemTraDangKy(ngban);
                if (kt > 0)
                    MessageBox.Show("Số điện thoại đã được đăng ký!");
                else
                    Global.MoFormCon(new FThongTinDangKy(selctecOption, txtDK.Text), panelDK);
            }
            else
            {
                NguoiMua ngmua = new NguoiMua(txtDK.Text);
                int kt = ngbandao.KiemTraDangKy(ngmua);
                if (kt > 0)
                    MessageBox.Show("Số điện thoại đã được đăng ký!");
                else
                    Global.MoFormCon(new FThongTinDangKy(selctecOption, txtDK.Text), panelDK);
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
