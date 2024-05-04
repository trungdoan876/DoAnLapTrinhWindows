using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoANLapTrinhWin
{
    public partial class FSPNB : Form
    {
        SanPham sp;
        SanPhamDAO spdao = new SanPhamDAO();
        NguoiBan ngban;
        NguoiMua ngmua;
        NguoiDAO ngDao = new NguoiDAO();
        public FSPNB()
        {
            InitializeComponent();
        }
        public FSPNB(SanPham sp, NguoiBan ngBan,NguoiMua ngMua)
        {
            InitializeComponent();
            this.Size = new Size(1200, 600);
            this.sp = sp;
            this.ngban = ngBan;
            this.ngmua = ngMua;
            LayThongTinNB();
            LoadSP();
        }
        public void LoadSP()
        {
            DataSet dt = spdao.TatCaSanPhamNB(sp);

            panelSPNB.AutoScroll = true;
            int x = 0;
            int y = 0;
            foreach (DataRow row in dt.Tables[0].Rows)
            {
                SanPham sp = new SanPham
                (
                    row[1].ToString(),
                    row[2].ToString(),
                    "đ" + row[3].ToString(),
                    "đ" + row[4].ToString(),
                    row[5].ToString(),
                    row[6].ToString(),
                    (DateTime)row[7],
                    row[8].ToString(),
                    row[9].ToString(),
                    row[10].ToString(),
                    row[13].ToString(),
                    row[12].ToString(),
                    row[14].ToString(),
                    (byte[])row[0]
                );
                UCSP ucSP = new UCSP(sp,ngmua); //sao truyền manb dô đây z 
                //vi tri moi uc
                ucSP.Location = new Point(x, y);
                x += ucSP.Width + 5;
                if (x == ucSP.Width * 4)
                {
                    x = 0;
                    y += ucSP.Height + 5;
                }
                panelSPNB.Controls.Add(ucSP);
            }
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LayThongTinNB()
        {
            DataSet ds = ngDao.LayThongTin(ngban);
            foreach(DataRow r in ds.Tables[0].Rows)
            {
                this.picHinhNB.Image = Global.ByteArrayToImage((byte[])r[0]);
                this.lbltenNB.Text = r[1].ToString();
            }    
        }
    }
}
