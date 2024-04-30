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
    public partial class FThongTinChiTietNguoiMua : Form
    {
        byte[] hinh;
        NguoiMuaDAO nguoiDao = new NguoiMuaDAO();
        string maNM;
        public FThongTinChiTietNguoiMua(string maNM)
        {
            InitializeComponent();
            this.maNM = maNM;
        }
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
        private void LoadData()
        {
            Nguoi ng = new Nguoi(maNM);

            DataTable dt = nguoiDao.ThongTinNguoi(ng);
            foreach (DataRow row in dt.Rows)
            {
                // Đưa dữ liệu vào TextBox
                txtMaTaiKhoan.Text = row[0].ToString();
                txtHoTen.Text = row[1].ToString();
                dtpNgSinh.Text = row[3].ToString();
                txtGioiTinh.Text = row[4].ToString();
                txtCCCD.Text = row[5].ToString();
                txtDiaChi.Text = row[6].ToString();
                txtSDT.Text = row[7].ToString();
                txtEmail.Text = row[8].ToString();
                if (row[9] != DBNull.Value)
                {
                    hinh = (byte[])row[9];
                }
                picHinh.Image = ByteArrayToImage(hinh);
            }
        }
        private void FThongTinChiTiet_Load(object sender, EventArgs e)
        {
            LoadData();
            lblGioiThieu.Text = "Xin chào khách hàng,   " + txtHoTen.Text;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NguoiMua nguoimua = new NguoiMua(ImageToByteArray(picHinh.Image), txtMaTaiKhoan.Text, txtHoTen.Text, txtSDT.Text, dtpNgSinh.Value, txtGioiTinh.Text, txtCCCD.Text, txtDiaChi.Text, txtEmail.Text);
            nguoiDao.CapNhatMua(nguoimua);
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
