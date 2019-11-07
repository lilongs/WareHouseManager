using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using BULayer;
//using Microsoft.SqlServer.Management.Common;
//using Microsoft.SqlServer.Management.Smo;

namespace InventoryManagersystem.sys
{
    public partial class frmSqlSet : Form
    {
        public frmSqlSet()
        {
            InitializeComponent();
        }


        StringBuilder Sql = new StringBuilder();
        BULogin myBULogin = new BULogin();

        #region   获取到连接数据  Link()
        /// <summary>
        /// 获取到连接数据
        /// </summary>
        /// <returns></returns>
        public SqlConnection Link()
        {
            string paramLinkstr = "data source='" + txtServerName.Text.Trim() + "';database='" + txtDB.Text.Trim() + "';uid='" + txtUid.Text.Trim() + "';pwd='" + txtPwd.Text.Trim() + "';";
            SqlConnection mySqlConnection = new SqlConnection(paramLinkstr);

            return mySqlConnection;
        }
        #endregion

        #region 判断是否有数据库
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool CheckSql()
        {
            bool ReturnValue = false;
            try
            {
                SqlConnection mySqlConnection = Link();
                mySqlConnection.Open();
                mySqlConnection.Close();
                ReturnValue = true;

            }
            catch
            {
             //   MessageBox.Show("测试失败！请确认数据！");
                ReturnValue = false;
                return ReturnValue;
            }


            return ReturnValue;
        }
        #endregion

