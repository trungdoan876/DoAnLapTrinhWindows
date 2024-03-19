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
        public FCTSPSua(string maSanPham)
        {
            InitializeComponent();
        }
        public FCTSPSua(SanPham sp)
        {
            InitializeComponent();
            //this.maSanPham = sp.ma;
            ucTextBox4.textBox.Text = sp.ma;
            ucTextBox2.textBox.Text = sp.ten;
            ucTextBox5.textBox.Text = sp.giaBan.ToString();
        }
        private void FCTSPSua_Load(object sender, EventArgs e)
        {

        }
    }
}
