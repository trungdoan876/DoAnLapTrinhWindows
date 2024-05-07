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
        ChiTietDonHangDAO ctdhDao = new ChiTietDonHangDAO();
        DonHang dh;
        DonHangDAO dhdao = new DonHangDAO();
        public FCTDonHangNM(DonHang dh)
        {
            InitializeComponent();
            this.Size = new Size(1200,600);
            this.dh = dh;
            this.lblMaDH.Text = dh.MaDonHang.ToString();
            LoadData();
            TongTienDH();
        }
        int x = 0;
        int y = 0;
        //lấy thông tin về tổng tiền, ngày đặt hàng -> ngày giao hàng 
        public void TongTienDH()
        {
            DataSet ds = dhdao.TongTienNgayDat(dh);
            if (ds.Tables[0].Rows.Count > 0)
            {
                // Lấy tổng tiền và ngày đặt hàng từ dòng đầu tiên của kết quả truy vấn
                string tongTien = ds.Tables[0].Rows[0][0].ToString();
                DateTime ngayDatHang = Convert.ToDateTime(ds.Tables[0].Rows[0][1]);
                DateTime ngayGiaoHang = ngayDatHang.AddDays(1);
                this.lbltongtienDH.Text = tongTien.ToString() + "đ";
                this.lblNgayGiao.Text = ngayGiaoHang.ToString("yyyy-MM-dd");
            }
        }
        public void LoadData()
        {
            ChiTietDonHang ctdh = new ChiTietDonHang(dh.MaDonHang);
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
