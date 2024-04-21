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
    public partial class FDaDangBan : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        string maNB;
        byte[] hinh;
        SanPhamDAO spDao = new SanPhamDAO();
        public FDaDangBan(string maNB)
        {
            InitializeComponent();
            this.maNB = maNB;
        }
        //Trong bảng SanPham DangBan = 1 -> đã đăng bán
        private void LoadData()
        {
                DataSet dt = spDao.LoadDaDangBan(maNB);
                int x = 0;
                int y = 0;
                foreach (DataRow row in dt.Tables[0].Rows)
                {
                    //lấy thông tin sản phẩm từ dataset
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
                    //khởi tạo đối tượng để truyền vào UCSPDangBan
                    SanPham sp = new SanPham(maSP, tenSP, giaTien, giaGoc, xuatXu, thoiGianSuDung, ngayDang, moTaSP, nganhHang, tinhTrang, diaChi, "", "",hinh);

                    UCSPDangBan ucSPBan = new UCSPDangBan(sp);

                    ucSPBan.Location = new Point(x, y);
                    x += ucSPBan.Width += 5;
                    if (x == ucSPBan.Width * 3)
                    {
                        x = 0;
                        y += ucSPBan.Height + 5;
                    }
                    panelDangBan.Controls.Add(ucSPBan);
                }
        }
        private void FDaDangBan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
