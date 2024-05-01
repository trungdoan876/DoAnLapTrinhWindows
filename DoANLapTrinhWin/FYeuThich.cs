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
        SanPhamDAO spDao = new SanPhamDAO();
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

        public void LoadYeuThich()
        {
            DataSet ds = new DataSet();
            ds = spDao.SanPhamYeuThich(tenTK);
            int x = 0;
            int y = 0;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                SanPham sp = new SanPham(
                    row[5].ToString(), //masp
                    row[1].ToString(), //ten
                    row[2].ToString(), //giaban
                    row[3].ToString(), //gia goc
                    row[4].ToString(), //diachi
                    (byte[])row[0] //hinh
                    );
                UCSP ucSP = new UCSP(sp, tenTK);

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
            /*try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT SanPham.Hinh as Hinh, SanPham.TenSanPham as TenSP, SanPham.GiaBan as GiaBan, SanPham.GiaGoc as GiaGoc, SanPham.DiaChi as DiaChi, " +
                    "YeuThich.MaSanPham as MaSP FROM YeuThich, SanPham WHERE YeuThich.MaSanPham = SanPham.MaSanPham and MaNguoiMua = '{0}'", tenTK);
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
            }*/
        }
    }
}
