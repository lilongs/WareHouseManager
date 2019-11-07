using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BULayer;
using InventoryManagersystem.ClassAssist;
using Model;

namespace InventoryManagersystem.InventoryManager
{
    public partial class frmStockPile : Form
    {
        BUStoreHouse myBUStoreHouse = new BUStoreHouse();
        string paramPramPrudcutID = string.Empty;
        string paramProductSpec = string.Empty;
        string paramProductUnitName = string.Empty;
        string paramProductUnitId = string.Empty;
        string paramProductClassName = string.Empty;

        public frmStockPile()
        {
            InitializeComponent();
            this.dateEdit1.EditValue = DateTime.Now;
        }

        public void SetStoreHouse()
        {
            DataTable myPudtClass = new DataTable();
            myPudtClass = myBUStoreHouse.GetStoreHousInfo(string.Empty).Tables[0];
            combStoreHouse_ID.DataSource = myPudtClass;
            combStoreHouse_ID.DisplayMember = "store_house_id";
            combStoreHouse_ID.ValueMember = "store_house_id";
        }

        public void SetSupplier(string paramProductID)
        {
            DataTable mySupplierDt = new DataTable();
            BUProductSupplierInfo myBUProductSupplierInfo = new BUProductSupplierInfo();
            mySupplierDt = myBUProductSupplierInfo.GetAll_ProSupInfo(paramProductID,string.Empty).Tables[0];
            combSpplier.DataSource = mySupplierDt;
            combSpplier.DisplayMember = "name";
            combSpplier.ValueMember = "supplier_id";
            this.combSpplier.SelectedValueChanged += new System.EventHandler(this.combSpplier_SelectedValueChanged);

            if (mySupplierDt.Rows.Count > 0)
            {
                string paramSupplierID = combSpplier.SelectedValue.ToString();
                GetPrice(paramProductID, paramSupplierID);
            }
        }
        public void GetPrice(string paramProductID,string paramSupplierID)
        {
            DataTable myPriceDt = new DataTable();
            BUProductSupplierInfo myBUProductSupplierInfo = new BUProductSupplierInfo();
            myPriceDt = myBUProductSupplierInfo.GetProductSupplierPrice(paramProductID, paramSupplierID);
            txtPrice.Text = myPriceDt.Rows[0]["Proprice"].ToString();
        }

        private void frmStockPile_Load(object sender, EventArgs e)
        {
            SetStoreHouse();
        }

