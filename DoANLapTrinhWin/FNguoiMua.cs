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
            panel8.Controls.Add(form);
            panel8.Tag = form;
            form.BringToFront();
            form.Show();
        }
        private void FNguoiMua_Load(object sender, EventArgs e)
        {

        }
        private void btnThongTin_Click_1(object sender, EventArgs e)
        {
            moFormConMua(new FThongTinNguoiMua(tenTK));
            TaoButton(sender);
        }

        private void btnMH_Click_1(object sender, EventArgs e)
        {
            moFormConMua(new FMuaHang(tenTK));
            TaoButton(sender);
        }

        private void btnGH_Click(object sender, EventArgs e)
        {
            moFormConMua(new FGioHang(tenTK));
            TaoButton(sender);
        }

        private void btnDH_Click(object sender, EventArgs e)
        {
            moFormConMua(new FDonHang());
            TaoButton(sender);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
