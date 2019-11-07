using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BULayer;

namespace InventoryManagersystem.sys
{
    public partial class frmModuleInfo : Form
    {
        public frmModuleInfo()
        {
            InitializeComponent();
        }
        BLLModelInfo myBLLModelInfo = new BLLModelInfo();

        /// <summary>
        /// 获取到所有的模块信息
        /// </summary>
        public void GetModulList()
        {
            DataSet myDs = new DataSet();
            myDs = myBLLModelInfo.GetAllList("");
            this.dgvModuleList.DataSource = myDs.Tables[0];

        }


        private void frmModuleInfo_Load(object sender, EventArgs e)
        {
            GetModulList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmModuleAdd myfrmModuleAdd = new frmModuleAdd();
            if (myfrmModuleAdd.ShowDialog() == DialogResult.Yes)
            {
                frmModuleInfo_Load(sender, e);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string paramUserID = this.dgvModuleList.SelectedRows[0].Cells["ID"].Value.ToString();
            frmModuleAdd myfrmModuleAdd = new frmModuleAdd(paramUserID);
            if (myfrmModuleAdd.ShowDialog() == DialogResult.Yes)
            {
                frmModuleInfo_Load(sender, e);
            }
        }

        private void btnResh_Click(object sender, EventArgs e)
        {

        }
    }
}
