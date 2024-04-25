using DoANLapTrinhWin.UC;
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

namespace DoANLapTrinhWin
{
    public partial class FDHDangThucHienNB : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        string maNB;
        byte[] hinh;
        public FDHDangThucHienNB(string maNB)
        {
            InitializeComponent();
            this.maNB = maNB;
            LoadData();
        }
        Image ByteArrayToImage(byte[] a)
        {
            MemoryStream ms = new MemoryStream(a);
            return Image.FromStream(ms);
        }
        public void LoadData()
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("select DonHang.MaDonHang as MaDonHang, TongTien as TongTien, NgayDatHang as NgDat," +
                    "TrangThaiDonHangNB as TrangThaiDonHangNB, SanPham.TenSanPham as TenSP, SanPham.Hinh as Hinh " +
                    "FROM DonHang, (SELECT MaDonHang, MIN(MaSanPham) AS MaSanPham FROM ChiTietDonHang GROUP BY MaDonHang) Q, SanPham " +
                    " WHERE DonHang.MaNguoiBan = '{0}' AND DonHang.MaDonHang = Q.MaDonHang AND SanPham.MaSanPham = Q.MaSanPham" +
                    " AND DonHang.TrangThaiDonHangNB = N'{1}'", maNB, "Chuẩn bị hàng");
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dtSet = new DataSet();
                adapter.Fill(dtSet);
                int y = 0;
                foreach (DataRow row in dtSet.Tables[0].Rows)
                {
                    string maDH = row["MaDonHang"].ToString();
                    string tongTien = row["TongTien"].ToString();
                    DateTime NgDat = (DateTime)row["NgDat"];
                    string TTDH = row["TrangThaiDonHangNB"].ToString();
                    string tenSP = row["TenSP"].ToString();
                    if (row["Hinh"] != DBNull.Value)
                    {
                        hinh = (byte[])row["Hinh"];
                    }
                    DonHang dh = new DonHang(maDH, tongTien, NgDat, TTDH);
                    SanPham sp = new SanPham(tenSP, hinh);

                    UCDonHangNB uc = new UCDonHangNB(dh, sp);

                    uc.Location = new Point(0, y);
                    y += uc.Height + 5;
                    panelDangThucHien.Controls.Add(uc);
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
    }
}
