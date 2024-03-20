using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoANLapTrinhWin
{
    public class NguoiMua
    {
        private string tenTaiKhoan;
        private string maNM;
        private string Ten;
        private string SDT;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string CCCD;
        private string diaChi;
        private string eMail;
        public NguoiMua (string tenTaiKhoan, string maNM,string Ten, string SDT,DateTime ngaySinh,string gioiTinh,string CCCD,string diaChi,string eMail)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.maNM = maNM;
            this.Ten = Ten;
            this.SDT = SDT;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.CCCD= CCCD;
            this.diaChi = diaChi;
            this.eMail = eMail;
        }

    }
}
