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
    public partial class UCTheoNB : UserControl
    {
        string mangban;
        public UCTheoNB(string mangban)
        {
            InitializeComponent();
            
            this.mangban = mangban;
            this.lbltenNB.Text = mangban;
        }
    }
}
