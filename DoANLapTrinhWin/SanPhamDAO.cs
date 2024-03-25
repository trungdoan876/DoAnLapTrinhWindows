using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoANLapTrinhWin
{
    internal class SanPhamDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection tt = new DBConnection();
        public void ThemSanPham(SanPham sp)
        {
            string sqlStr = string.Format("INSERT INTO SanPham(MaSanPham, TenSanPham, GiaBan, GiaGoc, XuatXu, TGDSD, MoTaSanPham, NganhHang, TinhTrang,DiaChi,MaNguoiBan,NgayDang ) VALUES ('{0}', '{1}', '{2}','{3}', '{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}' )", sp.MaSP, sp.TenSP, sp.GiaBan, sp.GiaGoc, sp.XuatXu, sp.ThoiGianDaSuDung, sp.MoTaSanPham, sp.NganhHang, sp.TinhTrang,sp.DiaChi,sp.MaNguoiBan,sp.NgayDang);
            tt.ThucThi(sqlStr);
        }
        public void XoaSanPham(SanPham sp)
        {
            string sqlStr = string.Format("DELETE FROM SanPham WHERE MaSanPham = '{0}'", sp.MaSP);
            tt.ThucThi(sqlStr);
        }
        public void CapNhatSanPham(SanPham sp)
        {
            string sqlStr = string.Format("UPDATE SanPham SET TenSanPham = '{0}', GiaBan = '{1}', GiaGoc ='{2}', XuatXu = '{3}', TGDSD = '{4}',MoTaSanPham ='{5}', NganhHang ='{6}',TinhTrang ='{7}',DiaChi='{9}',NgayDang='{10}' WHERE MaSanPham = '{8}'", sp.TenSP, sp.GiaBan, sp.GiaGoc, sp.XuatXu, sp.ThoiGianDaSuDung, sp.MoTaSanPham, sp.NganhHang, sp.TinhTrang, sp.MaSP, sp.DiaChi, sp.NgayDang);
            tt.ThucThi(sqlStr);
        }
    }
}
