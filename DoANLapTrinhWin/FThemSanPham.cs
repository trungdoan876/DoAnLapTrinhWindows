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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoANLapTrinhWin
{
    public partial class FThemSanPham : Form
    {
        private List<Image> arrPicture = new List<Image>();  
        SanPhamDAO spDAO = new SanPhamDAO();
        Global gl = new Global(); 
        public FThemSanPham(string maNB)
        {
            InitializeComponent();
            this.lblMaNB.Text = maNB;
            cmbNganhHang.DisplayMember = "Text";
        }

        private void FSanPhamNguoiBan_Load(object sender, EventArgs e)
        {

        }

        private void tinhTrang_Scroll(object sender, ScrollEventArgs e)
        {
            int value = tinhTrang.Value;
            lblTinhTrang.Text = value.ToString() + "%"; // Hiển thị giá trị của TrackBar trong Label

            // Tính toán vị trí mới của Label dựa trên giá trị của TrackBar và kích thước của thanh kéo
            float percent = (float)value / (float)tinhTrang.Maximum;
            int newPosition = (int)(percent * (tinhTrang.Width - lblTinhTrang.Width)) + tinhTrang.Left;

            // Cập nhật vị trí mới của Label
            lblTinhTrang.Left = newPosition;
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            byte[] b = Global.ImageToByteArray(picHinh.Image);
            SanPham sp = new SanPham(txtMaSanPham.Text, txtTenSP.Text, txtGiaBan.Text, txtGiaGoc.Text,
                    txtXuatXu.Text, txtTGSD.Text, dtp.Value, txtMoTa.Text, cmbNganhHang.Text,
                    lblTinhTrang.Text, txtDiaChi.Text, lblMaNB.Text, txtSoLuonSanCo.Text, b);
            spDAO.ThemSanPham(sp);
            spDAO.ThemNhieuHinh(txtMaSanPham.Text, arrPicture);
        }

        private void btnThemHinh_Click(object sender, EventArgs e)
        {
            picHinh.Image = Global.CreateOpenFileDialog(picHinh);
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnThemNhieuHinh_Click(object sender, EventArgs e)
        {
            arrPicture = Global.CreateOpenFileDialogMore(picHinh,panelThemNhieuHinh,arrPicture);
        }
    }
}
