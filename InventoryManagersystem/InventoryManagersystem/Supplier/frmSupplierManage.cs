using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BULayer;

namespace InventoryManagersystem.Supplier
{
    public partial class frmSupplierManage : Form
    {
        public frmSupplierManage()
        {
            InitializeComponent();
        }
        BUSupplier myBUDeleteSupplier = new BUSupplier();

        #region public void GetAllData() 获取所有供应商数据
        /// <summary>
        /// 获取所有数据
        /// </summary>
        public void GetAllData()
        {
            string paramSupplierName = this.txtSupplierID.Text.Trim();
            DataSet myDs = new DataSet();
            myDs = myBUDeleteSupplier.GetAllSupplierListByName(paramSupplierName);
            this.gdcInfo.DataSource = myDs.Tables[0];
        }
        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetAllData();
        }

        private void frmSupplierManage_Load(object sender, EventArgs e)
        {
            GetAllData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSupplierAdd myfrmSupplierAdd = new frmSupplierAdd();
            if (myfrmSupplierAdd.ShowDialog() == DialogResult.Yes)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("确定删除?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int count = this.gdvInfo.SelectedRowsCount;
                    int i = 0;
                    if (count == 0)
                    {
                        MessageBox.Show("请先搜索/刷新并选择需要修改的行", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        int[] indexArr = gdvInfo.GetSelectedRows();
                        for (int j = 0; j < indexArr.Count(); j++)
                        {

                            string SupplierID = this.gdvInfo.GetDataRow(indexArr[j])["supplier_id"].ToString();
                            i = myBUDeleteSupplier.DeleteSupplier(SupplierID);
                        }
                    }
                    if (i != 0)
                    {
                        MessageBox.Show("操作成功");
                    }
                    else
                    {
                        MessageBox.Show("操作失败或当前供应商已存在关系!");
                    }
                    GetAllData();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            int count = this.gdvInfo.SelectedRowsCount;
            if (count == 0)
            {
                MessageBox.Show("请先搜索/刷新并选择需要修改的行", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string SupplierID = this.gdvInfo.GetFocusedRowCellValue("supplier_id").ToString();
            string SupplierName = this.gdvInfo.GetFocusedRowCellValue("name").ToString();
            string Address = this.gdvInfo.GetFocusedRowCellValue("address").ToString(); 
            string Phone = this.gdvInfo.GetFocusedRowCellValue("phone").ToString();
            string Fax = this.gdvInfo.GetFocusedRowCellValue("fax").ToString(); 
            string PostalCode = this.gdvInfo.GetFocusedRowCellValue("postal_code").ToString(); 
            string ConstactPerson = this.gdvInfo.GetFocusedRowCellValue("constact_person").ToString(); 

            frmSupplierAdd myfrmSupplierAdd = new frmSupplierAdd(SupplierID, SupplierName, Address, Phone, Fax, PostalCode, ConstactPerson);
            if (myfrmSupplierAdd.ShowDialog() == DialogResult.Yes)
            {
                btnSearch_Click(sender, e);
            }
        }
    }
}
