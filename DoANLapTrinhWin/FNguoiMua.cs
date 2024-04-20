using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace DoANLapTrinhWin
{
    public partial class FNguoiMua : Form
    {
        string tenTK;
        public FNguoiMua(string tenTK)
        {
            InitializeComponent();
            this.Size = new Size(1200, 600);
            this.tenTK = tenTK;
        }
        private Form formconmua;
        private void moFormConMua(Form form)
        {
            if (formconmua != null)
            {
                formconmua.Close();
            }
            formconmua = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelThan.Controls.Add(form);
            panelThan.Tag = form;
            form.BringToFront();
            form.Show();
        }
        private void FNguoiMua_Load(object sender, EventArgs e)
        {

        }
        private Guna2Button btnOK;
        private void TaoButton(object button)
        {
            var btn = (Guna2Button)button;

            btn.FillColor = Color.Gold;

            if (btnOK != null && btnOK != btn)
            {
                btnOK.FillColor = Color.FromArgb(64, 64, 64);
            }

            btnOK = btn;
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            TaoButton(btnThongTin);
            moFormConMua(new FThongTinChiTietNguoiMua());    
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            TaoButton(btnDangXuat);
            this.Close();
        }

        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            TaoButton(btnMuaHang);
            moFormConMua(new FMuaHang(tenTK));
        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {
            TaoButton(btnGioHang);
            moFormConMua(new FGioHang(tenTK));
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            TaoButton(btnDonHang);
            moFormConMua(new FDonHang());
        }

        private void btnYeuThich_Click(object sender, EventArgs e)
        {
            TaoButton(btnYeuThich);
            moFormConMua(new FYeuThich(tenTK));
        }
    }
}
