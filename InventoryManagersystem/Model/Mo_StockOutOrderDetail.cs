using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Mo_StockOutOrderDetail
    {
        public string out_order_no { get; set; }
        public string order_no { get; set; }
        public string product_id { get; set; }
        public string product_name { get; set; }
        public string location_id { get; set; }
        public string store_house_id { get; set; }
        public string location_no { get; set; }
        public string supplier_id { get; set; }
        public string name { get; set; }
        public string product_class_name { get; set; }
        public string product_spec { get; set; }
        public string product_unit_name { get; set; }
        public string quantity { get; set; }
        public string price { get; set; }
        public string out_quantity { get; set; }
        public string project_no { get; set; }
        public string operators{get;set;}
        public string stock_out_date { get; set; }

    }

}
