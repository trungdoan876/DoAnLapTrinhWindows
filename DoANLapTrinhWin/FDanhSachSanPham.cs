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
    public partial class FDanhSachSanPham : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        string maNB;
        public FDanhSachSanPham(string maNB)
        {
            InitializeComponent();
            this.maNB = maNB;
        }
        //đổ dữ liệu vào user control trong danh sách sản phẩm
        private void FTatCaSanPham_Load(object sender, EventArgs e)
        {
            try
            {
                panelTatCaSP.AutoScroll = true;
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM SanPham WHERE MaNguoiBan ='{0}'",maNB);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dtSet = new DataSet();
                adapter.Fill(dtSet);
                int x = 0;
                int y  = 0;
                foreach (DataRow row in dtSet.Tables[0].Rows)
                {
                    string maSP = row["MaSanPham"].ToString();
                    string tenSP = row["TenSanPham"].ToString();
                    string giaTien = row["GiaBan"].ToString();
                    string giaGoc = row["GiaGoc"].ToString();
                    string moTaSP = row["MoTaSanPham"].ToString();
                    string tinhTrang = row["TinhTrang"].ToString();
                    string nganhHang = row["NganhHang"].ToString();
                    string xuatXu = row["XuatXu"].ToString();
                    string diaChi = row["DiaChi"].ToString() ;
                    string thoiGianSuDung = row["TGDSD"].ToString();
                    string soLuong = row["SoLuong"].ToString();
                    DateTime ngayDang = DateTime.Now;
                    SanPham sp = new SanPham(maSP,tenSP,giaTien,giaGoc,xuatXu,thoiGianSuDung,ngayDang,moTaSP,nganhHang,tinhTrang, diaChi,"",soLuong);

                    UCSPBan ucSPBan = new UCSPBan(sp);
                    
                    ucSPBan.Location = new Point(x, y);
                    x += ucSPBan.Width += 5;
                    if (x == ucSPBan.Width * 4)
                    {
                        x = 0;
                        y += ucSPBan.Height + 5;
                    }
                    panelTatCaSP.Controls.Add(ucSPBan);
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
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            this.Hide(); //an form 1
            FThemSanPham form2 = new FThemSanPham(maNB) ; // tao doi tuong form 2
            form2.ShowDialog();
            form2 = null; //tat form2, tuc la form 2 tro ve null
            this.Show();
        }
    }
}
