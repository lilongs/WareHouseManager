using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALayer;
using System.Data;

namespace BULayer
{
    public class BUProductSupplierInfo
    {
        DAProductSupplierInfo dal = new DAProductSupplierInfo();

        public int InsertSupplier(string paramProductID, string paramSupplierID, string paramPrice, string paramRemark)
        {
            return dal.InsertProSupInfo(paramProductID, paramSupplierID, paramPrice, paramRemark);
        }

        public int UpdateProSupInfo(string paramProductID, string paramSupplierID, string paramPrice, string paramRemark)
        {
            return dal.UpdateProSupInfo(paramProductID, paramSupplierID, paramPrice, paramRemark);
        }

        public int DeleteProSupInfo(string paramProductID, string paramSupplierID)
        {
            return dal.DeleteProSupInfo(paramProductID, paramSupplierID);
        }

        public DataSet GetAll_ProSupInfo(string paramProductID, string paramProductName)
        {
            return dal.GetAll_ProSupInfo(paramProductID, paramProductName);
        }

        public DataTable GetProductSupplierPrice(string paramProductID, string paramSupplierID)
        {
            return dal.GetProductSupplierPrice(paramProductID, paramSupplierID);
        }

        public bool IsExistsSameSupplier(string productID, string supplierID)
        {
            return dal.IsExistsSameSupplier(productID, supplierID);
        }
    }
}
