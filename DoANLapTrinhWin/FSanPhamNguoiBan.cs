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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoANLapTrinhWin
{
    public partial class FSanPhamNguoiBan : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FSanPhamNguoiBan()
        {
            InitializeComponent();
        }

        private void FSanPhamNguoiBan_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Ket noi
                conn.Open();
               string sqlStr = string.Format("INSERT INTO SanPham(MaSanPham, TenSanPham, GiaBan, MoTaSanPham, NganhHang ) VALUES ('{0}', '{1}', '{2}','{3}', '{4}' )", ucTextBox4.textBox.Text, ucTextBox2.textBox.Text, ucTextBox5.textBox.Text, ucTextBox8.textBox.Text, ucTextBox1.textBox.Text);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Them thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Them that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
