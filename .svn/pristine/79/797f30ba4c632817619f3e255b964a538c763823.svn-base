using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALayer;
using System.Data.Sql;
using System.Data;

namespace BULayer
{
    
    public class BUUnitAdd
    {
        DAUnitAdd myDAUnitAdd = new DAUnitAdd();
        DAProductManagerResult MyPMR = new DAProductManagerResult();
        public bool CheckUnitAdd(string paramUnitName,string paramRemark)
        {
            bool returnValue = false;
            int excuteRows = myDAUnitAdd.UnitAdd(paramUnitName, paramRemark);

            if (excuteRows >0)
            {
                returnValue = true;
                return returnValue;
            }

            return returnValue;
        }

        public bool CheckUnitValue(string paramUnitName)
        {
            bool returnValue = false;

            if (MyPMR.CheckUnitName(paramUnitName))
            {
                returnValue = true;
                return returnValue;
            }
           
            return returnValue;
        }
    }
}
