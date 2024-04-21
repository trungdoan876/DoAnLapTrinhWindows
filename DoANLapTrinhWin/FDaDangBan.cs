﻿using System;
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
        public FDaDangBan(string maNB)
        {
            InitializeComponent();
            this.maNB = maNB;
        }
        //Trong bảng SanPham DangBan = 1 -> đã đăng bán
        private void LoadData()
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM SanPham WHERE MaNguoiBan ='{0}'AND DangBan ='{1}'", maNB, 1);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dtSet = new DataSet();
                adapter.Fill(dtSet);
                int x = 0;
                int y = 0;
                foreach (DataRow row in dtSet.Tables[0].Rows)
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void FDaDangBan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
