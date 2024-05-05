using Guna.UI2.WinForms;
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
using System.Web;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DoANLapTrinhWin
{
    public partial class FMuaHang : Form
    {
        Global gl = new Global();
        SanPhamDAO spdao = new SanPhamDAO();
        NguoiMua ngmua;
        public FMuaHang(NguoiMua ngmua)
        {
            InitializeComponent();
            panelThongTin.Hide();
            this.ngmua = ngmua;
        }
        public void LoadData()
        {
            DataSet dt = spdao.TatCaSanPham();

            panelMuaHang.AutoScroll = true;
            int x = 0;
            int y = 0;
            foreach (DataRow row in dt.Tables[0].Rows)
            {
                SanPham sp = new SanPham
                (
                    row[1].ToString(),
                    row[2].ToString(),
                    "đ" + row[3].ToString(),
                    "đ" + row[4].ToString(),
                    row[5].ToString(),
                    row[6].ToString(),
                    (DateTime)row[7],
                    row[8].ToString(),
                    row[9].ToString(),
                    row[10].ToString(),
                    row[13].ToString(),
                    row[12].ToString(),
                    row[14].ToString(),
                    (byte[])row[0]
                );
                UCSP ucSP = new UCSP(sp,ngmua);
                //vi tri moi uc
                ucSP.Location = new Point(x, y);
                x += ucSP.Width + 5;
                if (x == ucSP.Width * 4)
                {
                    x = 0;
                    y += ucSP.Height + 5;
                }
                panelMuaHang.Controls.Add(ucSP);
            }  
        }
        public void LoadBoLoc(string nganhhang)
        {
            DataSet dt = spdao.BoLocSanPham(nganhhang);
            panelMuaHang.AutoScroll = true;
            int x = 0;
            int y = 0;
            panelMuaHang.Controls.Clear();
            foreach (DataRow row in dt.Tables[0].Rows)
            {
                SanPham sp = new SanPham
                (
                    row[1].ToString(),
                    row[2].ToString(),
                    row[3].ToString(),
                    row[4].ToString(),
                    row[5].ToString(),
                    row[6].ToString(),
                    (DateTime)row[7],
                    row[8].ToString(),
                    row[9].ToString(),
                    row[10].ToString(),
                    row[13].ToString(),
                    row[12].ToString(),
                    row[14].ToString(),
                    (byte[])row[0]
                );
                UCSP ucSP = new UCSP(sp, ngmua);
                //vi tri moi uc
                ucSP.Location = new Point(x, y);
                x += ucSP.Width + 5;
                if (x == ucSP.Width * 4)
                {
                    x = 0;
                    y += ucSP.Height + 5;
                }
                panelMuaHang.Controls.Add(ucSP);
            }
        }
        public void LoadTimKiem(string timkiem)
        {
            DataSet dt = spdao.TimKiemSanPham(timkiem);
            int x = 0;
            int y = 0;
            panelMuaHang.Controls.Clear();
            foreach (DataRow row in dt.Tables[0].Rows)
            {
                SanPham sp = new SanPham
                (
                    row[1].ToString(),
                    row[2].ToString(),
                    row[3].ToString(),
                    row[4].ToString(),
                    row[5].ToString(),
                    row[6].ToString(),
                    (DateTime)row[7],
                    row[8].ToString(),
                    row[9].ToString(),
                    row[10].ToString(),
                    row[13].ToString(),
                    row[12].ToString(),
                    row[14].ToString(),
                    (byte[])row[0]
                );
                UCSP ucSP = new UCSP(sp, ngmua);
                //vi tri moi uc
                ucSP.Location = new Point(x, y);
                x += ucSP.Width + 5;
                if (x == ucSP.Width * 4)
                {
                    x = 0;
                    y += ucSP.Height + 5;
                }
                panelMuaHang.Controls.Add(ucSP);
            }
        }
        private void FMuaHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void BoLoc(string boloc)
        {
            LoadBoLoc(boloc.Trim());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panelMuaHang.Controls.Clear();
            Global.TaoButtonTimKiem(btnMenu,ref gl.btnOK);
            LoadData();
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            Global.TaoButtonTimKiem(btnSach, ref gl.btnOK);
            BoLoc(btnSach.Text.Trim());
        }

        private void btnThoitrangnu_Click(object sender, EventArgs e)
        {
            Global.TaoButtonTimKiem(btnThoitrangnu, ref gl.btnOK);
            BoLoc(btnThoitrangnu.Text.Trim());
        }

        private void btnDochonam_Click(object sender, EventArgs e)
        {
            Global.TaoButtonTimKiem(btnDochonam, ref gl.btnOK);
            BoLoc(btnDochonam.Text.Trim());
        }

        private void btnDochoi_Click(object sender, EventArgs e)
        {
            Global.TaoButtonTimKiem(btnDochoi, ref gl.btnOK);
            BoLoc(btnDochoi.Text.Trim());
        }

        private void btnDodungnhacua_Click(object sender, EventArgs e)
        {
            Global.TaoButtonTimKiem(btnDodungnhacua, ref gl.btnOK);
            BoLoc(btnDodungnhacua.Text.Trim());
        }

        private void btnThietbidientu_Click(object sender, EventArgs e)
        {
            Global.TaoButtonTimKiem(btnThietbidientu, ref gl.btnOK);
            BoLoc(btnThietbidientu.Text.Trim());
        }

        private void btnDothethao_Click(object sender, EventArgs e)
        {
            Global.TaoButtonTimKiem(btnDothethao, ref gl.btnOK);
            BoLoc(btnDothethao.Text.Trim());
        }

        private void btndolamdep_Click(object sender, EventArgs e)
        {
            Global.TaoButtonTimKiem(btndolamdep, ref gl.btnOK);
            BoLoc(btndolamdep.Text.Trim());
        }

        private void btnKhac_Click(object sender, EventArgs e)
        {
            Global.TaoButtonTimKiem(btnKhac, ref gl.btnOK);
            BoLoc(btnKhac.Text.Trim());
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            LoadTimKiem(txtTimKiem.Text.Trim());
        }

        private void txtTimKiem_IconRightClick(object sender, EventArgs e)
        {
            LoadTimKiem(txtTimKiem.Text.Trim());
            //tần suất tìm kiếm
            TanSuatTimKiem();
            /*try
            {
                if(conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                //lấy ngành hàng
                string sql = string.Format("select distinct NganhHang From SanPham where TenSanPham LIKE N'%{0}%'",txtTimKiem.Text.Trim());
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                string nganhHang = "";

                // Kiểm tra xem có bất kỳ hàng nào được trả về từ truy vấn không
                if (reader.HasRows)
                {
                    // Đọc hàng đầu tiên (giả sử chỉ có một hàng được trả về)
                    reader.Read();

                    // Lấy giá trị của cột đầu tiên trong tập kết quả (NganhHang)
                    nganhHang = reader.GetString(0);
                }
                reader.Close();
                //một lần tìm kiếm sẽ insert vào bảng nếu chưa có trong bảng
                string sql1 = string.Format("Select TanSuatTimKiem From TimKiem where NganhHang like N'{0}'",nganhHang);
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                int tanSuat;
                // Kiểm tra xem có bất kỳ hàng nào được trả về từ truy vấn không
                if (reader1.HasRows)
                {
                    // Đọc hàng đầu tiên (giả sử chỉ có một hàng được trả về)
                    reader1.Read();
                    tanSuat = reader1.GetInt32(0); // +1;
                }
                else
                {
                     tanSuat = 0;
                }
                reader1.Close();
                if(tanSuat == 0)
                {
                    string sqlStr = string.Format("INSERT INTO TimKiem (MaNguoiMua,TanSuatTimKiem,NganhHang) VALUES ('{0}','{1}',N'{2}')", ngmua.Ma , 1, nganhHang);
                    SqlCommand cmd2 = new SqlCommand(sqlStr, conn);
                    cmd2.ExecuteNonQuery();
                }
                else //nếu đã có, cập nhật tuần suất lên 1
                {
                    string sqlStr = string.Format("UPDATE TimKiem SET TanSuatTimKiem ='{0}' WHERE MaNguoiMua ='{1}'and NganhHang =N'{2}'",tanSuat+1, ngmua.Ma,nganhHang);
                    SqlCommand cmd3 = new SqlCommand(sqlStr, conn);
                    cmd3.ExecuteNonQuery();
                } 
                    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }*/
        }
        private void TanSuatTimKiem()
        {
            DataTable dt = spdao.LayNganhHang(txtTimKiem.Text.Trim());
            string nganhHang = "";
            foreach (DataRow row in dt.Rows)
            {
                nganhHang = row[0].ToString();
            }
            int tanSuat;
            DataTable dta = spdao.TanSuatTimKiem(nganhHang, ngmua.Ma);
            if (dta.Rows.Count > 0)
            {
                // Đọc hàng đầu tiên 
                tanSuat = Convert.ToInt32(dta.Rows[0][0]); // +1; //dta.Rows[0][0] là giá trị của cột đầu tiên của hàng đó.
            }
            else
            {
                tanSuat = 0;
            }
            if (tanSuat == 0)
            {
                spdao.ThemTanSuatVaoTimKiem(ngmua, nganhHang);
            }
            else //nếu đã có, cập nhật tuần suất lên 1
            {
                spdao.CapNhatTanSuatTimKiem(ngmua, nganhHang, tanSuat);
            }
        }
        private void panelChiTiet_MouseMove_1(object sender, MouseEventArgs e)
        {
            panelThongTin.Show();
        }

        private void panelThongTin_MouseMove(object sender, MouseEventArgs e)
        {
            panelThongTin.Show();
        }

        private void panelThongTin_MouseLeave(object sender, EventArgs e)
        {
            panelThongTin.Hide();
        }

        private void panelThongTin_MouseDown(object sender, MouseEventArgs e)
        {
            panelThongTin.Hide();
        }
    }
}
