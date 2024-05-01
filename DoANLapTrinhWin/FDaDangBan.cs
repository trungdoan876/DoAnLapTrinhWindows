using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoANLapTrinhWin
{
    public partial class FDaDangBan : Form
    {
        string maNB;
        byte[] hinh;
        SanPhamDAO spDao = new SanPhamDAO();
        public FDaDangBan(string maNB)
        {
            InitializeComponent();
            this.maNB = maNB;
        }
        //Trong bảng SanPham DangBan = 1 -> đã đăng bán
        private void LoadData()
        {
            DataSet dt = spDao.LoadDaDangBan(maNB);
            int x = 0;
            int y = 0;
            foreach (DataRow row in dt.Tables[0].Rows)
            {
                SanPham sp = new SanPham
                (
                    row[1].ToString(),
                    row[2].ToString(),
                    row[3].ToString(),
                    row[4].ToString(),
                    row[5].ToString(),
                    row[6].ToString(),
                    (DateTime)row[7],
                    row[8].ToString(),
                    row[9].ToString(),
                    row[10].ToString(),
                    row[11].ToString(),
                    row[12].ToString(),
                    row[13].ToString(),
                    (byte[])row[0]
                );
                UCSPDangBan ucSPBan = new UCSPDangBan(sp);

                ucSPBan.Location = new Point(x, y);
                x += ucSPBan.Width += 5;
                if (x == ucSPBan.Width * 3)
                {
                    x = 0;
                    y += ucSPBan.Height + 5;
                }
                panelDangBan.Controls.Add(ucSPBan);
            }
        }
        private void FDaDangBan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
