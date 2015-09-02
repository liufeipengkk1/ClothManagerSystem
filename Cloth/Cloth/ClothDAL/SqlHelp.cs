using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ClothDAL
{
    public static class SqlHelper
    {
        //private static String connStr = ConfigurationManager.ConnectionStrings["name"].ConnectionString;
        private static String connStr = "Data Source = 127.0.0.1; Initial Catalog = Cloth;User Id = feipeng;Password=6255710122kk1";
        

        /// <summary>
        /// 检测数据库是否能够连接
        /// </summary>
        /// <returns></returns>
        public static bool TestLinkDatabase()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                }
                return true;
            }
            catch (Exception )
            {
                return false;
            }
            
        }

        /// <summary>
        ///  增 、删 、改操作
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns>受影响的行数</returns>
        public static int ExecuteNonQuery(String sql,params SqlParameter [] parameters )
        {
            try 
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = sql;
                        cmd.Parameters.AddRange(parameters);
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            
        }

        /// <summary>
        ///  查询只有一个结果的语句
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns>返回查询结果</returns>
        public static object ExecuteScalar(String sql, params SqlParameter[] parameters) 
        {
            try 
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = sql;
                        cmd.Parameters.AddRange(parameters);
                        return cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorBox eb = new ErrorBox();
                eb.ErrorMsg = ex.Message;
                eb.ShowDialog();
                return null;
            }
            
        }
        
        /// <summary>
        /// 执行少量查询 离线化 数据
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns> DataTable</returns>
        public static DataTable ExecuteDataTable(String sql, params SqlParameter[] parameters)
        {
            try 
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = sql;
                        cmd.Parameters.AddRange(parameters);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataSet dataset = new DataSet();
                        adapter.Fill(dataset);
                        return dataset.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                //ErrorBox eb = new ErrorBox();
                //eb.ErrorMsg = ex.Message;
                //eb.ShowDialog();
                return null;
            }
        }


        /// <summary>
        ///  DBValue.NULL ->null
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static object FromDbValue(object value)
        {
            if (value == DBNull.Value)
            {
                return null;
            }
            else
            {
                return value;
            }
        }

        /// <summary>
        ///  null->DBValue.NULL
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static object ToDbValue(object value)
        {
            if (value == null || value == "")
            {
                return DBNull.Value;
            }
            else
            {
                return value;
            }
        }
    }
}
