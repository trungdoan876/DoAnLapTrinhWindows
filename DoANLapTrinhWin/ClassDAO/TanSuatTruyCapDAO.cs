using DoANLapTrinhWin.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoANLapTrinhWin.ClassDAO
{
    public class TanSuatTruyCapDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection tt = new DBConnection();
        public DataTable TanSuatTruyCap(TanSuatTruyCap ts)
        {
            string sql1 = string.Format("Select TanSuatTruyCap From TanSuatTruyCap where NganhHang = N'{0}' and MaNguoiMua = '{1}' ", ts.NganhHang, ts.MaNM);
            DataTable dt = new DataTable();
            dt = tt.DocDuLieu(sql1);
            return dt;
        }
        public void ThemTanSuatTruyCapCuaSanPham(TanSuatTruyCap ts)
        {
            string sqlStr = string.Format("INSERT INTO TanSuatTruyCap (MaNguoiMua,TanSuatTruyCap,NganhHang) VALUES ('{0}','{1}',N'{2}')", ts.MaNM, 1, ts.NganhHang);
            tt.ThucThiKhong(sqlStr);
        }
        public void CapNhatTanSuatTruyCap(TanSuatTruyCap ts)
        {
            string sqlStr = string.Format("UPDATE TanSuatTruyCap SET TanSuatTruyCap = '{0}' WHERE MaNguoiMua = '{1}' and NganhHang = N'{2}' ", ts.TanSuat+1, ts.MaNM, ts.NganhHang);
            tt.ThucThiKhong(sqlStr);
        }
    }
}
