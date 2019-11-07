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
    public partial class frmLocationNoMange : Form
    {
        public frmLocationNoMange()
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
            DataTable dt = new DataTable();
            dt = myStoreHouse.GetLocationNOInfo(paramInventID);
            this.gdcInfo.DataSource = dt;
        }
        #endregion
        private void frmLocationMange_Load(object sender, EventArgs e)
        {
            GetAllData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmLocationNoAdd myfrmLocationAdd = new frmLocationNoAdd();
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
                            string LocationNO = dr["id"].ToString();
                            myStoreHouse.DeleteLocationNo(LocationNO);
                        }
                        MessageBox.Show("操作成功");
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
            string LocationID = this.gdvInfo.GetFocusedRowCellValue("id").ToString();
            string StoreHouse_ID = this.gdvInfo.GetFocusedRowCellValue("store_house_id").ToString();
            string LocationNo= this.gdvInfo.GetFocusedRowCellValue("location_no").ToString();

            frmLocationNoAdd myfrmLocationAdd = new frmLocationNoAdd(LocationID,StoreHouse_ID,LocationNo);
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
