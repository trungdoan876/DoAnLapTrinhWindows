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
        string maNM,slmua;
        byte[] hinh;
        Image ByteArrayToImage(byte[] a)
        {
            MemoryStream ms = new MemoryStream(a);
            return Image.FromStream(ms);
        }
        public FDatHang(string maNM,string slmua)
        {
            InitializeComponent();
            this.maNM=maNM;
            this.slmua=slmua;
            LoadData();
            ThongTin();
        }
        public void ThongTin()
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("select GioHang.MaNguoiMua, GioHang.MaSanPham, NguoiMua.TenNguoiMua as ten, NguoiMua.DiaChi as diachi " +
                    "FROM GioHang, NguoiMua WHERE GioHang.MaNguoiMua = NguoiMua.MaNguoiMua AND NguoiMua.MaNguoiMua = '{0}'", maNM);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dtSet = new DataSet();
                adapter.Fill(dtSet);
                foreach (DataRow row in dtSet.Tables[0].Rows)
                {
                    string ten = row["ten"].ToString();
                    string diachi = row["diachi"].ToString();
                    this.lblTenNguoiNhan.Text = ten;
                    this.lblDiaChi.Text = diachi;
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
                    string soLuong = slmua;
                    if (row["Hinh"] != DBNull.Value)
                    {
                        hinh = (byte[])row["Hinh"];
                    }
                    SanPham sp = new SanPham(maSP, tenSP, giaBan, soLuong,hinh);
                    
                    UCDatHang ucdh = new UCDatHang(sp);
                    
                    //chinh sua public
                    ucdh.lblTenSP.Text = tenSP;
                    ucdh.lblGiaTien.Text = giaBan;

                    ucdh.lblsoluong.Text = slmua;
                    ucdh.picHinh.Image = ByteArrayToImage(hinh);
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

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đặt hàng thành công!!!");
        }

        private void FDatHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
