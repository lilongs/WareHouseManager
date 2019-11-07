using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALayer;
using System.Data;

namespace BULayer
{
    public class BUProductList
    {
        DAProductList myDAProductList = new DAProductList();
        public bool CheckProductAdd(string paramProductID, string paramProductClassID, string paramProductName, string paramProductSpec, string paramUnitID, string paramEmployeeName, string paramRemark)
        {
            bool returnValue = false;
            int excuteRows = myDAProductList.ProductAdd(paramProductID, paramProductClassID, paramProductName, paramProductSpec, paramUnitID, paramEmployeeName, paramRemark);

            if (excuteRows > 0)
            {
                returnValue = true;
                return returnValue;
            }

            return returnValue;
        }

        public bool ProductDelete(string ProductId)
        {
            return myDAProductList.ProductDelete(ProductId);
        }

        public bool UpdateProductList(string paramProductID, string paramProductClassID, string paramProductName, string paramProductSpec, string paramUnitID, string paramEmployeeName, string paramRemark)
        {
            return myDAProductList.UpdateProductList(paramProductID, paramProductClassID, paramProductName, paramProductSpec, paramUnitID, paramEmployeeName,  paramRemark);
        }

        public bool IsExistsProduct(string productID)
        {
            return myDAProductList.IsExistsProduct(productID);
        }

        /// <summary>
        /// 模糊查询物料信息
        /// </summary>
        /// <param name="paramItemName"></param>
        /// <returns></returns>
        public DataTable GetProductInfoByName(string paramItemName, string productId)
        {
            return myDAProductList.GetProductInfoByName(paramItemName, productId);
        }

        #region excel导入数据     
        public int Excel_InsertProductList(DataTable Data, int index, int Total)
        {
            return myDAProductList.Excel_InsertProductList(Data, index, Total);
        }
        #endregion
    }
}
