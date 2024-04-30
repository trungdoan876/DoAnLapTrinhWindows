using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DoANLapTrinhWin
{
    internal class NguoiDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection tt = new DBConnection();
        string Table;
        //này làm j z
        public DataTable Load()
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM {0}", Table);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        public void CapNhat(Nguoi nguoi)
        {

            string anh = BitConverter.ToString(nguoi.Hinh).Replace("-", "");
            string sqlStr = string.Format("UPDATE {0} SET Hinh = 0x{1}, Ten = N'{3}', SDT = '{4}', NgaySinh = '{5}', GioiTinh = N'{6}', " +
                "CCCD = '{7}', DiaChi = N'{8}', Email = N'{9}', MoTaShop = N'{10}' WHERE Ma = '{2}'", Table, anh, nguoi.Ma, nguoi.Ten1, 
                nguoi.SDT, nguoi.NgaySinh, nguoi.GioiTinh, nguoi.CCCD, nguoi.DiaChi, nguoi.EMail, nguoi.MoTa);
            tt.ThucThi(sqlStr);
        }
        public void CapNhatMua(Nguoi nguoi)
        {

            string anh = BitConverter.ToString(nguoi.Hinh).Replace("-", "");
            string sqlStr = string.Format("UPDATE {0} SET Hinh =0x{1}, Ten = N'{3}', SDT = '{4}', NgaySinh = '{5}', GioiTinh =N'{6}', " +
                "CCCD = '{7}', DiaChi = N'{8}', Email =N'{9}' WHERE Ma='{2}'", Table, anh, nguoi.Ma, nguoi.Ten1, nguoi.SDT, nguoi.NgaySinh, nguoi.GioiTinh, nguoi.CCCD,
                nguoi.DiaChi, nguoi.EMail);
            tt.ThucThi(sqlStr);
        }
        public NguoiDAO(string Table)
        {
            this.Table = Table;
        }
        public NguoiDAO() { }
        //load thông tin người lên form thông tin
        public DataTable ThongTinNguoi(Nguoi ng)
        {
            string sqlStr = string.Format("SELECT *FROM {0} WHERE Ma = '{1}'", Table, ng.Ma);
            DataTable dt = new DataTable();
            dt = tt.DocDuLieu(sqlStr);
            return dt;
        }
        public DataTable DangNhapNM(Nguoi ng)
        {
            string sql = string.Format("SELECT * FROM NguoiMua WHERE Ma = '{0}' and MatKhau ='{1}'", ng.Ma,ng.MatKhau);
            DataTable dt = new DataTable();
            dt = tt.DocDuLieu(sql);
            return dt;
        }
        public DataTable DangNhapNB(Nguoi ng)
        {
            string sql = string.Format("SELECT * FROM NguoiBan WHERE Ma = '{0}' and MatKhau ='{1}'", ng.Ma, ng.MatKhau);
            DataTable dt = new DataTable();
            dt = tt.DocDuLieu(sql);
            return dt;
        }
    }
}
