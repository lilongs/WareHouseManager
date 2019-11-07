using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace InventoryManagersystem
{
    class Sqlconn
    {
        string strConn = "server=172.18.21.128;database=Inventory;uid=sa;pwd=sa;";
        public DataSet Query(string SQLString)
        {
            using (SqlConnection connection = new SqlConnection(strConn))
            {
                DataSet ds = new DataSet();
                try
                {
                    connection.Open();
                    SqlDataAdapter command = new SqlDataAdapter(SQLString, connection);
                    command.Fill(ds, "ds");
                }
                catch
                {
                    return ds;
                }
                return ds;
            }
        }

        /// <summary>
        /// 定义一个带参数的、返回值为string类型的ExcuteSql()方法
        /// 如果传入参数（SQL执行语句）执行查询后，返回结果集第一行第一列值为空，则返回空值，否则将结果集第一行第一列值返回给此方法ExcuteSql()并显示出来。
        /// </summary>
        /// <param name="SQLString"></param>
        /// <returns>rows</returns>
        public string ExecuteSql(string SQLString)
        {
            using (SqlConnection connection = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand(SQLString, connection))
                {
                    try
                    {
                        connection.Open();
                       // int rows = cmd.ExecuteNonQuery();

                        string rows = "";
                        object obj = cmd.ExecuteScalar();
                        /*如果Object类型的obj值为空，或者为系统DBNull默认空值，
                         * 则返回空白值，否则将Object类型的obj值强行转换为string值，回附值给row,
                         * 然后返回给ExecuteSql()方法
                         * 
                         * 注意：public string ExecuteSql(string SQLString) 中public 后的string 类型必须return rows中rows的类型保持一致或能够
                         * 实现隐性转换
                         *
                         * 
                        */
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value))) 
                        {
                            return "";
                        }
                        else
                        {
                            rows = obj.ToString();
                            return rows;
                        }
                    }
                    catch (System.Data.SqlClient.SqlException e)   //如果try异常，则执行catch内容。将导演内容赋值给e 然后由下面的throw将异常内容返回给函数
                    {
                        throw e;
                    }
                }
            }
        }
        
    }

}
