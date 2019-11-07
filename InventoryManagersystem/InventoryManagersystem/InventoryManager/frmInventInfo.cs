using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BULayer;
using InventoryManagersystem.Sales;
using Model;

namespace InventoryManagersystem.InventoryManager
{
    public partial class frmInventInfo : Form
    {
        BUStoreHouse myBUStoreHouse = new BUStoreHouse();
        BUStockOutOrder myBUStockOutOrder = new BUStockOutOrder();
        public List<Mo_StockOutOrderDetail> selectedList = new List<Mo_StockOutOrderDetail>();
        public frmInventInfo()
        {
            InitializeComponent();
        }

        private void frmInventInfo_Load(object sender, EventArgs e)
        {
            try
            {
                SetStoreHouse();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void SetStoreHouse()
        {
            DataTable myPudtClass = new DataTable();
            myPudtClass = myBUStoreHouse.GetStoreHousInfo(string.Empty).Tables[0];
            combStoreHouse_ID.DataSource = myPudtClass;
            combStoreHouse_ID.DisplayMember = "store_house_id";
            combStoreHouse_ID.ValueMember = "store_house_id";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string StoreHouseID = combStoreHouse_ID.Text;
                string locationID = combLocation.SelectedValue.ToString();
                string paramProductID = txtProduct_ID.Text.Trim();
                string paramProductName = txtProductName.Text.Trim();
                DataTable dt = new DataTable();
                dt = myBUStockOutOrder.GetStockInfo(StoreHouseID, locationID, paramProductID, paramProductName);

                this.gdcInfo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                int selectCounts = this.gdvInfo.SelectedRowsCount;
                if (selectCounts <= 0)
                {
                    MessageBox.Show("请选择出货数据！");
                    return;
                }

                int[] indexArr = this.gdvInfo.GetSelectedRows();
                for (int i=0;i<indexArr.Count();i++)
                {
                    Mo_StockOutOrderDetail orderDetail = new Mo_StockOutOrderDetail();
                    orderDetail.order_no = this.gdvInfo.GetDataRow(indexArr[i])["order_no"].ToString();
                    orderDetail.product_id = this.gdvInfo.GetDataRow(indexArr[i])["product_id"].ToString();
                    orderDetail.product_name = this.gdvInfo.GetDataRow(indexArr[i])["product_name"].ToString();
                    orderDetail.supplier_id = this.gdvInfo.GetDataRow(indexArr[i])["supplier_id"].ToString();
                    orderDetail.name = this.gdvInfo.GetDataRow(indexArr[i])["name"].ToString();
                    orderDetail.location_id = this.gdvInfo.GetDataRow(indexArr[i])["location_id"].ToString();
                    orderDetail.store_house_id = this.gdvInfo.GetDataRow(indexArr[i])["store_house_id"].ToString();
                    orderDetail.location_no = this.gdvInfo.GetDataRow(indexArr[i])["location_no"].ToString();
                    orderDetail.product_class_name = this.gdvInfo.GetDataRow(indexArr[i])["product_class_name"].ToString();
                    orderDetail.product_spec = this.gdvInfo.GetDataRow(indexArr[i])["product_spec"].ToString();
                    orderDetail.product_unit_name = this.gdvInfo.GetDataRow(indexArr[i])["product_unit_name"].ToString();
                    orderDetail.quantity = this.gdvInfo.GetDataRow(indexArr[i])["quantity"].ToString();
                    orderDetail.price = this.gdvInfo.GetDataRow(indexArr[i])["price"].ToString();

                    selectedList.Add(orderDetail);
                }
                this.DialogResult = DialogResult.Yes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void combStoreHouse_ID_SelectedValueChanged(object sender, EventArgs e)
        {
            string StoreHouseId = combStoreHouse_ID.Text;
            SetLocation(StoreHouseId);
        }

        private void SetLocation(string StoreHouseId)
        {
            DataTable dt = myBUStoreHouse.GetLocationByHouseId(StoreHouseId);
            this.combLocation.DataSource = dt;
            this.combLocation.DisplayMember = "location_no";
            this.combLocation.ValueMember = "id";
        }
    }
}






