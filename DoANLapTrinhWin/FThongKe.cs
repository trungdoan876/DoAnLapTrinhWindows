using DoANLapTrinhWin.ClassDAO;
using Guna.Charts.WinForms;
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
    public partial class FThongKe : Form
    {
        ThongKeDAO tkDao = new ThongKeDAO();
        string ten;
        public FThongKe()
        {
            InitializeComponent();
            TheoThangg();
            BestSeller();
            
        }
        public void TheoThangg()
        {
            DataSet ds = tkDao.LayThongKe();
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                int thangTrongNam = Convert.ToInt32(r[0]); //tháng trong năm
                int x = thangTrongNam;
                chartTheoThang.DataPoints[x - 1].Y = (int)r[1]; //số lần bán
            }
        }
        public void BestSeller()
        {
            DataSet ds = tkDao.LayBestSeller();
            int x = 0;
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                chartBestSeller.DataPoints[x].Y = (int)r["LuotMua"]; //số lần bán
                ten = r["TenSanPham"].ToString();
                if(x==0)
                    lblsp0.Text = ten;
                if (x == 1)
                    lblsp1.Text = ten;
                if (x ==2)
                    lblsp2.Text = ten;
                if (x == 3)
                    lblsp3.Text = ten;
                if (x == 4)
                    lblsp4.Text = ten;
                x += 1;

            }
            MessageBox.Show(x.ToString());
                lblsp0.Text = ten;
        }
    }
}
