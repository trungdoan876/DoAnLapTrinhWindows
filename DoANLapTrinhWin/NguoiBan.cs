
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoANLapTrinhWin
{
     class NguoiBan : Nguoi
    {
        private string moTaShop;
        public NguoiBan(byte[]hinh,string ma, string Ten, string SDT, DateTime NgaySinh, string gioiTinh, string CCCD, string diaChi, string eMail, string moTaShop)
                : base(hinh,ma, Ten, SDT, NgaySinh, gioiTinh, CCCD, diaChi, eMail,moTaShop)
        {
                // Thuộc tính không được kế thừa từ lớp Nguoi
                this.moTaShop = moTaShop;
        }
    }

}
