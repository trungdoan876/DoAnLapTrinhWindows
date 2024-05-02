using DoANLapTrinhWin.Class;
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
    public partial class UCDanhGiaCT : UserControl
    {
        string ten, nx;
        int sao;
        byte[] hinh;
        string masp;
        string manm;
        private List<byte[]> byteImage = new List<byte[]>();
        private List<System.Drawing.Image> arrPicture = new List<System.Drawing.Image>();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        NguoiMua ngmua;
        DanhGia dg;
        System.Drawing.Image ByteArrayToImage(byte[] a)
        {
            MemoryStream ms = new MemoryStream(a);
            return System.Drawing.Image.FromStream(ms);
        }
        public UCDanhGiaCT(NguoiMua ng, DanhGia dg,string masp, string manm)
        {
            MessageBox.Show(manm);
            InitializeComponent();
            this.ten = ng.Ten1;
            this.nx = dg.NhanXet;
            this.sao = dg.Sao1;
            this.hinh = ng.Hinh;
            this.masp = masp;
            this.picHinhNM.Image = ByteArrayToImage(ng.Hinh);
            this.lblnhanxet.Text = dg.NhanXet;
            this.lblTenNM.Text = ng.Ten1;
            this.ratingsao.Value = dg.Sao1;
            LoadImagesFromDatabase(masp, manm);
            this.manm = manm;
        }
        private PictureBox CreatePictureBox(System.Drawing.Image image)
        {
            PictureBox pic = new PictureBox();
            pic.Size = new Size(30, 30);
            pic.Dock = DockStyle.Left;
            pic.Image = image;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Cursor = Cursors.Hand;
            //pic.Click += PictureBox_Click;
            return pic;
        }

        private void LoadImagesFromDatabase(string masp,string manm)
        {
            try
            {
                conn.Open();
                string sql = "SELECT Hinh FROM HinhDanhGia WHERE MaSanPham = @id AND MaNguoiMua = @ngmua";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ngmua", manm);
                cmd.Parameters.AddWithValue("@id", masp); // Đặt giá trị id của bạn tại đây
                MessageBox.Show(sql);
                /*masp = masp.Trim();
                 string sql = string.Format("SELECT Hinh FROM HinhDanhGia WHERE MaSanPham = '{0}' AND MaNguoiMua = '{1}'",manm,masp);
                 SqlCommand cmd = new SqlCommand(sql, conn);*/
                

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
                        panelHinh.Controls.Add(pic);
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
    }
}
