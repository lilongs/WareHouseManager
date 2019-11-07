using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALayer;
using System.Data;

namespace BULayer
{
   public class BLIRoleInfo
    {
       DAIRoleInfo dal = new DAIRoleInfo();
        #region  Method

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return dal.GetMaxId();
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetRoleList(string strWhere)
        {
            return dal.GetRoleList(strWhere);
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int RoleID)
        {
            return dal.Exists(RoleID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.MoIRoleInfo model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.MoIRoleInfo model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int RoleID)
        {

            return dal.Delete(RoleID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string RoleIDlist)
        {
            return dal.DeleteList(RoleIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.MoIRoleInfo GetModel(int RoleID)
        {

            return dal.GetModel(RoleID);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetRoleAllList(string strWhere)
        {
            return dal.GetRoleAllList(strWhere);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 通过选中的节点将该权限下的模块增删改查的权限查出来来
        /// </summary>
        /// <param name="paramRoleID"></param>
        /// <param name="paramModuleID"></param>
        /// <returns></returns>
        public DataSet GetCheckRoleInfo(string paramRoleID, string paramModuleID, string paramModuleName)
        {

            return dal.GetCheckRoleInfo(paramRoleID, paramModuleID, paramModuleName);
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }

       

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool ExistsRoleID(int UserRole)
        {
            return dal.ExistsRoleID(UserRole);
        }

         /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.MoRole model)
        {
            return dal.Add(model);
        }
         /// <summary>
        /// 更新权限
        /// </summary>
        /// <param name="myModelRole"></param>
        /// <returns></returns>
        public int updateRole(Model.MoRole myModelRole)
        {
            return dal.updateRole(myModelRole);
        }
        #endregion  Method
    }
}
