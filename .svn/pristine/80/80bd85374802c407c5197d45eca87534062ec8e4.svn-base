using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DALayer
{
   public   class DAQueryGrid
    {
       Sqlconn mySqlconn = new Sqlconn();

       #region  public DataTable GetInfo(string paramUserName, string paramPhone) 获取数据
       /// <summary>
       /// 获取数据
       /// </summary>
       /// <param name="paramUserName"></param>
       /// <param name="paramPhone"></param>
       /// <returns></returns>
       public DataTable GetInfo(string paramUserName, string paramPhone)
       {
           DataTable myDt = new DataTable();
           string SQL = string.Empty;
           SQL = "select username,telephone,email,address from adminuser  where 1=1";
           if (paramUserName.Length > 0)
           {
               SQL += " and  userName ='" + paramUserName + "'";
           }
           if (paramPhone.Length > 0)
           {
               SQL += " and  telephone = '" + paramPhone + "'";
           }
           DataSet myDs = new DataSet();
           myDs = mySqlconn.Query(SQL);
           if (myDs.Tables.Count >0 && myDs.Tables[0].Rows.Count> 0)
           {
               myDt = myDs.Tables[0];
           }
          
           return myDt;
       }
       #endregion

    }
}
