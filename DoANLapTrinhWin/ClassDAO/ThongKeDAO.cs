using DoANLapTrinhWin.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoANLapTrinhWin.ClassDAO
{
    public class ThongKeDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection tt = new DBConnection();
        public DataTable LaySoLanBanRaTheoNgay(string maNB)
        {
            string sql1 = string.Format("select SoLanBan from ThongKeSP where MaNguoiBan = '{0}'", maNB);
            DataTable dt = new DataTable();
            dt = tt.DocDuLieu(sql1);
            return dt;
        }
        public void ThemSoLanBan(ThongKe tk)
        {
            string sqlStr = string.Format("INSERT INTO ThongKeSP (MaNguoiBan,NgayDatHang,SoLanBan) VALUES ('{0}','{1}','{2}')", tk.MaNB, tk.NgayBan, tk.SoLan);
            tt.ThucThiKhong(sqlStr);
        }
        public void CapNhatSoLanBan(ThongKe tk)
        {
            string sqlStr = string.Format("UPDATE ThongKeSP SET SoLanBan = '{0}' WHERE MaNguoiBan = '{1}' ", tk.SoLan, tk.MaNB);
            tt.ThucThiKhong(sqlStr);
        }
        //thống kê theo tháng, 1 năm có 12 tháng
        //khi insert vào, so sánh ngày đặt hàng trong csdl với ngày hiện tại, nếu tháng/năm hiện tại có trong csdl -> thêm vào solan
        //nếu chưa có, add tháng đó vào cơ sở dữ liệu
        public int KiemTraNgay(DateTime ngayhientai)
        {
            string sql = string.Format("SELECT COUNT(*) FROM ThongKeSP WHERE MONTH(NgayDatHang) = '{0}' AND YEAR(NgayDatHang) = '{1}'", ngayhientai.Month, ngayhientai.Year);
            int k = tt.KetQuaDuyNhat(sql);
            return k;
        }
        //hiện lên form thống kê ->FThongKe
        public DataSet LayThongKe()
        {
            string sql = string.Format("SELECT MONTH(NgayDatHang) AS ThangTrongNam, SoLanBan FROM ThongKeSP WHERE YEAR(NgayDatHang) = 2024 ORDER BY ThangTrongNam");
            DataSet dt = new DataSet();
            dt = tt.Load(sql);
            return dt;
        }
        public DataTable SoLuotMua(string maSP)
        {
            string sql1 = string.Format("select LuotMua from LuotMuaSanPham where MaSanPham = '{0}'", maSP);
            DataTable dt = new DataTable();
            dt = tt.DocDuLieu(sql1);
            return dt;
        }
        public void ThemLuotMua(string maSP,string maNB,int luotMua)
        {
            string sqlStr = string.Format("INSERT INTO LuotMuaSanPham (MaSanPham, MaNguoiBan, LuotMua) " +
                "VALUES ('{0}','{1}','{2}')", maSP, maNB, luotMua);
            tt.ThucThiKhong(sqlStr);
        }
        public void CapNhatLuotMua(string maSP, int luotMua)
        {
            string sqlStr = string.Format("UPDATE LuotMuaSanPham SET LuotMua = '{0}' WHERE MaSanPham = '{1}' ", luotMua,maSP);
            tt.ThucThiKhong(sqlStr);
        }
        public DataSet LayBestSeller()
        {
            string sql = string.Format("select top 5  LuotMuaSanPham.MaSanPham, SanPham.MaNguoiBan, LuotMua, SanPham.TenSanPham " +
                "from LuotMuaSanPham,SanPham where LuotMuaSanPham.MaSanPham = SanPham.MaSanPham order by LuotMua desc");
            DataSet dt = new DataSet();
            dt = tt.Load(sql);
            return dt;
        }
        public int TatCaSP(NguoiBan ng)
        {
            string sql = string.Format("Select count(*) from SanPham Where MaNguoiBan ='{0}'", ng.Ma);
            return tt.KetQuaDuyNhat(sql);
        }
        public int SPDaDangBan(NguoiBan ng)
        {
            string sql = string.Format("Select count(*) from SanPham Where MaNguoiBan ='{0}' AND DangBan = '{1}'", ng.Ma, 1);
            return tt.KetQuaDuyNhat(sql);
        }
        public int SPChuaDB(NguoiBan ng)
        {
            string sql = string.Format("Select count(*) from SanPham Where MaNguoiBan ='{0}' AND DangBan = '{1}'", ng.Ma, 0);
            return tt.KetQuaDuyNhat(sql);
        }
    }
}
