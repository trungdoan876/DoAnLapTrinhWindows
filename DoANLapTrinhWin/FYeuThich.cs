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
    public partial class FYeuThich : Form
    {
        public string tenTK;
        byte[] hinh;
        Image ByteArrayToImage(byte[] a)
        {
            MemoryStream ms = new MemoryStream(a);
            return Image.FromStream(ms);
        }
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FYeuThich(string tenTK)
        {
            InitializeComponent();
            this.tenTK = tenTK;
            LoadYeuThich();
        }
        private void FYeuThich_Load(object sender, EventArgs e)
        {
        }

        public void LoadYeuThich()
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT SanPham.Hinh as Hinh, SanPham.TenSanPham as TenSP, SanPham.GiaBan as GiaBan, SanPham.GiaGoc as GiaGoc, SanPham.DiaChi as DiaChi, " +
                    "YeuThich.MaSanPham as MaSP FROM YeuThich,SanPham WHERE YeuThich.MaSanPham = SanPham.MaSanPham and MaNguoiMua = '{0}'", tenTK);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dtSet = new DataSet();
                adapter.Fill(dtSet);
                int x = 0;
                int y = 0;
                foreach (DataRow row in dtSet.Tables[0].Rows)
                {
                    string maSP = row["MaSP"].ToString();
                    string tenSP = row["TenSP"].ToString();
                    string giaBan = "đ" + row["GiaBan"].ToString();
                    string giaGoc = "đ" + row["GiaGoc"].ToString();
                    string diaChi = row["DiaChi"].ToString();
                    if (row["Hinh"] != DBNull.Value)
                    {
                        hinh = (byte[])row["Hinh"];
                    }
                    SanPham sp = new SanPham(maSP,tenSP, giaBan, giaGoc, diaChi, hinh);
                    UCSP ucSP = new UCSP(sp, tenTK);

                    ucSP.lblTenSP.Text = tenSP;
                    ucSP.lblGiaBan.Text = giaBan;
                    ucSP.lblGiaGoc.Text = giaGoc;
                    ucSP.lblDiaChi.Text = diaChi;
                    ucSP.picHinh.Image = ByteArrayToImage(hinh);
                    //vi tri moi uc
                    ucSP.Location = new Point(x, y);
                    x += ucSP.Width += 5;
                    if (x == ucSP.Width * 3)
                    {
                        x = 0;
                        y += ucSP.Height + 5;
                    }
                    panelYeuThich.Controls.Add(ucSP);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
