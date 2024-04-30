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
    public partial class UCSPGioHang : UserControl
    {
        SanPham sp;
        string slmua ;
        GioHangDAO ghDAO = new GioHangDAO();
        Image ByteArrayToImage(byte[] a)
        {
            MemoryStream ms = new MemoryStream(a);
            return Image.FromStream(ms);
        }
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public UCSPGioHang(SanPham sanpham)
        {
            InitializeComponent();
            this.sp = sanpham;
            this.lblTenSP.Text = sp.TenSP;
            this.lblGiaTien.Text = "đ" + sp.GiaBan;
            this.lblTinhTrang.Text = sp.TinhTrang;
            this.lblSoLuong.Text = sp.SoLuong+" san pham san co";
            this.lblgia.Text = "đ" + sp.GiaGoc;
            this.lblDiaChi.Text = sp.DiaChi;
            //xoa chu %
            string str = sp.TinhTrang.Substring(0, sp.TinhTrang.Length - 1);
            int tt = int.Parse(str);
            this.vongtrontt.Value = tt;
            this.picHinh.Image = ByteArrayToImage(sp.Hinh);
        }
        bool check = false;
        private void checkBoxSP_CheckedChanged(object sender, EventArgs e)
        {
            if (check == false) //tick vao checkbox
            {
                check = true;
                GioHang gh = new GioHang(sp.MaSP);
                ghDAO.CapNhatChonSanPham(gh);
            }
            else //nhấn vào checkbox 1 lần nữa
            {
                check = false;
                GioHang gh = new GioHang(sp.MaSP);
                ghDAO.CapNhatKhongchon(gh);
            }
        }
        private void soluongmuaGH_ValueChanged(object sender, EventArgs e)
        {
            soluongmuaGH.Minimum = 1;
            soluongmuaGH.Maximum = int.Parse(sp.SoLuong);
            slmua = soluongmuaGH.Value.ToString();
            try
            {
                // Ket noi
                conn.Open();

                string sqlStr = string.Format("UPDATE GioHang SET SoLuong = '{0}' WHERE MaSanPham = '{1}'", slmua, sp.MaSP);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.ExecuteNonQuery();

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

        private void btnXoaKhoiGioHang_Click_1(object sender, EventArgs e)
        {
            GioHang gh = new GioHang(sp.MaSP);
            ghDAO.XoaGioHang(gh);
        }
    }
}
