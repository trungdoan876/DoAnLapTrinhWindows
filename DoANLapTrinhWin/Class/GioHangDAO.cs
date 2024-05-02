using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoANLapTrinhWin
{
    internal class GioHangDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection tt = new DBConnection();
        public void ThemVaoGioHang(GioHang gh)
        {
            string anh = BitConverter.ToString(gh.Hinh).Replace("-", "");
            string sqlStr = string.Format("INSERT INTO GioHang(MaNguoiBan, MaNguoiMua, MaSanPham, " +
                "TenSanPham, SoLuong, GiaBan,Hinh,TrangThaiSP) VALUES ('{0}', N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',0x{6},'{7}')",
                gh.MaNB, gh.MaNM, gh.MaSP, gh.TenSP, gh.SoLuong, gh.GiaBan, anh, 1);
            tt.ThucThi(sqlStr);
        }
        public void CapNhatChonSanPham(GioHang gh)
        {
            string sqlStr = string.Format("UPDATE GioHang SET TrangThaiSP = '{0}' WHERE MaSanPham = '{1}'", 1, gh.MaSP);
            tt.ThucThiKhong(sqlStr);
        }
        public void CapNhatKhongchon(GioHang gh)
        {
            string sqlStr = string.Format("UPDATE GioHang SET TrangThaiSP = '{0}' WHERE MaSanPham = '{1}'", 0, gh.MaSP);
            tt.ThucThiKhong(sqlStr);
        }
        public void XoaGioHang(GioHang gh)
        {
            string sqlStr = string.Format("DELETE FROM GioHang WHERE MaSanPham = '{0}'", gh.MaSP);
            tt.ThucThi(sqlStr);
        }
        public DataSet HienGioHang(string maNM)
        {
            string sqlStr = string.Format("SELECT SanPham.MaNguoiBan as maNB,SanPham.Hinh,SanPham.MaSanPham as MaSP, " +
                    "SanPham.TenSanPham as TenSP, SanPham.GiaBan as GiaBan, SanPham.TinhTrang as TinhTrang, SanPham.GiaGoc as GiaGoc, SanPham.DiaChi as DiaChi, SanPham.SoLuong as SL, GioHang.SoLuong as SLMua, GioHang.TrangThaiSP as TrangThai FROM GioHang, " +
                    "SanPham WHERE GioHang.MaSanPham = SanPham.MaSanPham and MaNguoiMua = '{0}'", maNM);
            DataSet dt = new DataSet();
            dt = tt.Load(sqlStr);
            return dt;
        }
        //ucspgiohang
        public void CapNhatSoLuong(SanPham sp, string slmua)
        {
            string sqlStr = string.Format("UPDATE GioHang SET SoLuong = '{0}' WHERE MaSanPham = '{1}'", slmua, sp.MaSP);
            tt.ThucThiKhong(sqlStr);
        }
        public DataSet LoadDatHang(string maNM)
        {
            string sqlStr = string.Format("SELECT * From GioHang WHERE TrangThaiSP = '{0}' " +
                    "and MaNguoiMua ='{1}'", 1, maNM);
            DataSet dt = new DataSet();
            dt = tt.Load(sqlStr);
            return dt;
        }
        public DataSet LoadThongTinNguoiMuaTrongGioHang(string maNM)
        {
            string sqlStr = string.Format("Select GioHang.MaNguoiMua, GioHang.MaSanPham, NguoiMua.Ten as ten, NguoiMua.DiaChi as diachi " +
                    "FROM GioHang, NguoiMua WHERE GioHang.MaNguoiMua = NguoiMua.Ma AND NguoiMua.Ma = '{0}'", maNM);
            DataSet dt = new DataSet();
            dt = tt.Load(sqlStr);
            return dt;
        }
    }
}
