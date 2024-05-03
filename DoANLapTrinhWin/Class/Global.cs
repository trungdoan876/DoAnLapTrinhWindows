using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        //Bỏ nhiều hình
        public static PictureBox CreatePictureBoxNoClickTo(System.Drawing.Image image)
        {
            PictureBox pic = new PictureBox();
            pic.Size = new Size(100, 100);
            pic.Dock = DockStyle.Left;
            pic.Image = image;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Cursor = Cursors.Hand;
            return pic;
        }
        public static PictureBox CreatePictureBoxNoClick(System.Drawing.Image image)
        {
            PictureBox pic = new PictureBox();
            pic.Size = new Size(50, 50);
            pic.Dock = DockStyle.Left;
            pic.Image = image;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Cursor = Cursors.Hand;
            return pic;
        }
        public static PictureBox CreatePictureBox(System.Drawing.Image image, PictureBox picHinh)
        {
            PictureBox pic = new PictureBox();
            pic.Size = new Size(100, 100);
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
        //thêm hình vào giao diện
        public static Image CreateOpenFileDialog(PictureBox picHinh)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Title = "Open File";
            openFileDialog.Filter = "Image files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                picHinh.Image = Image.FromFile(openFileDialog.FileName);
            return picHinh.Image;
        }
        public static List<Image> CreateOpenFileDialogMore(PictureBox picHinh,Panel panel, List<Image> arrPicture)
        {
            OpenFileDialog odlgOpenFile = new OpenFileDialog();
            odlgOpenFile.InitialDirectory = "C:\\";
            odlgOpenFile.Title = "Open File";
            odlgOpenFile.Filter = "Image files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (odlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(odlgOpenFile.FileName);
                PictureBox pic = Global.CreatePictureBox(image, picHinh);
                panel.Controls.Add(pic);
                arrPicture.Add(image);
            }
            return arrPicture;
        }

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
    }
}
