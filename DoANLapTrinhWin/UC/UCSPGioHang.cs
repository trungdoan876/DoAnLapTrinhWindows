using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace DoANLapTrinhWin
{
    public partial class UCSPGioHang : UserControl
    {
        SanPham sp;
        string slmua ;
        string check;
        NguoiMua ngmua;
        GioHangDAO ghDAO = new GioHangDAO();
        public UCSPGioHang(SanPham sanpham,NguoiMua ngmua,string check)
        {
            InitializeComponent();
            this.sp = sanpham;
            this.ngmua = ngmua;
            this.check = check;
            this.lblTenSP.Text = sp.TenSP;
            this.lblGiaTien.Text = "đ" + sp.GiaBan;
            this.lblTinhTrang.Text = sp.TinhTrang;
            this.lblSoLuong.Text = sp.SoLuong+" sản phẩm sẵn có";
            this.lblgia.Text = "đ" + sp.GiaGoc;
            this.lblDiaChi.Text = sp.DiaChi;
            this.vongtrontt.Value = TinhTinhTrang();
            this.picHinh.Image = Global.ByteArrayToImage(sp.Hinh);
            loadtinhtrang();
        }
        public int TinhTinhTrang()
        {
            string str = sp.TinhTrang.Substring(0, sp.TinhTrang.Length - 1); //xoa chu %
            int tt = int.Parse(str);
            return tt;
        }
        private void loadtinhtrang()
        {
            if (check == "False") //tick vao checkbox
            {
                GioHang gh = new GioHang(sp.MaSP);
                ghDAO.CapNhatChonSanPham(gh);
            }
            else //=true -> đã chọn
            {
                GioHang gh = new GioHang(sp.MaSP);
                ghDAO.CapNhatKhongchon(gh);
            }
        }
        private void checkBoxSP_CheckedChanged(object sender, EventArgs e)
        {
            loadtinhtrang();
        }
        private void soluongmuaGH_ValueChanged(object sender, EventArgs e)
        {
            soluongmuaGH.Minimum = 1;
            soluongmuaGH.Maximum = int.Parse(sp.SoLuong);
            slmua = soluongmuaGH.Value.ToString();
            SanPham spham = new SanPham(sp.MaSP);
            ghDAO.CapNhatSoLuong(spham,slmua);
        }

        private void btnXoaKhoiGioHang_Click_1(object sender, EventArgs e)
        {
            GioHang gh = new GioHang(sp.MaSP);
            ghDAO.XoaGioHang(gh);
            MessageBox.Show("Đã xóa sản phẩm khỏi giỏ hàng! TT ");
        }
    }
}
