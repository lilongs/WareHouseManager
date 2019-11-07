using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALayer;
using System.Data.Sql;
using System.Data;


namespace BULayer
{
    public class BUProductClass
    {
        DAProductClass myDAClass = new DAProductClass();
        public bool ProductClassAdd(string paramClassName, string paramRemark, string paramEmployeeName, string paramParentID)
        {
            bool returnValue = false;
            int excuteRows = myDAClass.ProductClassAdd(paramClassName, paramRemark, paramEmployeeName, paramParentID);

            if (excuteRows > 0)
            {
                returnValue = true;
                return returnValue;
            }

            return returnValue;
        }

        /// <summary>
        /// 获取到类比的主类别
        /// </summary>
        /// <returns></returns>
        public DataTable GetClassList(string ParentID)
        {
            return myDAClass.GetClassList(ParentID);
        }

        public DataTable GetClass(string ProductClassID)
        {
            return myDAClass.GetClass(ProductClassID);
        }

        public DataTable GetProductClassByName(string ClassName)
        {
            return myDAClass.GetProductClassByName(ClassName);
        }

        public bool IsExistsClassName(string ClassName)
        {
            return myDAClass.IsExistsClassName(ClassName);
        }

        public int UpdateClass(string paramClassName, string paramRemark, int paramClassCode, string paramEmployeeName, string paramParentID)
        {
            return myDAClass.UpdateClass(paramClassName, paramRemark, paramClassCode, paramEmployeeName, paramParentID);
        }

        public bool DeleteProductClass(string ClassId)
        {
            return myDAClass.DeleteProductClass(ClassId);
        }
    }
}
