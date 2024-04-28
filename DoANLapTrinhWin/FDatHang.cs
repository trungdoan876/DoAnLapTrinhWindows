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
using System.Security.Cryptography;

namespace DoANLapTrinhWin
{
    public partial class FDatHang : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        SanPham sp;
        string maNM;
        string maNB;
        int tongtien;
        string diachi;
        string ten;
        string trangthai;
        byte[] hinh;
        DateTime ngayhientai = DateTime.Now;
        List<SanPham> listsp = new List<SanPham>();
        
        Image ByteArrayToImage(byte[] a)
        {
            MemoryStream ms = new MemoryStream(a);
            return Image.FromStream(ms);
        }
        public FDatHang(string maNM,SanPham sp, int tongtien)
        {
            InitializeComponent();
            this.Size = new Size(1200, 600);
            this.sp = sp;
            this.maNM=maNM;
            this.tongtien=tongtien;
            lblTongTien.Text = "đ"+ tongtien.ToString()+".000";
            LoadData();
            ThongTin();
        }
        public void ThongTin()
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("select GioHang.MaNguoiMua, GioHang.MaSanPham, NguoiMua.Ten as ten, NguoiMua.DiaChi as diachi " +
                    "FROM GioHang, NguoiMua WHERE GioHang.MaNguoiMua = NguoiMua.Ma AND NguoiMua.Ma = '{0}'", maNM);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dtSet = new DataSet();
                adapter.Fill(dtSet);
                foreach (DataRow row in dtSet.Tables[0].Rows)
                {
                    ten = row["ten"].ToString();
                    diachi = row["diachi"].ToString();
                    this.lblTenNguoiNhan.Text = ten;
                    this.lblDiaChi.Text = diachi;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
                string sqlStr = string.Format("SELECT * From GioHang WHERE TrangThaiSP = '{0}' " +
                    "and MaNguoiMua ='{1}'", 1, maNM);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dtSet = new DataSet();
                adapter.Fill(dtSet);
                int yc = 0;
                int y = 0;

                Dictionary<string, UCTheoNB> dictUCTheoNB = new Dictionary<string, UCTheoNB>();

                foreach (DataRow row in dtSet.Tables[0].Rows)
                {
                    maNB = row["MaNguoiBan"].ToString();
                    string maSP = row["MaSanPham"].ToString();
                    string tenSP = row["TenSanPham"].ToString();
                    string giaBan = row["GiaBan"].ToString();
                    string soLuong = row["SoLuong"].ToString();
                    if (row["Hinh"] != DBNull.Value)
                    {
                        hinh = (byte[])row["Hinh"];
                    }

                    sp = new SanPham(maNB, maSP, tenSP, giaBan, hinh, soLuong);
                    listsp.Add(sp);

                    UCTheoNB uc;
                    if (!dictUCTheoNB.ContainsKey(maNB))
                    {
                        uc = new UCTheoNB(maNB);
                        uc.Location = new Point(0, yc);
                        yc += uc.Height + 5;
                        paneldathang.Controls.Add(uc);
                        dictUCTheoNB.Add(maNB, uc); //them 1 uc theo ma nguoi ban
                    }
                    else
                    {
                        uc = dictUCTheoNB[maNB];
                    }

                    //uc thong tin moi san pham
                    UCDatHang ucdh = new UCDatHang(sp); 
                    
                    ucdh.lblTenSP.Text = tenSP;
                    ucdh.lblGiaTien.Text = giaBan;
                    ucdh.lblsoluong.Text = soLuong;
                    ucdh.picHinh.Image = ByteArrayToImage(hinh);

                    //tinh tien
                    string giaban = giaBan.Substring(1); // Loại bỏ ký tự "đ" ở đầu chuỗi
                    decimal gb = decimal.Parse(giaban); // Chuyển đổi giá trị của giaban thành kiểu decimal
                    int tien = (int)(gb * int.Parse(soLuong)); // Thực hiện phép nhân và chuyển đổi kết quả thành kiểu int
                    ucdh.lblthanhtien.Text = "đ" + tien.ToString()+".000            "; // gán giá trị lên uc

                    //vi tri moi uc
                    ucdh.Location = new Point(0, y);
                    y += ucdh.Height += 5;
                    uc.panelSP.Controls.Add(ucdh);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDatHang_Click_1(object sender, EventArgs e)
        {
            if(cmbThanhToan.Text =="Chuyển khoản")
            {
                trangthai = "Đã thanh toán";
                FChuyenKhoan fdh = new FChuyenKhoan(maNM, sp, tongtien,ten,diachi);
                fdh.ShowDialog();
            }
            else
            {
                trangthai = "Chưa thanh toán";
            }
            try
            {
                conn.Open();
                var nguoiBanGroup = listsp.GroupBy(sp => sp.MaNguoiBan); //nhom nguoi ban lai de tao thanh 1 don hang
                foreach (var grp in nguoiBanGroup)
                {

                    string maDonHang = Global.TaoMaDonHangTuDong();
                    string sql = string.Format("INSERT INTO DonHang(MaDonHang,MaNguoiMua,MaNguoiBan,TongTien,NgayDatHang,TrangThaiDonHangNM,TrangThaiDonHangNB) " +
                    "VALUES('{0}','{1}','{2}','{3}','{4}',N'{5}',N'{6}')", maDonHang, maNM, grp.Key, tongtien, ngayhientai, "Đặt hàng thành công","Chuẩn bị hàng");
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    foreach (var sanPham in grp)
                    {
                        string soluong = sanPham.SoLuong.Trim();
                        int soLuong = int.Parse(sanPham.SoLuong);

                        string giaban = sanPham.GiaBan.Substring(1);
                        decimal giatien = decimal.Parse(giaban);

                        // Tính giá trị tổng tiền
                        decimal totalValue = soLuong * giatien;

                        string sqlstr = string.Format("INSERT INTO ChiTietDonHang(MaDonHang, MaSanPham, SoLuong, GiaTien)" +
                    "VALUES('{0}','{1}','{2}','{3}')", maDonHang, sanPham.MaSP, sanPham.SoLuong, totalValue);
                        string sqlstr2 = string.Format("DELETE GioHang WHERE MaSanPham ='{0}' ", sanPham.MaSP);
                        SqlCommand cmdn = new SqlCommand(sqlstr2, conn);
                        SqlCommand cmdm = new SqlCommand(sqlstr, conn);
                        cmdm.ExecuteNonQuery();
                        cmdn.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Dat hang thanh cong!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
