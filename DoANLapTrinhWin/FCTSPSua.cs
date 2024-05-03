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
        Global gl = new Global();
        public FCTSPSua()
        {
            InitializeComponent();
            
        }
        public FCTSPSua(SanPham sp)
        {
            InitializeComponent(); 
            this.Size = new Size(1100,550); //tao size moi cho form
            //thông tin hiện lên của sản phẩm
            ThongTin(sp);
            LoadImagesFromDatabase(txtMaSanPham.Text);
        }
        private void ThongTin(SanPham sp)
        {
            txtMaSanPham.Text = sp.MaSP;
            txtTenSP.Text = sp.TenSP;
            txtGiaBan.Text = sp.GiaBan;
            txtGiaGoc.Text = sp.GiaGoc;
            txtXuatXu.Text = sp.XuatXu;
            txtNganhHang.Text = sp.NganhHang;
            txtMoTa.Text = sp.MoTaSanPham;
            txtTGSD.Text = sp.ThoiGianDaSuDung;
            lblTinhTrang.Text = sp.TinhTrang;
            // Cập nhật vị trí mới của Label
            lblTinhTrang.Left = ViTriTinhTrang();
            txtDiaChi.Text = sp.DiaChi;
            txtSoLuonSanCo.Text = sp.SoLuong;
            picHinh.Image = Global.ByteArrayToImage(sp.Hinh);
        }
        private int ViTriTinhTrang()
        {
            //xóa cái chữ % cuối cùng chuỗi
            string str = lblTinhTrang.Text.Substring(0, lblTinhTrang.Text.Length - 1);
            int tt = int.Parse(str);
            tinhTrang.Value = tt;
            //cho cái label di chuyển theo cái %
            float percent = (float)tt / (float)tinhTrang.Maximum;
            int newPosition = (int)(percent * (tinhTrang.Width - lblTinhTrang.Width)) + tinhTrang.Left;
            return newPosition;
        }
        //hien nhieu hinh
        private void LoadImagesFromDatabase(string masp)
        {
            DataSet dt = new DataSet();
            dt = spDao.LayHinhAnhTheoMaSanPham(masp);
            foreach (DataRow row in dt.Tables[0].Rows)
            {
                byte[] imageBytes = (byte[])row["Hinh"];
                using (MemoryStream mss = new MemoryStream(imageBytes))
                {
                    System.Drawing.Image image = System.Drawing.Image.FromStream(mss);
                    PictureBox pic = Global.CreatePictureBox(image, picHinh);
                    panelThemNhieuHinh.Controls.Add(pic);
                }
            }
        
        }
        //chỉnh sửa sản phẩm
        private void btnSuaSanPham_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham(txtMaSanPham.Text, txtTenSP.Text,  txtGiaBan.Text, txtGiaGoc.Text,
                    txtXuatXu.Text, txtTGSD.Text, dtp.Value, txtMoTa.Text, txtNganhHang.Text,
                    lblTinhTrang.Text, txtDiaChi.Text, "",txtSoLuonSanCo.Text, Global.ImageToByteArray(picHinh.Image));
            spDao.CapNhatSanPham(sp);
            spDao.ThemNhieuHinh(txtMaSanPham.Text, arrPicture);
        }
        //đăng bán sản phẩm
        private void btnDangBan_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham(txtMaSanPham.Text, txtTenSP.Text, txtGiaBan.Text, txtGiaGoc.Text,
                    txtXuatXu.Text, txtTGSD.Text, dtp.Value, txtMoTa.Text, txtNganhHang.Text,
                   lblTinhTrang.Text, txtDiaChi.Text, "", txtSoLuonSanCo.Text, Global.ImageToByteArray(picHinh.Image));
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
            picHinh.Image = Global.CreateOpenFileDialog(picHinh);
        }
        private void btnThemNhieuHinh_Click(object sender, EventArgs e)
        {
            arrPicture = Global.CreateOpenFileDialogMore(picHinh, panelThemNhieuHinh, arrPicture);  
        }
    }
}
