using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoANLapTrinhWin.Class
{
    public class ChiTietDonHang
    {
        private string maDonHang;
        private string maSP;
        private string tenSP;
        private string soLuong; //so luong mà người mua mua
        private string giaTien; //gia tien 1 san pham
        private byte[] hinh;
        public ChiTietDonHang(string maDonHang)
        {
            this.maDonHang = maDonHang;
        }
        public ChiTietDonHang(DataRow r)
        {
            this.MaDonHang = r[0].ToString();
            this.tenSP = r[2].ToString();
            this.SoLuong = r[3].ToString();
            this.GiaTien = r[4].ToString();
            this.hinh = (byte[])r[5];
        }
        public ChiTietDonHang(string maDonHang, string maSP, string soLuong, string giaTien, string tenSP, byte[] hinh)
        {
            this.MaDonHang = maDonHang;
            this.MaSP = maSP;
            this.SoLuong = soLuong;
            this.GiaTien = giaTien;
            this.tenSP = tenSP;
            this.hinh = hinh;
        }
        public string MaDonHang { get => maDonHang; set => maDonHang = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public string SoLuong { get => soLuong; set => soLuong = value; }
        public string GiaTien { get => giaTien; set => giaTien = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public byte[] Hinh { get => hinh; set => hinh = value; }
    }
}
