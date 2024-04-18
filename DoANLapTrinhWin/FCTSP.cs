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
        string maSP;
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
            this.Size = new Size(1000, 500);
            this.sp = sp;
            this.maSP = maSP;
            this.lblRating.Text= DanhGia.Value.ToString();
            txtMota.Text = sp.MoTaSanPham;
            lblDiaChi.Text = sp.DiaChi;
            lblGiaBan.Text = sp.GiaBan;
            lblGiaGoc.Text = sp.GiaGoc;
            btnNganhHang.Text = sp.NganhHang;
            dtpngaydang.Value = sp.NgayDang;
            lblTenSP.Text = sp.TenSP;
            lblXuatxu.Text = sp.XuatXu;
            lbltinhtrang.Text = sp.TinhTrang;
            //xoa chu % cuoi cung
            string str = sp.TinhTrang.Substring(0, sp.TinhTrang.Length - 1);
            int tt = int.Parse(str);
            vongtrontt.Value = tt;
            lblThoigiandasd.Text = sp.ThoiGianDaSuDung;
            lblSoLuong.Text = sp.SoLuong+" sản phẩm sẵn có";
            picHinh.Image = ByteArrayToImage(sp.Hinh);
        }    
        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemVaoGio_Click_1(object sender, EventArgs e)
        {
            //bang gio hang: maNB,maNM,maSP,soluongSP,giaban
            //hien len uc: ten, dia chi, tinh trang, gia tien, so luong
            //them vao bang gio hang
            try
            {
                string slmua = soluongmua.Value.ToString();
                // Ket noi
                conn.Open();
                string anh = BitConverter.ToString(sp.Hinh).Replace("-", "");
                string sqlStr = string.Format("INSERT INTO GioHang(MaNguoiBan, MaNguoiMua, MaSanPham, TenSanPham, SoLuong, GiaBan,Hinh,TrangThaiSP) VALUES ('{0}', N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',0x{6},'{7}')", sp.MaNguoiBan, "NM01", sp.MaSP, sp.TenSP, slmua, sp.GiaBan, anh, 1);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thêm thành công");
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

        private void btnMuaNgay_Click(object sender, EventArgs e)
        {
            this.Hide();
            FThanhToan form2 = new FThanhToan(sp);
            form2.ShowDialog();
            form2 = null; //tat form2, tuc la form 2 tro ve null
            this.Show();
        }

        private void soluongmua_ValueChanged(object sender, EventArgs e)
        {
            soluongmua.Maximum = int.Parse(sp.SoLuong);
            soluongmua.Minimum = 1;
        }
    }
}
