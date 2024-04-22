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
    public partial class FCTSPSua : Form
    {
        private List<byte[]> byteImage = new List<byte[]>();
        private List<System.Drawing.Image> arrPicture = new List<System.Drawing.Image>();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        SanPhamDAO spDao= new SanPhamDAO();
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        Image ByteArrayToImage(byte[] a)
        {
            MemoryStream ms = new MemoryStream(a);
            return Image.FromStream(ms);
        }
        public FCTSPSua()
        {
            InitializeComponent();
            
        }
        public FCTSPSua(SanPham sp)
        {
            InitializeComponent(); 
            this.Size = new Size(1100,550); //tao size moi cho form
            //thông tin hiện lên của sản phẩm
            txtMaSanPham.Text = sp.MaSP;
            txtTenSP.Text = sp.TenSP;
            txtGiaBan.Text = sp.GiaBan;
            txtGiaGoc.Text = sp.GiaGoc;
            txtXuatXu.Text = sp.XuatXu;
            txtNganhHang.Text = sp.NganhHang;
            txtMoTa.Text = sp.MoTaSanPham;
            txtTGSD.Text = sp.ThoiGianDaSuDung;
            //bỏ vô cái %
            lblTinhTrang.Text = sp.TinhTrang;
            //xóa cái chữ % cuối cùng chuỗi
            string str = sp.TinhTrang.Substring(0, sp.TinhTrang.Length - 1);
            int tt = int.Parse(str);
            tinhTrang.Value = tt;
            //cho cái label di chuyển theo cái %
            float percent = (float)tt / (float)tinhTrang.Maximum;
            int newPosition = (int)(percent * (tinhTrang.Width - lblTinhTrang.Width)) + tinhTrang.Left;
            // Cập nhật vị trí mới của Label
            lblTinhTrang.Left = newPosition;

            txtDiaChi.Text = sp.DiaChi;
            txtSoLuonSanCo.Text = sp.SoLuong;
            picHinh.Image = ByteArrayToImage(sp.Hinh);
            LoadImagesFromDatabase(txtMaSanPham.Text);
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
        //chỉnh sửa sản phẩm
        private void btnSuaSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                foreach (System.Drawing.Image image in arrPicture)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        image.Save(ms, image.RawFormat);
                        byte[] imageBytes = ms.ToArray();
                        string sql = "INSERT INTO HinhAnh (MaSanPham, Hinh) VALUES (@id, @hinh)";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@hinh", imageBytes);
                        cmd.Parameters.AddWithValue("@id", txtMaSanPham.Text);
                        if (cmd.ExecuteNonQuery() > 0)
                            MessageBox.Show("đã lưu");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            SanPham sp = new SanPham(txtMaSanPham.Text, txtTenSP.Text,  txtGiaBan.Text, txtGiaGoc.Text,
                    txtXuatXu.Text, txtTGSD.Text, dtp.Value, txtMoTa.Text, txtNganhHang.Text,
                    lblTinhTrang.Text, txtDiaChi.Text, "",txtSoLuonSanCo.Text, ImageToByteArray(picHinh.Image));
            spDao.CapNhatSanPham(sp);
        }
        //đăng bán sản phẩm
        private void btnDangBan_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham(txtMaSanPham.Text, txtTenSP.Text, txtGiaBan.Text, txtGiaGoc.Text,
                    txtXuatXu.Text, txtTGSD.Text, dtp.Value, txtMoTa.Text, txtNganhHang.Text,
                   lblTinhTrang.Text, txtDiaChi.Text, "", txtSoLuonSanCo.Text, ImageToByteArray(picHinh.Image));
            spDao.CapNhatDangBan(sp);
        }
        //nút back
        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //điều chỉnh giá trị tình trạng sản phẩm
        private void tinhTrang_Scroll(object sender, ScrollEventArgs e)
        {
            int value = tinhTrang.Value;
            lblTinhTrang.Text = value.ToString() +"%"; // Hiển thị giá trị của TrackBar trong Label

            // Tính toán vị trí mới của Label dựa trên giá trị của TrackBar và kích thước của thanh kéo
            float percent = (float)value / (float)tinhTrang.Maximum;
            int newPosition = (int)(percent * (tinhTrang.Width - lblTinhTrang.Width)) + tinhTrang.Left;

            // Cập nhật vị trí mới của Label
            lblTinhTrang.Left = newPosition;
        }
        //thêm hình ảnh
        private void btnThemHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog odlgOpenFile = new OpenFileDialog();
            odlgOpenFile.InitialDirectory = "C:\\";
            odlgOpenFile.Title = "Open File";
            odlgOpenFile.Filter = "Image files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (odlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                picHinh.Image = Image.FromFile(odlgOpenFile.FileName);
                this.Text = odlgOpenFile.FileName;
            }
        }
        private PictureBox CreatePictureBox(System.Drawing.Image image)
        {
            PictureBox pic = new PictureBox();
            pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
        private void btnThemNhieuHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog odlgOpenFile = new OpenFileDialog();
            odlgOpenFile.InitialDirectory = "D:\\HeQTCSDL\\AnhBia\\";
            odlgOpenFile.Title = "Open File";
            odlgOpenFile.Filter = "Image files (*.jpg)|*.jpg|All files (*.*)|*.*";
            try
            {
                if (odlgOpenFile.ShowDialog() == DialogResult.OK)
                {
                    System.Drawing.Image image = System.Drawing.Image.FromFile(odlgOpenFile.FileName);
                    // picAnhBia.Image = image;
                    PictureBox pic = CreatePictureBox(image);
                    panelThemNhieuHinh.Controls.Add(pic);
                    arrPicture.Add(image);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
