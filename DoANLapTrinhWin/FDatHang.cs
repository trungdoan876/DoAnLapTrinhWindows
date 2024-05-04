using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using DoANLapTrinhWin.Class;

namespace DoANLapTrinhWin
{
    public partial class FDatHang : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        SanPham sp;
        NguoiMua ngmua;
        string maNB;
        int tongtien;
        string diachi;
        string ten;
        string trangthai;
        byte[] hinh;
        DateTime ngayhientai = DateTime.Now;
        List<SanPham> listsp = new List<SanPham>();
        GioHangDAO ghDao = new GioHangDAO();
        DonHangDAO dhDao = new DonHangDAO();
        ChiTietDonHangDAO ctdhDao = new ChiTietDonHangDAO();
        public FDatHang(NguoiMua ngMua,SanPham sp, int tongtien)
        {
            InitializeComponent();
            this.Size = new Size(1200, 600);
            this.sp = sp;
            this.ngmua = ngMua;
            this.tongtien = tongtien;
            this.lblTongTien.Text = "đ" + tongtien.ToString() + ".000";
            ThongTin();
            this.lblTenNguoiNhan.Text = ten;
            this.lblDiaChi.Text = diachi;
            LoadData();
        }
        public string TaoMaDonHang()
        {
            DataSet ds = dhDao.TaoMaDonHang();

            string ma = "";
            if (ds.Tables[0].Rows.Count <= 0)
            {
                ma = "DH01";
            }
            else
            {
                int k;
                ma = "DH0";
                k = Convert.ToInt32(ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1][0].ToString().Substring(2));
                k = k + 1;
                ma = ma + k.ToString();
            }
            return ma;
        }
        public void ThongTin()
        {
            DataSet ds = new DataSet();
            ds = ghDao.LoadThongTinNguoiMuaTrongGioHang(ngmua);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                ten = row["ten"].ToString();
                diachi = row["diachi"].ToString();
            }
        }
         public void LoadData()
         {
            DataSet ds = new DataSet();
            ds = ghDao.LoadDatHang(ngmua);
            int yc = 0;
            int y = 0;

            Dictionary<string, UCTheoNB> dictUCTheoNB = new Dictionary<string, UCTheoNB>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                maNB = row["MaNguoiBan"].ToString();
                UCTheoNB uc;
                if (!dictUCTheoNB.ContainsKey(maNB))
                {
                    uc = new UCTheoNB(maNB);
                    uc.Location = new Point(0, yc);
                    yc += uc.Height + 5;
                    paneldathang.Controls.Add(uc);
                    dictUCTheoNB.Add(maNB, uc); //them 1 uc theo ma nguoi ban
                }
                else
                {
                    uc = dictUCTheoNB[maNB];
                }
                string maSP = row["MaSanPham"].ToString();
                string tenSP = row["TenSanPham"].ToString();
                string giaBan = row["GiaBan"].ToString();
                string soLuong = row["SoLuong"].ToString();
                if (row["Hinh"] != DBNull.Value)
                {
                    hinh = (byte[])row["Hinh"];
                }

                sp = new SanPham(maNB, maSP, tenSP, giaBan, hinh, soLuong);
                listsp.Add(sp);

                //uc thong tin moi san pham
                UCDatHang ucdh = new UCDatHang(sp);

                //vi tri moi uc
                ucdh.Location = new Point(0, y);
                y += ucdh.Height += 5;
                uc.panelSP.Controls.Add(ucdh);
            }
        }
        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDatHang_Click_1(object sender, EventArgs e)
        {
            if(cmbThanhToan.Text =="Chuyển khoản")
            {
                trangthai = "Đã thanh toán";
                FChuyenKhoan fdh = new FChuyenKhoan(ngmua.Ma, sp, tongtien,ten,diachi);
                fdh.ShowDialog();
            }
            else
            {
                trangthai = "Chưa thanh toán";
            }
            var NhomNguoiBan = listsp.GroupBy(sp => sp.MaNguoiBan); //nhom nguoi ban lai de tao thanh 1 don hang
            foreach (var i in NhomNguoiBan)
            {
                string maDonHang = TaoMaDonHang();
                DonHang dh = new DonHang(maDonHang,i.Key, ngmua.Ma, tongtien.ToString(), ngayhientai,"Đặt hàng thành công","Chuẩn bị hàng");
                dhDao.TaoDonHang(dh);
                foreach (var sanPham in i)
                {
                    decimal totalValue = tinhTien(sanPham);
                    ChiTietDonHang ct = new ChiTietDonHang(maDonHang,sanPham.MaSP,sanPham.SoLuong, totalValue.ToString(),sanPham.TenSP,sanPham.Hinh);
                    ctdhDao.ThemVaoChiTiet(ct);

                    GioHang gh = new GioHang(sanPham.MaSP);
                    ghDao.XoaGioHang(gh);
                }
            }
            MessageBox.Show("Đặt hàng thành công");
        }
        private decimal tinhTien(SanPham sanPham)
        {
            string soluong = sanPham.SoLuong.Trim();
            int soLuong = int.Parse(sanPham.SoLuong);

            string giaban = sanPham.GiaBan.Substring(1);
            decimal giatien = decimal.Parse(giaban);

            // Tính giá trị tổng tiền
            decimal totalValue = soLuong * giatien;
            return totalValue;
        }
    }
}
