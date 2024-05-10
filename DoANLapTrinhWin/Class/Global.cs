﻿using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DoANLapTrinhWin
{
    public class Global
    {
        //mo form con
        public static Form formcon;

        public static void MoFormCon(Form form, Panel panel)
        {
            formcon = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            panel.Tag = form;
            form.BringToFront();
            form.Show();
        }
        //giữ sáng cho button khi nhấn vào
        public Guna2Button btnOK;
        public static void TaoButton(object button, ref Guna2Button btnOK)
        {
            var btn = (Guna2Button)button; //chuyển đổi biến button từ kiểu object sang kiểu Guna2Button

            btn.FillColor = Color.Gold;

            if (btnOK != null && btnOK != btn)
            {
                btnOK.FillColor = Color.FromArgb(64, 64, 64);
            }
            btnOK = btn;
        }
        public static void TaoButtonTimKiem(object button, ref Guna2Button btnOK)
        {
            var btn = (Guna2Button)button; //chuyển đổi biến button từ kiểu object sang kiểu Guna2Button

            btn.FillColor = Color.Gold;

            if (btnOK != null && btnOK != btn)
            {
                btnOK.FillColor = Color.PowderBlue;
            }
            btnOK = btn;
        }
        public Guna2GradientButton btncheck;
        //tạo button đăng nhập
        public static void TaoButtonDangNhap(object button, ref Guna2GradientButton btncheck)
        {
            var btn = (Guna2GradientButton)button;

            btn.FillColor = Color.DeepSkyBlue;
            btn.FillColor2 = Color.Violet;

            if (btncheck != null && btncheck != btn)
            {
                btncheck.FillColor = Color.FromArgb(255, 128, 128);
                btncheck.FillColor2 = Color.Gray;
            }

            btncheck = btn;
        }
        //chuyển từ Hình sang Byte
        public static byte[] ImageToByteArray(Image img)
        {
            using (MemoryStream m = new MemoryStream())
            {
                img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
                return m.ToArray();
            }
        }
        //chuyển Byte thành Hình
        public static Image ByteArrayToImage(byte[] a)
        {
            using (MemoryStream ms = new MemoryStream(a))
            {
                return Image.FromStream(ms);
            }
        }
        //Bỏ nhiều hình
        public static PictureBox CreatePictureBoxNoClickTo(Image image) // khong click to
        {
            PictureBox pic = new PictureBox();
            pic.Size = new Size(100, 100);
            pic.Dock = DockStyle.Left;
            pic.Image = image;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Cursor = Cursors.Hand;
            return pic;
        }
        public static PictureBox CreatePictureBox(System.Drawing.Image image, PictureBox picHinh) // co click
        {
            PictureBox pic = new PictureBox();
            pic.Size = new Size(150, 150);
            pic.Dock = DockStyle.Top;
            pic.Image = image;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Cursor = Cursors.Hand;
            pic.Click += (sender, e) => PictureBox_Click(sender, e, picHinh);
            return pic;
        }
        private static void PictureBox_Click(object sender, EventArgs e, PictureBox picHinh)
        {
            PictureBox ptb = (PictureBox)sender;
            picHinh.Image = ptb.Image;
        }
        //thêm hình vào giao diện
        public static Image CreateOpenFileDialog(PictureBox picHinh) //bo 1 hinh vai picturebox
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Title = "Open File";
            openFileDialog.Filter = "Image files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                picHinh.Image = Image.FromFile(openFileDialog.FileName);
            return picHinh.Image;
        }
        //bo hinh vao panel co click
        public static List<Image> CreateOpenFileDialogMore(PictureBox picHinh, Panel panel, List<Image> arrPicture)
        {
            OpenFileDialog odlgOpenFile = new OpenFileDialog();
            odlgOpenFile.InitialDirectory = "C:\\";
            odlgOpenFile.Title = "Open File";
            odlgOpenFile.Filter = "Image files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (odlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(odlgOpenFile.FileName);
                PictureBox pic = CreatePictureBox(image, picHinh);
                panel.Controls.Add(pic);
                arrPicture.Add(image);
            }
            return arrPicture;
        }
        //bo nhieu hinh vao panel khong click
        public static List<Image> CreateOpenFileDialogMoreNoClick(Panel panel, List<Image> arrPicture)
        {
            OpenFileDialog odlgOpenFile = new OpenFileDialog();
            odlgOpenFile.InitialDirectory = "C:\\";
            odlgOpenFile.Title = "Open File";
            odlgOpenFile.Filter = "Image files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (odlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(odlgOpenFile.FileName);
                PictureBox pic = CreatePictureBoxNoClickTo(image);
                panel.Controls.Add(pic);
                arrPicture.Add(image);
            }
            return arrPicture;
        }
        //bo nhieu hinh (to) vao panel khong click

        public static void TimDo(PictureBox picHeart)
        {
            string imagePath = Application.StartupPath + "\\HinhAnh\\timdo.png";
            Image image = Image.FromFile(imagePath);
            picHeart.Image = image;
        }
        public static void TimDen(PictureBox picHeart)
        {
            string imagePath = Application.StartupPath + "\\HinhAnh\\timden.png";
            Image image = Image.FromFile(imagePath);
            picHeart.Image = image;
        }
        //hiện tình trạng sao đánh giá
        public static string tinhtrangsao(double sosao)
        {
            if (sosao >= 0 && sosao < 1)
                return "Tệ";
            else if (sosao >= 1 && sosao < 2)
                return "Không hài lòng";
            else if (sosao >= 2 && sosao < 3)
                return "Bình thường";
            else if (sosao >= 3 && sosao < 4)
                return "Hài lòng";
            else if (sosao >= 4 && sosao <= 5)
                return "Tuyệt vời";
            return "";
        }

    }
}
