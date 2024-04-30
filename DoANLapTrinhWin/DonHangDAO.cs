using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoANLapTrinhWin
{
    internal class DonHangDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection tt = new DBConnection();
        public void CapNhatGiaoHangNB(DonHang dh)
        {
            string sqlStr = string.Format("UPDATE DonHang SET TrangThaiDonHangNM = N'{0}', TrangThaiDonHangNB = N'{1}' WHERE MaDonHang ='{2}'",
                    "Đang giao hàng", "Đang giao hàng", dh.MaDonHang);
            tt.ThucThi(sqlStr);
        }
    }
}
