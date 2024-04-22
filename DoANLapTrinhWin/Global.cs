using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoANLapTrinhWin
{
    public class Global
    {
        //tạo mã đơn hàng
        public static int ma = 0;
        public static string TaoMaDonHangTuDong()
        {
            Global.ma++;
            return "DH" + ma.ToString();
        }
        //mo form con
        public static Form formcon;

        public static void MoFormCon(Form form, Panel panel)
        {
            /*if (formcon != null)
            {
                formcon.Close();
            }*/
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
    }
}
