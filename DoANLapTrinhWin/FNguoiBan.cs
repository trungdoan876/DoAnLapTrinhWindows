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
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            moFormCon(new FThongTinNguoiBan(TenTaiKhoan));
            TaoButton(sender);
        }
        private void btnSP_Click(object sender, EventArgs e)
        {
            moFormCon(new FSanPham(TenTaiKhoan));
            TaoButton(sender);
        }
        private void btnDonHang_Click(object sender, EventArgs e)
        {
            moFormCon(new FDonHangNguoiBan());
            TaoButton(sender);
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            moFormCon(new FThongKeNguoiBan());
            TaoButton(sender);
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

    }
}
