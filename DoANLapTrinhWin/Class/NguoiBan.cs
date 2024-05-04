
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DoANLapTrinhWin
{
     public class NguoiBan : Nguoi
     {
        private string moTaShop;
        //dùng để đăng kí
        public NguoiBan(string ma, string matkhau) : base(ma, matkhau)
        {

        }
        public NguoiBan (string sdt) : base(sdt)
        {

        }
        public NguoiBan(string ma, string mk, string ten, string sdt, DateTime ngaySinh, string gt, string cccd, string diachi, byte[] hinh)
            : base(ma, mk, ten, sdt, ngaySinh, gt, cccd, diachi ,hinh)
        {
            
        }
        public NguoiBan(byte[]hinh,string ma, string Ten, string SDT, DateTime NgaySinh, string gioiTinh, string CCCD, string diaChi,  string moTaShop)
                : base(hinh,ma, Ten, SDT, NgaySinh, gioiTinh, CCCD, diaChi, moTaShop)
        {
                // Thuộc tính không được kế thừa từ lớp Nguoi
                this.moTaShop = moTaShop;
        }
     }
}
