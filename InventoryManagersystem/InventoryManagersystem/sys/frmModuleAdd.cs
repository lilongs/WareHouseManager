using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BULayer;

namespace InventoryManagersystem.sys
{
    public partial class frmModuleAdd : Form
    {
        public frmModuleAdd()
        {
            InitializeComponent();
        }
        string paramModuleID = string.Empty;
        string paramParentID = string.Empty;
        public frmModuleAdd(string  paramMoID)
        {
            InitializeComponent();
            paramModuleID = paramMoID;
            this.txtID.Text = paramModuleID;
        }
        BLLModelInfo myBLLModelInfo = new BLLModelInfo();

        public void SetModule()
        {
            DataSet myDs = new DataSet();
            myDs = myBLLModelInfo.GetAllList(this.paramModuleID);
            this.txtID.Text = myDs.Tables[0].Rows[0]["ID"].ToString();
            this.txtModuleName.Text = myDs.Tables[0].Rows[0]["ModuleName"].ToString();
            this.txtFormName.Text = myDs.Tables[0].Rows[0]["FormName"].ToString();
            this.txtSort.Text = myDs.Tables[0].Rows[0]["sort"].ToString();
            string  paramParentID=string .Empty ;
            paramParentID= myDs.Tables[0].Rows[0]["ParentID"].ToString();
            if (!paramParentID.Equals("0"))
            {
                chekChild.Checked = true;
                //加载该模块信息
                DataSet myParentDs = new DataSet();
                myParentDs = myBLLModelInfo.GetAllList(paramParentID);
                cmbParent.ValueMember = "ID";
                cmbParent.DisplayMember = "ModuleName";
                cmbParent.DataSource = myParentDs.Tables[0];
                cmbParent.Text = myParentDs.Tables[0].Rows[0]["ModuleName"].ToString();
                
            }
            else 
                 chekChild.Checked = false ;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int paramID = Convert.ToInt32(txtID.Text.Trim());
            string paramModuleName = this.txtModuleName.Text.Trim();
            string paramParamFormName = this.txtFormName.Text.Trim();
            string Sort = txtSort.Text;
            paramParentID = "0";//默认为父窗体
            if (chekChild.Checked == true)
            {
                paramParentID = cmbParent.SelectedValue.ToString();
            }
           
            int Result = 0;
            if (paramModuleID.Length > 0)
            {
               
                Result = myBLLModelInfo.UpdateModuleInfo(paramID,paramModuleName, paramParamFormName, paramParentID, Sort);
            }
            else
            {

                Result = myBLLModelInfo.AddModuleInfo(paramModuleName, paramParamFormName, paramParentID, Sort);
            }
            if (Result > 0)
            {
                MessageBox.Show("操作成功！");
            }
            

            
            this.DialogResult = DialogResult.Yes;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No ;
        }

        private void chekChild_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
             if (chekChild.Checked == true)
             {
                //加载子节点
                DataSet myParentDs = new DataSet();
                myParentDs = myBLLModelInfo.GetAllParentList("0");
                cmbParent.DataSource = myParentDs.Tables[0];
                cmbParent.ValueMember = "ID";
                cmbParent.DisplayMember = "ModuleName";
             }
            else
             {
                 DataTable mydt = new DataTable();
                 cmbParent.DataSource = mydt;
                 cmbParent.Text = "父节点";
                 paramParentID = "0";
              }

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void frmModuleAdd_Load(object sender, EventArgs e)
        {
            if (paramModuleID.Length == 0)
            {
                //添加 获取最大的ID
                txtID.Text = myBLLModelInfo.GetMaxId().ToString();
            }
            else
            {
                SetModule();
            }
        }

        private void cmbParent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
