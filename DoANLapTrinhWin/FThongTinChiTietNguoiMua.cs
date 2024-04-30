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
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
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
            /*try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM NguoiMua WHERE Ma='{0}'",maNM);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader docDuLieu = cmd.ExecuteReader();
                if (docDuLieu.Read())
                {
                    // Đưa dữ liệu vào TextBox
                    txtMaTaiKhoan.Text = docDuLieu["Ma"].ToString();
                    txtHoTen.Text = docDuLieu["Ten"].ToString();
                    txtGioiTinh.Text = docDuLieu["GioiTinh"].ToString();
                    dtpNgSinh.Text = docDuLieu["NgaySinh"].ToString();
                    txtCCCD.Text = docDuLieu["CCCD"].ToString();
                    txtSDT.Text = docDuLieu["SDT"].ToString();
                    txtDiaChi.Text = docDuLieu["Diachi"].ToString();
                    txtEmail.Text = docDuLieu["Email"].ToString();
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
            }*/
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
