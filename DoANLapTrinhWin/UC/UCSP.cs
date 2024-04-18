﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DoANLapTrinhWin
{
    public partial class UCSP : UserControl
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        SanPham sanPham;
        SanPhamDAO spDAO = new SanPhamDAO();
        string tenTK;
       // string trangthai;

        System.Drawing.Image ByteArrayToImage(byte[] a)
        {
            MemoryStream ms = new MemoryStream(a);
            return System.Drawing.Image.FromStream(ms);
        }
        private void UCSP_Load(object sender, EventArgs e)
        {

        }
        public UCSP()
        {
               InitializeComponent();
        }
        public UCSP(SanPham sp,string tenTK)
        {
            this.sanPham = sp;
            this.tenTK= tenTK;
            InitializeComponent();
            this.lblMaSP.Text = sp.MaSP;
            this.lblTenSP.Text = sp.TenSP;
            this.lblGiaBan.Text = "đ" + sp.GiaBan ;
            this.lblGiaGoc.Text = "đ" + sp.GiaGoc ;
            this.lblDiaChi.Text = sp.DiaChi;
            this.picHinh.Image = ByteArrayToImage(sp.Hinh);
            
        }
        private void UCSP_Click(object sender, EventArgs e)
        {
            this.Hide(); //an form 1
            FCTSP formCTSP = new FCTSP(sanPham);
            formCTSP.ShowDialog();
            formCTSP = null;
            this.Show();
        }
        bool picClick ;
        private void traitim()
        {
            //false la chua them
            if (picClick) //=true dang la tim do
            {
              /*  string imagePath = System.Windows.Forms.Application.StartupPath + "\\HinhAnh\\timden.png";
                System.Drawing.Image image = System.Drawing.Image.FromFile(imagePath);
                picHeart.Image = image;
                picClick = false;*/
                try
                {
                    conn.Open();
                    string sqlStr = string.Format("DELETE FROM YeuThich WHERE MaSanPham ='{0}'", sanPham.MaSP);
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);

                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Xoa khoi yeu thich thanh cong");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi \n" + ex);
                    //MessageBox.Show("Đã thêm vào yêu thích");
                }
                finally
                {
                    conn.Close();
                }
            }
            //ban dau la false nhan vao la true chuyen thanh mau do
            else
            {
               /* string imagePath = System.Windows.Forms.Application.StartupPath + "\\HinhAnh\\timdo.png";
                System.Drawing.Image image = System.Drawing.Image.FromFile(imagePath);
                picHeart.Image = image;
                picClick = true;*/
                try
                {
                    conn.Open();
                    string sqlStr = string.Format("INSERT INTO YeuThich (MaSanPham , MaNguoiMua, MaNguoiBan, TrangThai) VALUES ('{0}', '{1}','{2}','{3}')", sanPham.MaSP, tenTK, sanPham.MaNguoiBan,"Có");
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);

                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Them vao yeu thich thanh cong");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi \n" + ex);
                    //MessageBox.Show("Đã thêm vào yêu thích");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void picHeart_Click(object sender, EventArgs e)
        {
            traitim();
        }

        private void UCSP_Load_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT MaSanPham FROM YeuThich ");
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dtSet = new DataSet();
                adapter.Fill(dtSet);

                // Tạo một danh sách các mã sản phẩm trong danh sách yêu thích
                List<string> maSanPhamYeuThich = new List<string>();
                foreach (DataRow row in dtSet.Tables[0].Rows)
                {
                    string maSP = row["MaSanPham"].ToString();
                    maSanPhamYeuThich.Add(maSP);
                }

                // Kiểm tra xem sản phẩm hiện tại có trong danh sách yêu thích không
                if (maSanPhamYeuThich.Contains(sanPham.MaSP))
                {
                    string imagePath = System.Windows.Forms.Application.StartupPath + "\\HinhAnh\\timdo.png";
                    System.Drawing.Image image = System.Drawing.Image.FromFile(imagePath);
                    picHeart.Image = image;
                    picClick = true;
                }
                else
                {
                    string imagePath = System.Windows.Forms.Application.StartupPath + "\\HinhAnh\\timden.png";
                    System.Drawing.Image image = System.Drawing.Image.FromFile(imagePath);
                    picHeart.Image = image;
                    picClick = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
