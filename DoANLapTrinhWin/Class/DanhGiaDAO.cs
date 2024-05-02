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
            string sqlStr = string.Format("SELECT NguoiMua.Hinh, NguoiMua.Ten, NguoiMua.Ma, DanhGia.nhanxet, DanhGia.sao, DanhGia.ngaydg FROM NguoiMua, DanhGia " +
                    "WHERE NguoiMua.Ma = DanhGia.MaNguoiMua AND DanhGia.MaSanPham ='{0}'", sp.MaSP);
            DataSet dt = new DataSet();
            dt = tt.Load(sqlStr);
            return dt;
        }
        public DataSet LayHinhAnhTheoMaSPvaMaNM(string masp,string manm, string Ngaydg)
        {
            string sqlStr = "SELECT Hinh FROM HinhDanhGia WHERE MaSanPham = @id AND MaNguoiMua = @ngmua AND Ngaydg = @ngaydg" ;
            DataSet ds = new DataSet();
            ds = tt.LoadHinh(sqlStr, new SqlParameter("@id", masp),new SqlParameter("@ngmua", manm),new SqlParameter("@ngaydg",Ngaydg));
            return ds;
        }
    }
}
