using DoANLapTrinhWin.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoANLapTrinhWin.ClassDAO
{
    public class HinhDanhGiaDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection tt = new DBConnection();
        public void ThemHinhDanhGia(HinhDanhGia hdg)
        {
            string anh = BitConverter.ToString(hdg.Hinh).Replace("-", "");
            string sql = string.Format("INSERT INTO HinhDanhGia (MaNguoiMua, MaSanPham, Hinh,NgayDanhGia) " +
                "VALUES ('{0}', '{1}', 0x{2},'{3}')", hdg.MaNguoiMua, hdg.MaSanPham, anh, hdg.NgayDanhGia);
            tt.ThucThi(sql);
        }
    }
}
