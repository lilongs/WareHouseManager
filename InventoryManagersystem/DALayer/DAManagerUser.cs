using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DALayer
{
   public class DAManagerUser
    {
       public string GetUserPassword(string paramUserName)
       {
           Sqlconn mySqlconn = new Sqlconn();
           DataSet myDs = new DataSet();
           string returnValue = string.Empty;
           string strSql = "select passwd from user where 1=1";
           if (paramUserName.Length >0)
           {
               strSql +=" and  userName ='" + paramUserName + "'";
               myDs = mySqlconn.Query(strSql);

               if (myDs.Tables.Count > 0 && myDs.Tables[0].Rows.Count > 0)
               {
                   returnValue = mySqlconn.ExecuteSql(strSql);
                   return returnValue;
                  
               }

               return returnValue;
           }



           return returnValue;
       }
    }
}
