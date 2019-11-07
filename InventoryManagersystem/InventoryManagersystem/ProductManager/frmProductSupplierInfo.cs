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
    public partial class frmProductSupplierInfo : Form
    {

        public frmProductSupplierInfo()
        {
            InitializeComponent();
        }

        public void GetAllProductSupplierInfo()
        { 

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string paramProductID = this.txtBoxProductCode.Text.Trim();
                string paramSupplierID = this.txtBoxSupplierID.Text.Trim();
                DataSet ds = new DataSet();
                BUProductSupplierInfo myBUProductSupplierInfo = new BUProductSupplierInfo();
                ds = myBUProductSupplierInfo.GetAll_ProSupInfo(paramProductID, paramSupplierID);
                gdcInfo.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmProductSupplierInfo_Load(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProductSupplierInfoAdd myfrmProSupInfo = new frmProductSupplierInfoAdd();
            myfrmProSupInfo.ShowDialog();
            if(myfrmProSupInfo.DialogResult==DialogResult.OK)
            {
                btnSearch_Click(sender,e);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int count = this.gdvInfo.SelectedRowsCount;
            if (count == 0)
            {
                MessageBox.Show("请先搜索/刷新并选择需要修改的用户行", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string paramProductID = this.gdvInfo.GetFocusedRowCellValue("product_id").ToString();
            string paramProductName = this.gdvInfo.GetFocusedRowCellValue("product_name").ToString(); 
            string paramSupplierID = this.gdvInfo.GetFocusedRowCellValue("supplier_id").ToString();
            string paramSupplierName = this.gdvInfo.GetFocusedRowCellValue("name").ToString(); 
            string paramPrice = this.gdvInfo.GetFocusedRowCellValue("pro_price").ToString(); 
            string paramRemark = this.gdvInfo.GetFocusedRowCellValue("remark").ToString();
            frmProductSupplierInfoAdd myfrmProSupInfo = new frmProductSupplierInfoAdd(paramProductID,paramProductName, paramSupplierID,paramSupplierName, paramPrice, paramRemark);
            myfrmProSupInfo.ShowDialog();
            if (myfrmProSupInfo.DialogResult == DialogResult.OK)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int count = this.gdvInfo.SelectedRowsCount;
            if (count == 0)
            {
                MessageBox.Show("请先搜索/刷新并选择需要修改的用户行", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dr = MessageBox.Show("确定删除此条信息吗？", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                string paramProductID = this.gdvInfo.GetFocusedRowCellValue("product_id").ToString();
                string paramSupplierID = this.gdvInfo.GetFocusedRowCellValue("supplier_id").ToString();


                BUProductSupplierInfo myBUProductSupplierInfo = new BUProductSupplierInfo();
                int i = myBUProductSupplierInfo.DeleteProSupInfo(paramProductID, paramSupplierID);
                if (i > 0)
                {
                    MessageBox.Show("删除成功");
                    btnSearch_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }                
        }
    }
}
