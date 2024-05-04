using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.Mime.MediaTypeNames;

namespace DoANLapTrinhWin
{
    public partial class UCSP : UserControl
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        SanPham sp;
        YeuThichDAO ytdao = new YeuThichDAO();
        Global gl = new Global();
        NguoiBan ngban;
        string tenTK;
        private void UCSP_Load(object sender, EventArgs e)
        {

        }
        public UCSP()
        {
               InitializeComponent();
        }
        public UCSP(SanPham sp,string tenTK)
        {
            this.sp = sp;
            this.tenTK= tenTK;
            InitializeComponent();
            this.lblMaSP.Text = sp.MaSP;
            this.lblTenSP.Text = sp.TenSP;
            this.lblGiaBan.Text =  sp.GiaBan ;
            this.lblGiaGoc.Text =  sp.GiaGoc ;
            this.lblDiaChi.Text = sp.DiaChi;
            this.picHinh.Image = Global.ByteArrayToImage(sp.Hinh);
        }
        private void UCSP_Click(object sender, EventArgs e)
        {
            this.Hide(); //an form 1
            FCTSP formCTSP = new FCTSP(sp,picClick,tenTK);
            formCTSP.ShowDialog();
            formCTSP = null;
            this.Show();  
        }
        bool picClick;
        private void traitim()
        {
            //false la chua them
            if (picClick) //=true dang la tim do
            {
                Global.TimDen(picHeart);
                YeuThich yt = new YeuThich(sp.MaNguoiBan, tenTK, sp.MaSP);
                ytdao.XoaYeuThich(yt);
            }
            //ban dau la false nhan vao la true chuyen thanh mau do
            else
            {
                Global.TimDo(picHeart);
                YeuThich yt = new YeuThich(sp.MaNguoiBan, tenTK, sp.MaSP);
                ytdao.ThemYeuThich(yt);
            }
        }

        private void picHeart_Click(object sender, EventArgs e)
        {
            traitim();
        }
        private void UCSP_Load_1(object sender, EventArgs e)
        {
            LoadTT();
        }
        private void LoadTT()
        {
            MessageBox.Show("huhu");
            DataSet dtSet = ytdao.HienYeuThich();
            foreach (DataRow row in dtSet.Tables[0].Rows)
            {
                if (row[0].ToString() == sp.MaSP && row[1].ToString().Trim() == tenTK.Trim())
                {
                    Global.TimDo(picHeart);
                    picClick = true;
                    break;
                }
                else
                {
                    Global.TimDen(picHeart);
                    picClick = false;
                }
            }
        }
    }
}
