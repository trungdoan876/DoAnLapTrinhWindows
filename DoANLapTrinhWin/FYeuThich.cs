﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoANLapTrinhWin
{
    public partial class FYeuThich : Form
    {
        public string tenTK;
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
                string sqlStr = string.Format("SELECT SanPham.Hinh as Hinh, SanPham.TenSanPham as TenSP, SanPham.GiaBan as GiaBan, SanPham.GiaGoc as GiaGoc, SanPham.DiaChi as DiaChi " +
                    "FROM YeuThich,SanPham WHERE YeuThich.MaSanPham = SanPham.MaSanPham and MaNguoiMua = '{0}'", tenTK);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dtSet = new DataSet();
                adapter.Fill(dtSet);
                int x = 0;
                int y = 0;
                foreach (DataRow row in dtSet.Tables[0].Rows)
                {
                    //string maSP = row["MaSanPham"].ToString();
                    string tenSP = row["TenSP"].ToString();
                    string giaBan = "đ" + row["GiaBan"].ToString();
                    string giaGoc = "đ" + row["GiaGoc"].ToString();
                    string diaChi = row["DiaChi"].ToString();
                    /*if (row["Hinh"] != null && row["Hinh"] is byte[])
                    {
                        hinh = (byte[])row["Hinh"];
                    }*/
                    SanPham sp = new SanPham(tenSP, giaBan, giaGoc, diaChi);
                    UCSP ucSP = new UCSP(sp, tenTK);

                    ucSP.lblTenSP.Text = tenSP;
                    ucSP.lblGiaBan.Text = giaBan;
                    ucSP.lblGiaGoc.Text = giaGoc;
                    ucSP.lblDiaChi.Text = diaChi;
                    //ucSP.picHinh.Image = ByteArrayToImage(hinh);

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
