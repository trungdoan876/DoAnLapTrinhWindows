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
        DonHangDAO dhDao = new DonHangDAO();
        string maNB;
        byte[] hinh;
        public FDHDangThucHienNB(string maNB)
        {
            InitializeComponent();
            this.maNB = maNB;
            LoadData();
            LoadData2();
        }
        public void LoadData()
        {
            DataSet ds = new DataSet();
            ds=dhDao.DangThucHienNB(maNB);
            int y = 0;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                DonHang dh = new DonHang
                (
                    row[0].ToString(),
                    row[1].ToString(),
                    (DateTime)row[2],
                    row[3].ToString()
                );
                SanPham sp = new SanPham
                (
                    row[4].ToString(),
                    (byte[])row[5]
                );

                UCDonHangNB uc = new UCDonHangNB(dh, sp);

                uc.Location = new Point(0, y);
                y += uc.Height + 5;
                panelDangThucHien.Controls.Add(uc);
            }
        }
        public void LoadData2()
        {
            DataSet ds = new DataSet();
            ds = dhDao.DangGiaoHangNB(maNB);
            int y = 0;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                DonHang dh = new DonHang
                (
                    row[0].ToString(),
                    row[1].ToString(),
                    (DateTime)row[2],
                    row[3].ToString()
                );
                SanPham sp = new SanPham
                (
                    row[4].ToString(),
                    (byte[])row[5]
                 );

                UCDonHangNB uc = new UCDonHangNB(dh, sp);

                uc.Location = new Point(0, y);
                y += uc.Height + 5;
                panelDangThucHien.Controls.Add(uc);
            }
        }
    }
}
