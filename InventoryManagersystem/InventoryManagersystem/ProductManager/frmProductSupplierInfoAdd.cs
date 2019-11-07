using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BULayer;
using InventoryManagersystem.InventoryManager;

namespace InventoryManagersystem.ProductManager
{
    public partial class frmProductSupplierInfoAdd : Form
    {
        BUProductSupplierInfo myBUProductSupplierInfo = new BUProductSupplierInfo();
        //修改时用到的全局变量
        string paramProductID_2 = string.Empty;
        string paramSupplierID_2 = string.Empty;
        //添加时用到的全局变量
        string paramProductID = string.Empty;
        string paramSupplierID = string.Empty;

        public frmProductSupplierInfoAdd()
        {
            InitializeComponent();
        }
        //修改信息
        public frmProductSupplierInfoAdd(string paramProductID, string paramProductName, string paramSupplierID, string paramSupplierName, string paramPrice, string paramRemark)
        {
            InitializeComponent();
            this.txtProductName.Text = paramSupplierName;
            this.paramProductID_2 = paramProductID;
            this.txtProductName.Enabled = false;

            this.txtSupplierName.Text = paramSupplierName;
            this.paramSupplierID_2 = paramSupplierID;
            this.txtSupplierName.Enabled = false;

            this.txtPrice.Text = paramPrice;
            this.txtRemark.Text = paramRemark;
            this.Text = "修改贸易信息";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string paramPrice = txtPrice.Text.Trim();
            string paramRemark = txtRemark.Text.Trim();
            //判断同一商品同一供应商
            bool result=myBUProductSupplierInfo.IsExistsSameSupplier(paramProductID, paramSupplierID);
            if (result)
            {
                paramProductID_2 = paramProductID;
                paramSupplierID_2 = paramSupplierID;
            }
            //添加
            if (paramProductID_2.Length == 0 &&paramSupplierID_2.Length==0)
            {

                int i = myBUProductSupplierInfo.InsertSupplier(paramProductID, paramSupplierID, paramPrice, paramRemark);
                if (i > 0)
                {
                    MessageBox.Show("添加成功");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
            else//修改
            {
                int i = myBUProductSupplierInfo.UpdateProSupInfo(paramProductID_2,paramSupplierID_2,paramPrice,paramRemark);
                if (i > 0)
                {
                    MessageBox.Show("修改成功");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
        }

        private void frmProductSupplierInfoAdd_Load(object sender, EventArgs e)
        {
        }

        private void btnAll_Pro_Click(object sender, EventArgs e)
        {
            frmItem myfrmItem = new frmItem();

            if (myfrmItem.ShowDialog() == DialogResult.Yes)
            {
                if (myfrmItem.paramProductID.Length > 0)
                {
                    this.paramProductID = myfrmItem.paramProductID;
                    this.txtProductName.Text = myfrmItem.paramProductName;                    
                }
            }
        }

        private void btnAllSup_Click(object sender, EventArgs e)
        {
            frmSup_All myfrmSup_All = new frmSup_All();
            if (myfrmSup_All.ShowDialog() == DialogResult.Yes)
            {
                this.txtSupplierName.Text = myfrmSup_All.paramSupplierName;
                this.paramSupplierID = myfrmSup_All.paramSupplierID;

            }
        }
    }
}
