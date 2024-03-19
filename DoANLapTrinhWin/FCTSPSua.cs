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
    public partial class FCTSPSua : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public string maSanPham;
        //UCSPBan uCSPBan = new UCSPBan();
        public FCTSPSua(string maSanPham)
        {
            InitializeComponent();
            this.maSanPham = maSanPham; 
            ucTextBox4.textBox.Text = maSanPham;
        }
        private void FCTSPSua_Load(object sender, EventArgs e)
        {
            /*try
            {
                conn.Open();
                //string sqlStr = string.Format("SELECT *FROM SanPham WHERE maSanPham ={0}",);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dtSet = new DataSet();

            }*/
        }
    }
}
