using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DoANLapTrinhWin
{
    public partial class UCDanhGiaNhieuSP : UserControl
    {
        SanPham sp;
        DonHang dh;
        public List<Image> arrPicture = new List<Image>();
        Global gt = new Global();
        public UCDanhGiaNhieuSP(SanPham sp,DonHang dh)
        {
            InitializeComponent();
            this.sp = sp;
            this.dh = dh;
            this.ucDanhGia1.picHinh.Image = Global.ByteArrayToImage(sp.Hinh);
            this.ucDanhGia1.lblTenSP.Text = sp.TenSP;
            this.ucDanhGia1.lblTrangthai.Text = dh.TrangThaiDonHangNM;
        }
        private void picThemHinh_Click(object sender, EventArgs e)
        {
            arrPicture = Global.CreateOpenFileDialogMoreNoClick(panelThemNhieuHinh,arrPicture);
        }

        private void ratingsp_ValueChanged_1(object sender, EventArgs e)
        {
            lblsao.Text = Global.tinhtrangsao(ratingsp.Value); // Gán giá trị trạng thái cho nhãn lblsao
        }

        private void ratingnguoiban_ValueChanged_1(object sender, EventArgs e)
        {
            lblnguoiban.Text = Global.tinhtrangsao(ratingnguoiban.Value); // Gán giá trị trạng thái cho nhãn lblnguoiban
        }

        private void ratinggiaohang_ValueChanged_1(object sender, EventArgs e)
        {
            lblgiaohang.Text = Global.tinhtrangsao(ratinggiaohang.Value); // Gán giá trị trạng thái cho nhãn lblgiaohang
        }
        
    }
}
