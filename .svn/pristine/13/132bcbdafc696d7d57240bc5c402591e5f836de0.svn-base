using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DALayer
{
   public  class DASysInfo
    {
        Sqlconn mySqlconn = new Sqlconn();//实例化类
        string SQL = string.Empty;//保持SQL语句

        /// <summary>
        /// 获取系统基本信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetSysInfo()
        {
            DataTable myDt = new DataTable();
            SQL = "select * from Sys_SystemInfo where 1=1";
            DataSet myDs = new DataSet();
            myDs = mySqlconn.Query(SQL);
            myDt = myDs.Tables[0];
            return myDt;
        }

        /// <summary>
        /// 获取系统模块基本信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetSysModuleInfo(string paramSysNameID)
        {
            DataTable myDt = new DataTable();
            SQL = "select * from Sys_SystemModule where SysNameID='" + paramSysNameID + "'";
            DataSet myDs = new DataSet();
            myDs = mySqlconn.Query(SQL);
            myDt = myDs.Tables[0];
            return myDt;
        }

        /// <summary>
        /// 获取系统模块子节点基本信息
        /// </summary>
        /// <returns></returns>
        public DataTable Get_SysChildNode(string paramSysModelID)
        {
            DataTable myDt = new DataTable();
            SQL = "select * from Sys_SysChildNode where SysModelID='" + paramSysModelID + "'";
            DataSet myDs = new DataSet();
            myDs = mySqlconn.Query(SQL);
            myDt = myDs.Tables[0];
            return myDt;
        }
    }
}
