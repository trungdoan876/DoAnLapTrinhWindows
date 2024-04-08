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
            SanPham sp = new SanPham(ucMaSP.textBox.Text,ucTenSP.textBox.Text, ucGiaBan.textBox.Text, ucGiaGoc.textBox.Text,
    ucXuatXu.textBox.Text, ucTGDSD.textBox.Text,dtpNgayDang.Value, ucMoTaSP.textBox.Text, ucNganhHang.textBox.Text,
    cbbTinhTrang.Text,ucDC.textBox.Text,lblMaNB.Text,ucSoLuong.textBox.Text, b);
            spDAO.ThemSanPham(sp);
        }

        private void picHinh_Click(object sender, EventArgs e)
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
    }
}
