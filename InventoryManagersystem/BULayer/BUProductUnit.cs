using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALayer;
using System.Data.Sql;
using System.Data;

namespace BULayer
{

    public class BUProductUnit
    {
        DAProductUnit myDAUnit = new DAProductUnit();

        public DataTable GetUnitInfo(string UnitName)
        {
            return myDAUnit.GetUnitInfo(UnitName);
        }
        public bool UnitDelete(string UnitId)
        {
            return myDAUnit.UnitDelete(UnitId);
        }
        public bool UnitAdd(string paramUnitName, string paramRemark)
        {
            bool returnValue = false;
            int excuteRows = myDAUnit.UnitAdd(paramUnitName, paramRemark);

            if (excuteRows > 0)
            {
                returnValue = true;
                return returnValue;
            }

            return returnValue;
        }


        public bool UnitUpdate(string productUnitId, string paramUnitName, string paramRemark)
        {
            return myDAUnit.UnitUpdate(productUnitId, paramUnitName, paramRemark);
        }

        public bool IsExistsUnitName(string UnitName)
        {
            return myDAUnit.IsExistsUnitName(UnitName);
        }
    }
}
