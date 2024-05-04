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
    public partial class Loading : Form
    {
        NguoiMua ngmua;
        Nguoi ng;
        string luachon;
        NguoiBan ngban;

        public Loading(NguoiMua ngmua,string luaChon)
        {
            InitializeComponent();
            this.Size = new Size(1200,600);
            this.ngmua = ngmua;
            this.luachon = luaChon; 
        }
       public Loading(NguoiBan ngban,string luaChon)
        {
            InitializeComponent();
            this.Size = new Size(1200, 600);
            this.ngban = ngban;
            this.luachon = luaChon;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2CircleProgressBar1.Value == 100)
            {
                timer1.Stop();
                if (luachon == "Mua hàng")
                {
                    FNguoiMua form2 = new FNguoiMua(ngmua);
                    form2.ShowDialog();
                    this.Hide();
                    form2 = null;
                    FDangNhap dn = new FDangNhap();
                    dn.ShowDialog();
                }
                else
                {
                    FNguoiBan form = new FNguoiBan(ngban);
                    form.ShowDialog();
                    this.Hide();
                    form = null;
                    FDangNhap dn = new FDangNhap();
                    dn.ShowDialog();
                } 
            }
            else
            {
                guna2CircleProgressBar1.Value += 1;
                label_val.Text = (Convert.ToInt32(label_val.Text) + 1).ToString();
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
