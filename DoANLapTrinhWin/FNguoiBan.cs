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
        public FNguoiBan()
        {
            InitializeComponent();
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
            moFormCon(new FThongTinNguoiBan());
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            moFormCon(new FSanPhamNguoiBan());
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            moFormCon(new FDonHangNguoiBan());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            moFormCon(new FThongKeNguoiBan());
        }
    }
}
