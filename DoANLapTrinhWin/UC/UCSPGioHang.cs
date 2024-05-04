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
    public partial class UCSPGioHang : UserControl
    {
        SanPham sp;
        string slmua ;
        GioHangDAO ghDAO = new GioHangDAO();
        public UCSPGioHang(SanPham sanpham)
        {
            InitializeComponent();
            this.sp = sanpham;
            this.lblTenSP.Text = sp.TenSP;
            this.lblGiaTien.Text = "đ" + sp.GiaBan;
            this.lblTinhTrang.Text = sp.TinhTrang;
            this.lblSoLuong.Text = sp.SoLuong+" sản phẩm sẵn có";
            this.lblgia.Text = "đ" + sp.GiaGoc;
            this.lblDiaChi.Text = sp.DiaChi;
            this.vongtrontt.Value = TinhTinhTrang();
            this.picHinh.Image = Global.ByteArrayToImage(sp.Hinh);
        }
        public int TinhTinhTrang()
        {
            string str = sp.TinhTrang.Substring(0, sp.TinhTrang.Length - 1); //xoa chu %
            int tt = int.Parse(str);
            return tt;
        }
        bool check = false;
        private void checkBoxSP_CheckedChanged(object sender, EventArgs e)
        {
            if (check == false) //tick vao checkbox
            {
                check = true;
                GioHang gh = new GioHang(sp.MaSP);
                ghDAO.CapNhatChonSanPham(gh);
            }
            else //nhấn vào checkbox 1 lần nữa
            {
                check = false;
                GioHang gh = new GioHang(sp.MaSP);
                ghDAO.CapNhatKhongchon(gh);
            }
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
        }
    }
}
