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
    public partial class frmReport_Check : Form
    {
        public frmReport_Check()
        {
            InitializeComponent();
        }
        public void SetSupplier()
        {
            DataTable mydt = new DataTable();
            BUSupplier myBUSupplier = new BUSupplier();
            mydt = myBUSupplier.GetAllSupplierListByName(string.Empty).Tables[0];
            combSupplier.DataSource = mydt;
            combSupplier.DisplayMember = "name";
            combSupplier.ValueMember = "supplier_id";
        }

        private void sbtnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                string SupplierId = string.Empty;
                string startTime = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string endTime = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                if (checkBox1.Checked == true)
                {
                    SupplierId = this.combSupplier.SelectedValue.ToString();
                }

                BUStockInOrder myBUStockInOrder = new BUStockInOrder();
                DataTable dt = myBUStockInOrder.GetStockInDetail(SupplierId, startTime, endTime);
                this.gdCInvent.DataSource = dt;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmReport_Check_Load(object sender, EventArgs e)
        {
            SetSupplier();
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
                    this.gdCInvent.ExportToXlsx(name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
