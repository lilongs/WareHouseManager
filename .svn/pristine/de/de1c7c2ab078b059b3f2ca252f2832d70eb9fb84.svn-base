using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALayer;
using System.Data;

namespace BULayer
{
    public  class BLLModelInfo
    {
        DALModelInfo dal = new DALModelInfo();
            /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return dal.GetMaxId();
        }
        /// <summary>
       /// 获取权限模块表
       /// </summary>
       /// <param name="paramRoleID"></param>
       /// <returns></returns>
        public DataSet GePermission(string paramRoleID)
        {
            return dal.GePermission(paramRoleID);
        }
         /// <summary>
       /// 获取模块表的主键ID，以便权限表的循环添加
       /// </summary>
       /// <returns></returns>
        public DataSet GetModuleIDList()
        {
            return dal.GetModuleIDList();
        }
        /// <summary>
        /// 是否存在该角色的权限记录
        /// </summary>
        public bool Exists(string paramRoldeID, string paramModelID)
        {
            return dal.Exists(paramRoldeID, paramModelID);
        }
          /// <summary>
       /// 获取到模块信息
       /// </summary>
       /// <returns></returns>
        public DataSet GetAllList(string paramID)
        {
            return dal.GetAllList(paramID);
        }
            /// <summary>
        /// 获取到主模块信息
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllParentList(string paramParentID)
        {
            return dal.GetAllParentList(paramParentID);
        }
        /// <summary>
       /// 添加模块信息
       /// </summary>
       /// <param name="paramModeName"></param>
       /// <param name="paramFormName"></param>
       /// <param name="paramParentID"></param>
       /// <returns></returns>
        public int AddModuleInfo(string paramModeName, string paramFormName, string paramParentID)
        {
            return dal.AddModuleInfo(paramModeName,  paramFormName,  paramParentID);
        }
         
        /// <summary>
        /// g更新模块信息
        /// </summary>
        /// <param name="paramID"></param>
        /// <param name="paramModeName"></param>
        /// <param name="paramFormName"></param>
        /// <param name="paramParentID"></param>
        /// <returns></returns>
        public int UpdateModuleInfo(int paramID, string paramModeName, string paramFormName, string paramParentID)
        {
            return dal.UpdateModuleInfo(paramID,  paramModeName,  paramFormName,  paramParentID);
        }
    }
}
