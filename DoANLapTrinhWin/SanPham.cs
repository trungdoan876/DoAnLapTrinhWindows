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
        private int giaBan;
        private int giaGoc;
        private string xuatXu;
	    private string thoiGianDaSuDung;
        private DateTime ngayDang;
        private string moTaSanPham;
        private string nganhHang;
        private string tinhTrang;
        private string maNguoiBan;

        public SanPham(string maSP, string tenSP, int giaBan, int giaGoc, string xuatXu, string thoiGianDaSuDung,DateTime ngayDang, string moTaSanPham,
            string nganhHang, string tinhTrang, string maNguoiBan)
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
        }

        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
        public int GiaGoc { get => giaGoc; set => giaGoc = value; }
        public string XuatXu { get => xuatXu; set => xuatXu = value; }
        public string ThoiGianDaSuDung { get => thoiGianDaSuDung; set => thoiGianDaSuDung = value; }
        public DateTime NgayDang { get => ngayDang; set => ngayDang = value; }
        public string MoTaSanPham { get => moTaSanPham; set => moTaSanPham = value; }
        public string NganhHang { get => nganhHang; set => nganhHang = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string MaNguoiBan { get => maNguoiBan; set => maNguoiBan = value; }
    }
}
