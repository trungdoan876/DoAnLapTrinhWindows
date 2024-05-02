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

namespace DoANLapTrinhWin
{
    public partial class UCDanhGiaCT : UserControl
    {
        string ten, nx;
        int sao;
        byte[] hinh;
        string masp;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        NguoiMua ngmua;
        DanhGia dg;
        DanhGiaDAO dgdao = new DanhGiaDAO();
        Global gt = new Global();
        public UCDanhGiaCT(NguoiMua ng, DanhGia dg,string masp)
        {
            InitializeComponent();
            this.ten = ng.Ten1;
            this.nx = dg.NhanXet;
            this.sao = dg.Sao1;
            this.hinh = ng.Hinh;
            this.masp = masp;
            this.picHinhNM.Image = Global.ByteArrayToImage(ng.Hinh);
            this.lblnhanxet.Text = dg.NhanXet;
            this.lblTenNM.Text = ng.Ten1;
            this.ratingsao.Value = dg.Sao1;
             this.dtpNgayDG.Text = dg.Ngaydg.ToString();
            LoadImagesFromDatabase(masp,ng.Ma,dg.Ngaydg.ToString());
        }

        private void LoadImagesFromDatabase(string masp,string manm,string ngaydg)
        {
            try
            {
                //MessageBox.Show(manm);
                DataSet dt = new DataSet();
                dt = dgdao.LayHinhAnhTheoMaSPvaMaNM(masp,manm,ngaydg);
                foreach (DataRow row in dt.Tables[0].Rows)
                {
                    byte[] imageBytes = (byte[])row["Hinh"];
                    using (MemoryStream mss = new MemoryStream(imageBytes))
                    {
                        Image image = Image.FromStream(mss);
                        PictureBox pic = Global.CreatePictureBoxNoClick(image);
                        panelHinh.Controls.Add(pic);
                    }
                }
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
