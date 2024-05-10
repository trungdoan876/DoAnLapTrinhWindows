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
                SanPham sp = new SanPham(row);
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
