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
    public partial class FDanhGia : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        SanPham sp;
        DonHang dh;
        private List<System.Drawing.Image> arrPicture = new List<System.Drawing.Image>();
        System.Drawing.Image ByteArrayToImage(byte[] a)
        {
            MemoryStream ms = new MemoryStream(a);
            return System.Drawing.Image.FromStream(ms);
        }
        
        public FDanhGia(SanPham sp, DonHang dh)
        {
            InitializeComponent();
           // this.ratingsp.Value = 4;
            this.sp = sp;
            this.dh = dh;
            this.ucDanhGia1.lblTenSP.Text = sp.TenSP;
            this.ucDanhGia1.picHinh.Image = ByteArrayToImage(sp.Hinh);
            this.ucDanhGia1.lblTrangthai.Text = dh.TrangThaiDonHangNM;
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string tinhtrangsao(double sosao)
        {
            string trangthai = "Tuyệt vời"; // Khởi tạo một chuỗi để lưu trạng thái
            if (sosao == 4 || sosao == 4.5)
            {
                trangthai = "Hài lòng";
            }
            else if (sosao == 3 || sosao == 3.5)
            {
                trangthai = "Bình thường";
            }
            else if (sosao == 2 || sosao == 2.5)
            {
                trangthai = "Không hài lòng";
            }
            else if (sosao == 1 || sosao == 0.5)
            {
                trangthai = "Tệ";
            }
            return trangthai; // Trả về giá trị trạng thái
        }

        private void ratingsp_ValueChanged(object sender, EventArgs e)
        {
            lblsao.Text = tinhtrangsao(ratingsp.Value); // Gán giá trị trạng thái cho nhãn lblsao
        }

        private void ratingnguoiban_ValueChanged(object sender, EventArgs e)
        {
            lblnguoiban.Text = tinhtrangsao(ratingnguoiban.Value); // Gán giá trị trạng thái cho nhãn lblnguoiban
        }

        private void ratinggiaohang_ValueChanged(object sender, EventArgs e)
        {
            lblgiaohang.Text = tinhtrangsao(ratinggiaohang.Value); // Gán giá trị trạng thái cho nhãn lblgiaohang
        }
        private PictureBox CreatePictureBox(System.Drawing.Image image)
        {
            PictureBox pic = new PictureBox();
            // pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pic.Size = new Size(100, 100);
            pic.Dock = DockStyle.Left;
            pic.Image = image;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Cursor = Cursors.Hand;
            pic.Click += PictureBox_Click;
            return pic;
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox ptb = (PictureBox)sender;
            picThemHinh.Image = ptb.Image;
        }
        private void picThemHinh_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(sp.MaSP);
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

        private void btnguii_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = string.Format("INSERT INTO DanhGia(MaNguoiMua,MaSanPham,sao,saonguoiban,saogiaohang,nhanxet) " +
                "VALUES('{0}','{1}','{2}','{3}','{4}',N'{5}')", dh.MaNguoiMua, sp.MaSP, ratingsp.Value, ratingnguoiban.Value, ratinggiaohang.Value, txtDanhGia.Text);
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thành công");
                foreach (System.Drawing.Image image in arrPicture)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        image.Save(ms, image.RawFormat);
                        byte[] imageBytes = ms.ToArray();
                        string anh = BitConverter.ToString(imageBytes).Replace("-", "");
                        string sql1 = string.Format("INSERT INTO HinhDanhGia (MaNguoiMua,MaSanPham, Hinh) VALUES ('{0}','{1}', 0x{2})", dh.MaNguoiMua, sp.MaSP, anh);
                        SqlCommand cmd1 = new SqlCommand(sql1, conn);
                        cmd1.ExecuteNonQuery();
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Loi" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }

}
