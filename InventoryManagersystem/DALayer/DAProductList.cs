using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DALayer;

namespace DALayer
{
    public class DAProductList
    {
        Sqlconn dbhelpersqlformess = new Sqlconn();

        string SQL = string.Empty;//保持SQL语句
        Sqlconn mysqlconn = new Sqlconn();
        public int ProductAdd(string paramProductID, string paramProductClassID, string paramProductName, string paramProductSpec , string paramUnitID, string paramEmployeeName, string paramRemark)
        {
            int returnValue = 0;
            string strSql = "INSERT INTO product_list(product_id,product_class_id,product_name,product_spec,product_unit_id,createby,remark,create_date) Values ('" + paramProductID + "', '" + paramProductClassID + "','" + paramProductName + "','" + paramProductSpec + "','" + paramUnitID + "','" + paramEmployeeName + "','" + paramRemark + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
            returnValue = mysqlconn.ExeNonQuery(strSql);
            return returnValue;
            
        }

        public bool ProductDelete(string ProductId)
        {
            string sql = "delete from product_list where product_id='"+ ProductId + "'";
            return mysqlconn.ExecuteNonQuery(sql) > 0 ? true : false;
        }
        public bool UpdateProductList(string paramProductID, string paramProductClassID, string paramProductName, string paramProductSpec, string paramUnitID, string paramEmployeeName, string paramRemark)
        {
            int returnValue = 0;
            string strSql = "update product_list set product_name='" + paramProductName + "',product_class_id='" + paramProductClassID + "',product_spec='" + paramProductSpec + "', product_unit_id = '" + paramUnitID + "',remark = '" + paramRemark + "',createby='" + paramEmployeeName + "',create_date='" + DateTime.Now.ToString("yyy-MM-dd") + "' where product_id ='" + paramProductID + "' ";
            returnValue = mysqlconn.ExeNonQuery(strSql);
            return returnValue>0?true:false;
        }
        public bool IsExistsProduct(string productID)
        {
            string sql = "select count(product_id) from product_list where product_id='"+productID+"'";
            return mysqlconn.Exists(sql);
        }

        /// <summary>
        /// 模糊查询物料信息
        /// </summary>
        /// <param name="paramItemName"></param>
        /// <returns></returns>
        public DataTable GetProductInfoByName(string paramItemName, string productId)
        {
            DataTable myDt = new DataTable();
            try
            {
                SQL = @"select product_id ,product_name , a.product_class_id,product_class_name  ,product_spec,
                        product_unit_name,a.product_unit_id,createby,a.remark,a.create_date
                        from product_list a
                        left join  product_class b on  b.product_class_id=a.product_class_id 
                        left join product_unit c on a.product_unit_id=c.product_unit_id
                        where 1=1 ";
                if(!String.IsNullOrEmpty(paramItemName))
                    SQL+=" and product_name like '%" + paramItemName + "%'";
                if(!String.IsNullOrEmpty(productId))
                    SQL += " and product_id like '%" + productId + "%'";
                DataSet myDs = new DataSet();
                myDs = mysqlconn.Query(SQL);
                myDt = myDs.Tables[0];
                return myDt;
            }
            catch 
            {
                return myDt;
               
            }
        }

        #region excel导入数据插入到数据库
        public int Excel_InsertProductList(DataTable dtData, int index, int Total)
        {
            int Result = 0;
            string strSql = string.Empty;
            string strSql_Midden = string.Empty;
            string strSql_End = string.Empty;

            strSql = "Insert into product_list (";
            for (int i = 0; i < dtData.Columns.Count; i++)
            {
                string Value = dtData.Rows[0][dtData.Columns[i].ColumnName].ToString();
                if (Value == string.Empty )
                {
                    continue;
                }
                if (strSql_Midden == string.Empty)
                {
                    strSql_Midden = dtData.Columns[i].ColumnName;
                }
                else
                {
                    strSql_Midden = strSql_Midden + "," + dtData.Columns[i].ColumnName;
                }

                if (strSql_End == string.Empty)
                {
                    strSql_End = Value;
                }
                else
                {
                    strSql_End = strSql_End + "," + Value;
                }
            }

            strSql = strSql + strSql_Midden + ") VALUES(" + strSql_End + ")";
            Result = dbhelpersqlformess.BatchOperateDATA(strSql, index, Total);
            return Result;
        }
        #endregion
    }
}
