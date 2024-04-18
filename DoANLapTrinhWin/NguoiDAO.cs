using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoANLapTrinhWin
{
    internal class NguoiDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection tt = new DBConnection();
        string Table;
        public DataTable Load()
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM {0}", Table);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtSinhVien = new DataTable();
                adapter.Fill(dtSinhVien);
                return dtSinhVien;
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
            string sqlStr = string.Format("UPDATE {0} SET Hinh =0x{1}, Ten = N'{3}', SDT = '{4}', NgaySinh = '{5}', GioiTinh =N'{6}', " +
                "CCCD = '{7}', DiaChi = N'{8}', Email =N'{9}', MoTaShop = N'{10}' WHERE Ma='{2}'", Table, anh, nguoi.Ma, nguoi.Ten1, nguoi.SDT1, nguoi.NgaySinh, nguoi.GioiTinh, nguoi.CCCD1, 
                nguoi.DiaChi, nguoi.EMail, nguoi.MoTa);
            tt.ThucThi(sqlStr);
        }
        public void CapNhatMua(Nguoi nguoi)
        {

            string anh = BitConverter.ToString(nguoi.Hinh).Replace("-", "");
            string sqlStr = string.Format("UPDATE {0} SET Hinh =0x{1}, Ten = N'{3}', SDT = '{4}', NgaySinh = '{5}', GioiTinh =N'{6}', " +
                "CCCD = '{7}', DiaChi = N'{8}', Email =N'{9}' WHERE Ma='{2}'", Table, anh, nguoi.Ma, nguoi.Ten1, nguoi.SDT1, nguoi.NgaySinh, nguoi.GioiTinh, nguoi.CCCD1,
                nguoi.DiaChi, nguoi.EMail);
            tt.ThucThi(sqlStr);
        }
        public void DangNhap(Nguoi nguoi)
        { 
        }
        public NguoiDAO(string Table)
        {
            this.Table = Table;
        }
    }
}
