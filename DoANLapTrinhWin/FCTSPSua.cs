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
            this.Size = new Size(1100,550);
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
        }
        private void FCTSPSua_Load(object sender, EventArgs e)
        {

        }

        private void btnSuaSanPham_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham(txtMaSanPham.Text, txtTenSP.Text,  txtGiaBan.Text, txtGiaGoc.Text,
                    txtXuatXu.Text, txtTGSD.Text, dtp.Value, txtMoTa.Text, txtNganhHang.Text,
                    lblTinhTrang.Text, txtDiaChi.Text, "",txtSoLuonSanCo.Text, ImageToByteArray(picHinh.Image));
            spDao.CapNhatSanPham(sp);
        }

        private void btnDangBan_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham(txtMaSanPham.Text, txtTenSP.Text, txtGiaBan.Text, txtGiaGoc.Text,
                    txtXuatXu.Text, txtTGSD.Text, dtp.Value, txtMoTa.Text, txtNganhHang.Text,
                   lblTinhTrang.Text, txtDiaChi.Text, "", txtSoLuonSanCo.Text, ImageToByteArray(picHinh.Image));
            spDao.CapNhatDangBan(sp);
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
    }
}
