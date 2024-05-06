using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoANLapTrinhWin
{
    public partial class FMuaNgay : Form
    {
        SanPham sp;
        NguoiBan ngBan;
        NguoiMua ngmua;
        NguoiMuaDAO ngmuadao = new NguoiMuaDAO();
        NguoiBanDAO ngbandao = new NguoiBanDAO();
        int slmua;
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
            UCSPGioHang ucgh = new UCSPGioHang(sp);
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
            lblTien.Text = sp.GiaBan;
        }
        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DatHang_Click(object sender, EventArgs e)
        {

        }
    }
}

      