        List<Mo_StockInOrderDetail> listStockOrder = new List<Mo_StockInOrderDetail>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //判断当前清单中是否有同一货架、产品、自来相同供应商的商品
                var item=listStockOrder.Where(x=>(x.locationId==this.combLocation.SelectedValue.ToString() && x.productId==this.paramPramPrudcutID && x.supplierId==this.combSpplier.SelectedValue.ToString())).FirstOrDefault();
                if (item != null)
                {
                    item.quantity = item.quantity + Convert.ToInt32(this.txtQuantity.Text);
                    item.totalPrice = item.totalPrice + Convert.ToDecimal(this.txtPrice.Text) * Convert.ToInt32(this.txtQuantity.Text);
                }
                else
                {
                    //添加入库产品到入库单中
                    Mo_StockInOrderDetail orderDetail = new Mo_StockInOrderDetail();
                    //获取当前单剧最大值
                    orderDetail.locationId = this.combLocation.SelectedValue.ToString();
                    orderDetail.locationNo = this.combLocation.Text;
                    orderDetail.storeHouseId = combStoreHouse_ID.Text;
                    orderDetail.productId = paramPramPrudcutID;
                    orderDetail.productName = this.txtPruductName.Text;
                    orderDetail.productSpec = this.paramProductSpec;
                    orderDetail.productClassName = this.paramProductClassName;
                    orderDetail.productUnitId = this.paramProductUnitId;
                    orderDetail.productUnitName = this.paramProductUnitName;
                    orderDetail.supplierId = this.combSpplier.SelectedValue.ToString();
                    orderDetail.name = this.combSpplier.Text;
                    int reuslt = 0;
                    int.TryParse(txtQuantity.Text.Trim(), out reuslt);
                    orderDetail.quantity = reuslt;
                    orderDetail.price = Convert.ToDecimal(this.txtPrice.Text);
                    orderDetail.totalPrice = orderDetail.quantity * orderDetail.price;
                    orderDetail.stockInDate = Convert.ToDateTime(this.dateEdit1.EditValue);
                    orderDetail.operators = this.Tag.ToString();

                    listStockOrder.Add(orderDetail);
                }
                this.gdCInvent.DataSource = listStockOrder;
                gdvInvent.RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEnterStock_Click(object sender, EventArgs e)
        {
            try
            {
                if (listStockOrder.Count<=0)
                {
                    MessageBox.Show("请选择产品和供应商并添加到单据中！");               
                }
                else
                {
                    BUStockInOrder bUStockIn = new BUStockInOrder();
                    int counts = bUStockIn.GetTodayOrderCount();
                    foreach(Mo_StockInOrderDetail detail in listStockOrder)
                    {
                        detail.orderNo = DateTime.Now.ToString("yyyyMMdd") + counts.ToString("0000");
                    }
                    if (bUStockIn.StockIn(listStockOrder))
                    {
                        MessageBox.Show("入库成功");
                        this.txtPrice.Text = string.Empty;
                        this.txtQuantity.Text = string.Empty;
                        this.txtPruductName.Text = string.Empty;
                        this.combSpplier.Text = string.Empty;
                        listStockOrder.Clear();
                        gdvInvent.RefreshData();
                    }                        
                    else
                        MessageBox.Show("入库失败");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SetStoreHouse();
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraEditors.SimpleButton tempBtn = (DevExpress.XtraEditors.SimpleButton)sender;
                if (tempBtn == null)
                    return;
                string tempItem = tempBtn.Tag.ToString();
                foreach (Control tempControl in this.groupBox1.Controls)
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

        private void btnAll_Click(object sender, EventArgs e)
        {
            frmItem myfrmItem = new frmItem();

            if (myfrmItem.ShowDialog() == DialogResult.Yes)
            {
                if (myfrmItem.paramProductID.Length > 0)
                {
                    this.paramProductSpec = myfrmItem.paramProductSpec;
                    this.paramProductUnitId = myfrmItem.paramProductUnitId;
                    this.paramProductUnitName = myfrmItem.paramProductUnitName;
                    this.paramPramPrudcutID = myfrmItem.paramProductID;
                    this.txtPruductName.Text = myfrmItem.paramProductName;
                    this.paramProductClassName = myfrmItem.paramProductClassName;
                    SetSupplier(myfrmItem.paramProductID);
                }
            }
        }

        private void SetLocation(string StoreHouseId)
        {
            DataTable dt = myBUStoreHouse.GetLocationByHouseId(StoreHouseId);
            this.combLocation.DataSource = dt;
            this.combLocation.DisplayMember = "location_no";
            this.combLocation.ValueMember = "id";
        }

        private void combStoreHouse_ID_SelectedValueChanged(object sender, EventArgs e)
        {
            string StoreHouseId = combStoreHouse_ID.Text;
            SetLocation(StoreHouseId);
        }

        private void combSpplier_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string paramSupplierID = combSpplier.SelectedValue.ToString();
                GetPrice(this.paramPramPrudcutID, paramSupplierID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var item = listStockOrder.Where(x => (x.locationId == this.gdvInvent.GetFocusedRowCellValue("locationId").ToString() && x.productId == this.gdvInvent.GetFocusedRowCellValue("productId").ToString() && x.supplierId == this.gdvInvent.GetFocusedRowCellValue("supplierId").ToString())).FirstOrDefault();
                if (item != null)
                {
                    listStockOrder.Remove(item);
                    gdvInvent.RefreshData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
