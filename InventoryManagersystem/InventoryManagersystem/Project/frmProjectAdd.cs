using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BULayer;
using System.Text.RegularExpressions;
using Model;


namespace InventoryManagersystem.Project
{
    public partial class frmProjectAdd : Form
    {
        Mo_Project myMo_Project = new Mo_Project();
        BUProject myProject = new BUProject();
        //BUCustomer myBUCustomer = new BUCustomer();//实例化BU 层BUCustomer
        public bool IsUpdate = false;

        public frmProjectAdd()
        {
            InitializeComponent();
            txtProjectNo.Focus();
        }

        public frmProjectAdd(Mo_Project myMo_Customer,bool IsUpdate)
        {
            InitializeComponent();
            this.myMo_Project = myMo_Customer;
          
            txtProjectNo.Focus();
            this.IsUpdate = IsUpdate;
            this.txtProjectNo.Enabled = false;
        }

        private void frmCustomerAdd_Load(object sender, EventArgs e)
        {
            if (IsUpdate)
            {
                SetModel();
            }
        }

        #region 1 输入判断 CheckInput()
        /// <summary>
        /// 输入判断
        /// </summary>
        /// <returns></returns>
        public bool CheckInput()
        {
            bool ReturnValue = false;

            if (txtProjectNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("项目编号不能为空");
                this.txtProjectNo.Focus();
                ReturnValue = true;
                return ReturnValue;
            }
            if (txtProjectName.Text.Trim().Length == 0)
            {
                MessageBox.Show("项目名称不能为空");
                this.txtProjectName.Focus();
                ReturnValue = true;
                return ReturnValue;
            }
            if (!IsUpdate)
            {
                if (myProject.IsExists(txtProjectNo.Text.Trim()))
                {
                    MessageBox.Show("项目编号已存在");
                    this.txtProjectNo.Focus();
                    ReturnValue = true;
                    return ReturnValue;
                }
            }

            return ReturnValue;
        }
        #endregion

        #region 2 给实体复制   GetMo_Customer()
        /// <summary>
        /// 获取到 Customer 实体
        /// </summary>
        /// <returns></returns>
        public Mo_Project GetMo_Project( )
        {
            Mo_Project myMo_Project = new Mo_Project();
            myMo_Project.projectNo = this.txtProjectNo.Text.Trim();
            myMo_Project.projectName = this.txtProjectName.Text.Trim();
            myMo_Project.projectHeader = this.txtProjectHeader.Text.Trim();
            myMo_Project.projectStartDate = Convert.ToDateTime(this.startTime.EditValue);
            myMo_Project.projectEndDate = Convert.ToDateTime(this.endTime.EditValue);
            myMo_Project.projectCompany = this.txtProjectCompany.Text.Trim();
            myMo_Project.projectContact=this.txtContact.Text.Trim();
            myMo_Project.contactPhone=this.txtContactPhone.Text.Trim(); 
            myMo_Project.remark = this.txtRemark.Text.Trim();
            return myMo_Project;
        }
        #endregion

        #region 3 将实体赋值到文本框 SetModel()
        /// <summary>
        /// 将实体赋值到文本框
        /// </summary>
        public void SetModel()
        {
            this.txtProjectNo.Text = myMo_Project.projectNo;
            this.txtProjectName.Text = myMo_Project.projectName;
            this.txtProjectHeader.Text = myMo_Project.projectHeader;
            this.startTime.Text = myMo_Project.projectStartDate.ToString("yyyy-MM-dd");
            this.endTime.Text = myMo_Project.projectEndDate.ToString("yyyy-MM-dd");
            this.txtProjectCompany.Text = myMo_Project.projectCompany;
            this.txtContact.Text = myMo_Project.projectContact;
            this.txtContactPhone.Text = myMo_Project.contactPhone;
            this.txtRemark.Text = myMo_Project.remark;
        }
        #endregion

        private void btnSure_Click(object sender, EventArgs e)
        {
           try
           {
             //输入判断
             if (CheckInput())
             {  return; }

                Mo_Project myMo_Project = new Mo_Project();
            bool ResultValue = false;
            string paramMessageBox = string.Empty;
            this.myMo_Project = GetMo_Project();
            ResultValue= IsUpdate == false  ? myProject.Add(this.myMo_Project): myProject.Update(this.myMo_Project);
            paramMessageBox = ResultValue == true ?"操作成功！" : "操作成功！";
            MessageBox.Show(paramMessageBox);
            this.DialogResult = ResultValue == true ? DialogResult.Yes :  DialogResult.No;
           
           }
            catch 
            {
                MessageBox.Show("操作异常,请确认是否用户编号重复！","温馨提示！");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

    }
}
