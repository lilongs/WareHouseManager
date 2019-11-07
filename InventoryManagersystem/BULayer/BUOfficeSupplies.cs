using DALayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BULayer
{
    public class BUOfficeSupplies
    {
        DAOfficeSupplies dal = new DAOfficeSupplies();
        public DataTable GetOfficeSuppliesList(string Name)
        {
            return dal.GetOfficeSuppliesList(Name);
        }

        public bool SuppliesAdd(string location, string name, string model, string price, string quantity, string unit, string create_time, string status, string keeper, string remark)
        {
            return dal.SuppliesAdd(location, name, model, price, quantity, unit, create_time, status, keeper, remark);
        }

        public bool SuppliesUpdate(string SuppliesId, string location, string status, string keeper, string remark)
        {
            return dal.SuppliesUpdate(SuppliesId, location, status, keeper, remark);
        }
    }
}
