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
        string loainguoi;
        string sdt;
        NguoiBanDAO ngdao = new NguoiBanDAO();
        NguoiMuaDAO ngmuadao = new NguoiMuaDAO();
        NguoiDAO nguoidao = new NguoiDAO();
        public FThongTinDangKy(string loainguoi, string sdt)
        {
            InitializeComponent();
            this.loainguoi = loainguoi;
            this.sdt = sdt;
        }
        public string TaoMa(string Table, string maBanDau)
        {
            DataSet dt = nguoidao.TaoMa(Table);
            string ma = "";
            if (dt.Tables[0].Rows.Count <= 0)
            {
                ma = maBanDau + "1";
            }
            else
            {
                int k;
                ma = maBanDau; //="NB01"
                k = Convert.ToInt32(dt.Tables[0].Rows[dt.Tables[0].Rows.Count - 1][0].ToString().Substring(2));
                k = k + 1;
                if (k < 10)
                    ma = ma + "0";
                ma = ma + k.ToString();
            }
            return ma;
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            byte[] b = Global.ImageToByteArray(picHinh.Image);
            if (loainguoi == "Bán hàng")
            {
                string maNB = TaoMa("NguoiBan", "NB");
                NguoiBan ngban = new NguoiBan(maNB, txtMK.Text, txtHoTen.Text, sdt, dtpNgSinh.Value, txtGioiTinh.Text, txtCCCD.Text, txtDiaChi.Text, b);
                ngdao.DangKy(ngban);
                MessageBox.Show("Đăng kí tài khoản bán hàng thành công!!");
            }
            else
            {
                string maNM = TaoMa("NguoiMua", "NM");
                NguoiMua ng = new NguoiMua(maNM, txtMK.Text, txtHoTen.Text, sdt, dtpNgSinh.Value, txtGioiTinh.Text, txtCCCD.Text, txtDiaChi.Text, b);
                ngmuadao.DangKy(ng);
                MessageBox.Show("Đăng kí tài khoản mua hàng thành công!!");
            } 
        }
        private void btnThemHinh_Click(object sender, EventArgs e)
        {
            picHinh.Image = Global.CreateOpenFileDialog(picHinh);  
        }
    }
}
