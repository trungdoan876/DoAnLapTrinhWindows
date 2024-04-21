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
    public partial class FChuaDangBan : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        string maNB;
        byte[] hinh;
        SanPhamDAO spDao = new SanPhamDAO();
        public FChuaDangBan(string maNB)
        {
            InitializeComponent();
            this.maNB = maNB;
            LoadData();
        }
        //DangBan trong bang SP = 0 -> chua dang ban
        public void LoadData()
        {
            DataSet dt = spDao.LoadChuaDangBan(maNB);
            int x = 0;
            int y = 0;
            foreach (DataRow row in dt.Tables[0].Rows)
            {
                string maSP = row["MaSanPham"].ToString();
                string tenSP = row["TenSanPham"].ToString();
                string giaTien = row["GiaBan"].ToString();
                string giaGoc = row["GiaGoc"].ToString();
                string moTaSP = row["MoTaSanPham"].ToString();
                string tinhTrang = row["TinhTrang"].ToString();
                string nganhHang = row["NganhHang"].ToString();
                string xuatXu = row["XuatXu"].ToString();
                string diaChi = row["DiaChi"].ToString();
                string thoiGianSuDung = row["TGDSD"].ToString();
                DateTime ngayDang = DateTime.Now;
                if (row["Hinh"] != DBNull.Value)
                {
                    hinh = (byte[])row["Hinh"];
                }
                SanPham sp = new SanPham(maSP, tenSP, giaTien, giaGoc, xuatXu, thoiGianSuDung, ngayDang, moTaSP, nganhHang, tinhTrang, diaChi, "", "", hinh);

                UCSPBan ucSPBan = new UCSPBan(sp);

                ucSPBan.Location = new Point(x, y);
                x += ucSPBan.Width += 5;
                if (x == ucSPBan.Width * 3)
                {
                     x = 0;
                     y += ucSPBan.Height + 5;
                }
                panelChuaDangBan.Controls.Add(ucSPBan);
            }
        }
    }
}

