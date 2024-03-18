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

namespace DoANLapTrinhWin
{
    public partial class FTatCaSanPham : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FTatCaSanPham()
        {
            InitializeComponent();
        }
        //đổ dữ liệu vào user control trong danh sách sản phẩm
        private void FTatCaSanPham_Load(object sender, EventArgs e)
        {
            try
            {
                panelTatCaSP.AutoScroll = true;
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM SanPham");
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dtSet = new DataSet();
                adapter.Fill(dtSet);
                int x = 0;
                int y  = 0;
                foreach (DataRow row in dtSet.Tables[0].Rows)
                {
                    string maSanPham = row["MaSanPham"].ToString();
                    string tenSanPham = row["TenSanPham"].ToString();
                    int giaTien = Convert.ToInt32(row["GiaBan"]);

                    UCSP ucSP = new UCSP();
                    ucSP.lblTenSP.Text = tenSanPham;
                    ucSP.lblGiaTien.Text = giaTien.ToString() +"VND";

                    ucSP.Location = new Point(x, y);
                    x += ucSP.Width += 5;
                    if (x == ucSP.Width * 4)
                    {
                        x = 0;
                        y += ucSP.Height + 5;
                    }
                    panelTatCaSP.Controls.Add(ucSP);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close(); // Đóng kết nối sau khi hoàn thành công việc
            }
        }
    }
}
