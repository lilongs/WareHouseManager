using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BULayer;
using Model;

namespace InventoryManagersystem.Project
{
    public partial class frmProjectManage : Form
    {
        public frmProjectManage()
        {
            InitializeComponent();
        }
        BUProject myBUCustomerInfo = new BUProject();
        public bool  IsUpdate=false ;

        #region public void GetAllData() 获取所有客户数据
        /// <summary>
        /// 获取所有数据
        /// </summary>
        public void GetAllData(string projectNo,string projectName)
        {
            DataSet myDs = new DataSet();
            myDs = myBUCustomerInfo.GetAllProject(projectNo, projectName);
            this.gdcInfo.DataSource = myDs.Tables[0];
        }
        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string projectNo = this.txtProjectNo.Text.Trim();
            string projectName = this.txtProjectName.Text.Trim();
            GetAllData(projectNo,projectName);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProjectAdd myfrmCustomerAdd = new frmProjectAdd();
            if (myfrmCustomerAdd.ShowDialog() == DialogResult.Yes)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            int count = this.gdvInfo.SelectedRowsCount;
            if (count == 0)
            {
                MessageBox.Show("请先搜索/刷新并选择需要修改的行", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Mo_Project myMo_Project = new Mo_Project();
            myMo_Project.projectNo= this.gdvInfo.GetFocusedRowCellValue("project_no").ToString();
            myMo_Project.projectName=this.gdvInfo.GetFocusedRowCellValue("project_name").ToString();
            myMo_Project.projectHeader = this.gdvInfo.GetFocusedRowCellValue("project_header").ToString();
            myMo_Project.projectStartDate = Convert.ToDateTime(this.gdvInfo.GetFocusedRowCellValue("project_start_date"));
            myMo_Project.projectEndDate = Convert.ToDateTime(this.gdvInfo.GetFocusedRowCellValue("project_end_date"));
            myMo_Project.projectCompany = this.gdvInfo.GetFocusedRowCellValue("project_company").ToString();
            myMo_Project.projectContact = this.gdvInfo.GetFocusedRowCellValue("project_contact").ToString();
            myMo_Project.contactPhone = this.gdvInfo.GetFocusedRowCellValue("contact_phone").ToString();
            myMo_Project.remark = this.gdvInfo.GetFocusedRowCellValue("remark").ToString();

            IsUpdate = true;

            frmProjectAdd myfrmCustomerAdd = new frmProjectAdd(myMo_Project, IsUpdate);
            if (myfrmCustomerAdd.ShowDialog() == DialogResult.Yes)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("确定删除?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int count = this.gdvInfo.SelectedRowsCount;
                    int i = 0;
                    if (count == 0)
                    {
                        MessageBox.Show("请先搜索/刷新并选择需要修改的行", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        int[] indexArr = gdvInfo.GetSelectedRows();
                        for (int j = 0; j < indexArr.Count(); j++)
                        {
                            string projectNo = this.gdvInfo.GetDataRow(indexArr[j])["project_no"].ToString();
                            i = myBUCustomerInfo.Delete(projectNo);
                        }
                    }
                    if (i != 0)
                    {
                        MessageBox.Show("操作成功");
                    }
                    else
                    {
                        MessageBox.Show("操作失败或该用户信息已在使用！");
                    }
                    btnSearch_Click(sender,e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
