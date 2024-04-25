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
        string maNB;
        Global gl = new Global();
        public FDonHangNguoiBan(string maNB)
        {
            InitializeComponent();
            this.maNB = maNB;
            Global.MoFormCon(new FDHDangThucHienNB(maNB), panelThan);
            Global.TaoButton(btnDangThucHien, ref gl.btnOK);
        }
        private void btnDangThucHien_Click(object sender, EventArgs e)
        {
            Global.TaoButton(btnDangThucHien, ref gl.btnOK);
            Global.MoFormCon(new FDHDangThucHienNB(maNB), panelThan);
        }

        private void btnDaGiao_Click(object sender, EventArgs e)
        {
            Global.TaoButton(btnDaGiao, ref gl.btnOK);
            Global.MoFormCon(new FDaGiaoNB(maNB), panelThan);
        }
    }
}
