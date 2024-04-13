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
        //string slmua ;
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
            this.picHinh.Image = ByteArrayToImage(sp.Hinh);
        }

        private void btnXoaKhoiGioHang_Click(object sender, EventArgs e)
        {
            try
            {
                // Ket noi
                conn.Open();
                string sqlStr = string.Format("DELETE FROM GioHang WHERE MaSanPham = '{0}'", sp.MaSP);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("xoa thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("xoa that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        bool check = false;
        private void checkBoxSP_CheckedChanged(object sender, EventArgs e)
        {
            if (check == false) //tick vao checkbox
            {
                check = true;
                try
                {

                    conn.Open();
                    string sqlStr = string.Format("UPDATE GioHang SET TrangThaiSP = '{0}' WHERE MaSanPham = '{1}'", 1, sp.MaSP);
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi:" + ex);
                }
                finally
                {
                    conn.Close();
                }
            }
            else //nhấn vào checkbox 1 lần nữa
            {
                check = false;
                try
                {
                    conn.Open();
                    string sqlStr = string.Format("UPDATE GioHang SET TrangThaiSP = '{0}' WHERE MaSanPham = '{1}'", 0, sp.MaSP);
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi:" + ex);
                }
                finally
                {
                    conn.Close();
                }
            }
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
                int sl = int.Parse(sp.SoLuong);
                if(value < sl)
                {
                    value++;
                    txtSL.Text = value.ToString();
                }
            }
        }

        
    }
    
}
