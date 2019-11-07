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
    public partial class frmUserMamager : Form
    {
        public frmUserMamager()
        {
            InitializeComponent();
        }

        BUUsers myBUUsers = new BUUsers();

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            string userName = this.txtBoxUser.Text.Trim();
            string phone = this.txtBoxPhone.Text.Trim();

            DataTable mydt = myBUUsers.GetUserInfo(userName, phone);
            this.gdcInfo.DataSource = mydt;
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            frmAddUser myfrmAdduser = new frmAddUser();
            DialogResult dr = new DialogResult();
            dr = myfrmAdduser.ShowDialog();
            if (dr == DialogResult.OK)
            {
                btnSearchUser_Click(sender, e);
            }    
        }

        private void btnReflash_Click(object sender, EventArgs e)
        {
            btnSearchUser_Click(sender, e);
        }

        private void btnUserDel_Click(object sender, EventArgs e)
        {
            if (this.gdvInfo.SelectedRowsCount<= 0)
            {
                MessageBox.Show("请选择要删除的用户！");
                return;       
            }

            int[] indexArr = this.gdvInfo.GetSelectedRows();
            bool Result = false;
            if (MessageBox.Show("确定删除被选中的信息吗？", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                for (int i = 0; i < indexArr.Count(); i++)
                {
                    string paramUserName = this.gdvInfo.GetDataRow(indexArr[i])["username"].ToString();//获取到需要删除的行的主健
                    BUUsers myBUUsers = new BUUsers();
                    Result = myBUUsers.DeleteUser(paramUserName); ;

                }
            }
            if (Result)
            {
                MessageBox.Show("删除成功");
                btnSearchUser_Click(sender, e);
            }
            else
            {
                MessageBox.Show("删除失败"); ;
            }
        }

        private void btnUserMod_Click(object sender, EventArgs e)
        {
            int count = this.gdvInfo.SelectedRowsCount;
            if (count == 0)
            {
                MessageBox.Show("请先搜索/刷新并选择需要修改的用户行","错误！",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            string realname = this.gdvInfo.GetFocusedRowCellValue("realname").ToString();
            string paramUserName = this.gdvInfo.GetFocusedRowCellValue("username").ToString();
            string paramAddress = this.gdvInfo.GetFocusedRowCellValue("address").ToString();
            string paramTelephone = this.gdvInfo.GetFocusedRowCellValue("telephone").ToString(); 
            string paramEmail = this.gdvInfo.GetFocusedRowCellValue("email").ToString();
            int paramRoleID = Convert.ToInt32(this.gdvInfo.GetFocusedRowCellValue("RoleID"));

            frmModifyUser myFrmModifyUser = new frmModifyUser(paramUserName,realname, paramAddress, paramTelephone, paramEmail, paramRoleID);
            DialogResult dr = new DialogResult();

            dr = myFrmModifyUser.ShowDialog();
            if (dr == DialogResult.OK)
            {
                btnReflash_Click(sender, e);
            }
        }

        private void frmUserMamager_Load(object sender, EventArgs e)
        {

        }

        private void frmUserMamager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
