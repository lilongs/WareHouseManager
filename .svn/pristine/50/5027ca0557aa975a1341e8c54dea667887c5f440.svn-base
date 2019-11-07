using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALayer;
using System.Data;

namespace BULayer
{
   public class BUSysInfo
    {
        DASysInfo myDASysInfo = new DASysInfo(); //实例话DA层类 
         /// <summary>
       /// 获取系统基本信息
       /// </summary>
       /// <returns></returns>
        public DataTable GetSysInfo()
        {
            return myDASysInfo.GetSysInfo();
        }
         /// <summary>
        /// 获取系统模块基本信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetSysModuleInfo(string paramSysNameID)
        {
            return myDASysInfo.GetSysModuleInfo(paramSysNameID);
        }

        /// <summary>
        /// 获取系统模块子节点基本信息
        /// </summary>
        /// <returns></returns>
        public DataTable Get_SysChildNode(string paramSysModelID)
        {
            return myDASysInfo.Get_SysChildNode(paramSysModelID);
        }

      
    }
}
