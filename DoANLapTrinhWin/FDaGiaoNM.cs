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
    public partial class FDaGiaoNM : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        byte[] hinh;
        string maNM;
        public FDaGiaoNM(string maNM)
        {
            InitializeComponent();
            this.maNM = maNM;
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("select DonHang.MaDonHang as MaDonHang, TongTien as TongTien, NgayDatHang as NgDat," +
                    "TrangThaiDonHangNB as TrangThaiDonHang, SanPham.TenSanPham as TenSP, SanPham.Hinh as Hinh " +
                    "FROM DonHang, (SELECT MaDonHang, MIN(MaSanPham) AS MaSanPham FROM ChiTietDonHang GROUP BY MaDonHang) Q, SanPham " +
                    "WHERE DonHang.MaNguoiMua = '{0}' AND DonHang.MaDonHang = Q.MaDonHang AND SanPham.MaSanPham = Q.MaSanPham AND TrangThaiDonHangNB='{1}'",
                    maNM, "Giao hàng thành công");

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dtSet = new DataSet();
                adapter.Fill(dtSet);
                int y = 0;
                foreach (DataRow row in dtSet.Tables[0].Rows)
                {
                    string maDH = row["MaDonHang"].ToString();
                    string tongTien = row["TongTien"].ToString();
                    DateTime NgDat = (DateTime)row["NgDat"];
                    string TTDH = row["TrangThaiDonHang"].ToString();
                    string tenSP = row["TenSP"].ToString();
                    if (row["Hinh"] != DBNull.Value)
                    {
                        hinh = (byte[])row["Hinh"];
                    }
                    DonHang dh = new DonHang(maDH, tongTien, NgDat, TTDH);
                    SanPham sp = new SanPham(tenSP, hinh);

                    UCDonHangNB uc = new UCDonHangNB(dh, sp);

                    panelDaGiao.Controls.Add(uc);
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
