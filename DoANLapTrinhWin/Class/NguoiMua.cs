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
    public class NguoiMua: Nguoi
    {
        public NguoiMua (byte[] hinh,string ma,string Ten, string SDT,DateTime ngaySinh,string gioiTinh,string CCCD,string diaChi,string eMail) 
            : base (hinh,ma, Ten, SDT, ngaySinh, gioiTinh, CCCD, diaChi, eMail)
        {
        }
        public NguoiMua(byte[]hinh,string ten) : base(hinh,ten)
        { 
        }
    }
}
