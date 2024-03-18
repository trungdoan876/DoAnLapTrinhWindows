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
    public partial class UCSP : UserControl
    {
        public UCSP()
        {
            InitializeComponent();
        }

        private void UCSP_Load(object sender, EventArgs e)
        {

        }

        private void UCSP_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FMuaHang>().Any())
            {
                this.Hide(); //an form 1
                FCTSP formCTSP = new FCTSP();
                formCTSP.ShowDialog();
                formCTSP = null;
                this.Show();
            }
            else if (Application.OpenForms.OfType<FTatCaSanPham>().Any())
            {
                this.Hide(); //an form 1
                FCTSPSua formCTSP1 = new FCTSPSua("SP1");
                formCTSP1.ShowDialog(); 
                formCTSP1 = null;
                this.Show();
            }
        }

    }
}
