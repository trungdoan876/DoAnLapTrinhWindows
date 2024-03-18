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
    public partial class FThongTinNguoiBan : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FThongTinNguoiBan()
        {
            InitializeComponent();
        }

        private void FThongTinNguoiBan_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM Nguoiban");
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader docDuLieu = cmd.ExecuteReader();
                if (docDuLieu.Read())
                {
                    // Đưa dữ liệu vào TextBox
                    ucMaNBan.textBox.Text = docDuLieu["Manguoiban"].ToString();
                    ucHoTenNB.textBox.Text = docDuLieu["Ten"].ToString();
                    ucGioiTinh.textBox.Text = docDuLieu["Gioitinh"].ToString();
                    ucNgSinh.textBox.Text = docDuLieu["Ngaysinh"].ToString();
                    ucCCCD.textBox.Text = docDuLieu["CMNDorCCCD"].ToString();
                    ucSDT.textBox.Text = docDuLieu["SDT"].ToString();
                    ucDiaChi.textBox.Text = docDuLieu["Diachi"].ToString();
                    ucEmail.textBox.Text = docDuLieu["Email"].ToString();
                    ucMoTaShop.textBox.Text = docDuLieu["Motashop"].ToString();    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
