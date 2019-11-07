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

        BUCheckResult myBUCheckResult = new BUCheckResult();


        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            string userName = this.txtBoxUser.Text.Trim();
            string passWord = this.txtBoxPhone.Text.Trim();

            BUQueryGrid myBUQueryGrid = new BUQueryGrid();
            DataTable mydt = myBUQueryGrid.GetInfo(userName,passWord);

            this.dataGridView1.DataSource = mydt;


        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            frmAddUser myfrmAdduser = new frmAddUser();
            BUCheckResult myBUCheckResult = new BUCheckResult();
            DialogResult dr = new DialogResult();
            dr = myfrmAdduser.ShowDialog();
            if (dr == DialogResult.OK)
            {
                btnReflash_Click(sender, e);
            }
            //myfrmAdduser.ShowDialog();
            //if (myfrmAdduser.ShowDialog() == DialogResult.OK)
            //{
            //    btnReflash_Click(sender, e);
            //}
        }

        private void btnReflash_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource =  ;//为空值 查询所有的
           // BUCheckResult myBUCheckResult =  new BUCheckResult();

            this.dataGridView1.DataSource = myBUCheckResult.GetCustomerDt("");
        }

        private void btnUserDel_Click(object sender, EventArgs e)
        {
           

            if (this.dataGridView1.RowCount == 0)
            {
                MessageBox.Show("请选择要删除的用户！");
                return;
                
            }

            //string paramUseName = this.dataGridView1.SelectedRows[0].Cells["username"].Value.ToString();//获取到需要删除的行的主健

            int count = this.dataGridView1.SelectedRows.Count;
            bool Result = false;
            if (MessageBox.Show("确定删除被选中的信息吗？", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                for (int i = 0; i < count; i++)
                {
                    string paramUserID = this.dataGridView1.SelectedRows[i].Cells["username"].Value.ToString();//获取到需要删除的行的主健

                    Result = myBUCheckResult.DelData(paramUserID); ;

                }
            }
            if (Result)
            {
                MessageBox.Show("删除成功");
                btnReflash_Click(sender, e);
            }
            else
            {
                //MessageBox.Show("操作异常");
                return;
            }

        }

        private void btnUserMod_Click(object sender, EventArgs e)
        {
            int count = this.dataGridView1.SelectedRows.Count;
            if (count == 0)
            {
                MessageBox.Show("请先搜索/刷新并选择需要修改的用户行","错误！",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            string paramUserName = this.dataGridView1.SelectedRows[0].Cells["username"].Value.ToString();//获取到需要删除的行的主健
            string paramAddress = this.dataGridView1.SelectedRows[0].Cells["address"].Value.ToString();
            string paramTelephone = this.dataGridView1.SelectedRows[0].Cells["telephone"].Value.ToString();
            string paramEmail = this.dataGridView1.SelectedRows[0].Cells["email"].Value.ToString();

            frmModifyUser myFrmModifyUser = new frmModifyUser(paramUserName,paramAddress,paramTelephone,paramEmail);
            DialogResult dr = new DialogResult();

     


            dr = myFrmModifyUser.ShowDialog();
            if (dr == DialogResult.OK)
            {
                btnReflash_Click(sender, e);
            }
            //myfrmAdduser.ShowDialog();
            //if (myfrmAdduser.ShowDialog() == DialogResult.OK)
            //{
            //    btnReflash_Click(sender, e);
            //}
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmUserMamager_Load(object sender, EventArgs e)
        {

        }

        private void frmUserMamager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

     


            //if (this.dataGridView1.RowCount == 0)
            //{
            //    MessageBox.Show("请选择要修改的用户！");
            //}
            //frmModifyUser myfrmModifyUser =  new frmModifyUser();
            
            //string paramUserName = this.dataGridView1.SelectedRows[0].Cells["username"].Value.ToString();
            //string paramPassWord = this.dataGridView1.SelectedRows[0].Cells["passwd"].Value.ToString();
            //string paramTelePhone = this.dataGridView1.SelectedRows[0].Cells["telephone"].Value.ToString();
            //string paramAddress = this.dataGridView1.SelectedRows[0].Cells["address"].Value.ToString();
            //string paramEmail = this.dataGridView1.SelectedRows[0].Cells["email"].Value.ToString();


            //myfrmModifyUser.ShowDialog();



    }
}
