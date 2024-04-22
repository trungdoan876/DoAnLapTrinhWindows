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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoANLapTrinhWin
{
    public partial class FThemSanPham : Form
    {
        private List<byte[]> byteImage = new List<byte[]>();
        private List<System.Drawing.Image> arrPicture = new List<System.Drawing.Image>();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        SanPhamDAO spDAO = new SanPhamDAO();
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        public FThemSanPham(string maNB)
        {
            InitializeComponent();
            this.lblMaNB.Text = maNB;
            cmbNganhHang.DisplayMember = "Text";
        }

        private void FSanPhamNguoiBan_Load(object sender, EventArgs e)
        {

        }

        private void tinhTrang_Scroll(object sender, ScrollEventArgs e)
        {
            int value = tinhTrang.Value;
            lblTinhTrang.Text = value.ToString() + "%"; // Hiển thị giá trị của TrackBar trong Label

            // Tính toán vị trí mới của Label dựa trên giá trị của TrackBar và kích thước của thanh kéo
            float percent = (float)value / (float)tinhTrang.Maximum;
            int newPosition = (int)(percent * (tinhTrang.Width - lblTinhTrang.Width)) + tinhTrang.Left;

            // Cập nhật vị trí mới của Label
            lblTinhTrang.Left = newPosition;
        }

        private void btnThemSP_Click(object sender, EventArgs e)
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
            byte[] b = ImageToByteArray(picHinh.Image);
            //string anh = BitConverter.ToString(b).Replace("-", "");
            SanPham sp = new SanPham(txtMaSanPham.Text, txtTenSP.Text, txtGiaBan.Text, txtGiaGoc.Text,
                    txtXuatXu.Text, txtTGSD.Text, dtp.Value, txtMoTa.Text, cmbNganhHang.Text,
                    lblTinhTrang.Text, txtDiaChi.Text, lblMaNB.Text, txtSoLuonSanCo.Text, b);
            spDAO.ThemSanPham(sp);
        }

        private void btnThemHinh_Click(object sender, EventArgs e)
        {
            MemoryStream ms;
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

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
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
