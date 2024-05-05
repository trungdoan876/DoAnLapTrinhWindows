using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace DoANLapTrinhWin
{
    public partial class FNguoiMua : Form
    {
        NguoiMua ngMua;
        Global gl = new Global();
        public FNguoiMua(NguoiMua ng)
        {
            InitializeComponent();
            this.Size = new Size(1200, 600);
            this.ngMua = ng;
        }
        private void FNguoiMua_Load(object sender, EventArgs e)
        {

        }
        private void btnThongTin_Click(object sender, EventArgs e)
        {
            Global.TaoButton(btnThongTin, ref gl.btnOK);
            Global.MoFormCon(new FThongTinChiTietNguoiMua(ngMua), panelThan);    
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Global.TaoButton(btnDangXuat, ref gl.btnOK);
            this.Close();
        }

        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            Global.TaoButton(btnMuaHang, ref gl.btnOK);
            Global.MoFormCon(new FMuaHang(ngMua), panelThan);
        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {
            Global.TaoButton(btnGioHang, ref gl.btnOK);
            Global.MoFormCon(new FGioHang(ngMua), panelThan);
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            Global.TaoButton(btnDonHang, ref gl.btnOK);
            Global.MoFormCon(new FDonHangNguoiMua(ngMua), panelThan);
        }

        private void btnYeuThich_Click(object sender, EventArgs e)
        {
            Global.TaoButton(btnYeuThich, ref gl.btnOK);
            Global.MoFormCon(new FYeuThich(ngMua), panelThan);
        }
    }
}
