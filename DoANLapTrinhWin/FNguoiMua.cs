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
        public FNguoiMua()
        {
            InitializeComponent();
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

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            moFormConMua(new FThongTinNguoiMua());
        }

        private void btnMH_Click(object sender, EventArgs e)
        {
            moFormConMua(new FMuaHang());
        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {
            moFormConMua(new FGioHang());
        }

        private void btnDonHangMua_Click(object sender, EventArgs e)
        {
            moFormConMua(new FDonHangMua());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
