﻿using System;
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
            string anh = BitConverter.ToString(sp.Hinh).Replace("-", "");
            string sqlStr = string.Format("INSERT INTO SanPham(MaSanPham, TenSanPham, GiaBan, " +
                "GiaGoc, XuatXu, TGDSD, MoTaSanPham, NganhHang, TinhTrang,DiaChi,NgayDang,MaNguoiBan,SoLuong,Hinh,DangBan) " +
                "VALUES ('{0}', N'{1}', '{2}','{3}', N'{4}','{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}','{11}','{12}',0x{13},'{14}')", 
                sp.MaSP, sp.TenSP, sp.GiaBan, sp.GiaGoc, sp.XuatXu, sp.ThoiGianDaSuDung, sp.MoTaSanPham, sp.NganhHang, sp.TinhTrang,sp.DiaChi,sp.NgayDang,sp.MaNguoiBan,sp.SoLuong,anh,0);
            tt.ThucThi(sqlStr);
        }
        public void XoaSanPham(SanPham sp)
        {
            string sqlStr = string.Format("DELETE FROM SanPham WHERE MaSanPham = '{0}'", sp.MaSP);
            tt.ThucThi(sqlStr);
        }
        public void CapNhatSanPham(SanPham sp)
        {
            
            string anh = BitConverter.ToString(sp.Hinh).Replace("-", "");
            string sqlStr = string.Format("UPDATE SanPham SET TenSanPham = N'{0}', GiaBan = '{1}', GiaGoc ='{2}', " +
                "XuatXu = N'{3}', TGDSD = N'{4}'," +
                "MoTaSanPham =N'{5}', NganhHang =N'{6}',TinhTrang =N'{7}',DiaChi=N'{8}',NgayDang='{9}',Hinh=0x{10}," +
                "SoLuong='{11}' WHERE MaSanPham = '{12}'", 
                sp.TenSP, sp.GiaBan, sp.GiaGoc, sp.XuatXu, sp.ThoiGianDaSuDung, sp.MoTaSanPham, sp.NganhHang, sp.TinhTrang,
                sp.DiaChi, sp.NgayDang,anh,sp.SoLuong, sp.MaSP);
            tt.ThucThi(sqlStr);
        }
        public void CapNhatDangBan(SanPham sp)
        {
            string sqlStr = string.Format("UPDATE SanPham SET DangBan = '{0}'WHERE MaSanPham ='{1}'", 1,sp.MaSP);
            //kiem tra dang ban xem da dang ban chua thi moi duoc dang ban
            tt.ThucThi(sqlStr);
        }
        public void GoSanPham(SanPham sp)
        {
            string sqlStr = string.Format("UPDATE SanPham SET DangBan = '{0}'WHERE MaSanPham ='{1}'", 0, sp.MaSP);
            tt.ThucThi(sqlStr);
        }
    }
}
