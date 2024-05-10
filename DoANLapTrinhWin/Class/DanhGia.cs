using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoANLapTrinhWin.Class
{
    public class DanhGia
    {
        private string maNM;
        private string maSP;
        private string sao;
        private string saoNB;
        private string saoGiaoHang;
        private string nhanXet;
        private DateTime ngaydg;
        private byte[] hinh;
        //FCTSP
        /*        public DanhGia(string nhanxet, string sao, DateTime ngaydg, string masp)
                {
                    this.nhanXet = nhanxet;
                    this.sao = sao;
                    this.ngaydg = ngaydg;
                    this.maSP = masp;
                }*/
         public DanhGia(DataRow row)
         {
                    this.nhanXet = row[3].ToString();
                    this.sao = row[4].ToString();
                    this.ngaydg = (DateTime)row[5];
                    this.maSP = row[6].ToString();
         }
        //FDanhGia
        public DanhGia(string maNM, string maSP, string sao, string saoNB, string saoGiaoHang, string nhanXet, DateTime ngaydg)
        {
            this.maNM = maNM;
            this.maSP = maSP;
            this.sao = sao;
            this.saoNB = saoNB;
            this.saoGiaoHang = saoGiaoHang;
            this.nhanXet = nhanXet;
            this.ngaydg = ngaydg;
        }
        public string MaNM { get => maNM; set => maNM = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public string Sao { get => sao; set => sao = value; }
        public string SaoNB { get => saoNB; set => saoNB = value; }
        public string SaoGiaoHang { get => saoGiaoHang; set => saoGiaoHang = value; }
        public string NhanXet { get => nhanXet; set => nhanXet = value; }
        public DateTime Ngaydg { get => ngaydg; set => ngaydg = value; }
    }
}
