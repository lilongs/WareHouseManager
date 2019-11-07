using DALayer;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BULayer
{
    public class BUStockInOrder
    {
        DAStockInOrder dal = new DAStockInOrder();

        /// <summary>
        /// 获取当天最大单号
        /// </summary>
        /// <returns></returns>
        public int GetTodayOrderCount()
        {
            DataTable dt = dal.GetTodayOrderCount();
            if (dt != null)
            {
                return Convert.ToInt32(dt.Rows[0][0]);
            }
            return 0;
        }

        /// <summary>
        /// 商品入库
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool StockIn(List<Mo_StockInOrderDetail> list)
        {
            return dal.StockIn(list);
        }

        /// <summary>
        /// 入库对账单
        /// </summary>
        /// <param name="supplierID"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public DataTable GetStockInDetail(string supplierID, string startTime, string endTime)
        {
            return dal.GetStockInDetail(supplierID, startTime, endTime);
        }
    }
}
