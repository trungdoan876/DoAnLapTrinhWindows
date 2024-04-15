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
        }

        private void FSanPhamNguoiBan_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            byte[] b = ImageToByteArray(picHinh.Image);
            //string anh = BitConverter.ToString(b).Replace("-", "");
            SanPham sp = new SanPham(txtMaSanPham.Text, txtTenSP.Text, txtGiaBan.Text, txtGiaGoc.Text,
                    txtXuatXu.Text, txtTGSD.Text, dtp.Value, txtMoTa.Text, txtNganhHang.Text,
                    lblTinhTrang.Text, txtDiaChi.Text, lblMaNB.Text, txtSoLuonSanCo.Text, b);
            spDAO.ThemSanPham(sp);
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

        private void picHinh_Click_1(object sender, EventArgs e)
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

        private void txtMaSanPham_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
