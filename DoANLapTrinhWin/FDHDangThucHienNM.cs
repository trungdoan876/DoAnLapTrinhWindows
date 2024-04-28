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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DoANLapTrinhWin
{
    public partial class FDHDangThucHienNM : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        string maNM;
        byte[] hinh;
        public FDHDangThucHienNM(string maNM)
        {
            InitializeComponent();
            this.maNM = maNM;
            LoadData1();
            LoadData2();
        }
        public void LoadData1()
        {
            try
            {
                conn.Open();
                // chonj 1 sanr phaamr de hien len uc 
                string sqlStr = string.Format("select DonHang.MaDonHang as MaDonHang, TongTien as TongTien, NgayDatHang as NgDat," +
                    "TrangThaiDonHangNM as TrangThaiDonHangNM, SanPham.TenSanPham as TenSP, SanPham.Hinh as Hinh " +
                    "FROM DonHang, (SELECT MaDonHang, MIN(MaSanPham) AS MaSanPham FROM ChiTietDonHang GROUP BY MaDonHang) Q, SanPham " +
                    "WHERE MaNguoiMua = '{0}' AND DonHang.MaDonHang = Q.MaDonHang AND SanPham.MaSanPham = Q.MaSanPham " +
                    " AND TrangThaiDonHangNM = N'{1}'", maNM, "Đặt hàng thành công");

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dtSet = new DataSet();
                adapter.Fill(dtSet);
                int y = 0;
                foreach (DataRow row in dtSet.Tables[0].Rows)
                {
                    string maDH = row["MaDonHang"].ToString();
                    string tongTien = row["TongTien"].ToString();
                    DateTime NgDat = (DateTime)row["NgDat"];
                    string TTDH = row["TrangThaiDonHangNM"].ToString();
                    string tenSP = row["TenSP"].ToString();
                    if (row["Hinh"] != DBNull.Value)
                    {
                        hinh = (byte[])row["Hinh"];
                    }
                    DonHang dh = new DonHang(maDH, tongTien, NgDat, TTDH);
                    SanPham sp = new SanPham(tenSP, hinh);

                    UCDonHangNM uc = new UCDonHangNM(dh, sp);

                    uc.Location = new Point(0, y);
                    y = y + uc.Height + uc.Height;
                    panelDonHang.Controls.Add(uc);
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
        public void LoadData2()
        {
            try
            {
                conn.Open();
                // chonj 1 sanr phaamr de hien len uc 
                string sqlStr = string.Format("select DonHang.MaDonHang as MaDonHang, TongTien as TongTien, NgayDatHang as NgDat," +
                    "TrangThaiDonHangNM as TrangThaiDonHangNM, SanPham.TenSanPham as TenSP, SanPham.Hinh as Hinh " +
                    "FROM DonHang, (SELECT MaDonHang, MIN(MaSanPham) AS MaSanPham FROM ChiTietDonHang GROUP BY MaDonHang) Q, SanPham " +
                    "WHERE MaNguoiMua = '{0}' AND DonHang.MaDonHang = Q.MaDonHang AND SanPham.MaSanPham = Q.MaSanPham " +
                    " AND TrangThaiDonHangNM = N'{1}'", maNM, "Đang giao hàng");

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dtSet = new DataSet();
                adapter.Fill(dtSet);
                int y = 0;
                foreach (DataRow row in dtSet.Tables[0].Rows)
                {
                    string maDH = row["MaDonHang"].ToString();
                    string tongTien = row["TongTien"].ToString();
                    DateTime NgDat = (DateTime)row["NgDat"];
                    string TTDH = row["TrangThaiDonHangNM"].ToString();
                    string tenSP = row["TenSP"].ToString();
                    if (row["Hinh"] != DBNull.Value)
                    {
                        hinh = (byte[])row["Hinh"];
                    }
                    DonHang dh = new DonHang(maDH, tongTien, NgDat, TTDH);
                    SanPham sp = new SanPham(tenSP, hinh);

                    UCDonHangNM uc = new UCDonHangNM(dh, sp);

                    uc.Location = new Point(0, y);
                    y = y + uc.Height + uc.Height;
                    panelDonHang.Controls.Add(uc);
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
