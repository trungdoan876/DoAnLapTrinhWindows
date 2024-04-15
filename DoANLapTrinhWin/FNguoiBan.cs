using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoANLapTrinhWin
{
    public partial class FNguoiBan : Form
    {
        string TenTaiKhoan;
        public FNguoiBan(string tenTaiKhoan)
        {
            InitializeComponent();
            this.TenTaiKhoan = tenTaiKhoan;
            this.WindowState = FormWindowState.Maximized;
        }
        private Form formcon;
        private void moFormCon(Form form)
        {
            if (formcon != null)
            {
                formcon.Close();
            }
            formcon = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelThan.Controls.Add(form);
            panelThan.Tag = form;
            form.BringToFront();
            form.Show();
        }
        private void FNguoiBan_Load(object sender, EventArgs e)
        {

        }
        private Button btnOK;
        private void TaoButton(object button)
        {
            var btn = (Button)button;

            btn.BackColor = Color.SeaGreen;
            btn.ForeColor = Color.White;
            if (btnOK != null && btnOK != btn)
            {
                btnOK.BackColor = Color.FromArgb(64, 64, 64);
                btnOK.ForeColor = Color.White;
            }
            btnOK = btn;
        }

        private void btnThongTin_Click_1(object sender, EventArgs e)
        {
            moFormCon(new FThongTinNguoiBan(TenTaiKhoan));
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            moFormCon(new FSanPham(TenTaiKhoan));
        }

        private void btnDonHang_Click_1(object sender, EventArgs e)
        {
            moFormCon(new FDonHangNguoiBan());
        }

        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            moFormCon(new FThongKeNguoiBan());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
