using DoANLapTrinhWin.UC;
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
    public partial class FDaGiaoNM : Form
    {
        DonHangDAO dhDao = new DonHangDAO();
        byte[] hinh;
        string maNM;
        public FDaGiaoNM(string maNM)
        {
            InitializeComponent();
            this.maNM = maNM;
            LoadData();
        }
        public void LoadData()
        {
            DataSet dt = new DataSet();
            dt = dhDao.DaGiaoNM(maNM); //them manb de hien len theo manb
            foreach (DataRow row in dt.Tables[0].Rows)
            {
                DonHang dh = new DonHang(row[2].ToString(), row[3].ToString(), (DateTime)row[4], row[5].ToString(), row[0].ToString());
                SanPham sp = new SanPham(row[6].ToString(), (byte[])row[7], row[1].ToString());
                UCDaGiaoNM uc = new UCDaGiaoNM(sp, dh);

                panelDaGiao.Controls.Add(uc);
            }
        }
    }
}
