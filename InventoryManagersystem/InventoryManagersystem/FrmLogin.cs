using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BULayer;
using Comm;
using InventoryManagersystem.sys;


namespace InventoryManagersystem
{
    public partial class FrmLogin : Form
    {
        BUAboutInfo myBUAboutInfo = new BUAboutInfo();

        public FrmLogin()
        {
            InitializeComponent();
        }

        BULogin myBULogin = new BULogin();//实例化BU层的BULogin

        //输入判断
        public bool IsInput(string paramUserName, string Pwd)
        {
            bool returnValue = false;
            if (paramUserName.Length == 0)
            {
                this.lblErr.Text = "用户名不能为空";
                this.textUserName.Focus();
                returnValue = true;
                return returnValue;
            }
            if (Pwd.Length == 0)
            {

                this.lblErr.Text = "密码不能为空";
                this.textBoxPwd.Focus();
                returnValue = true;
                return returnValue;
            }

            return returnValue;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = this.textUserName.Text.Trim();
                string passWord = this.textBoxPwd.Text.Trim();
               
                //输入判断
                if (IsInput(userName, passWord))
                {
                    return;
                }
                bool IsCheckUser = false;
                IsCheckUser = myBULogin.CheckUser(userName);
                if (!IsCheckUser)
                {
                    this.lblErr.Text = "用户不存在,请重新输入！";
                    this.textUserName.Text = "";
                    this.textUserName.Focus();
                    return;
                }
                bool IsCheckPwd = false;
                string md5_Password = DbEncrypt.MD5Encrypt(passWord);
                IsCheckPwd = myBULogin.IsCheckPwd(userName, md5_Password);
                if (!IsCheckPwd)
                {
                    this.lblErr.Text = "密码错误，请重新输入";
                    this.textBoxPwd.Text = "";
                    this.textBoxPwd.Focus();
                    return;
                }
                this.lblErr.Text = "";
                this.Hide();


                Frmmain myFrmmain = new Frmmain(userName); //将this.textUserName.Text的值做为参数传给窗体Frmmail,并在下一步打开开窗体时，将this.textUserName.Text的值传给frmmain窗体
                myFrmmain.ShowDialog();
            }
            catch
            {

                MessageBox.Show("数据库连接失败，请确认数据库是否配置成功");
                return;

            }


        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet myds = new DataSet();
                myds = myBUAboutInfo.GetAboutInfo();
                label1.Text = myds.Tables[0].Rows[0]["Version"].ToString() + "|" + myds.Tables[0].Rows[0]["Company"].ToString() + " " + myds.Tables[0].Rows[0]["CopyRight"].ToString();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }


        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TsmClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsMMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void TsMMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBoxPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void tsSQLset_Click(object sender, EventArgs e)
        {
            frmSqlSet myXtraSqlSet = new frmSqlSet();
            if (myXtraSqlSet.ShowDialog() == DialogResult.Yes)
            {
                FrmLogin_Load(sender, e);
            }

        }
    }
}
