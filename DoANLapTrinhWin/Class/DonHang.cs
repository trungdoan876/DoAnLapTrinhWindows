using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoANLapTrinhWin
{
    public class DonHang
    {
        private string maDonHang;
        private string maNguoiBan;
        private string maNguoiMua;
        private string tongTien;
        private DateTime ngayDatHang;
        private string trangThaiDonHangNM;
        private string trangThaiDonHangNB;
        public DonHang(string MaDonHang)
        {
            this.maDonHang = MaDonHang;
        }
        public DonHang(string MaDonHang, string TongTien, DateTime NgayDatHang, string TrangThaiDonHang)
        {
            this.maDonHang = MaDonHang;
            this.tongTien = TongTien;
            this.ngayDatHang = NgayDatHang;
            this.trangThaiDonHangNM = TrangThaiDonHang;
        }
        public DonHang(string MaDonHang, string TongTien, DateTime NgayDatHang, string TrangThaiDonHang, string MaNguoiMua)// khoi tao cho danh gia
        {
            this.maDonHang = MaDonHang;
            this.tongTien = TongTien;
            this.ngayDatHang = NgayDatHang;
            this.trangThaiDonHangNM = TrangThaiDonHang;
            this.maNguoiMua = MaNguoiMua;
        }
        public DonHang(string MaDonHang, string MaNguoiBan, string MaNguoiMua, string TongTien, DateTime NgayDatHang, string TrangThaiDonHang)
        {
            this.maDonHang = MaDonHang;
            this.maNguoiBan = MaNguoiBan;
            this.maNguoiMua = MaNguoiMua;
            this.tongTien = TongTien;
            this.ngayDatHang = NgayDatHang;
            this.trangThaiDonHangNM = TrangThaiDonHang;
        }

        public string MaDonHang { get => maDonHang; set => maDonHang = value; }
        public string MaNguoiBan { get => maNguoiBan; set => maNguoiBan = value; }
        public string MaNguoiMua { get => maNguoiMua; set => maNguoiMua = value; }
        public string TongTien { get => tongTien; set => tongTien = value; }
        public DateTime NgayDatHang { get => ngayDatHang; set => ngayDatHang = value; }
        public string TrangThaiDonHangNM { get => trangThaiDonHangNM; set => trangThaiDonHangNM = value; }
        public string TrangThaiDonHangNB { get => trangThaiDonHangNB; set => trangThaiDonHangNB = value; }
    }
}
