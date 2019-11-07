using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BULayer;
using System.Collections;


namespace InventoryManagersystem.Location
{
    public partial class frmLocationAdd : Form
    {
        BUStoreHouse myBUStoreHouse = new BUStoreHouse();
        public string paramStoreHouse_ID_2 = string.Empty;        

        public frmLocationAdd()
        {
            InitializeComponent();
            this.Text = "仓库信息维护-添加";
        }
        public frmLocationAdd(string StoreHouse_ID,string Remark,string Address)
        {
            InitializeComponent();
            this.Text = "仓库信息维护-修改";
            paramStoreHouse_ID_2 = StoreHouse_ID;

            this.txtStoreHouse_ID.Text= StoreHouse_ID;
            txtStoreHouse_ID.Enabled = false;
            this.txtRemark.Text=Remark;
            this.txtAddress.Text= Address;            
            
        }
        /// <summary>
        /// 判断输入是否为空
        /// </summary>
        /// <param name="paramInventID"></param>
        /// <param name="paramRemark"></param>
        /// <param name="paramAddress"></param>
        /// <returns></returns>
        public bool IsInput(string paramInventID, string paramRemark, string paramAddress)
        {
            bool returnValue = false;
            if (paramInventID.Length == 0)
            {
                MessageBox.Show("仓库编码不能为空");
                this.txtStoreHouse_ID.Focus();
                returnValue = true;
                return returnValue;
            }
            if (paramRemark.Length == 0)
            {

                MessageBox.Show("仓库用途不能为空");
                this.txtRemark.Focus();
                returnValue = true;
                return returnValue;
            }
            if (paramAddress.Length == 0)
            {

                MessageBox.Show("仓库地址不能为空");
                this.txtAddress.Focus();
                returnValue = true;
                return returnValue;
            }
            return returnValue;
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            string paramStoreHouse_ID = this.txtStoreHouse_ID.Text.Trim();
            string paramRemark = this.txtRemark.Text.Trim();
            string paramAddress = this.txtAddress.Text.Trim();
            //输入判断
            if (IsInput(paramStoreHouse_ID, paramRemark, paramAddress))
            {
                return;
            }  
            int i=0;
            i = paramStoreHouse_ID_2.Length == 0 ? myBUStoreHouse.InsertHouse(paramStoreHouse_ID, paramRemark, paramAddress) : myBUStoreHouse.UpdateHouse(paramStoreHouse_ID_2, paramRemark, paramAddress);
            string str=i==-1? "该ID已存在":((i>0)? "操作成功":"操作失败");
            MessageBox.Show(str);
            this.DialogResult = i == -1 ? DialogResult.No : (i > 0 ? DialogResult.Yes : DialogResult.No); 
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
