using DoANLapTrinhWin.Class;
using DoANLapTrinhWin.ClassDAO;
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
        byte[] hinh;
        DonHang dh;
        DanhGiaDAO dgdao = new DanhGiaDAO();
        HinhDanhGiaDAO hdgdao = new HinhDanhGiaDAO();
        private List<string> maSanPhamList = new List<string>();
        private List<System.Drawing.Image> arrPicture = new List<System.Drawing.Image>();
        public FDanhGia(DonHang dh)
        {
            InitializeComponent();
            this.Size = new Size(1250,700);
            this.dh = dh;
            LoadData();
        }
        public void LoadData()
        {
            DataSet ds = dgdao.LoadThongTinSanPham(dh);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                SanPham sp = new SanPham(
                    row[1].ToString(),
                    row[2].ToString(),
                    row[3].ToString(),
                    row[4].ToString(),
                    (byte[])row[5]
                    );
                maSanPhamList.Add(row[1].ToString());
                UCDanhGiaNhieuSP uc = new UCDanhGiaNhieuSP(sp, dh);
                fpanelSP.Controls.Add(uc);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnguii_Click(object sender, EventArgs e)
        {
            foreach (string maSanPham in maSanPhamList)
            {
                string maSP = maSanPham.ToString();  // Lấy thông tin đánh giá từ UserControl
                bool daXuLy = false;
                foreach (Control control in fpanelSP.Controls)
                {
                    if (control is UCDanhGiaNhieuSP uc) //xet tung cai uc trong panel de danh gia
                    {
                        if (daXuLy == true) //kiem tra neu da xet thi bo qua
                            continue;
                        else
                        {
                            string maNguoiMua = dh.MaNguoiMua;
                            float sao = uc.ratingsp.Value;
                            float saoNguoiBan = uc.ratingnguoiban.Value;
                            float saoGiaoHang = uc.ratinggiaohang.Value;
                            string danhGia = uc.txtDanhGia.Text;
                            arrPicture = uc.arrPicture;
                            // chèn vào bảng đánh giá

                            DanhGia dg = new DanhGia(maNguoiMua, maSP, sao.ToString(), saoNguoiBan.ToString(), saoGiaoHang.ToString(), danhGia, DateTime.Now);
                            dgdao.ThemDanhGia(dg);
                            foreach (System.Drawing.Image image in arrPicture)
                            {
                                using (MemoryStream ms = new MemoryStream())
                                {
                                    image.Save(ms, image.RawFormat);
                                    byte[] imageBytes = ms.ToArray();
                                    HinhDanhGia hdg = new HinhDanhGia(maNguoiMua, maSanPham, imageBytes, DateTime.Now);
                                    hdgdao.ThemHinhDanhGia(hdg);
                                }
                            }
                            daXuLy = true;
                        }
                        //daXuLy = true;
                    }
                }
            }
            MessageBox.Show("Đã gửi đánh giá thành công");
            this.Close(); // Đóng Form sau khi gửi đánh gi
        }
    }

}
