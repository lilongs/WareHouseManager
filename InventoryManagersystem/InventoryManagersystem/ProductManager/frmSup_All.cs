﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BULayer;

namespace InventoryManagersystem.ProductManager
{
    public partial class frmSup_All : Form
    {
        public string paramSupplierID = string.Empty;
        public string paramSupplierName = string.Empty;

        public frmSup_All()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string paramSupplierName = txtSupplierName.Text.Trim();
            BUSupplier myBUSupplier = new BUSupplier();
            this.gdCItem.DataSource = myBUSupplier.GetAllSupplierListByName(paramSupplierName).Tables[0];

        }

        private void gdCItem_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                paramSupplierID = this.gdvItem.GetFocusedRowCellValue("supplier_id").ToString();
                paramSupplierName = this.gdvItem.GetFocusedRowCellValue("name").ToString();
                this.DialogResult = DialogResult.Yes;

            }
            catch
            {
                MessageBox.Show("请选择行数据信息进行选择操作！");
                return;
            }
        }
    }
}
