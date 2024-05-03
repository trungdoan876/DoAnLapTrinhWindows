using System;
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
        string maNM;
        int tongtien = 0;
        GioHangDAO ghdao = new GioHangDAO();
        SanPham sp;
        public FGioHang(string tenTK)
        {
            InitializeComponent();
            this.maNM = tenTK;
            LoadGioHang();
        }
        //đoạn này mình thấy mình làm vẫn chưa đẹp lắm ý
        public void LoadGioHang()
        {
            DataSet ds = new DataSet();
            ds = ghdao.HienGioHang(maNM);
            Dictionary<string, UCTheoNB> dictUCTheoNB = new Dictionary<string, UCTheoNB>();
            int y = 0;
            int yc = 0;
            foreach (DataRow row in ds.Tables[0].Rows)
            {

                string maNB = row["maNB"].ToString();
                UCTheoNB ucnb = new UCTheoNB(maNB);

                if (dictUCTheoNB.ContainsKey(maNB))
                {
                    ucnb = dictUCTheoNB[maNB];
                }
                else
                {
                    ucnb = new UCTheoNB(maNB);
                    ucnb.Location = new Point(0, yc);
                    yc += ucnb.Height += 5;
                    panelGioHang.Controls.Add(ucnb);
                    dictUCTheoNB.Add(maNB, ucnb);
                }
                string soLuongMua = row["SLMua"].ToString();
                sp = new SanPham
                (
                    row[3].ToString(),
                    row[4].ToString(),
                    row[6].ToString(),
                    row[5].ToString(),
                    row[2].ToString(),
                    row[8].ToString(),
                    (byte[])row[1],
                    row[7].ToString()
                );

                UCSPGioHang spgh = new UCSPGioHang(sp);

                //vị trí uc
                spgh.Location = new Point(0, y);
                y += spgh.Height += 5;
                ucnb.panelSP.Controls.Add(spgh);

                spgh.lblTrangThai.Text = row[10].ToString(); //có được chọn để mua hay không
                spgh.soluongmuaGH.Value = int.Parse(soLuongMua); //số lượng thêm vào giỏ

                lblTongTien.Text = "đ"+ThanhTien(spgh.lblTrangThai.Text, spgh.lblGiaTien.Text, int.Parse(soLuongMua))+".000";
            }
        }
        public string ThanhTien(string TrangThai,string giaTien,int soluongmua)
        {
            string giaban = giaTien.Substring(1); // Loại bỏ ký tự "đ" ở đầu chuỗi
            decimal gb = decimal.Parse(giaban); // Chuyển đổi giá trị của giaban thành kiểu decimal
            int tien = (int)(gb * soluongmua); // Thực hiện phép nhân và chuyển đổi kết quả thành kiểu int
            tongtien += tien;
            return tongtien.ToString();
        }
        private void MuaHang_Click(object sender, EventArgs e)
        {
            FDatHang fdh = new FDatHang(maNM, sp, tongtien);
            fdh.ShowDialog();
        }
    }
}
