using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DALayer
{
    public class DAProductUnit
    {
        Sqlconn mysqlconn = new Sqlconn();
        public DataTable GetUnitInfo(string UnitName)
        {
            string sql = "select * from product_unit where 1=1";
            if (!String.IsNullOrEmpty(UnitName))
            {
                sql += " and product_name like '%"+UnitName+"%'";
            }
            return mysqlconn.Query(sql).Tables[0];
        }

        public bool UnitDelete(string UnitId)
        {
            string sql = "delete from product_unit where product_unit_id='"+ UnitId + "'";
            return mysqlconn.ExeNonQuery(sql)>0?true:false;
        }
        public int UnitAdd(string paramUnitName,string paramRemark)
        {
            string strSql = "INSERT INTO product_unit(product_unit_name,remark) Values ('" + paramUnitName+"','"+paramRemark+"')";
            int returnValue = 0;

            returnValue = mysqlconn.ExeNonQuery(strSql);
            return returnValue;
        }

        public bool UnitUpdate(string productUnitId,string paramUnitName, string paramRemark)
        {
            string sql = "update product_unit set product_unit_name='"+ paramUnitName + "', remark='"+ paramRemark + "' where product_unit_id='"+ productUnitId + "'";
            return mysqlconn.ExeNonQuery(sql) > 0 ? true : false;
        }

        public bool IsExistsUnitName(string UnitName)
        {
            string str = "select count(product_unit_id) from product_unit where product_unit_name='" + UnitName + "'";
            return mysqlconn.Exists(str);
        }

    }
}
