using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;

namespace DoANLapTrinhWin
{
    class NguoiMua: Nguoi
    {
        public NguoiMua (string tenTaiKhoan, string ma,string Ten, string SDT,DateTime ngaySinh,string gioiTinh,string CCCD,string diaChi,string eMail) 
            : base (tenTaiKhoan, ma, Ten, SDT, ngaySinh, gioiTinh, CCCD, diaChi, eMail)
        {
        }
    }
}
