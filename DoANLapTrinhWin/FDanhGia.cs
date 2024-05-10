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
            for (int i = 0; i < maSanPhamList.Count && i < fpanelSP.Controls.Count; i++)
            {
                string maSanPham = maSanPhamList[i].ToString();
                UCDanhGiaNhieuSP uc = fpanelSP.Controls[i] as UCDanhGiaNhieuSP;

                DanhGia dg = new DanhGia(dh.MaNguoiMua, maSanPham, uc.ratingsp.Value.ToString(), uc.ratingnguoiban.Value.ToString(),
                    uc.ratinggiaohang.Value.ToString(), uc.txtDanhGia.Text, DateTime.Now);
                dgdao.ThemDanhGia(dg);

                foreach (System.Drawing.Image image in uc.arrPicture)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        image.Save(ms, image.RawFormat);
                        byte[] imageBytes = ms.ToArray();
                        HinhDanhGia hdg = new HinhDanhGia(dh.MaNguoiMua, maSanPham, imageBytes, DateTime.Now);
                        hdgdao.ThemHinhDanhGia(hdg);
                    }
                }
            }
            MessageBox.Show("Đã gửi đánh giá thành công");
            this.Close(); // Đóng Form sau khi gửi đánh giá
        }
    }

}
