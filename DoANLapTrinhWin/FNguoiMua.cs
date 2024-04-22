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
        string tenTK;
        Global gl = new Global();
        public FNguoiMua(string tenTK)
        {
            InitializeComponent();
            this.Size = new Size(1200, 600);
            this.tenTK = tenTK;
        }
        private void FNguoiMua_Load(object sender, EventArgs e)
        {

        }
        private void btnThongTin_Click(object sender, EventArgs e)
        {
            Global.TaoButton(btnThongTin, ref gl.btnOK);
            Global.MoFormCon(new FThongTinChiTietNguoiMua(), panelThan);    
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Global.TaoButton(btnDangXuat, ref gl.btnOK);
            this.Close();
        }

        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            Global.TaoButton(btnMuaHang, ref gl.btnOK);
            Global.MoFormCon(new FMuaHang(tenTK), panelThan);
        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {
            Global.TaoButton(btnGioHang, ref gl.btnOK);
            Global.MoFormCon(new FGioHang(tenTK), panelThan);
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            Global.TaoButton(btnDonHang, ref gl.btnOK);
            Global.MoFormCon(new FDonHangNguoiMua(tenTK), panelThan);
        }

        private void btnYeuThich_Click(object sender, EventArgs e)
        {
            Global.TaoButton(btnYeuThich, ref gl.btnOK);
            Global.MoFormCon(new FYeuThich(tenTK), panelThan);
        }
    }
}
