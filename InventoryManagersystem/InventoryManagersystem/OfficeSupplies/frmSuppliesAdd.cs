using BULayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagersystem.OfficeSupplies
{
    public partial class frmSuppliesAdd : Form
    {
        public frmSuppliesAdd()
        {
            InitializeComponent();
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            try
            {
                string Location = this.txtLocation.Text.Trim();
                string Name = this.txtName.Text.Trim();
                string Quantity = this.txtQuantity.Text.Trim();
                int resultQuantity = 0;
                string CreateTime = Convert.ToDateTime(this.dateCreatetime.EditValue).ToString("yyyy-MM-dd HH:mm:ss");
                string Status = this.combStatus.Text;
                string Keeper = this.txtKeeper.Text.Trim();
                string Model = this.txtModel.Text.Trim();
                string Price = this.txtPrice.Text.Trim();
                decimal result_price = 0;
                string Unit = this.txtUnit.Text.Trim();
                string Remark = this.txtRemark.Text.Trim();

                #region CheckInput
                if(!decimal.TryParse(Price,out result_price))
                {
                    MessageBox.Show("请输入正确的物品价格！");
                    return;
                }
                if (String.IsNullOrEmpty(Location))
                {
                    MessageBox.Show("请输入当前位置！");
                    return;
                }
                
                if (String.IsNullOrEmpty(Name))
                {
                    MessageBox.Show("请输入物品名称！");
                    return;
                }
               
                if (!int.TryParse(Quantity,out resultQuantity))
                {
                    MessageBox.Show("请输入正确的物品数量！");
                    return;
                }
                
                if (String.IsNullOrEmpty(CreateTime))
                {
                    MessageBox.Show("请选择取得时间！");
                    return;
                }
               
                if(String.IsNullOrEmpty(Status))
                {
                    MessageBox.Show("请选择使用状态！");
                    return;
                }
               
                if (String.IsNullOrEmpty(Keeper))
                {
                    MessageBox.Show("请输入领用人信息！");
                    return;
                }
                #endregion

                BUOfficeSupplies myBUOfficeSupplies = new BUOfficeSupplies();
                bool result=myBUOfficeSupplies.SuppliesAdd(Location,Name,Model,Price,Quantity,Unit,CreateTime, Status, Keeper,Remark);
                if (result)
                {
                    MessageBox.Show("维护成功");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("维护失败");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
