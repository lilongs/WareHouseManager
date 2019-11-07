using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALayer;
using System.Data;

namespace BULayer
{
    public class BUProject
    {
        DAProject dal = new DAProject();
        /// <summary>
        /// 根据项目编号和名称查询信息
        /// </summary>
        /// <param name="projectNo"></param>
        /// <param name="projectName"></param>
        /// <returns></returns>
        public DataSet GetAllProject(string projectNo,string projectName)
        {
            return dal.GetAllProject(projectNo, projectName);
        }

        public DataTable GetProjectName()
        {
            return dal.GetProjectName();
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.Mo_Project model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.Mo_Project model)
        {
            return dal.Update(model);
        }

        public int Delete(string projectNo)
        {
            return dal.Delete(projectNo);
        }

        public bool IsExists(string projectNo)
        {
            return dal.IsExists(projectNo);
        }
    }
}
