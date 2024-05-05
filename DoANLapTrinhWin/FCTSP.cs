using DoANLapTrinhWin.Class;
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
        bool picClick;
        byte[] hinh;
        NguoiBan nguoiBan;
        NguoiMua ngmua;
        SanPham sp;
        YeuThichDAO ytdao = new YeuThichDAO();
        GioHangDAO ghdao = new GioHangDAO();
        SanPhamDAO spdao = new SanPhamDAO();
        DanhGiaDAO dgdao = new DanhGiaDAO();
        NguoiBanDAO ngbandao = new NguoiBanDAO();
        public FCTSP()
        {
            InitializeComponent();
        }
        public FCTSP(SanPham sp,bool picClick,NguoiMua ngmua)
        {
            InitializeComponent();
            this.Size = new Size(1200, 600);
            this.sp = sp;
            this.picClick = picClick;
            this.ngmua = ngmua;
            LoadThongTin();
            LoadPicClick();
            LoadHinh();
            LoadDanhGia();
            LoadSPChungNH();
            LoadNB();
        }
        public void LoadSPChungNH() //masp ?
        {
            DataSet dt = spdao.SanPhamChungNH(sp.NganhHang, sp.MaSP);

            fpanelSPChungNH.AutoScroll = true;
            foreach (DataRow row in dt.Tables[0].Rows)
            {
                SanPham sp = new SanPham
                (
                    row[1].ToString(),
                    row[2].ToString(),
                    "đ" + row[3].ToString(),
                    "đ" + row[4].ToString(),
                    row[5].ToString(),
                    row[6].ToString(),
                    (DateTime)row[7],
                    row[8].ToString(),
                    row[9].ToString(),
                    row[10].ToString(),
                    row[13].ToString(),
                    row[12].ToString(),
                    row[14].ToString(),
                    (byte[])row[0]
                );
                UCSP ucSP = new UCSP(sp, ngmua);
                fpanelSPChungNH.Controls.Add(ucSP);
            }
        }
        private void LoadThongTin()
        {
            this.lblRating.Text = DanhGia.Value.ToString();
            this.txtMota.Text = sp.MoTaSanPham;
            this.lblDiaChi.Text = sp.DiaChi;
            this.lblGiaBan.Text = sp.GiaBan;
            this.lblGiaGoc.Text = sp.GiaGoc;
            this.btnNganhHang.Text = sp.NganhHang;
            this.dtpngaydang.Value = sp.NgayDang;
            this.lblTenSP.Text = sp.TenSP;
            this.lblXuatxu.Text = sp.XuatXu;
            this.lbltinhtrang.Text = sp.TinhTrang;
            //xoa chu % cuoi cung
            vongtrontt.Value = tinhTrang();
            this.lblThoigiandasd.Text = sp.ThoiGianDaSuDung;
            this.lblSoLuong.Text = sp.SoLuong + " sản phẩm sẵn có";
            this.picHinh.Image = Global.ByteArrayToImage(sp.Hinh);
        }
        //private void LoadNB(string mnb) -mnb???
        private void LoadNB()
        {
            DataTable dt = ngbandao.ThongTinNguoiBan(sp.MaNguoiBan);
            foreach (DataRow row in dt.Rows)
            {
                lbltenNB.Text = row[2].ToString();
                lblDiaChiNB.Text = row[7].ToString();
                if (row[9] != DBNull.Value)
                {
                    hinh = (byte[])row[9];
                }
                picHinhNB.Image = Global.ByteArrayToImage(hinh);
                nguoiBan = new NguoiBan((byte[])row[9], row[2].ToString(), sp.MaNguoiBan);
            }
        }
        private void LoadPicClick()
        {
            if (picClick == true)
                Global.TimDo(picHeart);
            else
                Global.TimDen(picHeart);
        }
        private int tinhTrang()
        {
            string str = sp.TinhTrang.Substring(0, sp.TinhTrang.Length - 1);
            int tt = int.Parse(str);
            return tt;
        }
        private void LoadDanhGia()
        {
            DataSet ds = dgdao.HienDanhGia(sp);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                NguoiMua ngmua = new NguoiMua((byte[])row[0], row[1].ToString(), row[2].ToString());
                DanhGia dg = new DanhGia(row[3].ToString(), row[4].ToString(), (DateTime)row[5], row[6].ToString());
                UCDanhGiaCT uc = new UCDanhGiaCT(ngmua,dg);
                fpanelDanhGia.Controls.Add(uc);
            }
        }
        //hien nhieu hinh
        private void LoadHinh()
        {
            DataSet dt = new DataSet();
            dt = spdao.LayHinhAnhTheoMaSanPham(sp.MaSP);
            foreach (DataRow row in dt.Tables[0].Rows)
            {
                byte[] imageBytes = (byte[])row["Hinh"];
                using (MemoryStream mss = new MemoryStream(imageBytes))
                {
                    System.Drawing.Image image = System.Drawing.Image.FromStream(mss);
                    PictureBox pic = Global.CreatePictureBox(image,picHinh);
                    panelThemNhieuHinh.Controls.Add(pic);
                }
            }
            
        }
        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        //thêm sản phẩm vào giỏ hàng
        private void btnThemVaoGio_Click_1(object sender, EventArgs e)
        {
            string slmua = soluongmua.Value.ToString();
            GioHang gh = new GioHang(sp.MaSP,sp.TenSP,sp.GiaBan,int.Parse(slmua),sp.MaNguoiBan,ngmua.Ma,sp.Hinh);
            ghdao.ThemVaoGioHang(gh);
            MessageBox.Show("Đã thêm vào giỏ hàng!");
        }
        //mua ngay
        private void btnMuaNgay_Click(object sender, EventArgs e)
        {
            this.Hide();
            FMuaNgay form2 = new FMuaNgay(sp);
            form2.ShowDialog();
            form2 = null; //tat form2, tuc la form 2 tro ve null
            this.Show();
        }

        private void soluongmua_ValueChanged(object sender, EventArgs e)
        {
            soluongmua.Maximum = int.Parse(sp.SoLuong);
            soluongmua.Minimum = 1;
        }
        private void traitim()
        {
            //false la chua them
            if (picClick) //=true dang la tim do
            {
                Global.TimDen(picHeart);
                YeuThich yt = new YeuThich(sp.MaNguoiBan,ngmua.Ma,sp.MaSP);
                ytdao.XoaYeuThich(yt);
                MessageBox.Show("Đã xóa sản phẩm khỏi yêu thích! TT");
            }
            //ban dau la false nhan vao la true chuyen thanh mau do
            else
            {
                Global.TimDo(picHeart);
                YeuThich yt = new YeuThich(sp.MaNguoiBan, ngmua.Ma, sp.MaSP);
                ytdao.ThemYeuThich(yt);
                MessageBox.Show("Đã thêm sản phẩm vào yêu thích! <3");
            }
        }
        private void picHeart_Click(object sender, EventArgs e)
        {
            traitim();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            FSPNB form2 = new FSPNB(sp,nguoiBan,ngmua);
            form2.ShowDialog();
        }
    }
}
