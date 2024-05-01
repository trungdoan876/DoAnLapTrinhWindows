﻿using Guna.UI2.WinForms;
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
using System.Web;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DoANLapTrinhWin
{
    public partial class FMuaHang : Form
    {
        private Guna2Button btnOK;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        string tenTaiKhoan;
        byte[] hinh;
        Global gl = new Global();
        SanPhamDAO spdao = new SanPhamDAO();    
        System.Drawing.Image ByteArrayToImage(byte[] a)
        {
            MemoryStream ms = new MemoryStream(a);
            return System.Drawing.Image.FromStream(ms);
        }
        public FMuaHang(string tenTK)
        {
            InitializeComponent();
            this.tenTaiKhoan = tenTK;
        }
        public void LoadData()
        {
            DataSet dt = spdao.TatCaSanPham();

            panelMuaHang.AutoScroll = true;
            int x = 0;
            int y = 0;
            foreach (DataRow row in dt.Tables[0].Rows)
            {
                SanPham sp = new SanPham
                (
                    row[1].ToString(),
                    row[2].ToString(),
                    row[3].ToString(),
                    row[4].ToString(),
                    row[5].ToString(),
                    row[6].ToString(),
                    (DateTime)row[7],
                    row[8].ToString(),
                    row[9].ToString(),
                    row[10].ToString(),
                    row[13].ToString(),
                    row[12].ToString(),
                    row[14].ToString(),
                    (byte[])row[0]
                );
                UCSP ucSP = new UCSP(sp,tenTaiKhoan);
                //vi tri moi uc
                ucSP.Location = new Point(x, y);
                x += ucSP.Width + 5;
                if (x == ucSP.Width * 4)
                {
                    x = 0;
                    y += ucSP.Height + 5;
                }
                panelMuaHang.Controls.Add(ucSP);
            }  
        }
        private void FMuaHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        bool sidebarExpand = true;
        private void BoLoc(string boloc)
        {
            try
            {
                panelMuaHang.AutoScroll = true;
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM SanPham WHERE NganhHang = N'{0}' AND DangBan = '{1}'", boloc.Trim(), 1);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dtSet = new DataSet();
                adapter.Fill(dtSet);
                int x = 0;
                int y = 0;
                //xoa cai panel tat ca san pham truoc khi tao moi @_@
                panelMuaHang.Controls.Clear();
                foreach (DataRow row in dtSet.Tables[0].Rows)
                {
                    string maNB = row["MaNguoiBan"].ToString();
                    string maSP = row["MaSanPham"].ToString();
                    string tenSP = row["TenSanPham"].ToString();
                    string giaBan = "đ" + row["GiaBan"].ToString();
                    string giaGoc = "đ" + row["GiaGoc"].ToString();
                    string diaChi = row["DiaChi"].ToString();
                    string xuatXu = row["XuatXu"].ToString();
                    string nganhHang = row["NganhHang"].ToString();
                    DateTime ngayDang = DateTime.Now;
                    string moTaSP = row["MoTaSanPham"].ToString();
                    string tinhTrang = row["TinhTrang"].ToString();
                    string thoiGianSuDung = row["TGDSD"].ToString();
                    string soLuong = row["SoLuong"].ToString();
                    if (row["Hinh"] != null && row["Hinh"] is byte[])
                    {
                        hinh = (byte[])row["Hinh"];
                    }
                    SanPham sp = new SanPham(maSP, tenSP, giaBan, giaGoc, xuatXu, thoiGianSuDung, ngayDang, moTaSP, nganhHang, tinhTrang, diaChi, maNB, soLuong, hinh);
                    UCSP ucSP = new UCSP(sp, tenTaiKhoan);
                     //vi tri moi uc
                    ucSP.Location = new Point(x, y);
                    x = x + ucSP.Width + 5;
                    if (x == ucSP.Width * 3)
                    {
                        x = 0;
                        y += ucSP.Height + 5;
                    }
                    panelMuaHang.Controls.Add(ucSP);
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panelMuaHang.Controls.Clear();
            Global.TaoButtonTimKiem(btnMenu,ref gl.btnOK);
            LoadData();
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            Global.TaoButtonTimKiem(btnSach, ref gl.btnOK);
            BoLoc(btnSach.Text.Trim());
        }

        private void btnThoitrangnu_Click(object sender, EventArgs e)
        {
            Global.TaoButtonTimKiem(btnThoitrangnu, ref gl.btnOK);
            BoLoc(btnThoitrangnu.Text.Trim());
        }

        private void btnDochonam_Click(object sender, EventArgs e)
        {
            Global.TaoButtonTimKiem(btnDochonam, ref gl.btnOK);
            BoLoc(btnDochonam.Text.Trim());
        }

        private void btnDochoi_Click(object sender, EventArgs e)
        {
            Global.TaoButtonTimKiem(btnDochoi, ref gl.btnOK);
            BoLoc(btnDochoi.Text.Trim());
        }

        private void btnDodungnhacua_Click(object sender, EventArgs e)
        {
            Global.TaoButtonTimKiem(btnDodungnhacua, ref gl.btnOK);
            BoLoc(btnDodungnhacua.Text.Trim());
        }

        private void btnThietbidientu_Click(object sender, EventArgs e)
        {
            Global.TaoButtonTimKiem(btnThietbidientu, ref gl.btnOK);
            BoLoc(btnThietbidientu.Text.Trim());
        }

        private void btnDothethao_Click(object sender, EventArgs e)
        {
            Global.TaoButtonTimKiem(btnDothethao, ref gl.btnOK);
            BoLoc(btnDothethao.Text.Trim());
        }

        private void btndolamdep_Click(object sender, EventArgs e)
        {
            Global.TaoButtonTimKiem(btndolamdep, ref gl.btnOK);
            BoLoc(btndolamdep.Text.Trim());
        }

        private void btnKhac_Click(object sender, EventArgs e)
        {
            Global.TaoButtonTimKiem(btnKhac, ref gl.btnOK);
            BoLoc(btnKhac.Text.Trim());
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            LoadData();
            try
            {
                panelMuaHang.AutoScroll = true;
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM SanPham WHERE TenSanPham LIKE '%{0}%' AND DangBan = '{1}'", txtTimKiem.Text, 1);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dtSet = new DataSet();
                adapter.Fill(dtSet);
                int x = 0;
                int y = 0;
                //xoa cai panel tat ca san pham truoc khi tao moi @_@
                panelMuaHang.Controls.Clear();
                foreach (DataRow row in dtSet.Tables[0].Rows)
                {
                    string maNB = row["MaNguoiBan"].ToString();
                    string maSP = row["MaSanPham"].ToString();
                    string tenSP = row["TenSanPham"].ToString();
                    string giaBan = "đ" + row["GiaBan"].ToString();
                    string giaGoc = "đ" + row["GiaGoc"].ToString();
                    string diaChi = row["DiaChi"].ToString();
                    string xuatXu = row["XuatXu"].ToString();
                    string nganhHang = row["NganhHang"].ToString();
                    DateTime ngayDang = DateTime.Now;
                    string moTaSP = row["MoTaSanPham"].ToString();
                    string tinhTrang = row["TinhTrang"].ToString();
                    string thoiGianSuDung = row["TGDSD"].ToString();
                    string soLuong = row["SoLuong"].ToString();
                    if (row["Hinh"] != null && row["Hinh"] is byte[])
                    {
                        hinh = (byte[])row["Hinh"];
                    }
                    SanPham sp = new SanPham(maSP, tenSP, giaBan, giaGoc, xuatXu, thoiGianSuDung, ngayDang, moTaSP, nganhHang, tinhTrang, diaChi, maNB, soLuong, hinh);
                    UCSP ucSP = new UCSP(sp, tenTaiKhoan);

                    //vi tri moi uc
                    ucSP.Location = new Point(x, y);
                    x += ucSP.Width + 5;
                    if (x == ucSP.Width * 3)
                    {
                        x = 0;
                        y += ucSP.Height + 5;
                    }
                    panelMuaHang.Controls.Add(ucSP);
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

        private void txtTimKiem_IconRightClick(object sender, EventArgs e)
        {
            try
            {
                panelMuaHang.AutoScroll = true;
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM SanPham WHERE TenSanPham LIKE '%{0}%' AND DangBan = '{1}'", txtTimKiem.Text, 1);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dtSet = new DataSet();
                adapter.Fill(dtSet);
                int x = 0;
                int y = 0;
                //xoa cai panel tat ca san pham truoc khi tao moi @_@
                panelMuaHang.Controls.Clear();
                foreach (DataRow row in dtSet.Tables[0].Rows)
                {
                    string maNB = row["MaNguoiBan"].ToString();
                    string maSP = row["MaSanPham"].ToString();
                    string tenSP = row["TenSanPham"].ToString();
                    string giaBan = "đ" + row["GiaBan"].ToString();
                    string giaGoc = "đ" + row["GiaGoc"].ToString();
                    string diaChi = row["DiaChi"].ToString();
                    string xuatXu = row["XuatXu"].ToString();
                    string nganhHang = row["NganhHang"].ToString();
                    DateTime ngayDang = DateTime.Now;
                    string moTaSP = row["MoTaSanPham"].ToString();
                    string tinhTrang = row["TinhTrang"].ToString();
                    string thoiGianSuDung = row["TGDSD"].ToString();
                    string soLuong = row["SoLuong"].ToString();
                    if (row["Hinh"] != null && row["Hinh"] is byte[])
                    {
                        hinh = (byte[])row["Hinh"];
                    }
                    SanPham sp = new SanPham(maSP, tenSP, giaBan, giaGoc, xuatXu, thoiGianSuDung, ngayDang, moTaSP, nganhHang, tinhTrang, diaChi, maNB, soLuong, hinh);
                    UCSP ucSP = new UCSP(sp, tenTaiKhoan);

                    ucSP.lblMaSP.Text = maSP;
                    ucSP.lblTenSP.Text = tenSP;
                    ucSP.lblGiaBan.Text = giaBan;
                    ucSP.lblGiaGoc.Text = giaGoc;
                    ucSP.lblDiaChi.Text = diaChi;
                    //vi tri moi uc
                    ucSP.Location = new Point(x, y);
                    x += ucSP.Width + 5;
                    if (x == ucSP.Width * 3)
                    {
                        x = 0;
                        y += ucSP.Height + 5;
                    }
                    panelMuaHang.Controls.Add(ucSP);
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
    }
}
