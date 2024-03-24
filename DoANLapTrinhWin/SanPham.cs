using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoANLapTrinhWin
{
    public class SanPham
    {
        private string maSP;
        private string tenSP;
        private string giaBan;
        private string giaGoc;
        private string xuatXu;
	    private string thoiGianDaSuDung;
        private DateTime ngayDang;
        private string moTaSanPham;
        private string nganhHang;
        private string tinhTrang;
        private string maNguoiBan;
        private string diaChi;
        public SanPham(string maSP, string tenSP, string giaBan, string giaGoc, string xuatXu, string thoiGianDaSuDung,DateTime ngayDang, string moTaSanPham,
            string nganhHang, string tinhTrang, string maNguoiBan, string diaChi)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.giaBan = giaBan;
            this.giaGoc = giaGoc;
            this.xuatXu = xuatXu;
            this.thoiGianDaSuDung = thoiGianDaSuDung;
            this.ngayDang = ngayDang;
            this.moTaSanPham = moTaSanPham;
            this.nganhHang = nganhHang;
            this.tinhTrang = tinhTrang;
            this.maNguoiBan = maNguoiBan;
            this.diaChi = diaChi;

        }

        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string GiaBan { get => giaBan; set => giaBan = value; }
        public string GiaGoc { get => giaGoc; set => giaGoc = value; }
        public string XuatXu { get => xuatXu; set => xuatXu = value; }
        public string ThoiGianDaSuDung { get => thoiGianDaSuDung; set => thoiGianDaSuDung = value; }
        public DateTime NgayDang { get => ngayDang; set => ngayDang = value; }
        public string MoTaSanPham { get => moTaSanPham; set => moTaSanPham = value; }
        public string NganhHang { get => nganhHang; set => nganhHang = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string MaNguoiBan { get => maNguoiBan; set => maNguoiBan = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
