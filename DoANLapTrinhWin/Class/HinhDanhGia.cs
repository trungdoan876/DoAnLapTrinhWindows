using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoANLapTrinhWin.Class
{
    public class HinhDanhGia
    {
        private int id;
        private string maNguoiMua;
        private string maSanPham;
        private DateTime ngayDanhGia;
        private byte[] hinh;
        public HinhDanhGia(string maNguoiMua, string maSanPham, byte[] hinh, DateTime ngayDanhGia)
        {
            this.maNguoiMua = maNguoiMua;
            this.maSanPham = maSanPham;
            this.hinh = hinh;
            this.ngayDanhGia = ngayDanhGia;
        }

        public int Id { get => id; set => id = value; }
        public string MaNguoiMua { get => maNguoiMua; set => maNguoiMua = value; }
        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public DateTime NgayDanhGia { get => ngayDanhGia; set => ngayDanhGia = value; }
        public byte[] Hinh { get => hinh; set => hinh = value; }
    }
}
