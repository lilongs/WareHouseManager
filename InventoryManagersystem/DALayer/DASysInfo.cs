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
        ///   获取价格最大值
        /// </summary>
        /// <param name="paramUserName"></param>
        /// <returns></returns>
        public double GetPrice()
        {
            double RetuenValue = 0.0;
            SQL = "select  isnull (MaxPrice,1) as MaxPrice from PriceMax where 1=1 ";
            RetuenValue = Convert.ToDouble(mySqlconn.ExecuteSql(SQL));
            return RetuenValue;
        }

        /// <summary>
        /// 更新价格最大值
        /// </summary>
        /// <returns></returns>
        public bool UpdatePraiceMax(double paramValue)
        {
            bool RetrunValue = false;
            SQL = "UPDATE [PriceMax]  SET  [MaxPrice] =" + paramValue + "  WHERE  1=1 ";
            int row = mySqlconn.ExecuteSqlRow(SQL);
            if (row > 0)
            {
                RetrunValue = true;
            }
            return RetrunValue;
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
