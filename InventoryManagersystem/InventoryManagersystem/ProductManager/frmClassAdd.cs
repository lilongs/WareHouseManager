using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BULayer;

namespace InventoryManagersystem.ProductManager
{
    public partial class frmClassAdd : Form
    {
        public frmClassAdd()
        {
            InitializeComponent();
        }
        BUProductClass myBuClass = new BUProductClass();
        string paramParentID = "0";
        private void btnAddProductClass_Click(object sender, EventArgs e)
        {
            try
            {
                BUProductClass myBUClass = new BUProductClass();

                string paramRemark = this.txtBoxRemark.Text.ToString();
                string paramClassName = this.txtBoxProductClassName.Text.ToString();
                string paramEmployeeName = this.Tag.ToString();
                bool isValue = myBUClass.IsExistsClassName(paramClassName);
                paramParentID = "0";//默认为父窗体
                if (chekChild.Checked == true)
                {
                    paramParentID = cmbParent.SelectedValue.ToString();
                }
                if (paramClassName == string.Empty || paramClassName.Trim() == "")
                {
                    MessageBox.Show("请输入正确类别单位！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!isValue)
                {

                    bool returnValue = myBUClass.ProductClassAdd(paramClassName, paramRemark, paramEmployeeName, paramParentID);

                    if (returnValue)
                    {
                        MessageBox.Show("恭喜您，数据添加成功！", "恭喜", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;                        
                    }
                }
                else
                {
                    MessageBox.Show("类别名称重复！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {

                MessageBox.Show("添加失败");
                this.DialogResult = DialogResult.No;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void chekChild_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chekChild.Checked == true)
                {
                    //加载子节点
                    DataTable myParentDt = new DataTable();
                    myParentDt = myBuClass.GetClass("");
                    cmbParent.DataSource = myParentDt;
                    cmbParent.ValueMember = "product_class_id";
                    cmbParent.DisplayMember = "product_class_name";
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

        private void frmClassAdd_Load(object sender, EventArgs e)
        {
            chekChild.Checked = true;
            //加载该模块信息
            DataTable myParentDt = new DataTable();
            myParentDt = myBuClass.GetClass("");
            cmbParent.DataSource = myParentDt;
            cmbParent.ValueMember = "product_class_id";
            cmbParent.DisplayMember = "product_class_name";

            cmbParent.Text = myParentDt.Rows[0]["product_class_name"].ToString();
        }
    }
}
