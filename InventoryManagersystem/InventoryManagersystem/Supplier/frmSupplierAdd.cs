﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BULayer;
using System.Text.RegularExpressions;

namespace InventoryManagersystem.Supplier
{
    public partial class frmSupplierAdd : Form
    {
        public string paramSupplierID_2= string.Empty;   
        BUSupplier myBUSupplier = new BUSupplier();

        public frmSupplierAdd()
        {
            InitializeComponent();
        }
        public frmSupplierAdd(string SupplierID, string SupplierName, string Address, string Phone, string Fax, string PostalCode, string ConstactPerson)
        {
            InitializeComponent();
            paramSupplierID_2 = SupplierID;

            this.txtSupplierID.Text = SupplierID;
            this.txtSupplierID.Enabled = false;

            this.txtSupplierName.Text = SupplierName;
            this.txtAddress.Text = Address;
            this.txtPhone.Text = Phone;
            this.txtFax.Text = Fax;
            this.txtPostalCode.Text = PostalCode;
            this.txtConstactPerson.Text = ConstactPerson;
            txtSupplierName.Focus();
        }
        
        //判断是否输入为空
        public bool IsInput(string paramSupplierID, string paramName, string paramAddress, string paramPhone, string paramFax, string paramPostalCode, string paramConstactPerson)
        {
            bool returnValue = false;
            if (paramSupplierID.Length == 0)
            {
                MessageBox.Show("供应商编码不能为空");
                this.txtSupplierID.Focus();
                returnValue = true;
                return returnValue;
            }
            if (paramName.Length == 0)
            {
                MessageBox.Show("名称不能为空");
                this.txtSupplierName.Focus();
                returnValue = true;
                return returnValue;
            }
            if (paramAddress.Length == 0)
            {
                MessageBox.Show("地址不能为空");
                this.txtAddress.Focus();
                returnValue = true;
                return returnValue;
            }
            if ((Regex.IsMatch(paramPhone, @"^(\d{3,4}-)?\d{6,8}$")|| Regex.IsMatch(paramPhone,@"^[1]+[3,5]+\d{9}"))==false)          
            {
                MessageBox.Show("联系电话格式错误");
                this.txtPhone.Focus();
                returnValue = true;
                return returnValue;
            }
            if (paramFax.Length == 0)
            {
                MessageBox.Show("传真不能为空");
                this.txtFax.Focus();
                returnValue = true;
                return returnValue;
            }
            if (Regex.IsMatch(paramPostalCode, @"^\d{6}$")==false)            
            {
                MessageBox.Show("邮政编码格式不正确");
                this.txtPostalCode.Focus();
                returnValue = true;
                return returnValue;
            }
            if (paramConstactPerson.Length == 0)
            {
                MessageBox.Show("联系人不能为空");
                this.txtConstactPerson.Focus();
                returnValue = true;
                return returnValue;
            }
            
            return returnValue;
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            string paramSupplierID = this.txtSupplierID.Text.Trim();
            string paramName = this.txtSupplierName.Text.Trim();
            string paramAddress = this.txtAddress.Text.Trim();
            string paramPhone = this.txtPhone.Text.Trim();
            string paramFax = this.txtFax.Text.Trim();
            string paramPostalCode = this.txtPostalCode.Text.Trim();
            string paramConstactPerson = this.txtConstactPerson.Text.Trim();

            //输入判断
            if (IsInput(paramSupplierID,paramName,paramAddress,paramPhone,paramFax,paramPostalCode,paramConstactPerson))
            {
                return;
            }
            int i = 0;
            //二元运算
            i = paramSupplierID_2.Length == 0 ? myBUSupplier.InsertSupplier(paramSupplierID, paramName, paramAddress, paramPhone, paramFax, paramPostalCode, paramConstactPerson) : myBUSupplier.UpdateSupplier(paramSupplierID_2, paramName, paramAddress, paramPhone, paramFax, paramPostalCode, paramConstactPerson);
            string str = i == -1 ? "该ID已存在" : ((i > 0) ? "操作成功" : "操作失败");
            MessageBox.Show(str);
            this.DialogResult = i == -1 ? DialogResult.No : (i > 0 ? DialogResult.Yes : DialogResult.No); 



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }      

       
    }
}
