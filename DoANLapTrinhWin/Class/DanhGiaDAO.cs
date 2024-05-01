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
        //hiện đánh giá lên FCTSP
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection tt = new DBConnection();
        public DataSet HienDanhGia(SanPham sp)
        {
            string sqlStr = string.Format("SELECT NguoiMua.Hinh, NguoiMua.Ten, DanhGia.nhanxet, DanhGia.sao FROM NguoiMua, DanhGia " +
                    "WHERE NguoiMua.Ma = DanhGia.MaNguoiMua AND DanhGia.MaSanPham ='{0}'", sp.MaSP);
            DataSet dt = new DataSet();
            dt = tt.Load(sqlStr);
            return dt;
        }
    }
}
