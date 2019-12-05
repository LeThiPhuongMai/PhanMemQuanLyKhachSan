using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Phan_Mem_QL_Khach_San.T2_BUSSINESS;

namespace Phan_Mem_QL_Khach_San.T1_DATA
{
    public class ThuVienKetNoi
    {
        
        //Khởi tạo các biến để Contect tới Dataset
        static SqlConnection KS_Connection;
        SqlDataAdapter KS_DataAdapter;
        SqlCommand KS_SqlCommand;

        public static string KS_StringConnection = "Data Source=LINHNGOC\\SQLEXPRESS;Initial Catalog=ql_khachsan;User ID=sa;password=sa2012;";

        // Hàm mở Connection lên, nếu mở thành công thì trả về True
        public static bool OpenConnection()
        {
            try
            {
                if (KS_Connection == null)
                    KS_Connection = new SqlConnection(KS_StringConnection);
                if (KS_Connection.State != ConnectionState.Open)
                    KS_Connection.Open();
                return true;
            }
            catch
            {
                KS_Connection.Close();
                return false;
            }
        }

        //Hàm ExecuteNonQuery tổng quát, trả về số dòng bị ảnh hưởng
        public int ExecuteNoneQuery(string str)
        {

            int result = 0;
            SqlTransaction tr = null;
            //Mở kết nối
            if (OpenConnection())
            {
                try
                {
                    tr = KS_Connection.BeginTransaction();
                    KS_SqlCommand = new SqlCommand(str);
                    KS_SqlCommand.Connection = KS_Connection;
                    KS_SqlCommand.Transaction = tr;
                    result = KS_SqlCommand.ExecuteNonQuery();
                    tr.Commit();
                }
                catch (Exception e)
                {
                    if (tr != null) tr.Rollback();
                    tr.Dispose();
                }
                KS_Connection.Close();
                return result;
            }
            return 0;

        }

        //Hàm ExecuteScalar trả về ô đầu tiên
        public object ExecuteScalar(string str)
        {

            object result = null;

            if (OpenConnection()) 
                try
                {
                    KS_SqlCommand = new SqlCommand(str);
                    KS_SqlCommand.Connection = KS_Connection;
                    result = KS_SqlCommand.ExecuteScalar();
                }
                catch (Exception e)
                {
                    KS_Connection.Close();
                    return null;
                }

            KS_Connection.Close();
            return result;
        }

        //Hàm trả về bảng dữ liệu
        public DataTable GetTable(string command)
        {
            KS_SqlCommand = new SqlCommand(command);
            DataTable tb = new DataTable();
            try
            {
                if (OpenConnection())
                {
                    KS_DataAdapter = new SqlDataAdapter(command, KS_Connection);
                    KS_DataAdapter.Fill(tb);
                }
            }
            catch(Exception e){}
            KS_Connection.Close();
            return tb;
        }
    }
}
