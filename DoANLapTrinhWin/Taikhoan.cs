using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoANLapTrinhWin
{ 
    internal class Taikhoan
    {
        private string Tentaikhoan;
        private string Matkhau;
        public Taikhoan(string Tentaikhoan, string Matkhau)
        {
            this.Tentaikhoan = Tentaikhoan;
            this.Matkhau = Matkhau;

        }

        public string Tentaikhoan1 { get => Tentaikhoan; set => Tentaikhoan = value; }
        public string Matkhau1 { get => Matkhau; set => Matkhau = value; }
    }
}
