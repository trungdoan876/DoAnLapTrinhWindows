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
    public partial class FDonHangNguoiBan : Form
    {
        NguoiBan ngBan;
        Global gl = new Global();
        public FDonHangNguoiBan(NguoiBan ngban)
        {
            InitializeComponent();
            this.ngBan = ngban;
            Global.MoFormCon(new FDHDangThucHienNB(ngBan), panelThan);
            Global.TaoButton(btnDangThucHien, ref gl.btnOK);
        }
        private void btnDangThucHien_Click(object sender, EventArgs e)
        {
            Global.TaoButton(btnDangThucHien, ref gl.btnOK);
            Global.MoFormCon(new FDHDangThucHienNB(ngBan), panelThan);
        }

        private void btnDaGiao_Click(object sender, EventArgs e)
        {
            Global.TaoButton(btnDaGiao, ref gl.btnOK);
            Global.MoFormCon(new FDaGiaoNB(ngBan), panelThan);
        }
    }
}
