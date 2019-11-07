using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InventoryManagersystem.ClassAssist;
using BULayer;


namespace InventoryManagersystem.Report
{
    public partial class frmReport_Sales : Form
    {
        BUProject myProject = new BUProject();
        public frmReport_Sales()
        {
            InitializeComponent();
        }

        public void SetProject()
        {
            DataTable mydt = new DataTable();
            mydt = myProject.GetAllProject(string.Empty,string.Empty).Tables[0];
            combCustomer.DataSource = mydt;
            combCustomer.DisplayMember = "project_name";
            combCustomer.ValueMember = "project_no";
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

        private void sbtnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                string paramTime_1 = dateTimePicker1.Value.ToString("yyyy-MM-dd 00:00:00");
                string paramTime_2 = dateTimePicker2.Value.ToString("yyyy-MM-dd 23:59:59");
                string paramCustomer = string.Empty;
                if (checkBox1.Checked == true)
                {
                    paramCustomer = combCustomer.SelectedValue.ToString();
                }

                DataTable dt = new DataTable();
                BUStockOutOrder myBUStockOutOrder = new BUStockOutOrder();
                dt = myBUStockOutOrder.GetStockOutInfo(paramTime_1, paramTime_2, paramCustomer);
                this.gdCInvent.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void frmReport_Sales_Load(object sender, EventArgs e)
        {
            SetProject();
        }
    }
}
