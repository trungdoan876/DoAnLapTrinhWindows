﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Documents;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace DoANLapTrinhWin
{
    public class SanPhamDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection tt = new DBConnection();
        public void ThemSanPham(SanPham sp)
        {
            string anh = BitConverter.ToString(sp.Hinh).Replace("-", "");
            string sqlStr = string.Format("INSERT INTO SanPham(MaSanPham, TenSanPham, GiaBan, " +
                "GiaGoc, XuatXu, TGDSD, MoTaSanPham, NganhHang, TinhTrang,DiaChi,NgayDang,MaNguoiBan,SoLuong,Hinh,DangBan) " +
                "VALUES ('{0}', N'{1}', '{2}','{3}', N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}','{11}','{12}',0x{13},'{14}')",
                sp.MaSP, sp.TenSP, sp.GiaBan, sp.GiaGoc, sp.XuatXu, sp.ThoiGianDaSuDung, sp.MoTaSanPham, sp.NganhHang, sp.TinhTrang, sp.DiaChi, sp.NgayDang, sp.MaNguoiBan, sp.SoLuong, anh, 0);
            tt.ThucThiKhong(sqlStr);
            MessageBox.Show("Thêm sản phẩm thành công <3!");
        }
        public void XoaSanPham(SanPham sp)
        {
            string sqlStr = string.Format("DELETE FROM SanPham WHERE MaSanPham = '{0}'", sp.MaSP);
            tt.ThucThiKhong(sqlStr);
            MessageBox.Show("Đã xóa sản phẩm!");
        }
        public void CapNhatSanPham(SanPham sp)
        {
            string anh = BitConverter.ToString(sp.Hinh).Replace("-", "");
            string sqlStr = string.Format("UPDATE SanPham SET TenSanPham = N'{0}', GiaBan = '{1}', GiaGoc ='{2}', " +
                "XuatXu = N'{3}', TGDSD = N'{4}'," +
                "MoTaSanPham =N'{5}', NganhHang =N'{6}',TinhTrang =N'{7}',DiaChi=N'{8}',NgayDang='{9}',Hinh=0x{10}," +
                "SoLuong='{11}' WHERE MaSanPham = '{12}'",
                sp.TenSP, sp.GiaBan, sp.GiaGoc, sp.XuatXu, sp.ThoiGianDaSuDung, sp.MoTaSanPham, sp.NganhHang, sp.TinhTrang,
                sp.DiaChi, sp.NgayDang, anh, sp.SoLuong, sp.MaSP);
            tt.ThucThiKhong(sqlStr);
            MessageBox.Show("Cập nhật sản phẩm thành công!");
        }
        public void CapNhatDangBan(SanPham sp)
        {
            string sqlStr = string.Format("UPDATE SanPham SET DangBan = '{0}'WHERE MaSanPham ='{1}'", 1, sp.MaSP);
            tt.ThucThi(sqlStr);
        }
        public void GoSanPham(SanPham sp)
        {
            string sqlStr = string.Format("UPDATE SanPham SET DangBan = '{0}'WHERE MaSanPham ='{1}'", 0, sp.MaSP);
            tt.ThucThi(sqlStr);
        }
        public void XoaNhieuHinh(SanPham sp)
        {
            string sqlStr = string.Format("DELETE FROM HinhAnh WHERE MaSanPham = '{0}'", sp.MaSP);
            tt.ThucThiKhong(sqlStr);
        }
        public void ThemNhieuHinh(string maSP, List<System.Drawing.Image> arrPicture)
        {
            foreach (System.Drawing.Image image in arrPicture)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, image.RawFormat);
                    byte[] imageBytes = ms.ToArray();
                    string anh = BitConverter.ToString(imageBytes).Replace("-", "");
                    string sql = string.Format("INSERT INTO HinhAnh (MaSanPham, Hinh) VALUES ('{0}', 0x{1})", maSP, anh);
                    tt.ThucThiKhong(sql);
                }
            }
        }
        public DataSet LoadChuaDangBan(NguoiBan ngban)
        {
            string sqlStr = string.Format("SELECT *FROM SanPham WHERE MaNguoiBan ='{0}'AND DangBan ='{1}'", ngban.Ma, 0);
            DataSet dt = new DataSet();
            dt = tt.Load(sqlStr);
            return dt;
        }
        public DataSet LoadDaDangBan(NguoiBan ngban)
        {
            string sqlStr = string.Format("SELECT *FROM SanPham WHERE MaNguoiBan ='{0}'AND DangBan ='{1}'", ngban.Ma, 1);
            DataSet dt = new DataSet();
            dt = tt.Load(sqlStr);
            return dt;
        }
        public DataSet LoadDanhSachSanPham(NguoiBan ngban)
        {
            string sqlStr = string.Format("SELECT * FROM SanPham WHERE MaNguoiBan ='{0}'", ngban.Ma);
            DataSet dt = new DataSet();
            dt = tt.Load(sqlStr);
            return dt;
        }
        public DataSet TatCaSanPhamNB(SanPham sp)
        {
            string sqlStr = string.Format("select * from SanPham WHERE MaNguoiBan = '{0}' AND DangBan ='{1}'", sp.MaNguoiBan, 1);
            DataSet dt = new DataSet();
            dt = tt.Load(sqlStr);
            return dt;
        }
        //hiện lên FMuaHang
        public DataSet TatCaSanPham()
        {
            //load form theo tần suất bấm vào sản phẩm của người mua và load ra danh sách các sản phẩm có cùng ngành hàng đó
            string sqlStr = string.Format("select * from SanPham  left join (select max(TanSuatTruyCap) as Max, NganhHang " +
                "FROM TanSuatTruyCap GROUP BY NganhHang) Q ON SanPham.NganhHang = Q.NganhHang Where DangBan ='{0}' order by Q.Max desc",1);
            DataSet dt = new DataSet();
            dt = tt.Load(sqlStr);
            return dt;
        }
        public DataSet BoLocSanPham(string nganhhang)
        {
            string sqlStr = string.Format("SELECT *FROM SanPham WHERE NganhHang = N'{0}' AND DangBan = '{1}'", nganhhang, 1);
            DataSet dt = new DataSet();
            dt = tt.Load(sqlStr);
            return dt;
        }
        public DataSet SanPhamChungNH(string nganhhang, string masp)
        {
            string sqlStr = string.Format("SELECT *FROM SanPham WHERE NganhHang = N'{0}' AND DangBan = '{1}' AND MaSanPham !='{2}'", nganhhang, 1, masp);
            DataSet dt = new DataSet();
            dt = tt.Load(sqlStr);
            return dt;
        }
        public DataSet TimKiemSanPham(string timkiem)
        {
            string sqlStr = string.Format("SELECT * FROM SanPham WHERE TenSanPham LIKE N'%{0}%' AND DangBan = '{1}'", timkiem.Trim(), 1);
            DataSet dt = new DataSet();
            dt = tt.Load(sqlStr);
            return dt;
        }

        public DataSet SanPhamYeuThich(string maNM)
        {
            string sqlStr = string.Format("select SanPham.Hinh, YeuThich.MaSanPham, SanPham.TenSanPham, SanPham.GiaBan, SanPham.GiaGoc, SanPham.XuatXu, SanPham.TGDSD, " +
                    " SanPham.NgayDang, SanPham.MoTaSanPham, SanPham.NganhHang, SanPham.TinhTrang, SanPham.DangBan, SanPham.MaNguoiBan, SanPham.DiaChi, SanPham.SoLuong " +
                    " From YeuThich, SanPham WHERE YeuThich.MaSanPham = SanPham.MaSanPham and MaNguoiMua = '{0}'", maNM);
            DataSet dt = new DataSet();
            dt = tt.Load(sqlStr);
            return dt;
        }
        //Lay Hinh 
        public DataSet LayHinhAnhTheoMaSanPham(string masp)
        {
            string sqlStr = "SELECT Hinh FROM HinhAnh WHERE MaSanPham = @id";
            DataSet ds = new DataSet();
            ds = tt.LoadHinh(sqlStr, new SqlParameter("@id", masp));
            return ds;
        }
        //để tạo mã sản phẩm trong FThemSanPham
        public string TaoMaSanPham()
        {
            string sql = string.Format("select * from SanPham");
            DataSet dt = new DataSet();
            string ma = "";
            if (dt.Tables[0].Rows.Count <= 0)
            {
                ma = "SP01";
            }
            else
            {
                int k;
                ma = "SP"; 
                k = Convert.ToInt32(dt.Tables[0].Rows[dt.Tables[0].Rows.Count - 1][1].ToString().Trim().Substring(2));
                k = k + 1;
                if (k < 10)
                    ma = ma + "0";
                ma = ma + k.ToString();
            }
            return ma;
        }
        //tần suất truy cập vào sản phẩm của người mua

        public DataTable LayNganhHangTheoMaSanPham(string MaSanPham)
        {
            string sql = string.Format("select NganhHang From SanPham where MaSanPham='{0}'", MaSanPham);
            DataTable dt = new DataTable();
            dt = tt.DocDuLieu(sql);
            return dt;
        }
    }
}
