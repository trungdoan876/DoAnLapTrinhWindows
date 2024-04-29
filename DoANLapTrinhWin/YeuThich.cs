using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoANLapTrinhWin
{
    public class YeuThich
    {
        private string maNB;
        private string maNM;
        private string maSP;
        public YeuThich(string maNB, string maNM, string maSP)
        {
            this.maNB = maNB;
            this.maNM = maNM;
            this.maSP = maSP;
        }

        public string MaNB { get => maNB; set => maNB = value; }
        public string MaNM { get => maNM; set => maNM = value; }
        public string MaSP { get => maSP; set => maSP = value; }
    }
}
