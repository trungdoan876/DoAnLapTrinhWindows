using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DoANLapTrinhWin
{
    public partial class UCSP : UserControl
    {
        SanPham sp;
        NguoiBan ngban;
        NguoiMua ngmua;
        YeuThichDAO ytdao = new YeuThichDAO();
        SanPhamDAO spdao = new SanPhamDAO();
        public UCSP()
        {
               InitializeComponent();
        }
        public UCSP(SanPham sp,NguoiMua ngmua)
        {
            this.sp = sp;
            this.ngmua = ngmua;
            InitializeComponent();
            this.lblMaSP.Text = sp.MaSP;
            this.lblTenSP.Text = sp.TenSP;
            this.lblGiaBan.Text =  sp.GiaBan ;
            this.lblGiaGoc.Text =  sp.GiaGoc ;
            this.lblDiaChi.Text = sp.DiaChi;
            this.picHinh.Image = Global.ByteArrayToImage(sp.Hinh);
            HienYeuThich();
        }
        private void UCSP_Click(object sender, EventArgs e)
        {
            //cập nhật tần suất truy cập vào sản phẩm của người mua
            TanSuatTruyCap();
            this.Hide(); //an form 1
            FCTSP formCTSP = new FCTSP(sp,picClick,ngmua);
            formCTSP.ShowDialog();
            formCTSP = null;
            this.Show();  
        }
        bool picClick;
        private void traitim()
        {
            //false la chua them
            if (picClick) //=true dang la tim do
            {
                Global.TimDen(picHeart);
                YeuThich yt = new YeuThich(sp.MaNguoiBan, ngmua.Ma, sp.MaSP);
                ytdao.XoaYeuThich(yt);
            }
            //ban dau la false nhan vao la true chuyen thanh mau do
            else
            {
                Global.TimDo(picHeart);
                YeuThich yt = new YeuThich(sp.MaNguoiBan, ngmua.Ma, sp.MaSP);
                ytdao.ThemYeuThich(yt);
            }
        }
        private void TanSuatTruyCap()
        {
            DataTable dt = spdao.LayNganhHangTheoMaSanPham(sp.MaSP);
            string nganhHang = "";
            foreach (DataRow row in dt.Rows)
            {
                nganhHang = row[0].ToString();
            }
            int tanSuat;
            DataTable dta = spdao.TanSuatTruyCap(ngmua.Ma,nganhHang);
            if (dta.Rows.Count > 0)
            {
                // Đọc hàng đầu tiên 
                tanSuat = Convert.ToInt32(dta.Rows[0][0]); // +1; //dta.Rows[0][0] là giá trị của cột đầu tiên của hàng đó.
            }
            else
            {
                tanSuat = 0;
            }
            if (tanSuat == 0)
            {
                spdao.ThemTanSuatTruyCapCuaSanPham(ngmua.Ma,tanSuat,nganhHang);
            }
            else //nếu đã có, cập nhật tuần suất lên 1
            {
                tanSuat += 1;
                spdao.CapNhatTanSuatTruyCap(ngmua.Ma, tanSuat, nganhHang);
            }
        }
        private void picHeart_Click(object sender, EventArgs e)
        {
            traitim();
        }
        private void HienYeuThich()
        {
            DataSet dtSet = ytdao.HienYeuThich();
            foreach (DataRow row in dtSet.Tables[0].Rows)
            {
                if (row[0].ToString().Trim() == sp.MaSP.Trim() && row[1].ToString().Trim() == ngmua.Ma.Trim())
                {
                    Global.TimDo(picHeart);
                    picClick = true;
                    break;
                }
                else
                {
                    Global.TimDen(picHeart);
                    picClick = false;
                }
            }
        }

        private void UCSP_Load(object sender, EventArgs e)
        {

        }
    }
}
