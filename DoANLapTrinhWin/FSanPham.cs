using Guna.UI2.WinForms;
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
        Global gl = new Global();
        string maNBan;
        public FSanPham(string maNB)
        {
            InitializeComponent();
            this.maNBan = maNB;
            Global.MoFormCon(new FDanhSachSanPham(maNBan),panelThanSP);
            Global.TaoButton(btnTatCaSP, ref gl.btnOK);
        }
        private void btnTatCaSP_Click(object sender, EventArgs e)
        {
            Global.MoFormCon(new FDanhSachSanPham(maNBan), panelThanSP);
            Global.TaoButton(btnTatCaSP, ref gl.btnOK);
        }

        private void btnDaDangBan_Click(object sender, EventArgs e)
        {
            Global.MoFormCon(new FDaDangBan(maNBan), panelThanSP);
            Global.TaoButton(btnDaDangBan, ref gl.btnOK);
        }

        private void btnChuaDangBan_Click(object sender, EventArgs e)
        {
            Global.MoFormCon(new FChuaDangBan(maNBan), panelThanSP);
            Global.TaoButton(btnChuaDangBan, ref gl.btnOK);
        }
    }
}
