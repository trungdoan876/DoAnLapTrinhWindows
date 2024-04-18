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
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        NguoiBanDAO nguoiDao = new NguoiBanDAO();
        public FThongTinNguoiBan(string tenTaiKhoan)
        {
            InitializeComponent();
            this.maTK = tenTaiKhoan;
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
        private void LoadDuLieu()
        {
            //NguoiBan nguoiban = new NguoiBan(txtMaTaiKhoan.Text, txtHoTen.Text, ucSDT.textBox.Text, dtpNgSinh.Value, ucGioiTinh.textBox.Text, ucCCCD.textBox.Text, ucDiaChi.textBox.Text, ucEmail.textBox.Text, ucMoTaShop.textBox.Text);
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM NguoiBan WHERE Ma = '{0}'", maTK);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader docDuLieu = cmd.ExecuteReader();
                if (docDuLieu.Read())
                {
                    // Đưa dữ liệu vào TextBox
                    txtMaTaiKhoan.Text = docDuLieu["Ma"].ToString();
                    txtHoTen.Text = docDuLieu["Ten"].ToString();
                    txtGioiTinh.Text = docDuLieu["GioiTinh"].ToString();
                    dtpNgSinh.Text = docDuLieu["NgaySinh"].ToString();
                    //ucNgSinh.textBox.Text = docDuLieu["NgaySinh"].ToString();
                    txtCCCD.Text = docDuLieu["CCCD"].ToString();
                    txtSDT.Text = docDuLieu["SDT"].ToString();
                    txtDiaChi.Text = docDuLieu["DiaChi"].ToString();
                    txtEmail.Text = docDuLieu["Email"].ToString();
                    txtMoTa.Text = docDuLieu["MoTaShop"].ToString();
                    if (docDuLieu["Hinh"] != DBNull.Value)
                    {
                        hinh = (byte[])docDuLieu["Hinh"];
                    }
                    picHinh.Image = ByteArrayToImage(hinh);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        private void FThongTinNguoiBan_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            lblGioiThieu.Text = "Xin chào người bán,  " + txtHoTen.Text;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NguoiBan nguoiban = new NguoiBan(ImageToByteArray(picHinh.Image), txtMaTaiKhoan.Text, txtHoTen.Text, txtSDT.Text, dtpNgSinh.Value, txtGioiTinh.Text, txtCCCD.Text, txtDiaChi.Text, txtEmail.Text, txtMoTa.Text);
            nguoiDao.CapNhat(nguoiban);
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
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
