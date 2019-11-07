using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Mo_StockInOrderDetail
    {
        public string orderNo { get; set; }//入库单号
        public string locationId { get; set; }//库位编码
        public string locationNo { get; set; }//货架号
        public string storeHouseId { get; set; }//仓库编号
        public string productId { get; set; }//产品id
        public string productName { get; set; }//产品名称
        public string productSpec { get; set; }//产品规格
        public string productUnitName { get; set; }//产品单位
        public string productUnitId { get; set; }//产品单位id
        public string productClassName { get; set; }
        public string supplierId { get; set; }//供应商编码
        public string name { get; set; }//供应商名称
        public int quantity { get; set; }//数量
        public decimal price { get; set; }//单价
        public decimal totalPrice { get; set; }//总价
        public DateTime stockInDate { get; set; }//入库时间
        public string operators { get; set; }//入库员
    }
}
