using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DoANLapTrinhWin
{
    public partial class FThongTinDangKy : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        string loainguoi;
        string sdt;
        public FThongTinDangKy(string loainguoi, string sdt)
        {
            InitializeComponent();
            this.loainguoi = loainguoi;
            this.sdt = sdt;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                /*if (loainguoi == "Bán hàng")
                {
                    string sql = string.Format("INSERT INTO NguoiBan() VALUES());
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                        MessageBox.Show("Số điện thoại đã được đăng ký!");
                    else
                        Global.MoFormCon(new FThongTinDangKy(selctecOption, txtDK.Text), panelDK);
                }
                else if (loainguoi == "Mua hàng")*/


            }
            catch
            { 
            }
            finally
            {
                
            }
        }
    }
}
