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
    public partial class FYeuThich : Form
    {
        NguoiMua ngmua;
        SanPhamDAO spDao = new SanPhamDAO();
        public FYeuThich(NguoiMua ngmua)
        {
            InitializeComponent();
            this.ngmua = ngmua;
            LoadYeuThich();
        }

        public void LoadYeuThich()
        {
            DataSet ds = new DataSet();
            ds = spDao.SanPhamYeuThich(ngmua.Ma);
            int x = 0;
            int y = 0;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                SanPham sp = new SanPham(
                    row[1].ToString(), //ma
                    row[2].ToString(), //ten 
                    "đ" + row[3].ToString(), //giaban
                    "đ" + row[4].ToString(),//gia goc
                    row[5].ToString(), //xx
                    row[6].ToString(),//tgsd
                    (DateTime)row[7],//ngdang
                    row[8].ToString(),//mota
                    row[9].ToString(),//nganh hang
                    row[10].ToString(), //tinh trang
                    row[11].ToString(),//dia chi
                    row[12].ToString(),//mnb
                    row[13].ToString(),//sl
                    (byte[])row[0]//hinh
                    );
                UCSP ucSP = new UCSP(sp, ngmua);

                //vi tri moi uc
                ucSP.Location = new Point(x, y);
                x += ucSP.Width += 5;
                if (x == ucSP.Width * 6)
                {
                    x = 0;
                    y += ucSP.Height + 5;
                }
                panelYeuThich.Controls.Add(ucSP);
            }
        }
    }
}
