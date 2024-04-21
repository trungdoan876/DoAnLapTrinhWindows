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
        private string trangThaiDonHang;
        public DonHang(string MaDonHang, string TongTien, DateTime NgayDatHang, string TrangThaiDonHang)
        {
            this.maDonHang = MaDonHang;
            this.tongTien = TongTien;
            this.ngayDatHang = NgayDatHang;
            this.trangThaiDonHang = TrangThaiDonHang;
        }
        public DonHang(string MaDonHang, string MaNguoiBan, string MaNguoiMua, string TongTien, DateTime NgayDatHang, string TrangThaiDonHang)
        {
            this.maDonHang = MaDonHang;
            this.maNguoiBan = MaNguoiBan;
            this.maNguoiMua = MaNguoiMua;
            this.tongTien = TongTien;
            this.ngayDatHang = NgayDatHang;
            this.trangThaiDonHang = TrangThaiDonHang;
        }

        public string MaDonHang { get => maDonHang; set => maDonHang = value; }
        public string MaNguoiBan { get => maNguoiBan; set => maNguoiBan = value; }
        public string MaNguoiMua { get => maNguoiMua; set => maNguoiMua = value; }
        public string TongTien { get => tongTien; set => tongTien = value; }
        public DateTime NgayDatHang { get => ngayDatHang; set => ngayDatHang = value; }
        public string TrangThaiDonHang { get => trangThaiDonHang; set => trangThaiDonHang = value; }
    }
}