        #region 创建数据库，调用ExecuteNonQuery()执行
        /// <summary>  
        /// 创建数据库，调用ExecuteNonQuery()执行  
        /// </summary>  
        /// <param name="conn"></param>  
        /// <param name="DatabaseName"></param>  
        /// <param name="Sql"></param>  
        private void ExecuteSql(string conn, string DatabaseName, string Sql)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                using (SqlCommand cmd = new SqlCommand(Sql, connection))
                {
                    try
                    {
                        connection.Open();
                        int rows = cmd.ExecuteNonQuery();
                        //return rows;
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        connection.Close();
                        throw e;
                    }
                }
            }
       
        }
        #endregion

        #region 调用脚本进行表的新增 public bool ExecuSql()
        //调用脚本进行表的新增
        public bool ExecuSql()
        {
            bool ReturnValue = false;
            string path = Application.StartupPath + @"\Inventory.txt";
            if (File.Exists(path))
            {
                FileInfo file = new FileInfo(path);
                string script = file.OpenText().ReadToEnd();
                //script = script.Replace("H00001", CardNo);  //替换脚本里的参数
                try
                {
                    SqlConnection conn = Link();
                    string paramLinkstr = "data source='" + txtServerName.Text.Trim() + "';database='" + txtDB.Text.Trim() + "';uid='" + txtUid.Text.Trim() + "';pwd='" + txtPwd.Text.Trim() + "';";
                    SqlConnection mySqlConnection = new SqlConnection(paramLinkstr);
                    ExecuteSql(paramLinkstr, "", script);
                }
                catch
                {

                }
            }


            return ReturnValue;
        }
        #endregion

        #region 创建数据库 CreatSQLData()
        /// <summary>
        /// 创建数据库
        /// </summary>
        public void CreatSQLData()
        {
            string connStr = "data source='" + txtServerName.Text.Trim() + "';database='master';uid='" + txtUid.Text.Trim() + "';pwd='" + txtPwd.Text.Trim() + "';";
            string parammdfpath = txtPath.Text.Trim() + @"\Inventory.mdf";
            string paraldfpath = txtPath.Text.Trim() + @"\Inventory_log.ldf";
            Sql.Append(@"
                         CREATE DATABASE [Inventory]
                         CONTAINMENT = NONE
                         ON  PRIMARY 
                        ( NAME = N'Inventory', FILENAME = N'" + parammdfpath + "' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB ) ");
            Sql.Append(@" LOG ON 
                         ( NAME = N'Inventory_log', FILENAME = N'" + paraldfpath + "' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)  ");

            ExecuteSql(connStr, "master", Sql.ToString());
        }
        #endregion

        #region 调用脚本进行表数据的新增 public bool ExecuSqlinfo()
        //调用脚本进行表的新增
        public bool ExecuSqlinfo() 
        {
            bool ReturnValue = false;
            string path = Application.StartupPath + @"\InventoryData.txt";
            if (File.Exists(path))
            {
                //FileInfo file = new FileInfo(path);
                StreamReader sr = new StreamReader(path, Encoding.Default);
                string script = sr.ReadToEnd();
                try
                {
                    string paramLinkstr = "data source='" + txtServerName.Text.Trim() + "';database='" + txtDB.Text.Trim() + "';uid='" + txtUid.Text.Trim() + "';pwd='" + txtPwd.Text.Trim() + "';";
                    SqlConnection mySqlConnection = new SqlConnection(paramLinkstr);
                    ExecuteSql(paramLinkstr, "", script);
                }
                catch
                {
                }
            }
            return ReturnValue;
        }
        #endregion

        private void frmSqlSet_Load(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("Config.pp", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                txtServerName.Text = sr.ReadLine();
                txtDB.Text = sr.ReadLine();
                txtUid.Text = sr.ReadLine();
                txtPwd.Text = sr.ReadLine();
                txtPath.Text=sr.ReadLine();
                sr.Close();
                fs.Close();
            }
            catch
            {
                MessageBox.Show("请配置数据库，是否需要初始数据库","温馨提示");
                return;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtServerName.Text) || string.IsNullOrEmpty(txtDB.Text) || string.IsNullOrEmpty(txtUid.Text) || string.IsNullOrEmpty(txtPwd.Text) || string.IsNullOrEmpty(txtPath.Text))
            {
                MessageBox.Show("没有填写完整！");
                return;
            }
            try
            {
                SqlConnection mySqlConnection = Link();
                mySqlConnection.Open();
                mySqlConnection.Close();


            }
            catch
            {
                CreatSQLData();
                if (CheckSql())
                {
                    if (!myBULogin.CheckData()) //表不存在然后重新创建表
                    {
                        ExecuSql();
                        ExecuSqlinfo();
                    }
                    MessageBox.Show("数据库已经配有数据库，不需要重复配置");
                    return;
                }
                MessageBox.Show("测试失败！请确认数据！");
                return;
            }
            FileStream fs = new FileStream("Config.pp", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(txtServerName.Text.Trim());
            sw.WriteLine(txtDB.Text.Trim());
            sw.WriteLine(txtUid.Text.Trim());
            sw.WriteLine(txtPwd.Text.Trim());
            sw.WriteLine(txtPath.Text.Trim());
            sw.Close();
            fs.Close();
            MessageBox.Show("测试成功,");
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
           this.DialogResult = DialogResult.Yes;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //创建 数据库 
            try
            {
                if (txtPath.Text.Trim().Length == 0)
                {
                    MessageBox.Show("数据库的存放路径不能为空");
                    return;
                }
                //判断是否已有数据库
                if (CheckSql())
                {
                    if (!myBULogin.CheckData()) //表不存在然后重新创建表
                    {
                        ExecuSql();
                        ExecuSqlinfo();
                    }
                    MessageBox.Show("数据库已经配有数据库，不需要重复配置");
                    return;
                }
                CreatSQLData();
                MessageBox.Show("数据库创建成功！");
               
                ExecuSql();
                //补基础数据
                MessageBox.Show("表创建创建成功！");
                ExecuSqlinfo();
            }
           
            catch
            {
                MessageBox.Show("配置异常");
            }
           MessageBox.Show("创建成功");
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            System.Windows.Forms.FolderBrowserDialog fbd = new System.Windows.Forms.FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = fbd.SelectedPath;
            }
            txtPath.Text = path;
        }
    }
}
