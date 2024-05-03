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
    public partial class FNguoiBan : Form
    {
        NguoiBan ngBan;
        Global gl = new Global();
        public FNguoiBan(NguoiBan ngban)
        {
            InitializeComponent();
            this.Size = new Size(1200, 600);
            this.ngBan = ngban;
        }
        private void FNguoiBan_Load(object sender, EventArgs e)
        {

        }

        private void btnThongTin_Click_1(object sender, EventArgs e)
        {
            Global.TaoButton(btnThongTin, ref gl.btnOK);
            Global.MoFormCon(new FThongTinNguoiBan(ngBan), panelThan);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            Global.TaoButton(btnSanPham, ref gl.btnOK);
            Global.MoFormCon(new FSanPham(ngBan.Ma), panelThan);
        }

        private void btnDonHang_Click_1(object sender, EventArgs e)
        {
            Global.TaoButton(btnDonHang, ref gl.btnOK);
            Global.MoFormCon(new FDonHangNguoiBan(ngBan.Ma), panelThan);
        }

        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            Global.TaoButton(btnThongKe, ref gl.btnOK);
            //Global.MoFormCon(new FThongKeNguoiBan(), panelThan); 
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Global.TaoButton(btnThoat, ref gl.btnOK);
            this.Close();
        }
    }
}
