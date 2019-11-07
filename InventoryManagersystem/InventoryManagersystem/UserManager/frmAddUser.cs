﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BULayer;


namespace InventoryManagersystem
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }
        BLIRoleInfo myBLIRoleInfo = new BLIRoleInfo();
        private void frmAddUser_Load(object sender, EventArgs e)
        {
            GetCombRole();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = this.txtBoxUser.Text.Trim();
                string realname = this.txtRealname.Text.Trim();
                string passWord = this.txtBoxPwd.Text.Trim();
                string telePhone = this.txtBoxPhone.Text.Trim();
                string email = this.txtBoxEmail.Text.Trim();
                string address = this.txtBoxAddress.Text.Trim();
                int paramRoleID = Convert.ToInt32(this.cmbRole.SelectedValue.ToString());
                BUUsers myBUUsers = new BUUsers();
                bool result = myBUUsers.InsertUse(userName, passWord,realname, telePhone, email, address, paramRoleID);
                if (result)
                {
                    MessageBox.Show("用户添加成功");
                    this.DialogResult = DialogResult.OK;
                }

            }
            catch
            {
                MessageBox.Show("操作错误");
                this.DialogResult = DialogResult.No;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region  private void GetCombRole() 权限文本框的绑定
        /// 权限文本框的绑定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetCombRole()
        {
            DataTable myDt = new DataTable();
            myDt = myBLIRoleInfo.GetAllList().Tables[0];
            cmbRole.ValueMember = "RoleID";
            cmbRole.DisplayMember = "RoleName";
            cmbRole.DataSource = myDt;
        }
        #endregion

    }
}