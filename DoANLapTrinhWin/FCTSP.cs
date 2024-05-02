﻿using DoANLapTrinhWin.Class;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoANLapTrinhWin
{
    public partial class FCTSP : Form
    {
        private List<byte[]> byteImage = new List<byte[]>();
        private List<System.Drawing.Image> arrPicture = new List<System.Drawing.Image>();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        YeuThichDAO ytdao = new YeuThichDAO();
        GioHangDAO ghdao = new GioHangDAO();
        DanhGiaDAO dgdao = new DanhGiaDAO();
        SanPham sp;
        string maSP;
        bool picClick;
        string tenTK;
        byte[] hinh;
        
        System.Drawing.Image ByteArrayToImage(byte[] a)
        {
            MemoryStream ms = new MemoryStream(a);
            return System.Drawing.Image.FromStream(ms);
        }
        public FCTSP()
        {
            InitializeComponent();
        }
        public FCTSP(SanPham sp,bool picClick,string tenTK)
        {
            InitializeComponent();
            this.Size = new Size(1200, 600);
            this.sp = sp;
            this.picClick = picClick;
            this.tenTK = tenTK;
            LoadThongTin();
            LoadPicClick();
            LoadHinh(sp.MaSP);
            LoadDanhGia();
        }
        private void LoadThongTin()
        {
            this.lblRating.Text = DanhGia.Value.ToString();
            this.txtMota.Text = sp.MoTaSanPham;
            this.lblDiaChi.Text = sp.DiaChi;
            this.lblGiaBan.Text = sp.GiaBan;
            this.lblGiaGoc.Text = sp.GiaGoc;
            this.btnNganhHang.Text = sp.NganhHang;
            this.dtpngaydang.Value = sp.NgayDang;
            this.lblTenSP.Text = sp.TenSP;
            this.lblXuatxu.Text = sp.XuatXu;
            this.lbltinhtrang.Text = sp.TinhTrang;
            //xoa chu % cuoi cung
            vongtrontt.Value = tinhTrang();
            this.lblThoigiandasd.Text = sp.ThoiGianDaSuDung;
            this.lblSoLuong.Text = sp.SoLuong + " sản phẩm sẵn có";
            this.picHinh.Image = ByteArrayToImage(sp.Hinh);
        }
        private void LoadPicClick()
        {
            if (picClick == true)
            {
                string imagePath = System.Windows.Forms.Application.StartupPath + "\\HinhAnh\\timdo.png";
                System.Drawing.Image image = System.Drawing.Image.FromFile(imagePath);
                picHeart.Image = image;
                // picClick = false;
            }
            else
            {
                string imagePath = System.Windows.Forms.Application.StartupPath + "\\HinhAnh\\timden.png";
                System.Drawing.Image image = System.Drawing.Image.FromFile(imagePath);
                picHeart.Image = image;
                //picClick = true;
            }
        }
        private int tinhTrang()
        {
            string str = sp.TinhTrang.Substring(0, sp.TinhTrang.Length - 1);
            int tt = int.Parse(str);
            return tt;
        }
        private void LoadDanhGia()
        {
            //nguoimua: hinh,ten
            //danh gia: nhanxet,sao
            DataSet ds = new DataSet();
            ds = dgdao.HienDanhGia(sp);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                NguoiMua ngmua = new NguoiMua((byte[])row[0], row[1].ToString());
                DanhGia dg = new DanhGia(row[2].ToString(), (int)row[3]);

                UCDanhGiaCT uc = new UCDanhGiaCT(ngmua,dg,sp.MaSP,tenTK);
                int dodai = 0;
                //dodai += uc.Height;
                fpanelDanhGia.Controls.Add(uc);
            }
        }
        //hien nhieu hinh
        private void LoadHinh(string masp)
        {
            try
            {
                conn.Open();
                string sql = "SELECT Hinh FROM HinhAnh WHERE MaSanPham = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", masp); // Đặt giá trị id của bạn tại đây

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        byte[] imageBytes = (byte[])reader["Hinh"];
                        byteImage.Add(imageBytes);
                    }
                }

                foreach (byte[] imageBytes in byteImage)
                {
                    using (MemoryStream mss = new MemoryStream(imageBytes))
                    {
                        System.Drawing.Image image = System.Drawing.Image.FromStream(mss);
                        PictureBox pic = CreatePictureBox(image);
                        panelThemNhieuHinh.Controls.Add(pic);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private PictureBox CreatePictureBox(System.Drawing.Image image)
        {
            PictureBox pic = new PictureBox();
            pic.Size = new Size(100, 100);
            pic.Dock = DockStyle.Top;
            pic.Image = image;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Cursor = Cursors.Hand;
            pic.Click += PictureBox_Click;
            return pic;
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox ptb = (PictureBox)sender;
            picHinh.Image = ptb.Image;
        }
        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        //thêm sản phẩm vào giỏ hàng
        private void btnThemVaoGio_Click_1(object sender, EventArgs e)
        {
            string slmua = soluongmua.Value.ToString();
            GioHang gh = new GioHang(sp.MaSP,sp.TenSP,sp.GiaBan,int.Parse(slmua),sp.MaNguoiBan,tenTK,sp.Hinh);
            ghdao.ThemVaoGioHang(gh);
        }
        //mua ngay
        private void btnMuaNgay_Click(object sender, EventArgs e)
        {
            this.Hide();
            FThanhToan form2 = new FThanhToan(sp);
            form2.ShowDialog();
            form2 = null; //tat form2, tuc la form 2 tro ve null
            this.Show();
        }

        private void soluongmua_ValueChanged(object sender, EventArgs e)
        {
            soluongmua.Maximum = int.Parse(sp.SoLuong);
            soluongmua.Minimum = 1;
        }
        private void traitim()
        {
            //false la chua them
            if (picClick) //=true dang la tim do
            {
                string imagePath = System.Windows.Forms.Application.StartupPath + "\\HinhAnh\\timden.png";
                System.Drawing.Image image = System.Drawing.Image.FromFile(imagePath);
                picHeart.Image = image;
                YeuThich yt = new YeuThich(sp.MaNguoiBan,tenTK,sp.MaSP);
                ytdao.XoaYeuThich(yt);
            }
            //ban dau la false nhan vao la true chuyen thanh mau do
            else
            {
                string imagePath = System.Windows.Forms.Application.StartupPath + "\\HinhAnh\\timdo.png";
                System.Drawing.Image image = System.Drawing.Image.FromFile(imagePath);
                picHeart.Image = image;
                YeuThich yt = new YeuThich(sp.MaNguoiBan, tenTK, sp.MaSP);
                ytdao.ThemYeuThich(yt);
            }
        }
        private void picHeart_Click(object sender, EventArgs e)
        {
            traitim();
        }

    }
}
