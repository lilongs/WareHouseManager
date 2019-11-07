using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DALayer
{
    public class DAProductClass
    {
        Sqlconn mysqlconn = new Sqlconn();
        public int ProductClassAdd(string paramClassName, string paramRemark, string paramEmployeeName, string paramParentID)
        {
            string strSql = "INSERT INTO product_class(product_class_name, remark, employee_name, create_date, parent_id) Values ('" + paramClassName + "','" + paramRemark + "','" + paramEmployeeName + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + paramParentID + "')";
            int returnValue = 0;
            returnValue = mysqlconn.ExeNonQuery(strSql);
            return returnValue;
        }

        /// <summary>
        /// 获取到类比的主类别
        /// </summary>
        /// <returns></returns>
        public DataTable GetClassList(string ParentID)
        {
            DataTable myDt = new DataTable();
            string SQL = @" select * from  product_class where  1=1";
            if (ParentID.Length == 0 || ParentID.Equals("0"))
            {
                SQL += " and  parent_id=0 ";
            }
            else
                SQL += " and  parent_id= '" + ParentID + "'";
            DataSet myDs = new DataSet();
            myDs = mysqlconn.Query(SQL);
            myDt = myDs.Tables[0];
            return myDt;
        }

        public DataTable GetClass(string ProductClassID)
        {
            DataTable myDt = new DataTable();
            string SQL = @" select * from  product_class where  1=1";
            if (ProductClassID.Length > 0)
            {
                SQL += " and  product_class_id='"+ProductClassID+"' ";
            }
            DataSet myDs = new DataSet();
            myDs = mysqlconn.Query(SQL);
            myDt = myDs.Tables[0];
            return myDt;
        }

        public DataTable GetProductClassByName(string ClassName)
        {
            string sql = @"select * from product_class where 1=1 ";
            if (!String.IsNullOrEmpty(ClassName))
            {
                sql += " and product_class_name ='%"+ClassName+"%'";
            }
            return mysqlconn.Query(sql).Tables[0];
        }

        public bool IsExistsClassName(string ClassName)
        {
            string sql = "select count(product_class_id) from product_class where product_class_name='" + ClassName+"'";
            return mysqlconn.Exists(sql);
        }

        public int UpdateClass(string paramClassName, string paramRemark, int paramClassCode, string paramEmployeeName, string paramParentID)
        {
            int returnValue = 0;
            string strSql = "update product_class set product_class_name = '" + paramClassName + "',remark = '" + paramRemark + "',create_date='" + DateTime.Now.ToString("yyyy-MM-dd") + "',employee_name='" + paramEmployeeName + "', parent_id='" + paramParentID + "' where product_class_id ='" + paramClassCode + "' ";
            returnValue = mysqlconn.ExeNonQuery(strSql);
            return returnValue;
        }

        public bool DeleteProductClass(string ClassId)
        {
            string sql = "delete from product_class where product_class_id='"+ClassId+"'";
            return mysqlconn.ExeNonQuery(sql) > 0 ? true : false;
        }
    }
}
