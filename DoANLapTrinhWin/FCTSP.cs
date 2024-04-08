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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoANLapTrinhWin
{
    public partial class FCTSP : Form
    {
        SanPham sp;
        System.Drawing.Image ByteArrayToImage(byte[] a)
        {
            MemoryStream ms = new MemoryStream(a);
            return System.Drawing.Image.FromStream(ms);
        }
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FCTSP()
        {
            InitializeComponent();
        }
        public FCTSP(SanPham sp)
        {
            InitializeComponent();
            this.sp = sp;
            ucTBMTSP.textBox.Text = sp.MoTaSanPham;
            lblDiaChi.Text = sp.DiaChi;
            lblGiaBan.Text = sp.GiaBan;
            lblGiaGoc.Text = sp.GiaGoc;
            lblNganhHang.Text = sp.NganhHang;
            lblNgayDang.Text = sp.NgayDang.ToShortDateString();
            lblTenSP.Text = sp.TenSP;
            lblXuatxu.Text = sp.XuatXu;
            lblTinhTrang.Text = sp.TinhTrang;
            lblTGDSD.Text = sp.ThoiGianDaSuDung;
            lblSoLuong.Text = sp.SoLuong+" sản phẩm sẵn có";
            //picHinh.Image = ByteArrayToImage(sp.Hinh);
        }
        private void FCTSP_Load(object sender, EventArgs e)
        {

        }
        int count = -1;

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            if (count >0)
            {
                count--;
            }
            picHinh.Image = imageList1.Images[count];
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if(count <2) { 
                count++;
            }
            picHinh.Image = imageList1.Images[count];
        }
        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            //bang gio hang: maNB,maNM,maSP,soluongSP,giaban
            //hien len uc: ten, dia chi, tinh trang, gia tien, so luong
            //them vao bang gio hang
            try
            {
                // Ket noi
                conn.Open();
                //string anh = BitConverter.ToString(sp.Hinh).Replace("-", "");
                string sqlStr = string.Format("INSERT INTO GioHang(MaNguoiBan, MaNguoiMua, MaSanPham, SoLuong, GiaBan,Hinh) VALUES ('{0}', '{1}','{2}','{3}','{4}')", sp.MaNguoiBan,"NM01",sp.MaSP,sp.SoLuong,sp.GiaBan);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("them thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("them that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            FThanhToan form2 = new FThanhToan(sp);
            form2.ShowDialog();
            form2 = null; //tat form2, tuc la form 2 tro ve null
            this.Show();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSL.Text, out int value))
            {
                if (value > 0)
                {
                    value--;
                    txtSL.Text = value.ToString();
                }
            }
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSL.Text, out int value))
            {
                value++;
                txtSL.Text = value.ToString();
            }
        }
    }
}
