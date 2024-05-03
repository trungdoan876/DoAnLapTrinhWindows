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
        SanPhamDAO spDao = new SanPhamDAO();
        string tenTK;
        public FYeuThich(string tenTK)
        {
            InitializeComponent();
            this.tenTK = tenTK;
            LoadYeuThich();
        }

        public void LoadYeuThich()
        {
            DataSet ds = new DataSet();
            ds = spDao.SanPhamYeuThich(tenTK);
            int x = 0;
            int y = 0;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                SanPham sp = new SanPham(
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
                UCSP ucSP = new UCSP(sp, tenTK);

                //vi tri moi uc
                ucSP.Location = new Point(x, y);
                x += ucSP.Width += 5;
                if (x == ucSP.Width * 3)
                {
                    x = 0;
                    y += ucSP.Height + 5;
                }
                panelYeuThich.Controls.Add(ucSP);
            }
        }
    }
}
