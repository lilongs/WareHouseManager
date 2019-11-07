using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using BULayer;

namespace InventoryManagersystem.Location
{
    public partial class frmLocationMange : Form
    {
        public frmLocationMange()
        {
            InitializeComponent();
        }
        BUStoreHouse myStoreHouse = new BUStoreHouse();
        #region public void GetAllData() 获取所有数据
        /// <summary>
        /// 获取所有数据
        /// </summary>
        public void GetAllData()
        {
            string paramInventID = this.txtInventID.Text.Trim();
            DataSet myDs = new DataSet();
            myDs = myStoreHouse.GetStoreHousInfo(paramInventID);
            this.gdcInfo.DataSource = myDs.Tables[0];
        }
        #endregion
        private void frmLocationMange_Load(object sender, EventArgs e)
        {
            GetAllData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmLocationAdd myfrmLocationAdd = new frmLocationAdd();
            if (myfrmLocationAdd.ShowDialog() == DialogResult.Yes)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnUserDel_Click(object sender, EventArgs e)
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
                        int[] indexArr = this.gdvInfo.GetSelectedRows();
                        for (int j = 0; j < indexArr.Count(); j++)
                        {
                            DataRow dr = this.gdvInfo.GetDataRow(indexArr[i]);
                            string StoreHouse_ID = dr["store_house_id"].ToString();
                            i = myStoreHouse.DeleteHouse(StoreHouse_ID);
                        }
                    }
                    if (i > 0)
                    {
                        MessageBox.Show("操作成功");
                    }
                    else
                    {
                        MessageBox.Show("当前库房使用中!");
                    }
                    GetAllData();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnUserMod_Click(object sender, EventArgs e)
        {
            int count = this.gdvInfo.SelectedRowsCount;
            if (count == 0)
            {
                MessageBox.Show("请先搜索/刷新并选择需要修改的行", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string StoreHouse_ID = this.gdvInfo.GetFocusedRowCellValue("store_house_id").ToString();
            string Remark = this.gdvInfo.GetFocusedRowCellValue("remark").ToString();
            string Address= this.gdvInfo.GetFocusedRowCellValue("address").ToString(); 

            frmLocationAdd myfrmLocationAdd = new frmLocationAdd(StoreHouse_ID,Remark,Address);
            if (myfrmLocationAdd.ShowDialog() == DialogResult.Yes)
            {
                GetAllData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetAllData();

        }
    }
}
