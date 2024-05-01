using DoANLapTrinhWin.Class;
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
        ChiTietDonHangDAO ctdhDao = new ChiTietDonHangDAO();
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
            ChiTietDonHang ctdh = new ChiTietDonHang(maDH);
            DataSet dt = new DataSet();
            dt = ctdhDao.HienChiTietDonHang(ctdh);
            foreach (DataRow row in dt.Tables[0].Rows)
            {
                ChiTietDonHang ct = new ChiTietDonHang(
                    row[0].ToString(),
                    row[3].ToString(),
                    row[4].ToString(),
                    row[2].ToString(),
                    (byte[])row[5]
                    );

                UCDatHang uc = new UCDatHang(ct);
                uc.Location = new Point(0, y);
                y += uc.Height += 10;
                panelDH.Controls.Add(uc);
            }
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
