using DALayer;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BULayer
{
    public class BUStockOutOrder
    {
        DAStockOutOrder dal = new DAStockOutOrder();
        public DataTable GetStockInfo(string storeHouseID, string locationID, string productID, string productName)
        {
            return dal.GetStockInfo(storeHouseID, locationID, productID, productName);
        }

        public int TodayCountStockOut()
        {
            return dal.TodayCountStockOut();
        }

        public bool StockOut(List<Mo_StockOutOrderDetail> list)
        {
            return dal.StockOut(list);
        }

        public DataTable GetStockOutInfo(string startTime, string endTime, string projectNo)
        {
            return dal.GetStockOutInfo(startTime, endTime, projectNo);
        }
    }
}
