using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DALayer
{
    public class DAProductSupplierInfo
    {
        Sqlconn mySqlconn = new Sqlconn();

        public int InsertProSupInfo(string paramProductID, string paramSupplierID, string paramPrice, string paramRemark)
        {
            string Sql = string.Empty;
            Sql = "insert into product_supplier_info (product_id ,supplier_id,pro_price,remark)values('" + paramProductID + "','" + paramSupplierID + "','" + paramPrice + "','" + paramRemark + "')";
            int i = mySqlconn.ExecuteNonQuery(Sql);
            return i;
        }

        public int UpdateProSupInfo(string paramProductID, string paramSupplierID, string paramPrice, string paramRemark)
        {
            string Sql = string.Empty;
            Sql = "update product_supplier_info set pro_price='" + paramPrice + "',remark='" + paramRemark + "' where product_id='" + paramProductID + "' and supplier_id='" + paramSupplierID + "'";
            int i = mySqlconn.ExecuteNonQuery(Sql);
            return i;
        }

        public int DeleteProSupInfo(string paramProductID, string paramSupplierID)
        {
            string Sql = string.Empty;
            Sql = "delete from product_supplier_info where product_id='" + paramProductID + "' and supplier_id='" + paramSupplierID + "'";
            int i = mySqlconn.ExecuteNonQuery(Sql);
            return i;
        }

        public DataSet GetAll_ProSupInfo(string paramProductID, string paramProductName)
        {
            string str = @" select  a.product_id,c.product_name,a.supplier_id,b.name,pro_price,a.remark 
                              from  product_supplier_info a
                              left join  Supplier b  on  a.supplier_id=b.supplier_id
                              left join  Product_List c on  a.product_id=c.product_id
                              Where 1=1";
            if (paramProductID.Length > 0)
            {
                str += " and a.product_id like'%" + paramProductID + "%' ";
            }
            if (paramProductName.Length > 0)
            {
                str += " and c.product_name like '%" + paramProductName + "%'";
            }
            return mySqlconn.Query(str);
        }

        public DataTable GetProductSupplierPrice(string paramProductID, string paramSupplierID)
        {
            DataTable mydt = new DataTable();
            DataSet myds = new DataSet();
            string strSql = @"select pro_price as ProPrice 
                            from product_supplier_info 
                            where product_id='" + paramProductID + "'and supplier_id='" + paramSupplierID + "'";
            myds = mySqlconn.Query(strSql);
            mydt = myds.Tables[0];
            return mydt;
        }

        public bool IsExistsSameSupplier(string productID,string supplierID)
        {
            string sql = "select count(*) from product_supplier_info where product_id='"+productID+"' and supplier_id='"+supplierID+"'";
            return mySqlconn.Exists(sql);
        }
    }
}
