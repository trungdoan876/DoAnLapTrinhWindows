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
        private string soLuong; //so luong co san
	    private string thoiGianDaSuDung;
        private DateTime ngayDang;
        private string moTaSanPham;
        private string nganhHang;
        private string tinhTrang;
        private string maNguoiBan;
        private string diaChi;
        public SanPham(string tenSP, string giaBan, string tinhTrang,string maSP,string soLuong) //khoi tao dung cho FGioHang
        {
            this.tenSP = tenSP;
            this.giaBan = giaBan;
            this.tinhTrang = tinhTrang;
            this.maSP = maSP;
            this.soLuong = soLuong;
        }
        public SanPham(string tenSP, string giaBan,string giaGoc,string diaChi) //khoi tao dung  cho FYeuThich
        {
            this.tenSP = tenSP;
            this.giaBan = giaBan;
            this.diaChi = diaChi;
            this.giaGoc = giaGoc;
        }
        public SanPham(string maSP, string tenSP, string giaBan, string giaGoc, string xuatXu, string thoiGianDaSuDung,DateTime ngayDang, string moTaSanPham,
            string nganhHang, string tinhTrang, string diaChi, string maNguoiBan, string soLuong)
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
            this.diaChi = diaChi;
            this.maNguoiBan = maNguoiBan;
            this.soLuong = soLuong;
        }
        public string SoLuong { get => soLuong; set => soLuong = value; }
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
