using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoANLapTrinhWin
{
    public partial class FMuaNgay : Form
    {
        SanPham sp;
        System.Drawing.Image ByteArrayToImage(byte[] a)
        {
            MemoryStream ms = new MemoryStream(a);
            return System.Drawing.Image.FromStream(ms);
        }
        public FMuaNgay()
        {
            InitializeComponent();
        }
        public FMuaNgay(SanPham sp)
        {
            this.sp = sp;
            InitializeComponent();
        }
    }
}

      
