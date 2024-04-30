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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DoANLapTrinhWin
{
    public partial class FDanhGia : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        SanPham sp;
        DonHang dh;
        string maDH;
        byte[] hinh;
        private List<System.Drawing.Image> arrPicture = new List<System.Drawing.Image>();
        private List<string> maSanPhamList = new List<string>();

        System.Drawing.Image ByteArrayToImage(byte[] a)
        {
            MemoryStream ms = new MemoryStream(a);
            return System.Drawing.Image.FromStream(ms);
        }
        
        public FDanhGia(string maDH, DonHang dh)
        {
            InitializeComponent();
            this.maDH = maDH;
            this.dh = dh;
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT MaDonHang, SanPham.MaSanPham,SanPham.TenSanPham, ChiTietDonHang.SoLuong AS slmua, ChiTietDonHang.GiaTien AS gtien, SanPham.Hinh " +
                                "FROM ChiTietDonHang, SanPham " +
                                "WHERE SanPham.MaSanPham = ChiTietDonHang.MaSanPham AND ChiTietDonHang.MaDonHang = '{0}'", maDH);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dtSet = new DataSet();
                adapter.Fill(dtSet);

                foreach (DataRow row in dtSet.Tables[0].Rows)
                {
                    string maSP = row["MaSanPham"].ToString();
                    string maDH = row["MaDonHang"].ToString();
                    string tenSP = row["TenSanPham"].ToString();
                    string giaTien = row["gtien"].ToString();
                    string soLuong = row["slmua"].ToString();
                    if (row["Hinh"] != DBNull.Value)
                    {
                        hinh = (byte[])row["Hinh"];
                    }
                    SanPham sp = new SanPham(maSP,tenSP, giaTien, soLuong, hinh);
                    maSanPhamList.Add(maSP);
                    UCDanhGiaNhieuSP uc = new UCDanhGiaNhieuSP(sp,dh);
                    fpanelSP.Controls.Add(uc);

                }
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnguii_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                foreach (string maSanPham in maSanPhamList)
                {
                    string maSP = maSanPham.ToString();
                    // Lấy thông tin đánh giá từ UserControl
                    bool daXuLy = false;
                    foreach (Control control in fpanelSP.Controls)
                    {
                        if (control is UCDanhGiaNhieuSP uc) //xet tung cai uc trong panel de danh gia
                        {
                            if (daXuLy==true) //kiem tra neu da xet thi bo qua
                                continue;
                            else
                            {
                                string maNguoiMua = dh.MaNguoiMua;
                                double sao = uc.ratingsp.Value;
                                double saoNguoiBan = uc.ratingnguoiban.Value;
                                double saoGiaoHang = uc.ratinggiaohang.Value;
                                string danhGia = uc.txtDanhGia.Text;
                                arrPicture = uc.arrPicture;

                                // Thực hiện chèn dữ liệu vào cơ sở dữ liệu
                                string sql = string.Format("INSERT INTO DanhGia (MaSanPham, MaNguoiMua, sao, saonguoiban, saogiaohang, nhanxet) " +
                                                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', N'{5}')",maSP, maNguoiMua, sao, saoNguoiBan, saoGiaoHang, danhGia);
                                SqlCommand cmd = new SqlCommand(sql, conn);
                                cmd.ExecuteNonQuery();
                                foreach (System.Drawing.Image image in arrPicture)
                                {
                                    using (MemoryStream ms = new MemoryStream())
                                    {
                                        image.Save(ms, image.RawFormat);
                                        byte[] imageBytes = ms.ToArray();
                                        string anh = BitConverter.ToString(imageBytes).Replace("-", "");
                                        string sql1 = string.Format("INSERT INTO HinhDanhGia (MaNguoiMua,MaSanPham, Hinh) VALUES ('{0}', '{1}', 0x{2})",maNguoiMua, maSP, anh);
                                        SqlCommand cmd1 = new SqlCommand(sql1, conn);
                                        cmd1.ExecuteNonQuery();
                                    }
                                }
                            }
                            daXuLy = true;
                        }
                    }
                }
                MessageBox.Show("Đã gửi đánh giá thành công");
                this.Close(); // Đóng Form sau khi gửi đánh giá
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }


        }
    }

}
