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
    public partial class FDanhGia : Form
    {
        SanPham sp;
        DonHang dh;
        System.Drawing.Image ByteArrayToImage(byte[] a)
        {
            MemoryStream ms = new MemoryStream(a);
            return System.Drawing.Image.FromStream(ms);
        }
        public FDanhGia(SanPham sp, DonHang dh)
        {
            InitializeComponent();
           // this.ratingsp.Value = 4;
            this.sp = sp;
            this.dh = dh;
            this.ucDanhGia1.lblTenSP.Text = sp.TenSP;
            this.ucDanhGia1.picHinh.Image = ByteArrayToImage(sp.Hinh);
            this.ucDanhGia1.lblTrangthai.Text = dh.TrangThaiDonHangNM;
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ratingsp_ValueChanged(object sender, EventArgs e)
        {
            if (ratingsp.Value ==4 && ratingsp.Value == 4.5)
            {
                lblsao.Text = "Hài lòng";
            }
            if (ratingsp.Value == 3 && ratingsp.Value == 3.5)
            {
                lblsao.Text = "Bình thường";
            }
            if (ratingsp.Value == 2 && ratingsp.Value == 2.5)
            {
                lblsao.Text = "Không hài lòng";
            }
            if (ratingsp.Value == 1 && ratingsp.Value == 0.5)
            {
                lblsao.Text = "Tệ";
            }
        }
    }
}
