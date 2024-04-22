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
    public partial class FDonHangNguoiMua : Form
    {
        string maNM;
        Global gl = new Global();
        public FDonHangNguoiMua(string maNM)
        {
            InitializeComponent();
            this.maNM = maNM;
            Global.MoFormCon(new FDHDangThucHienNM(maNM), panel1);
            Global.TaoButton(btnDangThucHien, ref gl.btnOK);
        }
        private void btnDangThucHien_Click(object sender, EventArgs e)
        {
            Global.MoFormCon(new FDHDangThucHienNM(maNM),panel1);
            Global.TaoButton(btnDangThucHien, ref gl.btnOK);
        }
    }
}
