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
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        string maNB;
        byte[] hinh;
        SanPhamDAO spDao = new SanPhamDAO();
        Image ByteArrayToImage(byte[] a)
        {
            MemoryStream ms = new MemoryStream(a);
            return Image.FromStream(ms);
        }
        public FDanhSachSanPham(string maNB)
        {
            InitializeComponent();
            this.maNB = maNB;
            LoadData();
        }
        //đổ dữ liệu vào user control trong danh sách sản phẩm
        private void LoadData()
        {
            DataSet dt = spDao.LoadDanhSachSanPham(maNB);
            int x = panelThem.Width + 5;
            int y = 0;
            foreach (DataRow row in dt.Tables[0].Rows)
            {
                SanPham sp = new SanPham(
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
                    ) ;
                UCSPBan ucSPBan = new UCSPBan(sp);
                ucSPBan.Location = new Point(x, y);
                x += ucSPBan.Width  + 5;
                if (x == ucSPBan.Width * 4)
                {
                    x = 0;
                    y += ucSPBan.Height + 5;
                }
                panelTatCaSP.Controls.Add(ucSPBan);
             }
        }
        private void FTatCaSanPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            Global.MoFormCon(new FThemSanPham(maNB),panelTatCaSP);
        }
    }
}
