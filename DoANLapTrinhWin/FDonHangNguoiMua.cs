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
    public partial class FDonHangNguoiMua : Form
    {
        NguoiMua ngmua;
        Global gl = new Global();
        public FDonHangNguoiMua(NguoiMua ngMua)
        {
            InitializeComponent();
            this.ngmua = ngMua;
            Global.MoFormCon(new FDHDangThucHienNM(ngmua), panel1);
            Global.TaoButton(btnDangThucHien, ref gl.btnOK);
        }
        private void btnDangThucHien_Click(object sender, EventArgs e)
        {
            Global.MoFormCon(new FDHDangThucHienNM(ngmua),panel1);
            Global.TaoButton(btnDangThucHien, ref gl.btnOK);
        }

        private void btnDaGiao_Click(object sender, EventArgs e)
        {
            Global.MoFormCon(new FDaGiaoNM(ngmua), panel1);
            Global.TaoButton(btnDaGiao, ref gl.btnOK);
        }
    }
}
