using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoANLapTrinhWin.Class
{
    public class ThongKe
    {
        private string maNB;
        private DateTime ngayBan;
        private int soLan;
        public ThongKe(string maNB, DateTime ngayBan, int soLan)
        {
            this.maNB = maNB;
            this.ngayBan = ngayBan;
            this.soLan = soLan;
        }
        public string MaNB { get => maNB; set => maNB = value; }
        public DateTime NgayBan { get => ngayBan; set => ngayBan = value; }
        public int SoLan { get => soLan; set => soLan = value; }
    }
}
