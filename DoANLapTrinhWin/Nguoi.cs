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
    class Nguoi
    {
        private string tenTaiKhoan;
        private string ma;
        private string Ten;
        private string SDT;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string CCCD;
        private string diaChi;
        private string eMail;
        public Nguoi(string tenTaiKhoan, string ma, string Ten, string SDT, DateTime ngaySinh, string gioiTinh, string CCCD, string diaChi, string eMail)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.ma = ma;
            this.Ten = Ten;
            this.SDT = SDT;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.CCCD = CCCD;
            this.diaChi = diaChi;
            this.eMail = eMail;
        }
    }
}
