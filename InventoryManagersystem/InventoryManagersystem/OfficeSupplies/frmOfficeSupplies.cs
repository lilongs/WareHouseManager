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
    public partial class frmOfficeSupplies : Form
    {
        public frmOfficeSupplies()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = this.txtName.Text.Trim();
                BUOfficeSupplies myBUOfficeSupplies = new BUOfficeSupplies();
                DataTable dt = myBUOfficeSupplies.GetOfficeSuppliesList(Name);
                this.gdcInfo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSuppliesAdd frm = new frmSuppliesAdd();
            if(frm.ShowDialog()==DialogResult.OK)
            {
                btnSearch_Click(sender,e);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int counts = this.gdvInfo.SelectedRowsCount;
                if (counts <= 0)
                {
                    MessageBox.Show("请选择要流转的数据行");
                    return;
                }
                string ID = this.gdvInfo.GetFocusedRowCellValue("id").ToString();
                frmSuppliesUpdate frm = new frmSuppliesUpdate();
                frm.ID = ID;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    btnSearch_Click(sender,e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
