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
    public partial class FThongTinNguoiBan : Form
    {
        string maTK;
        byte[] hinh;
        NguoiBanDAO nguoiDao = new NguoiBanDAO();
        Global gt = new Global();
        public FThongTinNguoiBan(string tenTaiKhoan)
        {
            InitializeComponent();
            this.maTK = tenTaiKhoan;
        }
        private void LoadDuLieu()
        {
            Nguoi ng = new Nguoi(maTK);

            DataTable dt = nguoiDao.ThongTinNguoi(ng);
            foreach (DataRow row in dt.Rows)
            {
                // Đưa dữ liệu vào TextBox
                txtMaTaiKhoan.Text = row[0].ToString();
                txtHoTen.Text = row[2].ToString();
                txtGioiTinh.Text = row[5].ToString();
                dtpNgSinh.Text = row[4].ToString();
                //ucNgSinh.textBox.Text = docDuLieu["NgaySinh"].ToString();
                txtCCCD.Text = row[6].ToString();
                txtSDT.Text = row[3].ToString();
                txtDiaChi.Text = row[7].ToString();
                txtEmail.Text = row[8].ToString();
                txtMoTa.Text = row[9].ToString();
                if (row[10] != DBNull.Value)
                {
                    hinh = (byte[])row[10];
                }
                picHinh.Image = Global.ByteArrayToImage(hinh);
            }
        }
        private void FThongTinNguoiBan_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            lblGioiThieu.Text = "Xin chào người bán,  " + txtHoTen.Text;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NguoiBan nguoiban = new NguoiBan(Global.ImageToByteArray(picHinh.Image), txtMaTaiKhoan.Text, txtHoTen.Text, txtSDT.Text, dtpNgSinh.Value, txtGioiTinh.Text, txtCCCD.Text, txtDiaChi.Text, txtEmail.Text, txtMoTa.Text);
            nguoiDao.CapNhat(nguoiban);
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
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
