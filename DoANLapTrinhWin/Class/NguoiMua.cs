using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using System.Drawing;

namespace DoANLapTrinhWin
{
    public class NguoiMua: Nguoi
    {
        public NguoiMua(string ma,string mk): base(ma, mk)
        {

        }
        public NguoiMua (string sdt) :base(sdt)
        {

        }
        public NguoiMua(string ma, string mk, string ten, string sdt, DateTime ngaySinh, string gt, string cccd, string diachi, byte[] hinh)
            : base(ma, mk, ten, sdt, ngaySinh, gt, cccd, diachi, hinh)
        {

        }
        public NguoiMua (byte[] hinh,string ma,string Ten, string SDT,DateTime ngaySinh,string gioiTinh,string CCCD,string diaChi,string eMail) 
            : base (hinh,ma, Ten, SDT, ngaySinh, gioiTinh, CCCD, diaChi, eMail)
        {
        }
        public NguoiMua(byte[]hinh,string ten) : base(hinh,ten)
        { 
        }
    }
}
