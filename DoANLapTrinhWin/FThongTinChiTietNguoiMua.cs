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
        NguoiMuaDAO nguoimuaDao = new NguoiMuaDAO();
        Global gt = new Global();
        NguoiMua ngMua;
        public FThongTinChiTietNguoiMua(NguoiMua ng)
        {
            InitializeComponent();
            this.ngMua = ng;
            LoadData();
        }
        private void LoadData()
        {
            DataTable dt = nguoimuaDao.ThongTinNguoi(ngMua);
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
                picHinh.Image = Global.ByteArrayToImage(hinh);
            }
        }
        private void FThongTinChiTiet_Load(object sender, EventArgs e)
        {
            LoadData();
            lblGioiThieu.Text = "Xin chào khách hàng,   " + txtHoTen.Text;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NguoiMua nguoimua = new NguoiMua(Global.ImageToByteArray(picHinh.Image), txtMaTaiKhoan.Text, txtHoTen.Text, txtSDT.Text, dtpNgSinh.Value, txtGioiTinh.Text, txtCCCD.Text, txtDiaChi.Text, txtEmail.Text);
            nguoimuaDao.CapNhatMua(nguoimua);
        }

        private void btnThemHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog odlgOpenFile = Global.CreateOpenFileDialog();
            if (odlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                picHinh.Image = Image.FromFile(odlgOpenFile.FileName);
                this.Text = odlgOpenFile.FileName;
            }
        }
    }
}
