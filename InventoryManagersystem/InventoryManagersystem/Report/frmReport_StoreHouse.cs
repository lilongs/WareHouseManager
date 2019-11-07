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

namespace InventoryManagersystem.Report
{
    public partial class frmReport_StoreHouse : Form
    {

        public frmReport_StoreHouse()
        {
            InitializeComponent();
        }
        public void SetStoreHouse()
        {
            DataTable myPudtClass = new DataTable();
            BUStoreHouse myBUStoreHouse = new BUStoreHouse();
            myPudtClass = myBUStoreHouse.GetStoreHousInfo(string.Empty).Tables[0];
            combStoreHouse_ID.DataSource = myPudtClass;
            combStoreHouse_ID.DisplayMember = "store_house_id";
            combStoreHouse_ID.ValueMember = "store_house_id";
        }

        

        private void frmReport_StoreHouse_Load(object sender, EventArgs e)
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
                foreach (Control tempControl in this.groupBox2.Controls)
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
                    this.gdcInfo.ExportToXlsx(name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void sbtnSelect_Click(object sender, EventArgs e)
        {
            string paramStoreHouseID = string.Empty;
            string ProductId = txtProductID.Text;
            string ProductName = txtProductName.Text;
            if (checkBox1.Checked == true)
            {
                paramStoreHouseID = combStoreHouse_ID.SelectedValue.ToString();
            }
            DataTable dt = new DataTable();
            BUStockOutOrder myBUStockOutOrder = new BUStockOutOrder();
            dt = myBUStockOutOrder.GetStockInfo(paramStoreHouseID,string.Empty, ProductId, ProductName);
            this.gdcInfo.DataSource = dt;     
        }

        
    }
}
