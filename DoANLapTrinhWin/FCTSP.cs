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
        SanPham sp;
        string maSP;
        bool picClick;
        string tenTK;
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
            this.lblRating.Text= DanhGia.Value.ToString();
            txtMota.Text = sp.MoTaSanPham;
            lblDiaChi.Text = sp.DiaChi;
            lblGiaBan.Text = sp.GiaBan;
            lblGiaGoc.Text = sp.GiaGoc;
            btnNganhHang.Text = sp.NganhHang;
            dtpngaydang.Value = sp.NgayDang;
            lblTenSP.Text = sp.TenSP;
            lblXuatxu.Text = sp.XuatXu;
            lbltinhtrang.Text = sp.TinhTrang;
            //xoa chu % cuoi cung
            string str = sp.TinhTrang.Substring(0, sp.TinhTrang.Length - 1);
            int tt = int.Parse(str);
            vongtrontt.Value = tt;
            lblThoigiandasd.Text = sp.ThoiGianDaSuDung;
            lblSoLuong.Text = sp.SoLuong+" sản phẩm sẵn có";
            picHinh.Image = ByteArrayToImage(sp.Hinh);
            if (picClick == true)
            {
                string imagePath = System.Windows.Forms.Application.StartupPath + "\\HinhAnh\\timdo.png";
                System.Drawing.Image image = System.Drawing.Image.FromFile(imagePath);
                picHeart.Image = image;
                picClick = false;
            }
            else
            {
                string imagePath = System.Windows.Forms.Application.StartupPath + "\\HinhAnh\\timden.png";
                System.Drawing.Image image = System.Drawing.Image.FromFile(imagePath);
                picHeart.Image = image;
                picClick = true;
            }
            LoadImagesFromDatabase(sp.MaSP);
        }
        //hien nhieu hinh
        private void LoadImagesFromDatabase(string masp)
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
            // pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            //bang gio hang: maNB,maNM,maSP,soluongSP,giaban
            //hien len uc: ten, dia chi, tinh trang, gia tien, so luong
            //them vao bang gio hang
            try
            {
                string slmua = soluongmua.Value.ToString();
                // Ket noi
                conn.Open();
                string anh = BitConverter.ToString(sp.Hinh).Replace("-", "");
                string sqlStr = string.Format("INSERT INTO GioHang(MaNguoiBan, MaNguoiMua, MaSanPham, TenSanPham, SoLuong, GiaBan,Hinh,TrangThaiSP) VALUES ('{0}', N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',0x{6},'{7}')", sp.MaNguoiBan, "NM01", sp.MaSP, sp.TenSP, slmua, sp.GiaBan, anh, 1);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại" + ex);
            }
            finally
            {
                conn.Close();
            }
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
                try
                {
                    conn.Open();
                    string sqlStr = string.Format("DELETE FROM YeuThich WHERE MaSanPham ='{0}'", sp.MaSP);
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);

                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Xoa khoi yeu thich thanh cong");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi \n" + ex);
                }
                finally
                {
                    conn.Close();
                }
            }
            //ban dau la false nhan vao la true chuyen thanh mau do
            else
            {
                string imagePath = System.Windows.Forms.Application.StartupPath + "\\HinhAnh\\timdo.png";
                System.Drawing.Image image = System.Drawing.Image.FromFile(imagePath);
                picHeart.Image = image;
                try
                {
                    conn.Open();
                    string sqlStr = string.Format("INSERT INTO YeuThich (MaSanPham , MaNguoiMua, MaNguoiBan) VALUES ('{0}', '{1}','{2}')", sp.MaSP, tenTK, sp.MaNguoiBan);
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);

                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Them vao yeu thich thanh cong");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi \n" + ex);
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

    }
}
