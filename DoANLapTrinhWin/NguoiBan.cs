using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoANLapTrinhWin
{
    public class NguoiBan
    {
        private string tenTaiKhoan;
        private string maNB;
        private string Ten;
        private string SDT;
        private DateTime NgaySinh;
        private string gioiTinh;
        private string CCCD;
        private string diaChi;
        private string moTaShop;
        private string eMail;
        public NguoiBan (string tenTaiKhoan, string maNB, string Ten,string SDT,DateTime NgaySinh,string gioiTinh, string CCCD, string diaChi,string moTaShop,string eMail) 
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.maNB = maNB;
            this.Ten = Ten;
            this.SDT = SDT;
            this.NgaySinh = NgaySinh;
            this.gioiTinh = gioiTinh;
            this.CCCD = CCCD;
            this.diaChi = diaChi;
            this.moTaShop  = moTaShop;
            this.eMail = eMail;
        }
    }
}
