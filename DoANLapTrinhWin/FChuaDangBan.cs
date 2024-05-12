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
    public partial class FChuaDangBan : Form
    {
        NguoiBan ngBan;
        SanPhamDAO spDao = new SanPhamDAO();
        public FChuaDangBan(NguoiBan ngBan)
        {
            InitializeComponent();
            this.ngBan = ngBan;
            LoadData();
        }
        //DangBan trong bang SP = 0 -> chua dang ban
        public void LoadData()
        {
            DataSet dt = spDao.LoadChuaDangBan(ngBan);
            int x = 0;
            int y = 0;
            int maxPerRow = 6;
            int ucCount = 0;
            foreach (DataRow row in dt.Tables[0].Rows)
            {
                SanPham sp = new SanPham(row);
                UCSPBan ucSPBan = new UCSPBan(sp);
                ucCount++;
                ucSPBan.Location = new Point(x, y);
                x += ucSPBan.Width += 5;
                
                if (ucCount == maxPerRow)
                {
                     x = 0;
                     y += ucSPBan.Height + 5;
                     ucCount = 0;
                }
                panelChuaDangBan.Controls.Add(ucSPBan);
            }
        }
    }
}

