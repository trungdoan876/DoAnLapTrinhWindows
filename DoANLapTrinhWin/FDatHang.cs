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
using System.Collections.Generic;

namespace DoANLapTrinhWin
{
    public partial class FDatHang : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        SanPham sp;
        string maNM;
        byte[] hinh;
        Image ByteArrayToImage(byte[] a)
        {
            MemoryStream ms = new MemoryStream(a);
            return Image.FromStream(ms);
        }
        public FDatHang(string maNM,SanPham sp)
        {
            InitializeComponent();
            this.sp = sp;
            this.maNM=maNM;
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
                    string soLuong = row["SoLuong"].ToString();
                    if (row["Hinh"] != DBNull.Value)
                    {
                        hinh = (byte[])row["Hinh"];
                    }
                    SanPham sp = new SanPham(maSP, tenSP, giaBan, soLuong,hinh);
                    
                    UCDatHang ucdh = new UCDatHang(sp);
                    
                    //chinh sua public
                    ucdh.lblTenSP.Text = tenSP;
                    ucdh.lblGiaTien.Text = giaBan;

                    ucdh.lblsoluong.Text = soLuong;
                    ucdh.picHinh.Image = ByteArrayToImage(hinh);
                    //tinh tien
                    string giaban = giaBan.Substring(1); // Loại bỏ ký tự "đ" ở đầu chuỗi
                    decimal gb = decimal.Parse(giaban); // Chuyển đổi giá trị của giaban thành kiểu decimal
                    int tien = (int)(gb * int.Parse(soLuong)); // Thực hiện phép nhân và chuyển đổi kết quả thành kiểu int
                    ucdh.lblthanhtien.Text = "đ" + tien.ToString(); // gán giá trị lên uc
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
            try
            {
                conn.Open();
                string sqlStr = string.Format("INSERT INTO DonHang(MaNguoiBan,MaNguoiMua,MaSanPham,TenSanPham,SoLuongSP,GiaBan,TongTien) " +
                    "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", sp.MaNguoiBan, maNM, sp.MaSP, sp.TenSP, sp.SoLuong, sp.GiaBan, sp.GiaBan);
                //List <SanPham> splist = new List <SanPham>();   
                string sqlStr2 = string.Format("DELETE FROM GioHang WHERE MaSanPham ='{0}'", sp.MaSP);
                
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Dat hang thanh cong");

                SqlCommand cmd2 = new SqlCommand(sqlStr2, conn);
                cmd2.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi"+ex);
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
