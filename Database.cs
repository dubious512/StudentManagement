using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public class Database
    {
        private string connectionString = "Server=DESKTOP-L14F4R5;Database=VNUF_StudentManagement;Trusted_Connection=True;MultipleActiveResultSets=true";
        private SqlConnection connection;
        private DataTable datatable;
        private SqlCommand cmd;

        public Database()
        {
            try
            {
                connection = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại : " + ex.Message);
            }
        }
        public DataTable SelectData(string sql,List<CustomParameter> lstPara)
        {
            try
            { 
                connection.Open();
                cmd = new SqlCommand(sql,connection);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var para in lstPara)
                {
                    cmd.Parameters.AddWithValue(para.key, para.value);
                }
                datatable = new DataTable();
                datatable.Load(cmd.ExecuteReader());
                return datatable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tải dữ liệu không thành công :" + ex.Message);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        public DataRow Select(string sql)
        {
             try
            {
                connection.Open();
                cmd = new SqlCommand(sql, connection);
                datatable = new DataTable();
                datatable.Load(cmd.ExecuteReader());
                return datatable.Rows[0];
            }
            catch //(Exception ex)
            {
                MessageBox.Show("Lỗi tải thông tin chi tiết");
                return null;
            }
            finally
            {
                connection.Close() ;
            }
        }
        public int ExeCute(string sql,List<CustomParameter>lstPara)
        {
            try
            {
                connection.Open();
                cmd = new SqlCommand (sql,connection);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var p in lstPara)
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                var rs = cmd.ExecuteNonQuery();
                return (int)rs;
            }
            catch //(Exception ex)
            {
                //MessageBox.Show("Lỗi thực thi câu lệnh :" + ex.Message);
                return -100;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
