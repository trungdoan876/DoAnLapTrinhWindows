﻿using System;
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
        private void chuyenKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); //an form 1
            FChuyenKhoan form2 = new FChuyenKhoan(); // tao doi tuong form 2
            form2.ShowDialog(); //show la thao tac dong thoi 2 form
                                //ShowDialog thi khi tat form2 thi moi tro lai thao tac tren form1
            form2 = null; //tat form2, tuc la form 2 tro ve null
            this.Show();
        }
        public void LoadGioHang(string maNM)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT SanPham.MaNguoiBan as maNB,SanPham.Hinh,SanPham.MaSanPham as MaSP, SanPham.TenSanPham as TenSP, SanPham.GiaBan as GiaBan, SanPham.TinhTrang as TinhTrang, SanPham.SoLuong as SL, GioHang.SoLuong as SLMua " +
                    "FROM GioHang, SanPham WHERE GioHang.MaSanPham = SanPham.MaSanPham and MaNguoiMua = '{0}'",maNM);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dtSet = new DataSet();
                adapter.Fill(dtSet);
                int y = 0;
                int yc = 0;
                
                List <SanPham> splist = new List<SanPham> ();

                foreach (DataRow row in dtSet.Tables[0].Rows)
                {
                    
                    string maNB = row["maNB"].ToString();
                    //MessageBox.Show(maNB);
                    UCTheoNB uc = new UCTheoNB(maNB);
                    uc.Location = new Point(0, yc);
                    yc += uc.Height +=  5;
                    panelGioHang.Controls.Add(uc);
                    string maSP = row["MaSP"].ToString();
                    string tenSP = row["TenSP"].ToString();
                    string giaBan = "đ" + row["GiaBan"].ToString();
                    string tinhTrang = row["TinhTrang"].ToString();
                    string soLuong = row["SL"].ToString();
                    string soLuongMua = row["SLMua"].ToString();
                    if (row["Hinh"] != DBNull.Value)
                    {
                        hinh = (byte[])row["Hinh"];
                    }
                    
                    sp = new SanPham(tenSP, giaBan, tinhTrang,maSP,soLuong, hinh);
                    
                    UCSPGioHang spgh = new UCSPGioHang(sp);

                    //splist.Add(sp);
                    //chinh sua public
                    spgh.lblTenSP.Text = tenSP;
                    spgh.lblGiaTien.Text = giaBan;
                    spgh.lblTinhTrang.Text = tinhTrang;
                    spgh.picHinh.Image = ByteArrayToImage(hinh);
                    spgh.lblSoLuong.Text = soLuong +" sản phẩm sẵn có";
                    spgh.txtSL.Text = soLuongMua;
                    uc.panelSP.Controls.Add(spgh);
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
        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            FDatHang fdh = new FDatHang(maNM,sp);
            fdh.ShowDialog();
        }
    }
}
