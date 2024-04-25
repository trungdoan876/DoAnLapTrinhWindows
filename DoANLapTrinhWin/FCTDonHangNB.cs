using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DoANLapTrinhWin
{
    public partial class FCTDonHangNB : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        string maDH;
        byte[] hinh;
        public FCTDonHangNB(string maDH)
        {
            InitializeComponent();
            this.Size = new Size(1200, 600);
            this.maDH = maDH;
            this.lblMaDH.Text = maDH;
            LoadData();
        }
        int y = 0;
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

                    uc.Location = new Point(0, y);
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

        private void btnGiaoHang_Click(object sender, EventArgs e)
        {
            try 
            { 
                conn.Open();
                string sqlStr = string.Format("UPDATE DonHang SET TrangThaiDonHangNM = N'{0}', TrangThaiDonHangNB = N'{1}' WHERE MaDonHang ='{2}'", 
                    "Đang giao hàng", "Đang giao hàng",maDH);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Giao hang thanh cong");
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
