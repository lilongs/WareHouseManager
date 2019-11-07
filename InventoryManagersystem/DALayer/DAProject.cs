using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DALayer
{
    public class DAProject
    {
        Sqlconn mySqlconn = new Sqlconn();

        public DataSet GetAllProject(string projectNo, string projectName)
        {
            StringBuilder Sql = new StringBuilder();            
            Sql.Append("select * from project where 1=1");
            if (!String.IsNullOrEmpty(projectNo))
            {
                Sql.Append(" and project_no like '%"+ projectNo + "%' ");
            }
            if (!String.IsNullOrEmpty(projectName))
            {
                Sql.Append(" and project_name like '%"+projectName+"%'");
            }
            Sql.Append(" order by project_start_date");
            DataSet myDs = new DataSet();
            myDs = mySqlconn.Query(Sql.ToString());
            return myDs;
        }

        public DataTable GetProjectName()
        {
            StringBuilder Sql = new StringBuilder();
            Sql.Append("select project_no,project_name from project ");
            return mySqlconn.Query(Sql.ToString()).Tables[0];
        }


        public bool Add(Model.Mo_Project model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into project ");
            strSql.Append("(project_no, project_name, project_header, project_start_date, project_end_date, project_company, project_contact, contact_phone, remark) ");
            strSql.Append("values ");
            strSql.Append("(@project_no,@project_name,@project_header,@project_start_date,@project_end_date,@project_company,@project_contact,@contact_phone,@remark)");
            SqlParameter[] parameters = {
                    new SqlParameter("@project_no", SqlDbType.NVarChar),
                    new SqlParameter("@project_name", SqlDbType.VarChar),
                    new SqlParameter("@project_header", SqlDbType.NVarChar),
                    new SqlParameter("@project_start_date", SqlDbType.DateTime),
                    new SqlParameter("@project_end_date", SqlDbType.DateTime),
                    new SqlParameter("@project_company", SqlDbType.NVarChar),
                    new SqlParameter("@project_contact", SqlDbType.NVarChar),
                    new SqlParameter("@contact_phone", SqlDbType.NVarChar),
                    new SqlParameter("@remark",SqlDbType.NVarChar)};
            parameters[0].Value = model.projectNo;
            parameters[1].Value = model.projectName;
            parameters[2].Value = model.projectHeader;
            parameters[3].Value = model.projectStartDate;
            parameters[4].Value = model.projectEndDate;
            parameters[5].Value = model.projectCompany;
            parameters[6].Value = model.projectContact;
            parameters[7].Value = model.contactPhone;
            parameters[8].Value = model.remark;

            int rows = mySqlconn.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.Mo_Project model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" update project ");
            strSql.Append(" set project_name=@project_name, project_header=@project_header, project_start_date=@project_start_date, project_end_date=@project_end_date, project_company=@project_company, project_contact=@project_contact, contact_phone=@project_contact, remark=@remark ");
            strSql.Append(" where project_no=@project_no");
            SqlParameter[] parameters = {
                    new SqlParameter("@project_no", SqlDbType.NVarChar),
                    new SqlParameter("@project_name", SqlDbType.VarChar),
                    new SqlParameter("@project_header", SqlDbType.NVarChar),
                    new SqlParameter("@project_start_date", SqlDbType.DateTime),
                    new SqlParameter("@project_end_date", SqlDbType.DateTime),
                    new SqlParameter("@project_company", SqlDbType.NVarChar),
                    new SqlParameter("@project_contact", SqlDbType.NVarChar),
                    new SqlParameter("@contact_phone", SqlDbType.NVarChar),
                    new SqlParameter("@remark",SqlDbType.NVarChar)};
            parameters[0].Value = model.projectNo;
            parameters[1].Value = model.projectName;
            parameters[2].Value = model.projectHeader;
            parameters[3].Value = model.projectStartDate;
            parameters[4].Value = model.projectEndDate;
            parameters[5].Value = model.projectCompany;
            parameters[6].Value = model.projectContact;
            parameters[7].Value = model.contactPhone;
            parameters[8].Value = model.remark;

            int rows = mySqlconn.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Delete(string projectNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" delete from  project where project_no='"+projectNo+"' ");
            int rows = mySqlconn.ExeNonQuery(strSql.ToString());
            return rows;
        }

        public bool IsExists(string projectNo)
        {
            StringBuilder str = new StringBuilder();
            str.Append("select count(project_no) from project where project_no='"+projectNo+"'");
            return mySqlconn.Exists(str.ToString());
        }
    }
}
