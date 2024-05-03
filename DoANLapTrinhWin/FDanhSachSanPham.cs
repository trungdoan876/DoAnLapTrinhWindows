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
            DataSet dt = spDao.LoadDanhSachSanPham(ngBan.Ma);
            int x = panelThem.Width + 5;
            int y = 0;
            foreach (DataRow row in dt.Tables[0].Rows)
            {
                SanPham sp = new SanPham(
                    row[1].ToString(), //masp
                    row[2].ToString(), //ten
                    row[3].ToString(), //gia ban
                    row[4].ToString(), //gia goc
                    row[5].ToString(), //xuat xu
                    row[6].ToString(),//tgsd
                    (DateTime)row[7],
                    row[8].ToString(), //mota
                    row[9].ToString(), //nganh hang
                    row[10].ToString(), //tinh trang
                    row[13].ToString(), //dang ban 
                    row[12].ToString(), //manb
                    row[14].ToString(),// dia chi //soluong
                    (byte[])row[0] //hinh
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
            Global.MoFormCon(new FThemSanPham(ngBan.Ma),panelTatCaSP);
        }
    }
}
