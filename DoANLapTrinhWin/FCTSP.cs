using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DoANLapTrinhWin
{
    public partial class FCTSP : Form
    {
        SanPham sp;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FCTSP()
        {
            InitializeComponent();
        }
        public FCTSP(string maSP)
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
        }
        private void FCTSP_Load(object sender, EventArgs e)
        {

        }
        int count = -1;

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            if (count >0)
            {
               // MessageBox.Show("huhu");
                count--;
            }
            pictureBox2.Image = imageList1.Images[count];
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if(count <2) { 
                count++;
            }
            pictureBox2.Image = imageList1.Images[count];
        }
        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            FThanhToan form2 = new FThanhToan();
            form2.ShowDialog();
            form2 = null; //tat form2, tuc la form 2 tro ve null
            this.Show();
        }
    }
}
