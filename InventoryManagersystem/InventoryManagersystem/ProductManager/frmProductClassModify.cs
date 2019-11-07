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
    public partial class frmProductClassModify : Form
    {
        BUProductClass myBuClass=new BUProductClass ();
        string  paramParentID="0";
        string EmployeeName=string.Empty;
        DataTable mydt = new DataTable();

        public frmProductClassModify(string paramClassName, int paramClassCode, string paramEmployeeName)
        {
            InitializeComponent();
            this.txtBoxProductClassCode.Text = paramClassCode.ToString();
            this.txtBoxProductClassName.Text = paramClassName.ToString();
            mydt = myBuClass.GetClass(paramClassCode.ToString());


            this.txtBoxRemark.Text = mydt.Rows[0]["remark"].ToString();
            this.EmployeeName = paramEmployeeName.ToString();
            this.paramParentID = mydt.Rows[0]["parent_id"].ToString(); ;
        }

        private void btnAddProductClass_Click(object sender, EventArgs e)
        {
            try
            {
                string paramClassName = this.txtBoxProductClassName.Text.Trim();
                string paramRemark = this.txtBoxRemark.Text.Trim();
                int paramClassCode = int.Parse(this.txtBoxProductClassCode.Text.Trim());
                paramParentID = "0";//默认为父窗体
                if (chekChild.Checked == true)
                {
                    paramParentID = cmbParent.SelectedValue.ToString();
                }
                BUProductClass myBUProductClass = new BUProductClass();
                bool isModifyClassOK = myBUProductClass.UpdateClass(paramClassName, paramRemark, paramClassCode, EmployeeName, paramParentID)>0?true:false;

                if (isModifyClassOK)
                {
                    MessageBox.Show("修改成功");
                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    MessageBox.Show("更新失败");
                    this.DialogResult = DialogResult.Yes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

        private void frmProductClassModify_Load(object sender, EventArgs e)
        {
          
            if (!paramParentID.Equals("0"))
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
            else 
                 chekChild.Checked = false ;
        
        
        }
    }
}
