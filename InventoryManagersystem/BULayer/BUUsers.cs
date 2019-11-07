using DALayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BULayer
{
    public class BUUsers
    {
        DAUsers dal = new DAUsers();
        public DataTable GetUserInfo(string paramUserName, string paramPhone)
        {
            return dal.GetUserInfo(paramUserName,paramPhone);
        }

        public bool IsExistsUserName(string UserName)
        {
            return dal.IsExistsUserName(UserName);
        }

        public bool InsertUse(string paramUsename, string paramPasswd,string realname, string paramTelephone, string paramEmail, string paramAddress, int paramRoleID)
        {
            return dal.InsertUse(paramUsename, paramPasswd, realname,paramTelephone, paramEmail, paramAddress, paramRoleID);

        }

        public bool UpdateUser(string paramUsename, string paramTelephone,string realname, string paramEmail, string paramAddress, int paramRoleID)
        {
            return dal.UpdateUser(paramUsename, paramTelephone, realname, paramEmail, paramAddress, paramRoleID);
        }

        public bool DeleteUser(string username)
        {
            return dal.DeleteUser(username);
        }

        public bool UpdateMyPassword(string Username, string NewPassword)
        {
            return dal.UpdateMyPassword(Username, NewPassword);
        }

        public bool CheckUserPassword(string UserName, string OldPassword)
        {
            return dal.CheckUserPassword(UserName, OldPassword);
        }
    }
}
