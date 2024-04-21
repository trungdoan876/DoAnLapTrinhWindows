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
    public partial class FDHDangThucHienNM : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        string maNM;
        byte[] hinh;
        public FDHDangThucHienNM(string maNM)
        {
            InitializeComponent();
            this.maNM = maNM;
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
                string sqlStr = string.Format("SELECT TOP 1 DonHang.MaDonHang as MaDonHang, TongTien as TongTien, NgayDatHang as NgDat, " +
                "TrangThaiDonHang as TrangThaiDonHang, SanPham.TenSanPham as TenSP, SanPham.Hinh as Hinh " +
                 "FROM DonHang, SanPham, ChiTietDonHang " +
                "WHERE MaNguoiMua = '{0}' AND DonHang.MaDonHang = ChiTietDonHang.MaDonHang " +
                "AND SanPham.MaSanPham = ChiTietDonHang.MaSanPham", maNM);
                
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dtSet = new DataSet();
                adapter.Fill(dtSet);
                int y = 0;
                foreach (DataRow row in dtSet.Tables[0].Rows)
                {
                    string maDH = row["MaDonHang"].ToString();
                    string tongTien = row["TenSP"].ToString();
                    DateTime NgDat = (DateTime)row["NgDat"];
                    string TTDH = row["TrangThaiDonHang"].ToString();
                    string tenSP = row["TenSP"].ToString();
                    if (row["Hinh"] != DBNull.Value)
                    {
                        hinh = (byte[])row["Hinh"];
                    }
                    DonHang dh = new DonHang(maDH, tongTien, NgDat, TTDH);
                    SanPham sp = new SanPham(tenSP, hinh);

                    UCDonHang uc = new UCDonHang(dh, sp);

                    uc.Location = new Point(0, y);
                    y += uc.Height + 5;
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
