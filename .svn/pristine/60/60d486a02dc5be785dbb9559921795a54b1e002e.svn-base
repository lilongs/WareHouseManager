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
    public partial class frmChangeMyPassword : Form
    {
        public string paramUserName = string.Empty;
        
        public frmChangeMyPassword()
        {
            InitializeComponent();
        }

        public frmChangeMyPassword(string paramUserName)
        {
            InitializeComponent();
            this.paramUserName = paramUserName;

        }
        public void getUserInfo()
        {
            this.txtBoxMyName.Text = this.Tag.ToString ();
        }

        private void txtMyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmChangeMyPassword_Load(object sender, EventArgs e)
        {
            getUserInfo();
           
          
        }

        private void txtBoxMyPassWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string userName = this.txtBoxMyName.Text.ToString();
            string passWord = this.txtBoxMyPassWord.Text.ToString();
            string newPassword = this.txtBoxNewPassWord.Text.ToString();
            string confirmPassword = this.txtBoxConfirm.Text.ToString();
            BUUserManager myBUUserManager = new BUUserManager();
            bool isCheckPassword = myBUUserManager.checkOldPassword(userName, passWord);
            if (isCheckPassword)
            {
                if (newPassword == confirmPassword)
                {
                    int checkLine = myBUUserManager.ModifyPassword(userName,newPassword);
                    if (checkLine >=1)
                    {
                        if (passWord != newPassword)
                        {
                            MessageBox.Show("密码修改成功", "恭喜您", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.txtBoxMyPassWord.Text = string.Empty;
                            this.txtBoxNewPassWord.Text = string.Empty;
                            this.txtBoxConfirm.Text = string.Empty;
                            this.txtBoxMyPassWord.Focus();
                        }
                        else if(passWord == newPassword)
                        {
                            MessageBox.Show("新密码与旧密码相同，请输入不同密码！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.txtBoxMyPassWord.Text = string.Empty;
                            this.txtBoxNewPassWord.Text = string.Empty;
                            this.txtBoxConfirm.Text = string.Empty;
                            this.txtBoxMyPassWord.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("您前后二次输入的密码不一致，请重新输入！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtBoxConfirm.Text = string.Empty;
                    this.txtBoxConfirm.Focus();          
                }
            }
            else
            {
                MessageBox.Show("您输入的旧密码有误，请重新输入！","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                this.txtBoxMyPassWord.Text = string.Empty;   
                this.txtBoxMyPassWord.Focus();
            }
        }
     
    }
}
