using System;
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
    public partial class frmModifyUser : Form
    {

        public string paramUserName = string.Empty;
        public string paramAddress = string.Empty;
        public string paramTelephone = string.Empty;
        public string paramEmail = string.Empty;
        public string realname = string.Empty;
        public int paramRoleID = 0;
        bool IsSystem = false;
        BLIRoleInfo myBLIRoleInfo = new BLIRoleInfo();
        public frmModifyUser()
        {
            InitializeComponent();
            IsSystem = true;     
        }
        public frmModifyUser(string paramUserName,string realname, string paramAddress, string paramTelephone, string paramEmail, int paramRoleID)
        {
            InitializeComponent();
            this.realname = realname;
            this.paramUserName = paramUserName;
            this.paramAddress = paramAddress;
            this.paramTelephone = paramTelephone;
            this.paramEmail = paramEmail;
            this.paramRoleID = paramRoleID;
            IsSystem = false;
        }

        /// <summary>
        ///将传递过来的参数赋值给文本框
        /// </summary>
        public void SetInfo()
        {
            this.txtBoxUser.Enabled = false;
            this.txtBoxUser.Text = this.paramUserName;
            this.txtBoxAddress.Text = this.paramAddress;
            this.txtBoxPhone.Text = this.paramTelephone;
            this.txtBoxEmail.Text = this.paramEmail;
            this.cmbRole.SelectedValue = paramRoleID;
            this.txtRealname.Text = this.realname;
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

        private void frmModifyUser_Load(object sender, EventArgs e)
        {
            GetCombRole();
            if(IsSystem)
            {
             this.paramUserName = this.Tag.ToString();
            }
            SetInfo();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = this.txtBoxUser.Text.Trim();
                string telePhone = this.txtBoxPhone.Text.Trim();
                string email = this.txtBoxEmail.Text.Trim();
                string address = this.txtBoxAddress.Text.Trim();
                string realname = this.txtRealname.Text.Trim();
                int paramRoleID = Convert.ToInt32(this.cmbRole.SelectedValue.ToString());
                BUUsers myBUUsers = new BUUsers();
                bool checkValue = myBUUsers.UpdateUser(userName,telePhone,realname,email,address,paramRoleID);

                if (checkValue)
                {
                    MessageBox.Show("用户修改成功");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("用户修改成功");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
