﻿using System;
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
        public FSanPham()
        {
            InitializeComponent();
            moFormCon(new FTatCaSanPham());
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

        private void btnTatCaSP_Click(object sender, EventArgs e)
        {
            moFormCon(new FTatCaSanPham());
        }
        private void btnThemSP_Click_1(object sender, EventArgs e)
        {
             this.Hide(); //an form 1
            FSanPhamNguoiBan form2 = new FSanPhamNguoiBan(); // tao doi tuong form 2
            form2.ShowDialog(); 
            form2 = null; //tat form2, tuc la form 2 tro ve null
            this.Show(); 
        }
    }
}
