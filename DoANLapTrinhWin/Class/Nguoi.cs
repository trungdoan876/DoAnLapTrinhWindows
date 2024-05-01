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
    public class Nguoi
    {
        byte[] hinh;
        private string ma;
        private string Ten;
        private string matKhau;
        private string sDT;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string cccd;
        private string diaChi;
        private string eMail;
        private string moTa;
        // dung cho nguoi mua
        public Nguoi(string ma)
        {
            this.ma = ma;
        }
        //dùng cho đăng nhập
        public Nguoi(string ma, string matkhau)
        {
            this.ma=ma;
            this.matKhau = matkhau;
        }
        //dung cho danh gia
        public Nguoi(byte[]hinh, string ten)
        {
            this.hinh = hinh;
            this.Ten=ten;
        }
        public Nguoi(byte[] hinh,string ma, string Ten, string SDT, DateTime ngaySinh, string gioiTinh, string CCCD, string diaChi, string eMail)
        {
            this.hinh = hinh;
            this.ma = ma;
            this.Ten = Ten;
            this.SDT = SDT;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.cccd = CCCD;
            this.diaChi = diaChi;
            this.eMail = eMail;
        }
        //dung cho nguoi ban
        public Nguoi(byte[] hinh, string ma, string Ten, string SDT, DateTime ngaySinh, string gioiTinh, string CCCD, string diaChi, string eMail,string moTa)
        {
            this.hinh= hinh;
            this.ma = ma;
            this.Ten = Ten;
            this.sDT = SDT;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.cccd = CCCD;
            this.diaChi = diaChi;
            this.eMail = eMail;
            this.moTa = moTa;
        }
        public string Ma { get => ma; set => ma = value; }
        public string Ten1 { get => Ten; set => Ten = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string CCCD { get => cccd; set => cccd = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string EMail { get => eMail; set => eMail = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public byte[] Hinh { get => hinh; set => hinh = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
    }
}
