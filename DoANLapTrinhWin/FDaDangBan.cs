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
        NguoiBan ngBan;
        SanPhamDAO spDao = new SanPhamDAO();
        public FDaDangBan(NguoiBan ng)
        {
            InitializeComponent();
            this.ngBan = ng;
            LoadData();
        }
        //Trong bảng SanPham DangBan = 1 -> đã đăng bán
        private void LoadData()
        {
            DataSet dt = spDao.LoadDaDangBan(ngBan);
            int x = 0;
            int y = 0;
            int dem = 0;
            foreach (DataRow row in dt.Tables[0].Rows)
            {
                SanPham sp = new SanPham(row);
                UCSPDangBan ucSPBan = new UCSPDangBan(sp);

                ucSPBan.Location = new Point(x, y);
                dem++;
                x += ucSPBan.Width += 5;
                if (dem == 6)
                {
                    dem = 0;
                    x = 0;
                    y += ucSPBan.Height + 5;
                }
                panelDangBan.Controls.Add(ucSPBan);
            }
        }
        private void FDaDangBan_Load(object sender, EventArgs e)
        {

        }
    }
}
