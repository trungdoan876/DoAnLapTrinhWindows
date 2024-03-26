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
        int currentImageIndex = 0;
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            currentImageIndex++;

            // Nếu vị trí hiện tại vượt quá số lượng hình ảnh, quay lại hình ảnh đầu tiên
            if (currentImageIndex >= imageList1.Images.Count)
            {
                currentImageIndex = 0;
            }

            // Đặt hình ảnh mới cho PictureBox
            pictureBox4.Image = imageList1.Images[currentImageIndex];


        }
    }
}
