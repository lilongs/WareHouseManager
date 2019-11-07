using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DALayer
{
    /// <summary>
    /// 根据产品单位条件，查出产品单位表相关字段内容
    /// </summary>
    public class DAProductManagerResult
    {
        Sqlconn MySqlConn = new Sqlconn();
        public DataTable GetMyDt(string productUnitName)
        {
            DataTable myResult = new DataTable();
            //string strSql = "SELECT ProductUnitID,ProductUnitName,Remark FROM ProductUnit WHERE ProductUnitName = '"+productUnitName+"' ";
            string strSql = "SELECT ProductUnitID,ProductUnitName,Remark FROM ProductUnit WHERE 1 = 1";
            if (productUnitName.Length > 0)
            {
                strSql +="AND ProductUnitName = '" + productUnitName + "' ";
            }
            //Sqlconn MySqlConn = new Sqlconn();
            DataSet MyDs = new DataSet();
            MyDs = MySqlConn.Query(strSql);
            myResult = MyDs.Tables[0];
            return myResult;

        }

        public DataTable GetProductClassTable(string paramProductClassName,string paramProductClassCode)
        {
            DataTable MyTable = new DataTable();
            DataSet MyDs = new DataSet();
            string strSql = "select ProductClassID,ProductClassName,CreateDate,EmployeeID,Remark from ProductClass where 1=1";
            if (paramProductClassName.Length == 0 && paramProductClassCode.Length == 0 )
            {
                strSql = "select ProductClassID,ProductClassName,CreateDate,EmployeeID,Remark from ProductClass";
            }
            if (paramProductClassName.Length >0)
            {
                strSql += "and ProductClassName = '" + paramProductClassName + "'";
            }
            if (paramProductClassCode.Length >0)
            {
                strSql += "and ProductClassID = '" + paramProductClassCode + "'";
            }

            MyDs = MySqlConn.Query(strSql);
            MyTable = MyDs.Tables[0];
            return MyTable;
        }

        public bool CheckUnitName(string paramUnitName)
        {
            bool myResult = false;
            int myValue = 0;
            myValue = GetMyDt(paramUnitName).Rows.Count;
           
            if (myValue > 0)
            {
                myResult = true;
                return myResult;

            }

            return myResult;
        }
        public bool DelData(string ProductUnitID)
        {
            int ReturnValue = 0;
            string strSql = "delete  from ProductUnit where ProductUnitID = '" + ProductUnitID + "'";
           //Sqlconn mySqlconn = new Sqlconn();

            ReturnValue = MySqlConn.ExeNonQuery(strSql); ;

            if (ReturnValue > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public int UpdateUnitReturnRowCount(string paramUnitName,string paramRemark,string paramUnitCode)
        {
            int returnValue = 0;
            string strSql = "update ProductUnit set ProductUnitName = '" + paramUnitName + "',Remark = '" + paramRemark + "' where ProductUnitID ='"+paramUnitCode+"' ";
            returnValue =MySqlConn.ExeNonQuery(strSql);

            return returnValue;
        }



    }
}
