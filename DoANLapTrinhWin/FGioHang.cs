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
using static System.Net.Mime.MediaTypeNames;

namespace DoANLapTrinhWin
{
    public partial class FGioHang : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        string maNM;
        byte[] hinh;
        int tongtien = 0;
        SanPham sp;
        System.Drawing.Image ByteArrayToImage(byte[] a)
        {
            MemoryStream ms = new MemoryStream(a);
            return System.Drawing.Image.FromStream(ms);
        }
        public FGioHang(string tenTK)
        {
            InitializeComponent();
            this.maNM = tenTK;
            LoadGioHang(maNM);
        }
        public void LoadGioHang(string maNM)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT SanPham.MaNguoiBan as maNB,SanPham.Hinh,SanPham.MaSanPham as MaSP, SanPham.TenSanPham as TenSP, SanPham.GiaBan as GiaBan, SanPham.TinhTrang as TinhTrang, SanPham.GiaGoc as GiaGoc, SanPham.DiaChi as DiaChi, SanPham.SoLuong as SL, GioHang.SoLuong as SLMua, GioHang.TrangThaiSP as TrangThai FROM GioHang, " +
                    "SanPham WHERE GioHang.MaSanPham = SanPham.MaSanPham and MaNguoiMua = '{0}'", maNM);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dtSet = new DataSet();
                adapter.Fill(dtSet);
                int y = 0;
                int yc = 0;

                Dictionary<string, UCTheoNB> dictUCTheoNB = new Dictionary<string, UCTheoNB>();

                foreach (DataRow row in dtSet.Tables[0].Rows)
                {

                    string maNB = row["maNB"].ToString();
                    string maSP = row["MaSP"].ToString();
                    string tenSP = row["TenSP"].ToString();
                    string giaBan = "đ" + row["GiaBan"].ToString();
                    string giaGoc = "đ" + row["GiaGoc"].ToString();
                    string tinhTrang = row["TinhTrang"].ToString();
                    string soLuong = row["SL"].ToString();
                    string soLuongMua = row["SLMua"].ToString();
                    string diaChi = row["DiaChi"].ToString();
                    string trangthai = row["TrangThai"].ToString();
                    if (row["Hinh"] != DBNull.Value)
                    {
                        hinh = (byte[])row["Hinh"];
                    }

                    UCTheoNB ucnb = new UCTheoNB(maNB);

                    if (dictUCTheoNB.ContainsKey(maNB))
                    {
                        ucnb = dictUCTheoNB[maNB];
                    }
                    else
                    {
                        ucnb = new UCTheoNB(maNB);
                        ucnb.Location = new Point(0, yc);
                        yc += ucnb.Height += 5;
                        panelGioHang.Controls.Add(ucnb);
                        dictUCTheoNB.Add(maNB, ucnb);
                    }
                    sp = new SanPham(tenSP, giaBan, giaGoc, tinhTrang, maSP, soLuong, hinh, diaChi);
                    UCSPGioHang spgh = new UCSPGioHang(sp);

                    //chinh sua public
                    spgh.lblTenSP.Text = tenSP;
                    spgh.lblGiaTien.Text = giaBan;
                    spgh.lblTinhTrang.Text = tinhTrang;
                    string str = sp.TinhTrang.Substring(0, sp.TinhTrang.Length - 1);
                    int tt = int.Parse(str);
                    spgh.vongtrontt.Value = tt;
                    spgh.picHinh.Image = ByteArrayToImage(hinh);
                    spgh.lblSoLuong.Text = soLuong + " sản phẩm sẵn có";
                    spgh.soluongmuaGH.Value = int.Parse(soLuongMua);
                    spgh.lblgia.Text = giaGoc;
                    spgh.lblDiaChi.Text = diaChi;
                    spgh.Location = new Point(0, y);
                    y += spgh.Height += 5;
                    ucnb.panelSP.Controls.Add(spgh);

                    spgh.lblTrangThai.Text = trangthai;

                    if (spgh.lblTrangThai.Text == "True")
                    {
                        spgh.checkBoxSP.Checked = true;
                        string giaban = spgh.lblGiaTien.Text.Substring(1); // Loại bỏ ký tự "đ" ở đầu chuỗi
                        decimal gb = decimal.Parse(giaban); // Chuyển đổi giá trị của giaban thành kiểu decimal
                        int tien = (int)(gb * spgh.soluongmuaGH.Value); // Thực hiện phép nhân và chuyển đổi kết quả thành kiểu int
                        tongtien += tien;
                        lblTongTien.Text = "đ" + tongtien.ToString() + ".000";
                    }
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
        private void btnMuaHang_Click_1(object sender, EventArgs e)
        {
            FDatHang fdh = new FDatHang(maNM, sp,tongtien);
            fdh.ShowDialog();
        }
    }
}
