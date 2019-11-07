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
    public partial class frmLocationNoAdd : Form
    {
        BUStoreHouse myBUStoreHouse = new BUStoreHouse();
        public string LocationID = string.Empty;        

        public frmLocationNoAdd()
        {
            InitializeComponent();
            this.Text = "仓库信息维护-添加";
        }
        public frmLocationNoAdd(string id,string StoreHouse_ID,string LocationNO)
        {
            InitializeComponent();
            this.Text = "仓库信息维护-修改";

            this.LocationID = id;
            this.combStoreHouse_ID.Text= StoreHouse_ID;
            this.txtLocationNo.Text= LocationNO;
            
        }
        /// <summary>
        /// 判断输入是否为空
        /// </summary>
        /// <param name="paramInventID"></param>
        /// <param name="paramRemark"></param>
        /// <param name="paramAddress"></param>
        /// <returns></returns>
        public bool IsInput(string paramStoreHouse_ID, string paramLocation_no)
        {
            bool returnValue = false;
            if (paramStoreHouse_ID.Length == 0)
            {
                MessageBox.Show("仓库编码不能为空");
                this.combStoreHouse_ID.Focus();
                returnValue = true;
                return returnValue;
            }
            if (paramLocation_no.Length == 0)
            {
                MessageBox.Show("货架号不能为空");
                this.txtLocationNo.Focus();
                returnValue = true;
                return returnValue;
            }
            
            return returnValue;
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            try
            {
                string paramStoreHouse_ID = this.combStoreHouse_ID.SelectedValue.ToString();
                string paramLocation_no = this.txtLocationNo.Text.Trim();
                //输入判断
                if (IsInput(paramStoreHouse_ID, paramLocation_no))
                {
                    return;
                }
                if (myBUStoreHouse.IsExistsLocationNO(paramStoreHouse_ID, paramLocation_no))
                {
                    MessageBox.Show("当前仓库已存在该货架号,请确认！");
                    return;
                }
                if(String.IsNullOrEmpty(this.LocationID))
                {
                    if (myBUStoreHouse.InsertLocationNo(paramStoreHouse_ID, paramLocation_no))
                    {
                        MessageBox.Show("添加成功");
                        this.DialogResult = DialogResult.Yes;
                    }
                    else
                    {
                        MessageBox.Show("添加失败");
                    }
                }
                else
                {
                    if (myBUStoreHouse.UpdateLocationNo(LocationID,paramStoreHouse_ID, paramLocation_no))
                    {
                        MessageBox.Show("修改成功");
                        this.DialogResult = DialogResult.Yes;
                    }
                    else
                    {
                        MessageBox.Show("添加失败");
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        public void SetStoreHouse()
        {
            DataTable myPudtClass = new DataTable();
            myPudtClass = myBUStoreHouse.GetStoreHousInfo(string.Empty).Tables[0];
            combStoreHouse_ID.DataSource = myPudtClass;
            combStoreHouse_ID.DisplayMember = "store_house_id";
            combStoreHouse_ID.ValueMember = "store_house_id";
        }

        private void frmLocationNoAdd_Load(object sender, EventArgs e)
        {
            SetStoreHouse();
        }
    }
}
