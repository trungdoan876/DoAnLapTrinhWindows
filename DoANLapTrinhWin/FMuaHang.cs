﻿using System;
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
using static System.Net.Mime.MediaTypeNames;

namespace DoANLapTrinhWin
{
    public partial class FMuaHang : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        string tenTaiKhoan;
        byte[] hinh;
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
        private void ucsp1_Load(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            try
            {
                panelMuaHang.AutoScroll = true;
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM SanPham WHERE DangBan = '{0}'",1);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dtSet = new DataSet();
                adapter.Fill(dtSet);
                int x = 0;
                int y = 0;
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
                    if (row["Hinh"] != DBNull.Value)
                    {
                        hinh = (byte[])row["Hinh"];
                    }
                    SanPham sp = new SanPham(maSP, tenSP, giaBan, giaGoc, xuatXu, thoiGianSuDung, ngayDang, moTaSP, nganhHang, tinhTrang, diaChi, maNB, soLuong, hinh);
                    UCSP ucSP = new UCSP(sp,tenTaiKhoan);
                    
                    ucSP.lblMaSP.Text = maSP;
                    ucSP.lblTenSP.Text = tenSP;
                    ucSP.lblGiaBan.Text = giaBan;
                    ucSP.lblGiaGoc.Text = giaGoc;
                    ucSP.lblDiaChi.Text = diaChi;
                    ucSP.picHinh.Image = ByteArrayToImage(hinh);
                    //vi tri moi uc
                    ucSP.Location = new Point(x, y);
                    x += ucSP.Width += 5;
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
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void FMuaHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        bool sidebarExpand = true;
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                // neu mo rong panelMenu
                panelBoLoc.Width -= 10;
                if (panelBoLoc.Width == panelBoLoc.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                   
                }
            }
            else
            {
                panelBoLoc.Width += 10;
                if (panelBoLoc.Width == panelBoLoc.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }
        private void btnBoLoc_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                panelMuaHang.AutoScroll = true;
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM SanPham WHERE TenSanPham LIKE '%{0}%'", txtTimKiem.Text);
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
                    x += ucSP.Width += 5;
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
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                panelMuaHang.AutoScroll = true;
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM SanPham WHERE TenSanPham LIKE '%{0}%'", txtTimKiem.Text);
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
                    x += ucSP.Width += 5;
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
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
