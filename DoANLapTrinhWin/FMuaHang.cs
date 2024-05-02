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
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        string tenTaiKhoan;
        Global gl = new Global();
        SanPhamDAO spdao = new SanPhamDAO();    
        public FMuaHang(string tenTK)
        {
            InitializeComponent();
            this.tenTaiKhoan = tenTK;
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
                UCSP ucSP = new UCSP(sp,tenTaiKhoan);
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
                UCSP ucSP = new UCSP(sp, tenTaiKhoan);
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
                UCSP ucSP = new UCSP(sp, tenTaiKhoan);
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
        }
    }
}
