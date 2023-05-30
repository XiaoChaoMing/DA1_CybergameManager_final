using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL_Cybergame_managers.helper
{
    internal class Sqlhelper
    {
        // Database connection strings
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;
        // Hashtable to store cached parameters
        private static Hashtable parmCache = Hashtable.Synchronized(new Hashtable());


        /// <summary>
        ///  Thực thi một SqlCommand(không trả về tập kết quả nào) đối với cơ sở dữ liệu được chỉ định trong chuỗi kết nối
        ///  bằng cách sử dụng các tham số được cung cấp.
        /// </summary>
        /// <remarks>
        /// e.g.:  
        ///  int result = ExecuteNonQuery(connString, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="connectionString">chuỗi kết nối hợp lệ cho một SqlConnection</param>
        /// <param name="commandType">loại lệnh (stored procedure, text, etc.)</param>
        /// <param name="commandText">tên store proceduce hoặc lệnh T-SQL</param>
        /// <param name="commandParameters">mảng SqlParamters được sử dụng để thực thi lệnh</param>
        /// <returns>một số(int) đại diện cho số hàng bị ảnh hưởng bởi lệnh</returns>
        public static int ExecuteNonQuery(string connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {

            SqlCommand cmd = new SqlCommand();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                int val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return val;
            }
        }

        //public static void X()
        //{
        //    SqlConnection connection = new SqlConnection(ConnectionString);

        //    // Khởi tạo SqlDependency
        //    SqlDependency.Start(ConnectionString);

        //    // Thiết lập câu lệnh SQL và event handler
        //    string sqlQuery = "SELECT Ten FROM ThanhVien";
        //    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
        //    {
        //        SqlDependency dependency = new SqlDependency(command);
        //        dependency.OnChange += Dependency_OnChange; ;

        //        // Mở kết nối và thực thi câu lệnh
        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();
        //        // Xử lý dữ liệu trả về
        //        // ...
        //    }
        //}

        //private static void Dependency_OnChange(object sender, SqlNotificationEventArgs e)
        //{
        //    if (e.Type == SqlNotificationType.Change && e.Info == SqlNotificationInfo.Update)
        //    {
        //        //_instance.Invoke((MethodInvoker)delegate {
        //        //    _instance.Refresh();
        //        //});
        //    }
        //}

        //private void OnSqlDependencyChange1(object sender, SqlNotificationEventArgs e)
        //{
        //    if (e.Type == SqlNotificationType.Change && e.Info == SqlNotificationInfo.Update)
        //    {
        //        // Xử lý sự thay đổi trong trường SQL
        //        // ...
        //    }
        //}


        /// <summary>
        ///  Thực thi một SqlCommand(không trả về tập kết quả nào) đối với cơ sở dữ liệu được chỉ định trong chuỗi kết nối
        ///  bằng cách sử dụng các tham số được cung cấp.
        /// </summary>
        /// <remarks>
        /// e.g.:  
        ///  int result = ExecuteNonQuery(connString, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="conn">kết nối tới database đã tồn tại</param>
        /// <param name="commandType">loại lệnh (stored procedure, text, etc.)</param>
        /// <param name="commandText">tên store proceduce hoặc lệnh T-SQL</param>
        /// <param name="commandParameters">mảng SqlParamters được sử dụng để thực thi lệnh</param>
        /// <returns>một số(int) đại diện cho số hàng bị ảnh hưởng bởi lệnh</returns>
        public static int ExecuteNonQuery(SqlConnection connection, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
            int val = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            return val;
        }
        /// <summary>
        ///  Thực thi một SqlCommand(không trả về tập kết quả nào) đối với cơ sở dữ liệu được chỉ định trong chuỗi kết nối
        ///  bằng cách sử dụng các tham số được cung cấp.
        /// </summary>
        /// <remarks>
        /// e.g.:  
        ///  int result = ExecuteNonQuery(connString, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="trans">sql transaction hiện có</param>
        /// <param name="commandType">loại lệnh (stored procedure, text, etc.)</param>
        /// <param name="commandText">tên store proceduce hoặc lệnh T-SQL</param>
        /// <param name="commandParameters">mảng SqlParamters được sử dụng để thực thi lệnh</param>
        /// <returns>một số(int) đại diện cho số hàng bị ảnh hưởng bởi lệnh</returns>
        public static int ExecuteNonQuery(SqlTransaction trans, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(cmd, trans.Connection, trans, cmdType, cmdText, commandParameters);
            int val = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            return val;
        }
        /// <summary>
        ///  Thực thi một SqlCommand(không trả về tập kết quả nào) đối với cơ sở dữ liệu được chỉ định trong chuỗi kết nối
        ///  bằng cách sử dụng các tham số được cung cấp.
        /// </summary>
        /// <remarks>
        /// e.g.:  
        ///  int result = ExecuteNonQuery(connString, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="connectionString">chuỗi kết nối hợp lệ cho SqlConnection</param>
        /// <param name="commandType">loại lệnh (stored procedure, text, etc.)</param>
        /// <param name="commandText">tên store proceduce hoặc lệnh T-SQL</param>
        /// <param name="commandParameters">mảng SqlParamters được sử dụng để thực thi lệnh</param>
        /// <returns>1 SqlDataReader chứa các kết quả</returns>

        public static SqlDataReader ExecuteReader(string connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {

            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection(connectionString);

            /// nếu method đưa ra một exception ngắt kết nối do không có trình đọc dữ liệu nào được thực hiện
            /// CommandBehavior.CloseConnection ko thể hoạt động
            try
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
                return rdr;
            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;
            }
        }
        /// <summary>
        ///  Thực thi một SqlCommand(không trả về tập kết quả nào) đối với cơ sở dữ liệu được chỉ định trong chuỗi kết nối
        ///  bằng cách sử dụng các tham số được cung cấp.
        /// </summary>
        /// <remarks>
        /// e.g.:  
        ///  int result = ExecuteNonQuery(connString, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="connectionString">chuỗi kết nối hợp lệ cho SqlConnection</param>
        /// <param name="commandType">loại lệnh (stored procedure, text, etc.)</param>
        /// <param name="commandText">tên store proceduce hoặc lệnh T-SQL</param>
        /// <param name="commandParameters">mảng SqlParamters được sử dụng để thực thi lệnh</param>
        /// <returns>Một đối tượng sẽ được chuyển đổi thành expected bằng cách sử dụng Convert.To{Type}</returns>

        public static object ExecuteScalar(string connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
                object val = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                return val;
            }
        }
        /// <summary>
        ///  Thực thi một SqlCommand(không trả về tập kết quả nào) đối với cơ sở dữ liệu được chỉ định trong chuỗi kết nối
        ///  bằng cách sử dụng các tham số được cung cấp.
        /// </summary>
        /// <remarks>
        /// e.g.:  
        ///  int result = ExecuteNonQuery(connString, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="connectionString">chuỗi kết nối hợp lệ cho SqlConnection</param>
        /// <param name="commandType">loại lệnh (stored procedure, text, etc.)</param>
        /// <param name="commandText">tên store proceduce hoặc lệnh T-SQL</param>
        /// <param name="commandParameters">mảng SqlParamters được sử dụng để thực thi lệnh</param>
        /// <returns>Một đối tượng sẽ được chuyển đổi thành expected bằng cách sử dụng Convert.To{Type}</returns>
        
        public static object ExecuteScalar(SqlConnection connection, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
            object val = cmd.ExecuteScalar();
            cmd.Parameters.Clear();
            return val;
        }

        /// <summary>
        /// thêm một mảng vào bộ nhớ đệm
        /// </summary>
        /// <param name="cacheKey">Key cho bộ nhớ đệm  parameter</param>
        /// <param name="cmdParms"> 1 mảng SqlParamters sẽ được lưu trữ</param>
        public static void CacheParameters(string cacheKey, params SqlParameter[] commandParameters)
        {
            parmCache[cacheKey] = commandParameters;
        }

        /// <summary>
        /// Truy xuất các tham số đã lưu trong bộ nhớ cache
        /// </summary>
        /// <param name="cacheKey">key để tra cứu parameters</param>
        /// <returns>Mảng SqlParamters được lưu trong bộ nhớ cache</returns>
        public static SqlParameter[] GetCachedParameters(string cacheKey)
        {
            SqlParameter[] cachedParms = (SqlParameter[])parmCache[cacheKey];

            if (cachedParms == null)
                return null;

            SqlParameter[] clonedParms = new SqlParameter[cachedParms.Length];

            for (int i = 0, j = cachedParms.Length; i < j; i++)
                clonedParms[i] = (SqlParameter)((ICloneable)cachedParms[i]).Clone();

            return clonedParms;
        }

        /// <summary>
        /// Chuẩn bị một lệnh để thực hiện
        /// </summary>
        /// <param name="cmd">đối tượng SqlCommand</param>
        /// <param name="conn">đối tượng SqlConnection</param>
        /// <param name="trans">đối tượng SqlTransaction</param>
        /// <param name="cmdType">Cmd type e.g. stored procedure or text</param>
        /// <param name="cmdText">Command text, e.g. Select * from Products</param>
        /// <param name="cmdParms">SqlParameters để sử dụng trong lệnh</param>
        private static void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, CommandType cmdType, string cmdText, SqlParameter[] cmdParms)
        {

            if (conn.State != ConnectionState.Open)
                conn.Open();

            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            if (trans != null)
                cmd.Transaction = trans;

            cmd.CommandType = cmdType;

            if (cmdParms != null)
            {
                foreach (SqlParameter parm in cmdParms)
                    cmd.Parameters.Add(parm);
            }
        }
    }
}
