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
        NguoiMua ngmua;
        DonHangDAO dhDao = new DonHangDAO();
        public FDHDangThucHienNM(NguoiMua ngMua)
        {
            InitializeComponent();
            this.ngmua = ngMua;
            LoadData1();
            LoadData2();
        }
        public void LoadData1()
        {
            DataSet ds = new DataSet();
            ds = dhDao.DatHangThanhCong(ngmua);
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

                UCDonHangNM uc = new UCDonHangNM(dh, sp);

                uc.Location = new Point(0, y);
                y += uc.Height + 5;
                panelDonHang.Controls.Add(uc);
            }
        }
        public void LoadData2()
        {
            DataSet ds = new DataSet();
            ds = dhDao.DangGiaoHangNM(ngmua);
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

                UCDonHangNM uc = new UCDonHangNM(dh, sp);

                uc.Location = new Point(0, y);
                y += uc.Height + 5;
                panelDonHang.Controls.Add(uc);
            }
        }
    }
}
