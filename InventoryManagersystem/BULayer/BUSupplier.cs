using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DALayer;


namespace BULayer{
    
    public class BUSupplier
    {
        DASupplier dal = new DASupplier();
        public int InsertSupplier(string SupplierID, string Name, string Address, string Phone, string Fax,
                                    string PostalCode, string ConstactPerson)
        {
            return dal.InsertSupplier(SupplierID, Name, Address, Phone, Fax, PostalCode, ConstactPerson);
        }

        public int UpdateSupplier(string SupplierID, string Name, string Address, string Phone, string Fax,
                                    string PostalCode, string ConstactPerson)
        {
            return dal.UpdateSupplier(SupplierID, Name, Address, Phone, Fax, PostalCode, ConstactPerson);
        }

        public int DeleteSupplier(string SupplierID)
        {
            return dal.DeleteSupplier(SupplierID);
        }
        /// <summary>
        /// 获取所有信息
        /// </summary>
        /// <param name="paramInventID"></param>
        /// <returns></returns>
        public DataSet GetAllSupplierListByName(string paramSupplierName)
        {
            return dal.GetAllSupplierList(paramSupplierName);
        }

        
    }
}
