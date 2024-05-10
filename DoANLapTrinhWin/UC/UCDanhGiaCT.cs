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
        NguoiMua ngmua;
        DanhGia dg;
        DanhGiaDAO dgdao = new DanhGiaDAO();
        Global gt = new Global();
        public UCDanhGiaCT(NguoiMua ng, DanhGia dg)
        {
            InitializeComponent();
            this.ngmua = ng;
            this.picHinhNM.Image = Global.ByteArrayToImage(ng.Hinh);
            this.lblnhanxet.Text = dg.NhanXet;
            this.lblTenNM.Text = ng.Ten1;
            //this.ratingsao.Value = int.Parse(dg.Sao);
            this.dtpNgayDG.Text = dg.Ngaydg.ToString().Trim();
            LoadImagesFromDatabase(ng,dg);
        }

        private void LoadImagesFromDatabase(NguoiMua ng,DanhGia dg)
        {
            DataSet dt = new DataSet();
            dt = dgdao.LayHinhAnhTheoMaSPvaMaNM(ng,dg);
            foreach (DataRow row in dt.Tables[0].Rows)
            {
                byte[] imageBytes = (byte[])row[0];
                using (MemoryStream mss = new MemoryStream(imageBytes))
                {
                    Image image = Image.FromStream(mss);
                    PictureBox pic = Global.CreatePictureBoxNoClickTo(image);
                    panelHinh.Controls.Add(pic);
                }
            }
        }
    }
}
