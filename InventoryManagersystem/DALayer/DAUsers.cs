using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DALayer
{
    public class DAUsers
    {
        Sqlconn mySqlconn = new Sqlconn();
        public DataTable GetUserInfo(string paramUserName, string paramPhone)
        {
            DataTable myDt = new DataTable();
            string SQL = string.Empty;
            SQL = @"select username,telephone,realname,email,address,createtime ,users.RoleID,T_RoleInfo.RoleName  
                    from users 
                    left join T_RoleInfo  on  users.RoleID=T_RoleInfo.RoleID  where 1=1";
            if (paramUserName.Length > 0)
            {
                SQL += " and  username ='" + paramUserName + "'";
            }
            if (paramPhone.Length > 0)
            {
                SQL += " and  telephone = '" + paramPhone + "'";
            }
            myDt = mySqlconn.Query(SQL).Tables[0];
            return myDt;
        }

        public bool IsExistsUserName(string UserName)
        {
            string sql = @"select count(username) from users where username='" + UserName+"'";
            return mySqlconn.Exists(sql);
        }

        public bool InsertUse(string paramUsename, string paramPasswd,string realname, string paramTelephone, string paramEmail, string paramAddress, int paramRoleID)
        {
            string strSQL = @" insert into users  (username,passwd,realname,telephone,email,address,RoleID,CreateTime)
               values('" + paramUsename + " ','" + paramPasswd + "','"+realname+"','" + paramTelephone + "','" + paramEmail + "','" + paramAddress + "'," + paramRoleID + ",CONVERT(nvarchar(200), GETDATE(), 20))";
            return mySqlconn.ReturnRowsLine(strSQL)>0?true:false;

        }

        public bool UpdateUser(string paramUsename, string paramTelephone,string realname, string paramEmail, string paramAddress, int paramRoleID)
        {
            string strSQL = " update users set telephone = '" + paramTelephone + "',realname='"+realname+"' ,[address] = '" + paramAddress + "',email = '" + paramEmail + "',RoleID=" + paramRoleID + " where username = '" + paramUsename + "' ";
            return mySqlconn.ReturnRowsLine(strSQL)>0?true:false; 
        }

        public bool DeleteUser(string username)
        {
            string strSql = "delete  from users where username = '" + username + "'";
            return mySqlconn.ExeNonQuery(strSql)>0?true:false ;
        }

        public bool UpdateMyPassword(string Username,string NewPassword)
        {
            string strSQL = " update users set passwd = '" + NewPassword + "' where username = '" + Username + "' ";
            return mySqlconn.ExecuteNonQuery(strSQL)>0?true:false;
        }

        public bool CheckUserPassword(string UserName,string OldPassword)
        {
            string sql = "select count(username) from users where username='"+UserName+"' and passwd='"+OldPassword+"'";
            return mySqlconn.Exists(sql);
        }
    }
}
