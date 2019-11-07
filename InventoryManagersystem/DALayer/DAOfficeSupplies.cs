using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DALayer
{
    public class DAOfficeSupplies
    {
        Sqlconn mysqlconn = new Sqlconn();
        public DataTable GetOfficeSuppliesList(string Name)
        {
            string sql = "select * from office_supplies_list where 1=1 ";
            if (!String.IsNullOrEmpty(Name))
            {
                sql += " name like '" + Name + "' ";
            }
            return mysqlconn.Query(sql).Tables[0];
        }

        public bool SuppliesAdd(string location,string  name,string  model,string  price,string  quantity,string  unit,string  create_time,string  status,string  keeper,string  remark)
        {
            List<string> sqlList = new List<string>();
            string sql = @"insert into office_supplies_list
                    (location, name, model, price, quantity, unit, create_time, status, keeper, remark)
                    values('"+location+"','"+ name+"','"+ model+"','"+ price+"','"+ quantity+"','"+ unit+"','"+ create_time+"','"+ status+"','"+ keeper+"','"+ remark+"')";
            sqlList.Add(sql);

            string sql2 = @"insert into supplies_flow_doc(supplies_id, location, status, keeper, create_time)
                        values(SCOPE_IDENTITY(),'"+location+"','"+status+"','"+keeper+"','"+create_time+"')";
            sqlList.Add(sql2);

            return mysqlconn.ExecuteSqlTran(sqlList) > 0 ? true : false;
        }

        public bool SuppliesUpdate(string SuppliesId,string location,string status,string keeper,string remark)
        {
            List<string> sqlList = new List<string>();
            string sql = "update office_supplies_list set location='" + location + "',status='" + status + "',keeper='" + keeper + "'";
            if (!String.IsNullOrEmpty(remark)) 
                sql += " ,remark='" + remark + "' ";
            sql+=" where id='"+SuppliesId+"' ";
            sqlList.Add(sql);

            string sql2 = @"insert into supplies_flow_doc(supplies_id, location, status, keeper, create_time)
                        values('"+ SuppliesId + "','" + location + "','" + status + "','" + keeper + "',getdate())";
            sqlList.Add(sql2);

            return mysqlconn.ExecuteSqlTran(sqlList) > 0 ? true : false;
        }
    }
}
