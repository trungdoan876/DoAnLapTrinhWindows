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
        NguoiBan ngBan;
        byte[] hinh;
        NguoiBanDAO nguoiDao = new NguoiBanDAO();
        Global gt = new Global();
        public FThongTinNguoiBan(NguoiBan nguoiBan)
        {
            InitializeComponent();
            this.ngBan = nguoiBan;
            LoadDuLieu();
        }
        private void LoadDuLieu()
        {
            DataTable dt = nguoiDao.ThongTinNguoi(ngBan);
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
                txtMoTa.Text = row[8].ToString();
                if (row[9] != DBNull.Value)
                {
                    hinh = (byte[])row[9];
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
            NguoiBan nguoiban = new NguoiBan(Global.ImageToByteArray(picHinh.Image), txtMaTaiKhoan.Text, txtHoTen.Text, txtSDT.Text, dtpNgSinh.Value, txtGioiTinh.Text, txtCCCD.Text, txtDiaChi.Text, txtMoTa.Text);
            nguoiDao.CapNhat(nguoiban);
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            picHinh.Image = Global.CreateOpenFileDialog(picHinh);
        }
    }
}
