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
    public partial class FSanPham : Form
    {
        string maNBan;
        public FSanPham(string maNB)
        {
            InitializeComponent();
            this.maNBan = maNB;
            moFormCon(new FDanhSachSanPham(maNB));
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
            panelThanSP.Controls.Add(form);
            panelThanSP.Tag = form;
            form.BringToFront();
            form.Show();
        }
        private void FSanPham_Load(object sender, EventArgs e)
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

        private void btnTatCaSP_Click(object sender, EventArgs e)
        {
            moFormCon(new FDanhSachSanPham(maNBan));
        }

        private void btnDaDangBan_Click(object sender, EventArgs e)
        {
            moFormCon(new FDaDangBan(maNBan));
        }

        private void btnChuaDangBan_Click(object sender, EventArgs e)
        {
            moFormCon(new FChuaDangBan(maNBan));
        }
    }
}
