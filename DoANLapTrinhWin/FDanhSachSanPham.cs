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
        //tạo mã sản phẩm
        public string TaoMa(string Table, string maBanDau)
        {
            DataSet ds = spDao.TaoMaSP(Table);
            string ma = "";
            if (ds.Tables[0].Rows.Count <= 0)
            {
                ma = maBanDau + "01";
            }
            else
            {
                int k;
                ma = maBanDau; //="NB0"
                k = Convert.ToInt32(ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1][1].ToString().Trim().Substring(2));
                k = k + 1;
                if(k<10)
                   ma = ma + "0";
                ma = ma + k.ToString();
            }
            return ma;
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            SanPham sanPham = new SanPham(TaoMa("SanPham", "SP"));
            Global.MoFormCon(new FThemSanPham(ngBan, sanPham), panelTatCaSP);
        }
    }
}
