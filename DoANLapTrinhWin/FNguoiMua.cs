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
using System.Drawing;

namespace DoANLapTrinhWin
{
    public partial class FNguoiMua : Form
    {
        string tenTK;
        public FNguoiMua(string tenTK)
        {
            InitializeComponent();
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
        private void TaoButton(Guna2Button button)
        {
            button.BackColor = Color.SeaGreen;
            button.ForeColor = Color.White;
            if (btnOK != null && btnOK != button)
            {
                btnOK.BackColor = Color.FromArgb(64, 64, 64);
                btnOK.ForeColor = Color.White;
            }
            btnOK = button;
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            moFormConMua(new FThongTinChiTietNguoiMua());
            TaoButton(btn);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            moFormConMua(new FMuaHang(tenTK));
        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {
            moFormConMua(new FGioHang(tenTK));
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            moFormConMua(new FDonHang());
        }

        private void btnYeuThich_Click(object sender, EventArgs e)
        {
            moFormConMua(new FYeuThich(tenTK));
        }
    }
}
