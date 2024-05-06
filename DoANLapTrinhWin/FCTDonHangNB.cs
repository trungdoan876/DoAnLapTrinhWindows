using DoANLapTrinhWin.Class;
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
        DonHang dh;
        DonHangDAO dhDao = new DonHangDAO();
        ChiTietDonHangDAO ctdhDao = new ChiTietDonHangDAO();
        public FCTDonHangNB(DonHang dh)
        {
            InitializeComponent();
            this.Size = new Size(1200, 600);
            this.dh = dh;
            this.lblMaDH.Text = dh.MaDonHang;
            LoadData();
        }
        int y = 0;
        public void LoadData()
        {
            ChiTietDonHang ctdh = new ChiTietDonHang(dh.MaDonHang);
            DataSet dt = ctdhDao.HienChiTietDonHang(ctdh);
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

        private void btnGiaoHang_Click(object sender, EventArgs e)
        {
            DonHang dhang = new DonHang(dh.MaDonHang);
            FLoadingGiaoHang fload = new FLoadingGiaoHang();
            fload.ShowDialog();
            dhDao.CapNhatGiaoHangNB(dhang);
        }
    }
}
