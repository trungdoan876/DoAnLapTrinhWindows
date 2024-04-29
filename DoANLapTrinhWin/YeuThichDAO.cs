using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DoANLapTrinhWin
{
    public class YeuThichDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection tt = new DBConnection();
        public void XoaYeuThich(YeuThich yt)
        {
            string sqlStr = string.Format("DELETE FROM YeuThich WHERE MaSanPham ='{0}'", yt.MaSP);
            tt.ThucThi(sqlStr);
        }
        public void ThemYeuThich(YeuThich yt)
        {
            string sqlStr = string.Format("INSERT INTO YeuThich (MaSanPham , MaNguoiMua, MaNguoiBan) VALUES ('{0}', '{1}','{2}')"
                , yt.MaSP, yt.MaNM, yt.MaNB);
            tt.ThucThi(sqlStr);
        }
    }
}
