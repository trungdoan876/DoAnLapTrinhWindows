using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoANLapTrinhWin
{
    public partial class UCHeart : UserControl
    {
        public UCHeart()
        {
            InitializeComponent();
        }
        bool picClick = false;
        private void picHeart_Click(object sender, EventArgs e)
        {
            if (picClick)
            {
                string imagePath = Application.StartupPath + "\\HinhAnh\\timden.png";
                Image image = Image.FromFile(imagePath);
                picHeart.Image = image;
                picClick = false;
            }
            else
            {
                string imagePath = Application.StartupPath + "\\HinhAnh\\timdo.png";
                Image image = Image.FromFile(imagePath);
                picHeart.Image = image;
                picClick = true;
            }
        }

        private void UCHeart_Load(object sender, EventArgs e)
        {
            string imagePath = Application.StartupPath + "\\HinhAnh\\timden.png";
            if (System.IO.File.Exists(imagePath))
            {
                Image image = Image.FromFile(imagePath);
                picHeart.Image = image;
            }
        }
    }
}
