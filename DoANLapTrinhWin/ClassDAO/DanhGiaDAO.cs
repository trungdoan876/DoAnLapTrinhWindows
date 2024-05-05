using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoANLapTrinhWin.Class
{
    public class DanhGiaDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection tt = new DBConnection();
        //hiện đánh giá lên FCTSP
        public DataSet HienDanhGia(SanPham sp)
        {
            string sqlStr = string.Format("SELECT NguoiMua.Hinh, NguoiMua.Ten, NguoiMua.Ma, DanhGia.Nhanxet, DanhGia.Sao, DanhGia.NgayDanhGia, DanhGia.MaSanPham FROM NguoiMua, DanhGia " +
                    "WHERE NguoiMua.Ma = DanhGia.MaNguoiMua AND DanhGia.MaSanPham ='{0}'", sp.MaSP);
            DataSet dt = tt.Load(sqlStr);
            return dt;
        }
        public DataSet LayHinhAnhTheoMaSPvaMaNM(NguoiMua ng, DanhGia dg)
        {
            string sqlStr = "SELECT Hinh FROM HinhDanhGia WHERE MaSanPham = @id AND MaNguoiMua = @ngmua AND NgayDanhGia=@ngaydg";
            DataSet ds = tt.LoadHinh(sqlStr, new SqlParameter("@id", dg.MaSP), new SqlParameter("@ngmua", ng.Ma), new SqlParameter("@ngaydg", dg.Ngaydg));
            return ds;
        }
        //load thông tin để đánh giá trong FDanhGia
        public DataSet LoadThongTinSanPham(DonHang dh)
        {
            string sqlStr = string.Format("SELECT MaDonHang, SanPham.MaSanPham,SanPham.TenSanPham, ChiTietDonHang.SoLuong AS slmua, ChiTietDonHang.GiaTien AS gtien, SanPham.Hinh " +
                                "FROM ChiTietDonHang, SanPham " +
                                "WHERE SanPham.MaSanPham = ChiTietDonHang.MaSanPham AND ChiTietDonHang.MaDonHang = '{0}'", dh.MaDonHang);
            DataSet dt = new DataSet();
            dt = tt.Load(sqlStr);
            return dt;
        }
        public void ThemDanhGia(DanhGia dg)
        {
            string sql = string.Format("INSERT INTO DanhGia (MaSanPham, MaNguoiMua, Sao, SaoNguoiBan, SaoGiaoHang, NhanXet,NgayDanhGia) " +
                            "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', N'{5}','{6}')",
                            dg.MaSP, dg.MaNM, dg.Sao, dg.SaoNB, dg.SaoGiaoHang, dg.NhanXet, dg.Ngaydg);
            tt.ThucThi(sql);
        }
    }
}
