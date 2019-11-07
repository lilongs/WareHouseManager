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

namespace InventoryManagersystem.sys
{
    public partial class frmRoleInfo : Form
    {
        private string paramRoleID = string.Empty;
        public frmRoleInfo()
        {
            InitializeComponent();
        }
        public frmRoleInfo(int paramRoleID)
        {
            InitializeComponent();
            this.txtRoleID.Text = paramRoleID.ToString();
        }
        public frmRoleInfo(string  paramRoleID)
        {
            InitializeComponent();
            this.paramRoleID = paramRoleID;
        }

        #region private MoIRoleInfo GetModelData() 将页面的文本框的值一一赋值给实体
        /// <summary>
        /// 将页面的文本框的值一一赋值给实体
        /// </summary>
        /// <returns></returns>
        private MoIRoleInfo GetModelData()
        {
            MoIRoleInfo myMoIRoleInfo = new MoIRoleInfo();


            myMoIRoleInfo.RoleID = Convert.ToInt32(this.txtRoleID.Text.Trim());
            myMoIRoleInfo.RoleName = this.txtRoleName.Text.Trim();
            myMoIRoleInfo.Remark = this.txtRemark.Text.Trim();

            return myMoIRoleInfo;
        }
        #endregion

        #region private void SetModelData() 通过ID获取到实体赋值到文本框
        /// <summary>
        /// 通过ID获取到实体赋值到文本框
        /// </summary>
        private void SetModelData()
        {
            MoIRoleInfo myMoIRoleInfo = new MoIRoleInfo();
            BLIRoleInfo myBLIRoleInfo = new BLIRoleInfo();
            myMoIRoleInfo = myBLIRoleInfo.GetModel(Convert.ToInt32(this.paramRoleID));
            this.txtRoleID.Text = myMoIRoleInfo.RoleID.ToString();
            this.txtRoleName.Text = myMoIRoleInfo.RoleName;
            this.txtRemark.Text = myMoIRoleInfo.Remark;

        }
        #endregion

        private void frmRoleInfo_Load(object sender, EventArgs e)
        {
            if (this.paramRoleID.Length > 0)
            {
                SetModelData();
            }
            this.txtRoleName.Focus();
            this.txtRoleName.Select();
        }
   
        private void btnSure_Click(object sender, EventArgs e)
        {
            string paramRoleName = this.txtRoleName.Text.Trim();
            string paramRemark = this.txtRemark.Text.Trim();

            if (paramRoleName.Length == 0)
            {
                MessageBox.Show("权限名称不能为空！");
                return;
            }
            BLIRoleInfo myBLIRoleInfo = new BLIRoleInfo();
            MoIRoleInfo myMoIRoleInfo = new MoIRoleInfo();

            //添加操作
            if (paramRoleID.Length == 0)
            {
                myMoIRoleInfo = GetModelData();
                myBLIRoleInfo.Add(myMoIRoleInfo);
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                myMoIRoleInfo = GetModelData();
                myBLIRoleInfo.Update(myMoIRoleInfo);
                this.DialogResult = DialogResult.Yes;
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No ;
        }
    }
}
