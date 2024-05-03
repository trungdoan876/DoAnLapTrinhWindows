using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoANLapTrinhWin.Class
{
    public class DanhGia
    {
        private string maNM;
        private string maSP;
        private int Sao;
        private int saoNB;
        private int saoGiaoHang;
        private string nhanXet;
        private DateTime ngaydg;
        public DanhGia(string nhanxet, int sao, DateTime ngaydg, string masp)
        {
            this.nhanXet = nhanxet;
            this.Sao = sao;
            this.ngaydg = ngaydg;
            this.maSP = masp;
        }

        public string MaNM { get => maNM; set => maNM = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public int Sao1 { get => Sao; set => Sao = value; }
        public int SaoNB { get => saoNB; set => saoNB = value; }
        public int SaoGiaoHang { get => saoGiaoHang; set => saoGiaoHang = value; }
        public string NhanXet { get => nhanXet; set => nhanXet = value; }
        public DateTime Ngaydg { get => ngaydg; set => ngaydg = value; }
    }
}
