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
    public partial class FLoadingGiaoHang : Form
    {
        public FLoadingGiaoHang()
        {
            InitializeComponent();
            this.Size = new Size(1250, 700);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2CircleProgressBar1.Value == 100)
            {
                timer1.Stop();
                this.Close();
            }
            else
            {
                guna2CircleProgressBar1.Value += 1;
            }
        }
    }
}
