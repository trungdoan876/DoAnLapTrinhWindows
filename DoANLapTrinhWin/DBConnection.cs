using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoANLapTrinhWin
{
    internal class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public DBConnection() { }
        //load dữ liệu, trả về dataset
        public DataSet Load(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dt = new DataSet();
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
        //thực thi 1 câu lệnh
        public void ThucThi(string sqlStr)
        {
            try
            {
                // Ket noi
                conn.Open();
               
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thực thi thành công!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public void ThucThiKhong(string sqlStr)
        {
            try
            {
                // Ket noi
                conn.Open();

                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
