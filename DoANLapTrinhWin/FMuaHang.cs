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
        private void ucsp1_Load(object sender, EventArgs e)
        {

        }
        private void LoadData()
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
                    string maNB = row["MaNguoiBan"].ToString();
                    string maSP = row["MaSanPham"].ToString();
                    string tenSP = row["TenSanPham"].ToString();
                    string giaBan = "đ" + row["GiaBan"].ToString();
                    string giaGoc = "đ" + row["GiaGoc"].ToString();
                    string diaChi = row["DiaChi"].ToString();
                    string xuatXu = row["XuatXu"].ToString();
                    string nganhHang = row["NganhHang"].ToString();
                    DateTime ngayDang = DateTime.Now;
                    string moTaSP = row["MoTaSanPham"].ToString();
                    string tinhTrang = row["TinhTrang"].ToString();
                    string thoiGianSuDung = row["TGDSD"].ToString();
                    string soLuong = row["SoLuong"].ToString();
                    SanPham sp = new SanPham(maSP, tenSP, giaBan, giaGoc, xuatXu, thoiGianSuDung, ngayDang, moTaSP, nganhHang, tinhTrang, diaChi, maNB, soLuong);
                    UCSP ucSP = new UCSP(sp);
                    ucSP.lblMaSP.Text = maSP;
                    ucSP.lblTenSP.Text = tenSP;
                    ucSP.lblGiaBan.Text = giaBan;
                    ucSP.lblGiaGoc.Text = giaGoc;
                    ucSP.lblDiaChi.Text = diaChi;
                    //vi tri moi uc
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
        private void FMuaHang_Load(object sender, EventArgs e)
        {
            LoadData();
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

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
