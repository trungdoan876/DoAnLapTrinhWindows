using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoANLapTrinhWin
{
    internal class GioHang
    {
        private string maSP;
        private string tenSP;
        private string giaBan;
        private int soLuong;
	    private string maNB;
        private string maNM;
        //TrangThaiSP bit,
        private byte[] hinh;
        public GioHang(string maSP, string tenSP, string giaBan, int soLuong, string maNB, string maNM, byte[] hinh)
        {
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.GiaBan = giaBan;
            this.SoLuong = soLuong;
            this.MaNB = maNB;
            this.MaNM = maNM;
            this.Hinh = hinh;
        }

        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string GiaBan { get => giaBan; set => giaBan = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string MaNB { get => maNB; set => maNB = value; }
        public string MaNM { get => maNM; set => maNM = value; }
        public byte[] Hinh { get => hinh; set => hinh = value; }
    }
}
