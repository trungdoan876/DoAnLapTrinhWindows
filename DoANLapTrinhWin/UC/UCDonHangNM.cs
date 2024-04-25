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

namespace DoANLapTrinhWin.UC
{
    public partial class UCDonHangNM : UserControl
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DonHang dh;
        SanPham sp;
        public UCDonHangNM()
        {
            InitializeComponent();
        }
        public UCDonHangNM(DonHang dhh, SanPham spp)
        {
            InitializeComponent();
            this.dh = dhh;
            this.sp = spp;
            this.lblMaDH.Text = dh.MaDonHang.ToString();
            this.lblTenSP.Text = sp.TenSP.ToString();
            //this.lblNgayDatHang.Text = dh.NgayDatHang.ToString();
            this.lblTongTien.Text = dh.TongTien.ToString();
            this.lblTrangThai.Text = dh.TrangThaiDonHangNM.ToString();
            this.pictureBox1.Image = ByteArrayToImage(sp.Hinh);
        }

        Image ByteArrayToImage(byte[] a)
        {
            MemoryStream ms = new MemoryStream(a);
            return Image.FromStream(ms);
        }

        private void UCDonHang_Load(object sender, EventArgs e)
        {

        }

        private void UCDonHang_Click(object sender, EventArgs e)
        {
            FCTDonHangNM fdh = new FCTDonHangNM(lblMaDH.Text);
            fdh.ShowDialog();
            
        }

        private void btnDaNhanHang_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("UPDATE DonHang SET TrangThaiDonHangNM = N'{0}', TrangThaiDonHangNB = N'{1}' WHERE MaDonHang ='{2}'",
                    "Giao hàng thành công", "Giao hàng thành công", lblMaDH.Text);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Da nhan hang, hay danh gia don hang cua ban");
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
    }
}
