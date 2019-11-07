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
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

         
            string userName = this.txtBoxUser.Text.Trim();
            string passWord = this.txtBoxPwd.Text.Trim();
            string telePhone = this.txtBoxPhone.Text.Trim();
            string email = this.txtBoxEmail.Text.Trim();
            string address = this.txtBoxAddress.Text.Trim();
            BUCheckResult  myBUCheckResult = new BUCheckResult();
            int checkValue = myBUCheckResult.CheckInput(userName,passWord,telePhone,email,address);
            if (checkValue > 0)
             {
                MessageBox.Show("用户添加成功");
                this.DialogResult = DialogResult.OK;
                //this.Hide();
                  
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
            this.DialogResult = DialogResult.No;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAddUser_Load(object sender, EventArgs e) 
        {

        }
    }
}
