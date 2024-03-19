using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoANLapTrinhWin
{
    public class SanPham
    {
        public string ma;
        public string ten;
        public int giaBan;
        public string nganhHang;
        public string tinhTrang;

        public SanPham(string ma, string ten, int giaBan, string nganhHang, string tinhTrang)
        {
            this.ma = ma;
            this.ten = ten;
            this.giaBan = giaBan;
            this.nganhHang = nganhHang;
            this.tinhTrang = tinhTrang;
        }

    }
}
