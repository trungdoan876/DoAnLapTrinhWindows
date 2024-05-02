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

namespace DoANLapTrinhWin
{
    public partial class FDatHang : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        SanPham sp;
        string maNM;
        string maNB;
        int tongtien;
        string diachi;
        string ten;
        string trangthai;
        byte[] hinh;
        DateTime ngayhientai = DateTime.Now;
        List<SanPham> listsp = new List<SanPham>();
        GioHangDAO ghDao = new GioHangDAO();
        
        //tao ma don hang
        public string TaoMaDonHang()
        {
            string sql = string.Format("Select * from DonHang");
            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "DH01";
            }
            else
            {
                int k;
                ma = "DH0";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3));
                k = k + 1;
                ma = ma + k.ToString();
            }
            return ma;
        }
        Image ByteArrayToImage(byte[] a)
        {
            MemoryStream ms = new MemoryStream(a);
            return Image.FromStream(ms);
        }
        public FDatHang(string maNM,SanPham sp, int tongtien)
        {
            InitializeComponent();
            this.Size = new Size(1200, 600);
            this.sp = sp;
            this.maNM = maNM;
            this.tongtien = tongtien;
            this.lblTongTien.Text = "đ" + tongtien.ToString() + ".000";
            ThongTin();
            this.lblTenNguoiNhan.Text = ten;
            this.lblDiaChi.Text = diachi;
            LoadData();
        }
        public void ThongTin()
        {
            DataSet ds = new DataSet();
            ds = ghDao.LoadThongTinNguoiMuaTrongGioHang(maNM);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                ten = row["ten"].ToString();
                diachi = row["diachi"].ToString();
            }
        }

         public void LoadData()
         {
            DataSet ds = new DataSet();
            ds = ghDao.LoadDatHang(maNM);
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
                FChuyenKhoan fdh = new FChuyenKhoan(maNM, sp, tongtien,ten,diachi);
                fdh.ShowDialog();
            }
            else
            {
                trangthai = "Chưa thanh toán";
            }
            try
            {
                conn.Open();
                var nguoiBanGroup = listsp.GroupBy(sp => sp.MaNguoiBan); //nhom nguoi ban lai de tao thanh 1 don hang
                foreach (var grp in nguoiBanGroup)
                {
                    string maDonHang = TaoMaDonHang();
                    string sql = string.Format("INSERT INTO DonHang(MaDonHang,MaNguoiMua,MaNguoiBan,TongTien,NgayDatHang,TrangThaiDonHangNM,TrangThaiDonHangNB) " +
                    "VALUES('{0}','{1}','{2}','{3}','{4}',N'{5}',N'{6}')", maDonHang, maNM, grp.Key, tongtien, ngayhientai, "Đặt hàng thành công","Chuẩn bị hàng");
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    foreach (var sanPham in grp)
                    {
                        string soluong = sanPham.SoLuong.Trim();
                        int soLuong = int.Parse(sanPham.SoLuong);

                        string giaban = sanPham.GiaBan.Substring(1);
                        decimal giatien = decimal.Parse(giaban);

                        // Tính giá trị tổng tiền
                        decimal totalValue = soLuong * giatien;

                        string sqlstr = string.Format("INSERT INTO ChiTietDonHang(MaDonHang, MaSanPham, SoLuong, GiaTien)" +
                    "VALUES('{0}','{1}','{2}','{3}')", maDonHang, sanPham.MaSP, sanPham.SoLuong, totalValue);
                        string sqlstr2 = string.Format("DELETE GioHang WHERE MaSanPham ='{0}' ", sanPham.MaSP);
                        SqlCommand cmdn = new SqlCommand(sqlstr2, conn);
                        SqlCommand cmdm = new SqlCommand(sqlstr, conn);
                        cmdm.ExecuteNonQuery();
                        cmdn.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Dat hang thanh cong!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
