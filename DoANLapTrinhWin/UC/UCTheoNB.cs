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
    public partial class UCTheoNB : UserControl
    {
        string mangban;
        byte[] hinh;
        NguoiBanDAO ngbandao = new NguoiBanDAO();
        public UCTheoNB(string mangban)
        {
            InitializeComponent();
            this.mangban = mangban;
            this.lbltenNB.Text = mangban;
            ThongTinNguoiBan();
        }
        private void ThongTinNguoiBan()
        {
            DataTable dt = ngbandao.ThongTinNguoiBan(mangban);
            foreach (DataRow row in dt.Rows)
            {
                lbltenNB.Text = row[2].ToString();
                if (row[9] != DBNull.Value)
                {
                    hinh = (byte[])row[9];
                }
                picHinhNB.Image = Global.ByteArrayToImage(hinh);
            }
        }
    }
}
