using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BULayer;

namespace InventoryManagersystem.InventoryManager
{
    public partial class frmItem : Form
    {
        public frmItem()
        {
            InitializeComponent();
        }
        BUProductList myBUPruduct = new BUProductList();
        public string paramProductID = string.Empty;//物料编码
        public string paramProductName = string.Empty;//物料名称
        public string paramProductSpec = string.Empty;
        public string paramProductUnitName = string.Empty;
        public string paramProductUnitId = string.Empty;
        public string paramProductClassName = string.Empty;


        private void gdCItem_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                paramProductID = this.gdvItem.GetFocusedRowCellValue("product_id").ToString();
                paramProductName = this.gdvItem.GetFocusedRowCellValue("product_name").ToString();
                paramProductSpec=this.gdvItem.GetFocusedRowCellValue("product_spec").ToString();
                paramProductUnitId= this.gdvItem.GetFocusedRowCellValue("product_unit_id").ToString();
                paramProductUnitName = this.gdvItem.GetFocusedRowCellValue("product_unit_name").ToString();
                paramProductClassName=this.gdvItem.GetFocusedRowCellValue("product_class_name").ToString();
                this.DialogResult = DialogResult.Yes;              
            }
            catch
            {
                MessageBox.Show("请选择行数据信息进行选择操作！");
                return;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string paramName= this.txtName.Text.Trim();
            DataTable myDt = new DataTable();
            myDt = myBUPruduct.GetProductInfoByName(paramName, string.Empty);
            this.gdCItem.DataSource = myDt;

        }
    }
}
