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
    public partial class FThanhToan : Form
    {
        SanPham sp;
        public FThanhToan()
        {
            InitializeComponent();
        }
        public FThanhToan(SanPham sp)
        {
            this.sp = sp;
            InitializeComponent();
            lblTenSP.Text = sp.TenSP;
            lblGiaBan.Text = sp.GiaBan;
            lblGiaGoc.Text = sp.GiaGoc;
        }
        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if(menuExpand == false)
            {
                menuContainer.Height += 10;
                if(menuContainer.Height >= 274)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if(menuContainer.Height <= 49)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }


        private void btnChonPTTT_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }
        private Button btnOK;
        private void TaoButton(object button)
        {
            var btn = (Button)button;

            btn.BackColor = Color.SeaGreen;
            btn.ForeColor = Color.White;
            if (btnOK != null && btnOK != btn)
            {
                btnOK.BackColor = Color.FromArgb(64, 64, 64);
                btnOK.ForeColor = Color.White;
            }
            btnOK = btn;
        }

        private void btnTTKNH_Click(object sender, EventArgs e)
        {
            TaoButton(sender);
            MessageBox.Show("Bạn đã đặt hàng thành công. Bạn sẽ thanh toán khi nhận hàng");
        }

        private void btnCK_Click(object sender, EventArgs e)
        {
            TaoButton(sender);
            this.Hide();
            FChuyenKhoan form2 = new FChuyenKhoan(sp);
            form2.ShowDialog();
            form2 = null; //tat form2, tuc la form 2 tro ve null
            this.Show();
        }

        private void btnTS_Click(object sender, EventArgs e)
        {
            TaoButton(sender);
            MessageBox.Show("Bạn đã đặt hàng thành công. ");

        }
        int soluong = 1;
        private void btnTru_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSL.Text, out int value))
            {
                if (value > 0)
                {
                    value--;
                    txtSL.Text = value.ToString();
                }
            }
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSL.Text, out int value))
            {
                value++;
                txtSL.Text = value.ToString();
            }
        }
    }

     
}
