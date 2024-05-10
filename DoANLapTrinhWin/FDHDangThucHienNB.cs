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
        NguoiBan ngban;
        DonHangDAO dhDao = new DonHangDAO();
        public FDHDangThucHienNB(NguoiBan ngBan)
        {
            InitializeComponent();
            this.ngban = ngBan;
            LoadData();
            LoadData2();
        }
        public void LoadData()
        {
            DataSet ds = new DataSet();
            ds=dhDao.DangThucHienNB(ngban);
            int y = 0;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                DonHang dh = new DonHang(row);
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
            ds = dhDao.DangGiaoHangNB(ngban);
            int y = 0;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                DonHang dh = new DonHang(row);
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
