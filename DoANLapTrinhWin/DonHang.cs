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

        public string MaDonHang { get => MaDonHang; set => MaDonHang = value; }
        public string MaNguoiBan { get => MaNguoiBan; set => MaNguoiBan = value; }
        public string MaNguoiMua { get => MaNguoiMua; set => MaNguoiMua = value; }
        public string TongTien { get => TongTien; set => TongTien = value; }
        public DateTime NgayDatHang { get => NgayDatHang; set => NgayDatHang = value; }
        public string TrangThaiDonHang { get => TrangThaiDonHang; set => TrangThaiDonHang = value; }
    }
}
}
