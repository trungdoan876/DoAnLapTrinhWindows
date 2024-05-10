using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoANLapTrinhWin.Class
{
    public class TanSuatTruyCap
    {
        private string maNM;
        private int tanSuat;
        private string nganhHang;
        public TanSuatTruyCap(string maNM, string nganhHang)
        {
            this.maNM = maNM;
            this.nganhHang = nganhHang;
        }
        public TanSuatTruyCap(string maNM,int tanSuat,string nganhHang)
        {
            this.maNM = maNM;
            this.tanSuat = tanSuat;
            this.nganhHang = nganhHang;
        }

        public string MaNM { get => maNM; set => maNM = value; }
        public int TanSuat { get => tanSuat; set => tanSuat = value; }
        public string NganhHang { get => nganhHang; set => nganhHang = value; }
    }
}
