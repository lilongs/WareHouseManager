using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DALayer
{
    public class DAStockOutOrder
    {
        Sqlconn sqlconn = new Sqlconn();
        public DataTable GetStockInfo(string storeHouseID,string locationID, string productID,string productName)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"select a.order_no,a.location_id,a.supplier_id,f.name,e.store_house_id,e.location_no,a.product_id,b.product_name,
                        product_spec,product_class_name,product_unit_name,a.quantity,a.price,a.total_price
                        from stock a
                        left join product_list b on a.product_id=b.product_id
                        left join product_class c on b.product_class_id=c.product_class_id
                        left join product_unit d on b.product_unit_id=d.product_unit_id
                        left join store_house_location e on a.location_id=e.id
                        left join supplier f on a.supplier_id=f.supplier_id
                        where a.quantity>0 ");
            if (!String.IsNullOrEmpty(locationID))
            {
                str.Append("and a.location_id  ='" + locationID + @"' ");
            }
            if (!String.IsNullOrEmpty(storeHouseID))
            {
                str.Append("and store_house_id='" + storeHouseID + "'");
            }
            if (!String.IsNullOrEmpty(productID))
            {
                str.Append(" and a.product_id like '%" + productID + "%'");
            }
            if (!String.IsNullOrEmpty(productName))
            {
                str.Append(" and product_name like '%"+ productName + "%'");
            }
            str.Append(" order by order_no ");
            return sqlconn.Query(str.ToString()).Tables[0];
        }

        public int TodayCountStockOut()
        {
            string sql = "select count(*)+1 from stock_out_order where DateDiff(dd, stock_out_date, getdate()) = 0 ";
            return Convert.ToInt32(sqlconn.Query(sql).Tables[0].Rows[0][0]);
        }

        public bool StockOut(List<Mo_StockOutOrderDetail> list)
        {
            List<string> sqlList = new List<string>();
            string StockOutOrder = @"insert into stock_out_order (out_order_no, stock_out_date, operator)
                                    values('"+ list [0].out_order_no+ "', getdate(), '"+ list[0].operators+ "')";
            sqlList.Add(StockOutOrder);
            foreach (Mo_StockOutOrderDetail detail in list)
            {
                decimal outStockTotalPrice = Convert.ToInt32(detail.out_quantity)* Convert.ToDecimal(detail.price);
                string StockOutOrderDetail = @"insert into stock_out_order_detail(product_id, quantity, price, total_price, out_order_no,supplier_id, project_no)
                                values('" + detail .product_id+ "','"+detail.out_quantity+"','"+detail.price+"','"+ outStockTotalPrice + "','"+detail.out_order_no+"','"+detail.supplier_id+"','"+detail.project_no+"')";
                sqlList.Add(StockOutOrderDetail);

                string UpdateStock = @"update stock set quantity = quantity - " + Convert.ToInt32(detail.out_quantity) + @",total_price=total_price - "+ outStockTotalPrice + @"
                            where order_no = '" + detail.order_no+ "' and product_id = '"+detail.product_id+"' and location_id = '"+detail.location_id+"' and supplier_id='"+detail.supplier_id+"'";
                sqlList.Add(UpdateStock);
            }
            return sqlconn.ExecuteSqlTran(sqlList)>0?true:false;
        }

        public DataTable GetStockOutInfo(string startTime,string endTime,string projectNo)
        {
            string sql = @"select a.out_order_no,stock_out_date,operator,b.product_id,c.product_name,
                        f.name,c.product_spec,d.product_class_name,e.product_unit_name,
                        quantity,price,total_price,b.project_no,project_name
                        from stock_out_order a
                        left join stock_out_order_detail b on a.out_order_no=b.out_order_no
                        left join product_list c on b.product_id=c.product_id
                        left join product_class d on c.product_class_id=d.product_class_id
                        left join product_unit e on c.product_unit_id=e.product_unit_id
                        left join supplier f on b.supplier_id=f.supplier_id
                        left join project g on b.project_no=g.project_no 
                        where stock_out_date between '"+ startTime + "' and '"+ endTime + "' ";
            if(!String.IsNullOrEmpty(projectNo))
            {
                sql += " and b.project_no='"+projectNo+"'";
            }
            return sqlconn.Query(sql).Tables[0];
        }
    }
}
