using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoANLapTrinhWin
{
    public partial class FDatHang : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        string maNM;
        byte[] hinh;
        public FDatHang(string maNM)
        {
            InitializeComponent();
            this.maNM=maNM;
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT * From GioHang WHERE TrangThaiSP = '{0}' and MaNguoiMua ='{1}'", 1, maNM);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dtSet = new DataSet();
                adapter.Fill(dtSet);
                int y = 0;
                foreach (DataRow row in dtSet.Tables[0].Rows)
                {
                    string maSP = row["MaSanPham"].ToString();
                    string tenSP = row["TenSanPham"].ToString();
                    string giaBan = row["GiaBan"].ToString();
                    string soLuong = row["SoLuong"].ToString();
                    
                    SanPham sp = new SanPham(maSP, tenSP, giaBan, soLuong);
                    
                    UCDatHang ucdh = new UCDatHang(sp);
                    
                    //chinh sua public
                    ucdh.lblTenSP.Text = tenSP;
                    ucdh.lblGiaTien.Text = giaBan;

                    ucdh.lblsoluong.Text = soLuong;
                    //ucdh.picHinh.Image = ByteArrayToImage(hinh);
                    //vi tri moi uc
                    ucdh.Location = new Point(0, y);
                    y += ucdh.Height += 5;

                    paneldathang.Controls.Add(ucdh);
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

        private void FDatHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
