﻿using System;
using System.Collections.Generic;
using System.Data;
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
        public void CapNhatNhanHang(DonHang dh)
        {
            string sqlStr = string.Format("UPDATE DonHang SET TrangThaiDonHangNM = N'{0}', TrangThaiDonHangNB = N'{1}' WHERE MaDonHang ='{2}'",
                    "Giao hàng thành công", "Giao hàng thành công", dh.MaDonHang);
            tt.ThucThi(sqlStr);
        }
        public DataSet CapNhatGHThanhCongNB(string maNB)
        {
            string sqlStr = string.Format("select DonHang.MaDonHang as MaDonHang, TongTien as TongTien, NgayDatHang as NgDat," +
                        "TrangThaiDonHangNB as TrangThaiDonHang, SanPham.TenSanPham as TenSP, SanPham.Hinh as Hinh " +
                        "FROM DonHang, (SELECT MaDonHang, MIN(MaSanPham) AS MaSanPham FROM ChiTietDonHang GROUP BY MaDonHang) Q, SanPham " +
                        "WHERE DonHang.MaNguoiBan = '{0}' AND DonHang.MaDonHang = Q.MaDonHang AND SanPham.MaSanPham = Q.MaSanPham AND TrangThaiDonHangNB='{1}'",
                       maNB, "Giao hàng thành công");
            DataSet dt = new DataSet();
            dt = tt.Load(sqlStr);
            return dt;
        }
        public DataSet DangThucHienNB(string maNB)
        {
            string sqlStr = string.Format("Select DonHang.MaDonHang as MaDonHang, TongTien as TongTien, NgayDatHang as NgDat," +
                    "TrangThaiDonHangNB as TrangThaiDonHangNB, SanPham.TenSanPham as TenSP, SanPham.Hinh as Hinh " +
                    "FROM DonHang, (SELECT MaDonHang, MIN(MaSanPham) AS MaSanPham FROM ChiTietDonHang GROUP BY MaDonHang) Q, SanPham " +
                    " WHERE DonHang.MaNguoiBan = '{0}' AND DonHang.MaDonHang = Q.MaDonHang AND SanPham.MaSanPham = Q.MaSanPham" +
                    " AND DonHang.TrangThaiDonHangNB = N'{1}'", maNB, "Chuẩn bị hàng");
            DataSet dt = new DataSet();
            dt = tt.Load(sqlStr);
            return dt;
        }
        public DataSet DangGiaoHangNB(string maNB)
        {
            string sqlStr = string.Format("select DonHang.MaDonHang as MaDonHang, TongTien as TongTien, NgayDatHang as NgDat," +
                    "TrangThaiDonHangNB as TrangThaiDonHangNB, SanPham.TenSanPham as TenSP, SanPham.Hinh as Hinh " +
                    "FROM DonHang, (SELECT MaDonHang, MIN(MaSanPham) AS MaSanPham FROM ChiTietDonHang GROUP BY MaDonHang) Q, SanPham " +
                    " WHERE DonHang.MaNguoiBan = '{0}' AND DonHang.MaDonHang = Q.MaDonHang AND SanPham.MaSanPham = Q.MaSanPham" +
                    " AND DonHang.TrangThaiDonHangNB = N'{1}'", maNB, "Đang giao hàng");
            DataSet dt = new DataSet();
            dt = tt.Load(sqlStr);
            return dt;
        }
        public DataSet DatHangThanhCong(string maNM)
        {
            string sqlStr = string.Format("select DonHang.MaDonHang as MaDonHang, TongTien as TongTien, NgayDatHang as NgDat," +
                    "TrangThaiDonHangNM as TrangThaiDonHangNM, SanPham.TenSanPham as TenSP, SanPham.Hinh as Hinh " +
                    "FROM DonHang, (SELECT MaDonHang, MIN(MaSanPham) AS MaSanPham FROM ChiTietDonHang GROUP BY MaDonHang) Q, SanPham " +
                    "WHERE MaNguoiMua = '{0}' AND DonHang.MaDonHang = Q.MaDonHang AND SanPham.MaSanPham = Q.MaSanPham " +
                    " AND TrangThaiDonHangNM = N'{1}'", maNM, "Đặt hàng thành công");
            DataSet dt = new DataSet();
            dt = tt.Load(sqlStr);
            return dt;
        }
        public DataSet DangGiaoHangNM(string maNM)
        {
            string sqlStr = string.Format("select DonHang.MaDonHang as MaDonHang, TongTien as TongTien, NgayDatHang as NgDat," +
                    "TrangThaiDonHangNM as TrangThaiDonHangNM, SanPham.TenSanPham as TenSP, SanPham.Hinh as Hinh " +
                    "FROM DonHang, (SELECT MaDonHang, MIN(MaSanPham) AS MaSanPham FROM ChiTietDonHang GROUP BY MaDonHang) Q, SanPham " +
                    "WHERE MaNguoiMua = '{0}' AND DonHang.MaDonHang = Q.MaDonHang AND SanPham.MaSanPham = Q.MaSanPham " +
                    " AND TrangThaiDonHangNM = N'{1}'", maNM, "Đang giao hàng");
            DataSet dt = new DataSet();
            dt = tt.Load(sqlStr);
            return dt;
        }
        public DataSet DaGiaoNM(string maNM)
        {
            string sqlStr = string.Format("select DonHang.MaNguoiMua,SanPham.MaSanPham,DonHang.MaDonHang as MaDonHang, TongTien as TongTien, NgayDatHang as NgDat," +
                   "TrangThaiDonHangNB as TrangThaiDonHang, SanPham.TenSanPham as TenSP, SanPham.Hinh as Hinh " +
                   "FROM DonHang, (SELECT MaDonHang, MIN(MaSanPham) AS MaSanPham FROM ChiTietDonHang GROUP BY MaDonHang) Q, SanPham " +
                   "WHERE DonHang.MaNguoiMua = '{0}' AND DonHang.MaDonHang = Q.MaDonHang AND SanPham.MaSanPham = Q.MaSanPham AND TrangThaiDonHangNB='{1}'",
                   maNM, "Giao hàng thành công");
            DataSet dt = new DataSet();
            dt = tt.Load(sqlStr);
            return dt;
        }
        //FDatHang -> tạo đơn hàng mới
        public void TaoDonHang(DonHang dh)
        {
            string sql = string.Format("INSERT INTO DonHang (MaDonHang, MaNguoiMua, MaNguoiBan, TongTien, NgayDatHang, TrangThaiDonHangNM, TrangThaiDonHangNB) " +
                    "VALUES('{0}','{1}','{2}','{3}','{4}',N'{5}',N'{6}')", dh.MaDonHang,dh.MaNguoiMua,dh.MaNguoiBan,dh.TongTien,dh.NgayDatHang,dh.TrangThaiDonHangNM,dh.TrangThaiDonHangNB);
            tt.ThucThiKhong(sql);
        }
    }
}