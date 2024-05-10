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
    public partial class FDaGiaoNB : Form
    {
        NguoiBan ngban;
        DonHangDAO dhDao = new DonHangDAO();
        public FDaGiaoNB(NguoiBan ngBan)
        {
            InitializeComponent();
            this.ngban = ngBan;
            LoadData();
        }
        public void LoadData()
        {
            DataSet dt = dhDao.CapNhatGHThanhCongNB(ngban); //them manb de hien len theo manb
            foreach (DataRow row in dt.Tables[0].Rows)
            {
                DonHang dh = new DonHang(row);
                SanPham sp = new SanPham(row[4].ToString(),(byte[])row[5]);
                UCDonHangNB uc = new UCDonHangNB(dh, sp);
                panelDaGiao.Controls.Add(uc);
            }
        }
    }
}
