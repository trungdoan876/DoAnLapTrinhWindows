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
    public partial class FThongTinNguoiMua : Form
    {
        string tenTK;
        public FThongTinNguoiMua(string tenTK)
        {
            InitializeComponent();
            this.tenTK = tenTK;
            moFormCon(new FThongTinChiTietNguoiMua());
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
            panel4.Controls.Add(form);
            panel4.Tag = form;
            form.BringToFront();
            form.Show();
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
        private void FThongTinNguoiMua_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            moFormCon(new FThongTinChiTietNguoiMua());
            TaoButton(sender);
        }

        private void btnYT_Click(object sender, EventArgs e)
        {
            moFormCon(new FYeuThich(tenTK));
            TaoButton(sender);
        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            //moFormCon(new FDanhGia());
            TaoButton(sender);
        }

      
    }
}
