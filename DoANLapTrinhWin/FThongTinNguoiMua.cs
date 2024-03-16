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
        public FThongTinNguoiMua()
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
            panel4.Controls.Add(form);
            panel4.Tag = form;
            form.BringToFront();
            form.Show();
        }

  
        private void FThongTinNguoiMua_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            moFormCon(new FThongTinChiTiet());
        }

        private void btnYT_Click(object sender, EventArgs e)
        {
            moFormCon(new FYeuThich());
        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            moFormCon(new FDanhGia());
        }

      
    }
}
