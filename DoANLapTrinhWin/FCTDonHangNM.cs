using DoANLapTrinhWin.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoANLapTrinhWin
{
    public partial class FCTDonHangNM : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        string maDH;
        byte[] hinh;
        public FCTDonHangNM(string madh)
        {
            InitializeComponent();
            this.Size = new Size(1200,600);
            this.maDH = madh;
            this.lblMaDH.Text = maDH.ToString();
            LoadData();
            TongTienDH();
        }
        int x = 0;
        int y = 0;
        //lấy thông tin về tổng tiền, ngày đặt hàng -> ngày giao hàng 
        public void TongTienDH()
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("select TongTien, NgayDatHang " +
                    "FROM DonHang " +
                    "WHERE MaDonHang = '{0}'",maDH);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dtSet = new DataSet();
                adapter.Fill(dtSet);
                if (dtSet.Tables[0].Rows.Count > 0)
                {
                    // Lấy tổng tiền và ngày đặt hàng từ dòng đầu tiên của kết quả truy vấn
                    string tongTien = dtSet.Tables[0].Rows[0]["TongTien"].ToString();
                    DateTime ngayDatHang = Convert.ToDateTime(dtSet.Tables[0].Rows[0]["NgayDatHang"]);
                    DateTime ngayGiaoHang = ngayDatHang.AddDays(1);
                    this.lbltongtienDH.Text = tongTien.ToString()+"đ";
                    this.lblNgayGiao.Text = ngayGiaoHang.ToString("yyyy-MM-dd");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void LoadData()
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT MaDonHang, SanPham.TenSanPham, ChiTietDonHang.SoLuong AS slmua, ChiTietDonHang.GiaTien AS gtien, SanPham.Hinh " +
                                "FROM ChiTietDonHang, SanPham " +
                                "WHERE SanPham.MaSanPham = ChiTietDonHang.MaSanPham AND ChiTietDonHang.MaDonHang = '{0}'", maDH);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dtSet = new DataSet();
                adapter.Fill(dtSet);

                foreach (DataRow row in dtSet.Tables[0].Rows)
                {
                    string maDH = row["MaDonHang"].ToString();
                    string tenSP = row["TenSanPham"].ToString();
                    string giaTien = row["gtien"].ToString();
                    string soLuong = row["slmua"].ToString();
                    
                    if (row["Hinh"] != DBNull.Value)
                    {
                        hinh = (byte[])row["Hinh"];
                    }
                    SanPham sp = new SanPham(tenSP, giaTien, soLuong, hinh);

                    UCDatHang uc = new UCDatHang(sp);

                    int sl = int.Parse(soLuong);
                    decimal giatien = decimal.Parse(giaTien);
                    decimal thanhTien = giatien * sl;
                    uc.lblthanhtien.Text = thanhTien.ToString();

                    uc.Location = new Point(x,y);
                    y += uc.Height += 10;
                    panelDH.Controls.Add(uc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
