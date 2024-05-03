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

namespace DoANLapTrinhWin
{
    public partial class UCDanhGiaNhieuSP : UserControl
    {
        SanPham sp;
        DonHang dh;
        public List<System.Drawing.Image> arrPicture = new List<System.Drawing.Image>();
        public UCDanhGiaNhieuSP(SanPham sp,DonHang dh)
        {
            InitializeComponent();
            this.sp = sp;
            this.dh = dh;
            this.ucDanhGia1.picHinh.Image = Global.ByteArrayToImage(sp.Hinh);
            this.ucDanhGia1.lblTenSP.Text = sp.TenSP;
            this.ucDanhGia1.lblTrangthai.Text = dh.TrangThaiDonHangNM;
        }
        private string tinhtrangsao(double sosao)
        {
            string trangthai = "Tuyệt vời"; // Khởi tạo một chuỗi để lưu trạng thái
            if (sosao == 4 || sosao == 4.5)
            {
                trangthai = "Hài lòng";
            }
            else if (sosao == 3 || sosao == 3.5)
            {
                trangthai = "Bình thường";
            }
            else if (sosao == 2 || sosao == 2.5)
            {
                trangthai = "Không hài lòng";
            }
            else if (sosao == 1 || sosao == 0.5)
            {
                trangthai = "Tệ";
            }
            return trangthai; // Trả về giá trị trạng thái
        }
        private void picThemHinh_Click(object sender, EventArgs e)
        {
            picThemHinh.Image = Global.CreateOpenFileDialog(picThemHinh);
        }

        private void ratingsp_ValueChanged_1(object sender, EventArgs e)
        {
            lblsao.Text = tinhtrangsao(ratingsp.Value); // Gán giá trị trạng thái cho nhãn lblsao
        }

        private void ratingnguoiban_ValueChanged_1(object sender, EventArgs e)
        {
            lblnguoiban.Text = tinhtrangsao(ratingnguoiban.Value); // Gán giá trị trạng thái cho nhãn lblnguoiban
        }

        private void ratinggiaohang_ValueChanged_1(object sender, EventArgs e)
        {
            lblgiaohang.Text = tinhtrangsao(ratinggiaohang.Value); // Gán giá trị trạng thái cho nhãn lblgiaohang
        }
        
    }
}
