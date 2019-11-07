using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DALayer
{
    public class DAUnitAdd
    {
        Sqlconn mysqlconn = new Sqlconn();
        public int UnitAdd(string paramUnitName,string paramRemark)
        {
            string strSql = "INSERT INTO productUnit(ProductUnitName,Remark) Values ('"+paramUnitName+"','"+paramRemark+"')";
            int returnValue = 0;

           returnValue = mysqlconn.ExeNonQuery(strSql);
            return returnValue;
        }
   

    }
}
