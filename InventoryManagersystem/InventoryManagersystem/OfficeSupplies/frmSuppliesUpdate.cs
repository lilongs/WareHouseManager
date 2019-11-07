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
    public partial class frmSuppliesUpdate : Form
    {
        public frmSuppliesUpdate()
        {
            InitializeComponent();
        }
        public string ID = string.Empty;

        private void btnSure_Click(object sender, EventArgs e)
        {
            try
            {
                string Location = this.txtLocation.Text.Trim();
                string Keeper = this.txtKeeper.Text.Trim();
                string Status = this.combStatus.Text;
                string Remark = this.txtRemark.Text.Trim();
                #region CheckInput
                if (String.IsNullOrEmpty(Location))
                {
                    MessageBox.Show("请输入当前位置！");
                    return;
                }
                                              
                if (String.IsNullOrEmpty(Status))
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
                bool result=myBUOfficeSupplies.SuppliesUpdate(ID, Location, Status, Keeper, Remark);
                if (result)
                {
                    MessageBox.Show("流转成功");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("流转失败");
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
