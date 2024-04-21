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
    public partial class FDonHangNguoiMua : Form
    {
        string maNM;
        public FDonHangNguoiMua(string maNM)
        {
            InitializeComponent();
            this.maNM = maNM;
            moFormCon(new FDHDangThucHienNM(maNM));
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
            panel1.Controls.Add(form);
            panel1.Tag = form;
            form.BringToFront();
            form.Show();
        }
        private void btnDangThucHien_Click(object sender, EventArgs e)
        {
            moFormCon(new FDHDangThucHienNM(maNM));
        }
    }
}
