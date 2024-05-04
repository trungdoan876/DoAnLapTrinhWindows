﻿using System;
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
            string sqlStr = "SELECT Hinh FROM HinhDanhGia WHERE MaSanPham = @id AND MaNguoiMua = @ngmua AND NgayDanhGia=@ngaydg" ;
            DataSet ds = tt.LoadHinh(sqlStr, new SqlParameter("@id", dg.MaSP),new SqlParameter("@ngmua", ng.Ma), new SqlParameter("@ngaydg", dg.Ngaydg));
            return ds;
        }
    }
}
