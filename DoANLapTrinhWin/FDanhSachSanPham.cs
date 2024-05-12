using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace DoANLapTrinhWin
{
    public partial class FDanhSachSanPham : Form
    {
        NguoiBan ngBan;
        SanPhamDAO spDao = new SanPhamDAO();
        public FDanhSachSanPham(NguoiBan ngban)
        {
            InitializeComponent();
            this.ngBan = ngban;
            LoadData();
        }
        //đổ dữ liệu vào user control trong danh sách sản phẩm
        private void LoadData()
        {
            DataSet dt = spDao.LoadDanhSachSanPham(ngBan);
            int x = panelThem.Width + 5;
            int y = 0;
            foreach (DataRow row in dt.Tables[0].Rows)
            {
                SanPham sp = new SanPham(row);
                UCSPBan ucSPBan = new UCSPBan(sp);
                //chỉnh vị trí uc
                ucSPBan.Location = new Point(x, y);
                x += ucSPBan.Width  + 5;
                if (x + ucSPBan.Width > panelTatCaSP.Width)
                {
                    x = 0;
                    y += ucSPBan.Height + 5;
                }
                panelTatCaSP.Controls.Add(ucSPBan);
             }
        }
        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            SanPham sanPham = new SanPham(spDao.TaoMaSanPham());
            Global.MoFormCon(new FThemSanPham(ngBan, sanPham), panelTatCaSP);
        }
    }
}
