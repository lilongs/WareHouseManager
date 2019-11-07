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
    public partial class frmProductList : Form
    {
        public frmProductList()
        {
            InitializeComponent();
        }     

        private void btnAddProduct_Click(object sender, EventArgs e)
        {            
            frmProductListAdd MyfrmProductAdd = new frmProductListAdd();
            MyfrmProductAdd.Tag = this.Tag;         

            DialogResult dr = new DialogResult();
            dr = MyfrmProductAdd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string paramProductName = this.txtBoxProductName.Text.ToString();
            string paramProductCode = this.txtBoxProductCode.Text.ToString();

            DataTable dt = new DataTable();
            BUProductList myBUProductList = new BUProductList();
            dt = myBUProductList.GetProductInfoByName(paramProductName, paramProductCode);
            if (dt.Rows.Count>0)
            {
                this.gdcInfo.DataSource = dt;
            }
            else
            {
                MessageBox.Show("查无记录");
            }
        }

        private void frmProductList_Load(object sender, EventArgs e)
        {
            btnSearch_Click(sender,e);
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            int count = this.gdvInfo.SelectedRowsCount;
            if (count == 0)
            {
                MessageBox.Show("请先搜索/刷新并选择需要修改的用户行", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            string paramProductID = this.gdvInfo.GetFocusedRowCellValue("product_id").ToString();
            string ProductClassId= this.gdvInfo.GetFocusedRowCellValue("product_class_id").ToString();
            string paramProductClassName = this.gdvInfo.GetFocusedRowCellValue("product_class_name").ToString();
            string paramProductName = this.gdvInfo.GetFocusedRowCellValue("product_name").ToString();
            string paramProductSpec = this.gdvInfo.GetFocusedRowCellValue("product_spec").ToString(); 
            string paramUnitName = this.gdvInfo.GetFocusedRowCellValue("product_unit_name").ToString();
            string paramEmployeeName = this.gdvInfo.GetFocusedRowCellValue("createby").ToString();
            string paramRemark = this.gdvInfo.GetFocusedRowCellValue("remark").ToString();

            frmProductListAdd MyfrmProductAdd = new frmProductListAdd(paramProductID, ProductClassId, paramProductClassName, paramProductName, paramProductSpec,paramUnitName, paramEmployeeName, paramRemark);
            MyfrmProductAdd.Tag = this.Tag;
            DialogResult dr = new DialogResult();
            dr = MyfrmProductAdd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnDelProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.gdvInfo.SelectedRowsCount == 0)
                {
                    MessageBox.Show("请选择要删除的信息！");
                    return;
                }
                int[] indexArr = this.gdvInfo.GetSelectedRows();
                bool ReturnValue = false;
                DialogResult dr = MessageBox.Show("确定删除此条信息吗？", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    for (int i = 0; i < indexArr.Count(); i++)
                    {
                        string paramProductID = this.gdvInfo.GetDataRow(indexArr[i])["product_id"].ToString();
                        BUProductList myBUProductList = new BUProductList();
                        ReturnValue = myBUProductList.ProductDelete(paramProductID);
                    }
                    if (ReturnValue)
                    {
                        MessageBox.Show("恭喜您，删除数据成功！", "恭喜", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnSearch_Click(sender, e);

                    }
                    else
                    {
                        MessageBox.Show("操作错误或该产品已进入库房", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
    }
}
