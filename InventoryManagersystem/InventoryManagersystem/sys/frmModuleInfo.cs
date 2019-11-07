using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BULayer;
using DevExpress.XtraTreeList.Nodes;

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
            this.gdcInfo.DataSource = myDs.Tables[0];
            gdcInfo.KeyFieldName = "ID";
            gdcInfo.ParentFieldName = "ParentID";
            gdcInfo.Columns[0].Caption = "菜单";
            gdcInfo.Columns[1].Caption = "路径";
            gdcInfo.OptionsView.ShowCheckBoxes = true;
            ExpandTree();
        }

        private void ExpandTree()
        {
            foreach (TreeListNode nodes in gdcInfo.Nodes)
            {
                nodes.ExpandAll();
            }
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

        List<string> lstChecked;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gdcInfo.Nodes.Count > 0)
            {
                lstChecked = new List<string>();
                foreach (TreeListNode root in gdcInfo.Nodes)
                {
                    //获取根节点信息
                    if (root.CheckState == CheckState.Checked)
                    {
                        DataRowView drv = gdcInfo.GetDataRecordByNode(root) as DataRowView;
                        if (drv != null)
                        {
                            string menuid =drv["ID"].ToString();
                            lstChecked.Add(menuid);
                        }

                    }
                    GetCheckedID(root);
                }
            }
            if (lstChecked.Count() <= 0)
            {
                MessageBox.Show("请选择要选择的行！");
                return;
            }
            else if (lstChecked.Count() > 1)
            {
                MessageBox.Show("每次只能更新一个菜单！");
                return;
            }

            string paramUserID = lstChecked[0];
            frmModuleAdd myfrmModuleAdd = new frmModuleAdd(paramUserID);
            if (myfrmModuleAdd.ShowDialog() == DialogResult.Yes)
            {
                frmModuleInfo_Load(sender, e);
            }
        }

        private void GetCheckedID(TreeListNode parentNode)
        {
            if (parentNode.Nodes.Count == 0)
            {
                return;//递归终止
            }

            foreach (TreeListNode node in parentNode.Nodes)
            {
                if (node.CheckState == CheckState.Checked)
                {
                    DataRowView drv = gdcInfo.GetDataRecordByNode(node) as DataRowView;
                    if (drv != null)
                    {
                        string menuid =  drv["ID"].ToString();
                        lstChecked.Add(menuid);
                    }

                }
                GetCheckedID(node);
            }
        }


        private void btnResh_Click(object sender, EventArgs e)
        {

        }
    }
}
