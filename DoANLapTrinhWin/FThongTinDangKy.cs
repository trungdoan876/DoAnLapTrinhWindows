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
    public partial class FThongTinDangKy : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        string loainguoi;
        string sdt;
        public string TaoMaNB()
        {
            string sql = string.Format("select * from NguoiBan");
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "NB01";
            }
            else
            {
                int k;
                ma = "NB0";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3));
                k = k + 1;
                ma = ma + k.ToString();
            }
            return ma;
        }
        public string TaoMaNM()
        {
            string sql = string.Format("select * from NguoiMua");
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "NM01";
            }
            else
            {
                int k;
                ma = "NM0";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3));
                k = k + 1;
                ma = ma + k.ToString();
            }
            return ma;
        }
        public FThongTinDangKy(string loainguoi, string sdt)
        {
            InitializeComponent();
            this.loainguoi = loainguoi;
            this.sdt = sdt;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (loainguoi == "Bán hàng")
                {
                    byte[] b = ImageToByteArray(picHinh.Image);
                    string maNB = TaoMaNB();
                    string sql = string.Format("INSERT INTO NguoiBan(Ma, MatKhau, Ten, SDT, NgaySinh, GioiTinh, CCCD, DiaChi, Hinh) " +
                        "VALUES('{0}','{1}',N'{2}','{3}','{4}',N'{5}','{6}',N'{7}',0x{8})",
                        maNB,txtMK.Text,txtHoTen.Text,sdt,dtpNgSinh.Value,txtGioiTinh.Text,txtCCCD.Text,txtDiaChi.Text,b);
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Tao tai khoan thanh cong");
                    this.Close();
                }
                else if (loainguoi == "Mua hàng")
                {
                    byte[] b = ImageToByteArray(picHinh.Image);
                    string maNM = TaoMaNM();
                    string sql = string.Format("INSERT INTO NguoiMua(Ma, MatKhau, Ten, SDT, NgaySinh, GioiTinh, CCCD, DiaChi, Hinh) " +
                        "VALUES('{0}','{1}',N'{2}','{3}','{4}',N'{5}','{6}',N'{7}',0x{8})",
                        maNM, txtMK.Text, txtHoTen.Text, sdt, dtpNgSinh.Value, txtGioiTinh.Text, txtCCCD.Text, txtDiaChi.Text,b);
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Tao tai khoan thanh cong");
                    this.Close();
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
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
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
    }
}
