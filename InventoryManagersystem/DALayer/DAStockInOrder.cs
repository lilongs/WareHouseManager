using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DALayer
{
    /// <summary>
    /// 入库
    /// </summary>
    public class DAStockInOrder
    {
        Sqlconn mySqlconn = new Sqlconn();

        /// <summary>
        /// 获取当天最大单号
        /// </summary>
        /// <returns></returns>
        public DataTable GetTodayOrderCount()
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"select count(*)+1 as counts from stock_in_order
                        where  DateDiff(dd, stock_in_date, getdate()) = 0");
            return mySqlconn.Query(str.ToString()).Tables[0];
        }

        /// <summary>
        /// 商品入库
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool StockIn(List<Mo_StockInOrderDetail> list)
        {
            List<string> listSql = new List<string>();
            string StockOrder = @"insert into stock_in_order (order_no, stock_in_date, operator) 
                                values('"+list[0].orderNo+"', '"+list[0].stockInDate+ "', '" + list[0].operators + "') ";
            listSql.Add(StockOrder);
            foreach (Mo_StockInOrderDetail detail in list)
            {
                string detailStr = @"insert into stock_in_order_detail(location_id, product_id, quantity, price, total_price, supplier_id, order_no)
                                    values ('" + detail.locationId + "','" + detail.productId + "','" + detail.quantity + "','" + detail.price + "','" + detail.totalPrice + "','" + detail.supplierId + "','" + detail.orderNo + "')";
                listSql.Add(detailStr);

                string updateStockInfo = @"insert into stock(order_no, product_id, location_id, supplier_id, quantity, price, total_price)
                                        values('"+ detail.orderNo+ "','" + detail.productId + "','" + detail.locationId + "', '"+detail.supplierId+"','" + detail.quantity + "','" + detail.price + "','" + detail.totalPrice + "')";
                listSql.Add(updateStockInfo);
            }
            return mySqlconn.ExecuteSqlTran(listSql)>0?true:false;
        }

        /// <summary>
        /// 入库对账单
        /// </summary>
        /// <param name="supplierID"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public DataTable GetStockInDetail(string supplierID,string startTime,string endTime)
        {
            StringBuilder str = new StringBuilder();
            str.Append(@"select d.store_house_id,d.location_no,a.order_no,
                    b.supplier_id,e.name,b.product_id,c.product_name,
                    c.product_spec,f.product_unit_name,g.product_class_name,
                    b.price,b.quantity,b.total_price,a.stock_in_date,a.operator
                    from stock_in_order a
                    left join stock_in_order_detail b on a.order_no=b.order_no
                    left join product_list c on b.product_id=c.product_id
                    left join store_house_location d on b.location_id=d.id
                    left join supplier e on b.supplier_id=e.supplier_id
                    left join product_unit f on c.product_unit_id=f.product_unit_id
                    left join product_class g on c.product_class_id=g.product_class_id
                    where stock_in_date between '"+ startTime + "' and '"+ endTime + "' ");
            if (!String.IsNullOrEmpty(supplierID))
            {
                str.Append("and b.supplier_id='"+supplierID+"'");
            }
            return mySqlconn.Query(str.ToString()).Tables[0];
        }
    }
}
