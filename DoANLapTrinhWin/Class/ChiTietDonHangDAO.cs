using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoANLapTrinhWin.Class
{
    internal class ChiTietDonHangDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection tt = new DBConnection();
        public DataSet HienChiTietDonHang(ChiTietDonHang ctdh)
        {
            string sqlStr = string.Format("SELECT MaDonHang, SanPham.MaSanPham, SanPham.TenSanPham, ChiTietDonHang.SoLuong AS slmua, ChiTietDonHang.GiaTien AS gtien, SanPham.Hinh " +
                                "FROM ChiTietDonHang, SanPham " +
                                "WHERE SanPham.MaSanPham = ChiTietDonHang.MaSanPham AND ChiTietDonHang.MaDonHang = '{0}'", ctdh.MaDonHang);
            DataSet dt = new DataSet();
            dt = tt.Load(sqlStr);
            return dt;
        }
    }
}
