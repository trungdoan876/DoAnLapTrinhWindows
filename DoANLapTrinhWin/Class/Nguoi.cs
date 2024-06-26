﻿using System;
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
        private string moTa;
        //dùng cho đăng kí
        public Nguoi()
        {

        }
        public Nguoi(string sdt)
        {
            this.sDT = sdt;
        }
        //dùng cho đăng nhập
        public Nguoi(string ma, string matkhau)
        {
            this.ma = ma;
            this.matKhau = matkhau;
        }
        //dung cho danh gia,fctsp
        public Nguoi(byte[]hinh, string ten, string ma)
        {
            this.hinh = hinh;
            this.Ten = ten;
            this.ma = ma;
        }
        //dùng cho thông tin đăng kí
        public Nguoi(string ma, string mk,string ten, string sdt,  DateTime ngaySinh,string gt, string cccd, string diachi, byte[]hinh)
        {
            this.ma = ma;
            this.matKhau = mk;
            this.Ten = ten;
            this.sDT = sdt;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gt;
            this.cccd = cccd;
            this.diaChi = diachi;
            this.hinh=hinh;
        }
        public Nguoi(byte[] hinh,string ma, string Ten, string SDT, DateTime ngaySinh, string gioiTinh, string CCCD, string diaChi)
        {
            this.hinh = hinh;
            this.ma = ma;
            this.Ten = Ten;
            this.SDT = SDT;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.cccd = CCCD;
            this.diaChi = diaChi;
        }
        //dung cho nguoi ban
        public Nguoi(byte[] hinh, string ma, string Ten, string SDT, DateTime ngaySinh, string gioiTinh, string CCCD, string diaChi, string moTa)
        {
            this.hinh= hinh;
            this.ma = ma;
            this.Ten = Ten;
            this.sDT = SDT;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.cccd = CCCD;
            this.diaChi = diaChi;
            this.moTa = moTa;
        }
        public string Ma { get => ma; set => ma = value; }
        public string Ten1 { get => Ten; set => Ten = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string CCCD { get => cccd; set => cccd = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public byte[] Hinh { get => hinh; set => hinh = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
    }
}
