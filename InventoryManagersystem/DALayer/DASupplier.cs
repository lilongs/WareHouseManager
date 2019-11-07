using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DALayer
{
    public class DASupplier
    {
        Sqlconn mySqlconn = new Sqlconn();
        /// <summary>
        /// 新增供应商信息
        /// </summary>
        /// <param name="SupplierID"></param>
        /// <param name="Name"></param>
        /// <param name="Address"></param>
        /// <param name="Phone"></param>
        /// <param name="Fax"></param>
        /// <param name="PostalCode"></param>
        /// <param name="ConstactPerson"></param>
        /// <returns></returns>
        public int InsertSupplier(string SupplierID , string Name,string Address,string Phone,string Fax,
                                    string PostalCode,string ConstactPerson)
        {
            string Sql = string.Empty;
            string str = string.Empty;
            str = "select * from  Supplier where supplier_id='" + SupplierID + "'";
            DataSet myDs = new DataSet();
            myDs = mySqlconn.Query(str);
            if (myDs.Tables[0].Rows.Count > 0)
            {
                return -1;      //返回-1，Supplier表中已存在该SupplierID
            }
            else
            {
                Sql = "insert into Supplier (supplier_id, name, address, phone, fax, postal_code, constact_person, create_date)values('" + SupplierID + "','" + Name + "','" + Address + "','" + Phone + "','" + Fax + "','" + PostalCode + "','" + ConstactPerson + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
                int i = mySqlconn.ExecuteNonQuery(Sql);
                return i;
            }
        }

        /// <summary>
        /// 供应商信息更新
        /// </summary>
        /// <param name="SupplierID"></param>
        /// <param name="Name"></param>
        /// <param name="Address"></param>
        /// <param name="Phone"></param>
        /// <param name="Fax"></param>
        /// <param name="PostalCode"></param>
        /// <param name="ConstactPerson"></param>
        /// <returns></returns>
        public int UpdateSupplier(string SupplierID, string Name, string Address, string Phone, string Fax,
                                    string PostalCode, string ConstactPerson)
        {
            string Sql = string.Empty;
            Sql = "update Supplier set Name='" + Name + "',Address='" + Address + "',Phone='" + Phone + "',Fax='" + Fax + "',postal_code='" + PostalCode + "',constact_person='" + ConstactPerson + "',create_date='" + DateTime.Now.ToString("yyyy-MM-dd") + "' where supplier_id='" + SupplierID + "'";
            int i = mySqlconn.ExecuteNonQuery(Sql);
            return i;
        }

        public int DeleteSupplier(string SupplierID)
        {
            string Sql = string.Empty;
            int i=0;
            Sql = "delete from Supplier where supplier_id='" + SupplierID + "'";
            i = mySqlconn.ExecuteNonQuery(Sql);
            return i;
        }

        public DataSet GetAllSupplierList(string paramSupplierName)
        {
            StringBuilder Sql = new StringBuilder();
            Sql.Append("select * from Supplier where  1=1");
            if (paramSupplierName.Length > 0)
            {
                Sql.Append(" and  Name like'" + paramSupplierName + "%'");
            }
            DataSet myDs = new DataSet();
            myDs = mySqlconn.Query(Sql.ToString());
            return myDs;
        }

        public DataSet GetAllSupplier_Name(string paramSupplierName)
        {
            StringBuilder Sql = new StringBuilder();
            Sql.Append("select supplier_id,Name,Address from Supplier where Name like '%" + paramSupplierName + "%'");
            DataSet myDs = new DataSet();
            myDs = mySqlconn.Query(Sql.ToString());
            return myDs;
        }
    }
}
