using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DoANLapTrinhWin
{
    public class SanPham
    {
        private byte[] hinh;
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
        private string dangBan;
        private string maNguoiBan;
        private string diaChi;
        private string soLuong; //so luong co san

        public SanPham(string maSP) //để xóa sản phẩm 
        {
            this.maSP = maSP;
        }
        public SanPham(string tenSP, byte[] hinh) //khoi tao dung cho quan ly don hang
        {
            this.tenSP = tenSP;
            this.hinh = hinh;
        }
        public SanPham(string tenSP, byte[] hinh,string maSP) //khoi tao dung cho danh gia
        {
            this.tenSP = tenSP;
            this.hinh = hinh;
            this.maSP = maSP;
        }
        public SanPham(string maSP,string tenSP, string giaTien, string soLuong, byte[]hinh)//danh gia
        {
            this.maSP= maSP;
            this.tenSP= tenSP;
            this.giaBan = giaTien;
            this.soLuong = soLuong;
            this.hinh = hinh;
        }
        public SanPham(string maNB, string maSP, string tenSP, string giaBan, byte[] hinh, string soLuong) // dung cho dat hang
        {
            this.maNguoiBan = maNB;
            this.MaSP = maSP;
            this.tenSP = tenSP;
            this.giaBan = giaBan;
            this.hinh = hinh;
            this.soLuong = soLuong;
        }

        public SanPham(string tenSP, string giaBan, string giaGoc, string tinhTrang, string maSP, string soLuong, byte[] hinh, string diaChi) //khoi tao dung cho FGioHang
        {
            this.tenSP = tenSP;
            this.giaBan = giaBan;
            this.giaGoc = giaGoc;
            this.tinhTrang = tinhTrang;
            this.maSP = maSP;
            this.soLuong = soLuong;
            this.hinh = hinh;
            this.diaChi = diaChi;
        }
        public SanPham(string maSP, string tenSP, string giaBan, string giaGoc, string xuatXu, string thoiGianDaSuDung, DateTime ngayDang, string moTaSanPham,
            string nganhHang, string tinhTrang, string diaChi, string maNguoiBan, string soLuong, byte[] hinh) //data row
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
            this.hinh = hinh;
        }
        public SanPham(DataRow r) //data row
        {
            this.hinh = (byte[])r[0];
            this.maSP = r[1].ToString();
            this.tenSP = r[2].ToString();
            this.giaBan = r[3].ToString();
            this.giaGoc = r[4].ToString();
            this.xuatXu = r[5].ToString();
            this.thoiGianDaSuDung = r[6].ToString();
            this.ngayDang = (DateTime)r[7];
            this.moTaSanPham = r[8].ToString();
            this.nganhHang = r[9].ToString();
            this.tinhTrang = r[10].ToString();
            this.dangBan = r[11].ToString();
            this.maNguoiBan = r[12].ToString();
            this.diaChi = r[13].ToString();
            this.soLuong = r[14].ToString();
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
        public byte[] Hinh { get => hinh; set => hinh = value; }
        public string DangBan { get => dangBan; set => dangBan = value; }
    }
}
