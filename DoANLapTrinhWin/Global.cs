using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoANLapTrinhWin
{
    public class Global
    {
        int ma=0;
        public string TaoMaDonHangTuDong()
        {
            ma++;
            return "DH" + ma.ToString();
        }
    }
}
