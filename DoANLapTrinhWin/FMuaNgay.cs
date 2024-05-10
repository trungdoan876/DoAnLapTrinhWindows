using DoANLapTrinhWin.Class;
using DoANLapTrinhWin.ClassDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Media;

namespace DoANLapTrinhWin
{
    public partial class FMuaNgay : Form
    {
        SanPham sp;
        NguoiBan ngBan;
        NguoiMua ngmua;
        NguoiMuaDAO ngmuadao = new NguoiMuaDAO();
        NguoiBanDAO ngbandao = new NguoiBanDAO();
        ThongKeDAO tkDao = new ThongKeDAO();
        DonHangDAO dhDao = new DonHangDAO();
        DateTime ngayhientai = DateTime.Now;
        ChiTietDonHangDAO ctdhDao = new ChiTietDonHangDAO();
        
        int slmua;
        string trangthai;
        public FMuaNgay()
        {
            InitializeComponent();
        }
        public FMuaNgay(SanPham sp, NguoiBan ngBan, NguoiMua ngmua,int slmua)
        {
            InitializeComponent();
            this.Size = new Size(1000, 500);
            this.sp = sp;
            this.ngBan = ngBan;
            this.ngmua = ngmua;
            this.slmua = slmua;
            LoadData();
        }
        private void LoadData()
        {
            UCSPGioHang ucgh = new UCSPGioHang(sp,ngmua,"True");
            ucgh.soluongmuaGH.Value= slmua;
            ucgh.soluongmuaGH.Enabled = false;
            panelSP.Controls.Add(ucgh);
            //ng ban
            DataTable ds = ngbandao.ThongTinNguoi(ngBan);
            foreach (DataRow row in ds.Rows)
                lblDiaChiNB.Text = row[7].ToString();
            picHinhNB.Image = Global.ByteArrayToImage(ngBan.Hinh);
            lbltenNB.Text = ngBan.Ten1;
            //dc
            DataTable dt = ngmuadao.ThongTinNguoi(ngmua);
            foreach (DataRow row in dt.Rows)
                txtDC.Text = row[6].ToString();
            //tien
            lblSLMua.Text = "Tổng số tiền (" + slmua.ToString() + " sản phẩm): ";

            lblTien.Text = "đ" + tinhTien(sp) ;
        }
        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //dung cho thong ke
        private void TinhSoLuotMuaSanPham(SanPham sanPham)
        {
            DataTable dta = tkDao.SoLuotMua(sanPham.MaSP);
            int soLuot;
            if (dta.Rows.Count > 0)
            {
                soLuot = Convert.ToInt32(dta.Rows[0][0]); // +1; //dta.Rows[0][0] là giá trị của cột đầu tiên của hàng đó.
            }
            else
            {
                soLuot = 0;
            }
            if (soLuot == 0)
            {
                tkDao.ThemLuotMua(sanPham.MaSP, sanPham.MaNguoiBan, soLuot + 1);
            }
            else //nếu đã có, cập nhật tuần suất lên 1
            {
                tkDao.CapNhatLuotMua(sanPham.MaSP, soLuot + 1);
            }
        }
        private void TinhSoLanBanSanPham(SanPham sanPham)
        {
            DataTable dta = tkDao.LaySoLanBanRaTheoNgay(sanPham.MaNguoiBan);
            int k = tkDao.KiemTraNgay(ngayhientai);
            int soLan;
            if (dta.Rows.Count > 0 && k > 0)
            {
                soLan = Convert.ToInt32(dta.Rows[0][0]); // +1; //dta.Rows[0][0] là giá trị của cột đầu tiên của hàng đó.
            }
            else
            {
                soLan = 0;
            }
            if (soLan == 0 && k == 0)
            {
                ThongKe tk = new ThongKe(sanPham.MaNguoiBan, DateTime.Now, soLan + 1);
                tkDao.ThemSoLanBan(tk);
            }
            else //nếu đã có, cập nhật tuần suất lên 1
            {
                ThongKe tk = new ThongKe(sanPham.MaNguoiBan, DateTime.Now, soLan + 1);
                tkDao.CapNhatSoLanBan(tk);
            }
        }
        public string TaoMaDonHang()
        {
            DataSet ds = dhDao.TaoMaDonHang();

            string ma = "";
            if (ds.Tables[0].Rows.Count <= 0)
            {
                ma = "DH01";
            }
            else
            {
                int k;
                ma = "DH";
                k = Convert.ToInt32(ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1][0].ToString().Substring(2));
                k = k + 1;
                if (k < 10)
                    ma = ma + "0";
                ma = ma + k.ToString();
                //MessageBox.Show(ma);
            }
            return ma;
        }
        private void DatHang_Click(object sender, EventArgs e)
        {
            if (cmbThanhToan.Text == "Chuyển khoản")
            {
                trangthai = "Đã thanh toán";
                FChuyenKhoan fdh = new FChuyenKhoan(ngmua, sp, tinhTien(sp));
                fdh.ShowDialog();
            }
            else
            {
                trangthai = "Chưa thanh toán";
            }
            string maDonHang = TaoMaDonHang();
            DonHang dh = new DonHang(maDonHang, sp.MaNguoiBan, ngmua.Ma, tinhTien(sp).ToString(), ngayhientai, "Đặt hàng thành công", "Chuẩn bị hàng");
            dhDao.TaoDonHang(dh);

            TinhSoLanBanSanPham(sp);
            TinhSoLuotMuaSanPham(sp);

            decimal totalValue = tinhTien(sp);
            ChiTietDonHang ct = new ChiTietDonHang(maDonHang, sp.MaSP, sp.SoLuong, totalValue.ToString(), sp.TenSP, sp.Hinh);
            ctdhDao.ThemVaoChiTiet(ct);
            MessageBox.Show("Đặt hàng thành công");
        }
        private decimal tinhTien(SanPham sanPham)
        {
            int soLuong = slmua;

            string giaban = sanPham.GiaBan;
            decimal giatien = decimal.Parse(giaban);

            // Tính giá trị tổng tiền
            decimal totalValue = soLuong * giatien;
            return totalValue;
        }
    }
}

      
