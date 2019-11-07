using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALayer;

namespace BULayer
{
    public class BUUserManager
    {
        public bool checkOldPassword (string paramUserName,string txtBoxPassword)
        {
            bool returnValue = false;
            
            DAManagerUser myDAManager = new DAManagerUser();
            string myPassword = myDAManager.GetUserPassword(paramUserName).Trim();
            if (myPassword == txtBoxPassword)
            {
                returnValue = true;
                return returnValue;
            }

            return returnValue;

        }


        public int ModifyPassword(string paramUsename,string paramPassword)
        {
            Sqlconn mySqlconn = new Sqlconn();
            int ReturnValue = 0;
            string strSQL = " update adminuser set passwd = '" + paramPassword + "' where username = '" + paramUsename + "' ";
            ReturnValue = mySqlconn.ReturnRowsLine(strSQL);
            return ReturnValue;

        }

    }
}
