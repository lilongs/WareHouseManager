using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DALayer
{
    public class DALModuleInfo
    {
        Sqlconn mySqlconn = new Sqlconn();

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return mySqlconn.GetMaxID("ID", "T_Module");
        }
        /// <summary>
        /// 获取权限模块表
        /// </summary>
        /// <param name="paramRoleID"></param>
        /// <returns></returns>
        public DataSet GePermission(string paramRoleID)
        {
            string sqlQuery = @" SELECT T_Module.ID,MODULENAME,PARENTID,FORMNAME ,[Enable] FROM T_Module,T_Role WHERE 
                       T_Role.MODULEID=T_Module.ID  AND ROLEID='" + paramRoleID + "' ";
            DataSet myDs = new DataSet();
            myDs = mySqlconn.Query(sqlQuery);
            return myDs;
        }
        /// <summary>
        /// 获取模块表的主键ID，以便权限表的循环添加
        /// </summary>
        /// <returns></returns>
        public DataSet GetModuleIDList()
        {
            string SqlQuery = "Select ID from  T_Module";
            DataSet myDs = new DataSet();
            myDs = mySqlconn.Query(SqlQuery);
            return myDs;
        }
        /// <summary>
        /// 是否存在该角色的权限记录
        /// </summary>
        public bool Exists(string paramRoldeID, string paramModelID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_Role where RoleID ='" + paramRoldeID + "' and ModuleID ='" + paramModelID + "'");
            return mySqlconn.Exists(strSql.ToString());
        }

        /// <summary>
        /// 获取到模块信息
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllList(string paramID)
        {
            string SqlQuery = "Select ID, ModuleName, FormName, Convert(int,ParentID) as ParentID, sort  from  T_Module";
            if (paramID.Length > 0)
            {
                SqlQuery += " where ID='"+paramID+"'";
            }
            SqlQuery += @" group by ID, ModuleName, FormName, ParentID, sort 
                        order by Convert(int, ParentID),sort";
            DataSet myDs = new DataSet();
            myDs = mySqlconn.Query(SqlQuery);
            return myDs;
        }
        /// <summary>
        /// 获取到主模块信息
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllParentList(string paramParentID) 
        {
            string SqlQuery = "Select *  from  T_Module";
            if (paramParentID.Length > 0)
            {
                SqlQuery += " where ParentID='" + paramParentID + "'";
            }
            DataSet myDs = new DataSet();
            myDs = mySqlconn.Query(SqlQuery);
            return myDs;
        }



        /// <summary>
        /// 添加模块信息
        /// </summary>
        /// <param name="paramModeName"></param>
        /// <param name="paramFormName"></param>
        /// <param name="paramParentID"></param>
        /// <returns></returns>
        public int AddModuleInfo(string paramModeName, string paramFormName, string paramParentID, string Sort)
        {
            string SqlQuery = @"INSERT INTO T_Module ([ModuleName]  ,[FormName] ,[ParentID],sort)
                              VALUES('" + paramModeName + "','" + paramFormName + "','" + paramParentID + "','"+ Sort + "')";
            int rows = 0;
            rows = mySqlconn.ExecuteNonQuery(SqlQuery);
            return rows;

        }
       
        /// <summary>
        /// g更新模块信息
        /// </summary>
        /// <param name="paramID"></param>
        /// <param name="paramModeName"></param>
        /// <param name="paramFormName"></param>
        /// <param name="paramParentID"></param>
        /// <returns></returns>
        public int UpdateModuleInfo(int paramID, string paramModeName, string paramFormName, string paramParentID,string Sort)
        {
            string SqlQuery = @"UPDATE  T_Module set  ModuleName='" + paramModeName
                                              +"' ,FormName='"+paramFormName
                                              +"' ,ParentID='" +paramParentID+"' ,sort='"+Sort+"'  where ID='"+paramID+"'    ";
            int rows = 0;
            rows = mySqlconn.ExecuteNonQuery(SqlQuery);
            return rows;

        }
    }
}
