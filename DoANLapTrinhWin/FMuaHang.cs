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
    public partial class FMuaHang : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FMuaHang()
        {
            InitializeComponent();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide(); //an form 1
            FCTSP form2 = new FCTSP(); // tao doi tuong form 2
            form2.ShowDialog(); //show la thao tac dong thoi 2 form
                                //ShowDialog thi khi tat form2 thi moi tro lai thao tac tren form1
            form2 = null; //tat form2, tuc la form 2 tro ve null
            this.Show();
        }
        private void ucsp1_Load(object sender, EventArgs e)
        {

        }

        private void FMuaHang_Load(object sender, EventArgs e)
        {
            try
            {
                panelMuaHang.AutoScroll = true;
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM SanPham");
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dtSet = new DataSet();
                adapter.Fill(dtSet);
                int x = 0;
                int y = 0;
                foreach (DataRow row in dtSet.Tables[0].Rows)
                {
                    string tenSanPham = row["TenSanPham"].ToString();
                    string giaBan = "đ" + row["GiaBan"].ToString() ;
                    string  giaGoc = "đ" + row["GiaGoc"].ToString();
                    string diaChi = row["DiaChi"].ToString();

                    UCSP ucSP = new UCSP();
                    ucSP.lblTenSP.Text = tenSanPham;
                    ucSP.lblGiaBan.Text = giaBan;
                    ucSP.lblGiaGoc.Text = giaGoc;
                    ucSP.lblDiaChi.Text = diaChi;

                    ucSP.Location = new Point(x, y);
                    x += ucSP.Width += 5;
                    if (x == ucSP.Width * 3)
                    {
                        x = 0;
                        y += ucSP.Height + 5;
                    }
                    panelMuaHang.Controls.Add(ucSP);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        bool sidebarExpand = true;

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                // neu mo rong panelMenu
                panelBoLoc.Width -= 10;
                if (panelBoLoc.Width == panelBoLoc.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                   
                }
            }
            else
            {
                panelBoLoc.Width += 10;
                if (panelBoLoc.Width == panelBoLoc.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void btnBoLoc_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

 
    }
    
    
}
