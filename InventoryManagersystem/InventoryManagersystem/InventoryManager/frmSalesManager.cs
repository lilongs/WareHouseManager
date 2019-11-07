using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InventoryManagersystem.InventoryManager;
using BULayer;
using InventoryManagersystem.ClassAssist;
using Model;

namespace InventoryManagersystem.Sales
{
    public partial class frmSalesManage : Form
    {
        BUProject myProject = new BUProject();
        BUStockOutOrder myBUStockOutOrder = new BUStockOutOrder();
        public frmSalesManage()
        {
            InitializeComponent(); 
        }
       
        private void frmSalesManage_Load(object sender, EventArgs e)
        {
            DataTable dt = myProject.GetProjectName();
            this.repositoryItemGridLookUpEdit1.DataSource = dt;
            this.repositoryItemGridLookUpEdit1.ValueMember = "project_no";
            this.repositoryItemGridLookUpEdit1.DisplayMember = "project_name";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraEditors.SimpleButton tempBtn = (DevExpress.XtraEditors.SimpleButton)sender;
                if (tempBtn == null)
                    return;
                string tempItem = tempBtn.Tag.ToString();
                foreach (Control tempControl in this.groupBox4.Controls)
                {
                    if (tempControl.GetType() == typeof(DevExpress.XtraGrid.GridControl))
                    {

                        DevExpress.XtraGrid.GridControl tempGridControl = (DevExpress.XtraGrid.GridControl)tempControl;
                        CommonOperator.DataPrint(tempGridControl, tempItem, null);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        List<Mo_StockOutOrderDetail> listStockOutOrder = new List<Mo_StockOutOrderDetail>();
        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmInventInfo myfrmInventInfo = new frmInventInfo();
            if (myfrmInventInfo.ShowDialog() == DialogResult.Yes)
            {
                List<Mo_StockOutOrderDetail> tempList = myfrmInventInfo.selectedList;
                //判断是否有重复添加的数据
                for (int i=0;i<tempList.Count;i++)
                {
                    string orderNO = tempList[i].order_no;
                    string locationID = tempList[i].location_id;
                    string productID = tempList[i].product_id;
                    string supplierID = tempList[i].supplier_id;

                    var item = listStockOutOrder.Where(x => (x.order_no == orderNO && x.location_id == locationID && x.product_id == productID&& x.supplier_id== supplierID)).FirstOrDefault();
                    if (item != null)
                    {
                        tempList.RemoveAt(i);
                    }
                    else
                    {
                        tempList[i].stock_out_date = DateTime.Now.ToString("yyyy/MM/dd");
                        tempList[i].out_order_no = DateTime.Now.ToString("yyyyMMdd")+myBUStockOutOrder.TodayCountStockOut().ToString("0000");
                        tempList[i].operators = this.Tag.ToString();
                        listStockOutOrder.Add(tempList[i]);
                    }
                }
                this.gdCInvent.DataSource = listStockOutOrder;
                this.gdvInvent.RefreshData();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listStockOutOrder.Clear();
            this.gdvInvent.RefreshData();
        }

        private void gdvInvent_ValidatingEditor_1(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            try
            {          
                if (gdvInvent.FocusedColumn.FieldName == "out_quantity")
                {
                    int paramQuantity = Convert.ToInt32(gdvInvent.GetFocusedRowCellValue("quantity"));
                    if (int.Parse(e.Value.ToString()) > paramQuantity)
                    {
                        e.ErrorText = "出库数量大于库存数量！";
                        e.Valid = false;
                        return;
                    }
                }
            }
            catch 
            {
                MessageBox.Show("请输入正确的数量和价格");
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "文件格式(*.xlsx)|*.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string name = saveFileDialog.FileName;
                    this.gdCInvent.ExportToXlsx(name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            try
            {
                if (listStockOutOrder.Count > 0)
                {
                    var item=listStockOutOrder.Where(x => (x.project_no == null || Convert.ToInt32(x.out_quantity) > Convert.ToInt32(x.quantity))).FirstOrDefault();
                    if(item != null)
                    {
                        MessageBox.Show("请准确填写出库数量和项目编号!");
                        return;
                    }

                    bool result = myBUStockOutOrder.StockOut(listStockOutOrder);
                    if (result)
                    {
                        listStockOutOrder.Clear();
                        this.gdvInvent.RefreshData();
                        MessageBox.Show("出库成功");
                    }
                        
                    else
                        MessageBox.Show("出库失败");
                }
            }
            catch
            {
                MessageBox.Show("操作异常，请正确操作");
            }
        }

        
    }
}
