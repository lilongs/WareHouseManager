using System;
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
    public partial class frmProductClassManager : Form
    {
        BUProductClass myBuClass = new BUProductClass();
        public frmProductClassManager()
        {
            InitializeComponent(); // 1
        }

        private void brnSearch_Click(object sender, EventArgs e)
        {
            string paramProductClassName = this.txtBoxProductName.Text.ToString();
            BUProductClass myBUProductClass = new BUProductClass();
            DataTable dt = myBUProductClass.GetProductClassByName(paramProductClassName);

            bool isNotNull = dt.Rows.Count > 0 ? true : false;
            if (isNotNull)
            {
                string paramNodeName = dt.Rows[0]["product_class_name"].ToString();
               SelectTreeView(trvPrdouctClass, paramNodeName);
            }
            else
            {
                MessageBox.Show("查无记录");
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if(trvPrdouctClass.SelectedNode.Text.Length<= 0)
                {
                    MessageBox.Show("请选择要修改的节点");
                    return;
                }
                string paramClassName = trvPrdouctClass.SelectedNode.Text;
                int paramClassCode = int.Parse(trvPrdouctClass.SelectedNode.Tag.ToString());
                string paramEmployeeName = this.Tag.ToString();

                frmProductClassModify myfrmClassAdd = new frmProductClassModify(paramClassName, paramClassCode, paramEmployeeName);
                if (myfrmClassAdd.ShowDialog() == DialogResult.Yes)
                {
                    frmProductClassManager_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmClassAdd myfrmClassAdd = new frmClassAdd();
            myfrmClassAdd.Tag = this.Tag.ToString();
            DialogResult dr = myfrmClassAdd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                frmProductClassManager_Load(sender, e);
            }
        }

        private void frmProductClassManager_Load(object sender, EventArgs e)
        {
            //加载主节点
            Bind_TreeView(trvPrdouctClass);
            trvPrdouctClass.ExpandAll();
        }

        #region   TreeView的数据绑定父\子、孙节点函数
        /// <summary>
        /// TreeView的数据绑定父节点函数
        /// </summary>
        /// <param name="treeview">TreeView控件ID名称</param>
        /// <param name="text">树控件要显示的文本的字段名称</param>
        public void Bind_TreeView(TreeView treeview)
        {
            DataTable mtDt = new DataTable();

            // mtDt = myBUSysInfo.GetSysInfo();  //测试注销
            mtDt = myBuClass.GetClassList("");
            treeview.Nodes.Clear();
            for (int i = 0; i < mtDt.Rows.Count; i++)
            {
                TreeNode rootnode = new TreeNode();//创建根节点
                rootnode.Text = mtDt.Rows[i]["product_class_name"].ToString();
                rootnode.Tag = mtDt.Rows[i]["product_class_id"].ToString();
                string paramParentID = mtDt.Rows[i]["product_class_id"].ToString(); 
                treeview.Nodes.Add(rootnode);//在添加完节点的内容之后，当然要添加根节点，
                CreateChildNodes(rootnode, paramParentID, rootnode.Text);//
            }
        }
        /// <summary>
        /// TreeView的数据绑定子节点函数
        /// </summary>
        /// <param name="treenode">上一级节点</param>
        /// <param name="parentName">数据表中字段名</param>
        /// <param name="text">树控件要显示的文本的字段名称</param>
        /// <param name="index">查询语句关键字</param>
        public void CreateChildNodes(TreeNode treenode, string paramParentID, string text)
        {
            DataTable myCNode = myBuClass.GetClassList(paramParentID);

            for (int i = 0; i < myCNode.Rows.Count; i++)
            {
                TreeNode childnode = new TreeNode();
                childnode.Text = myCNode.Rows[i]["product_class_name"].ToString();
                childnode.Tag = myCNode.Rows[i]["product_class_id"].ToString();
                treenode.Nodes.Add(childnode);
            }
        }
    
        #endregion
        private void btnDel_Click(object sender, EventArgs e)
        {
            BUProductClass myBUProductClass = new BUProductClass();
            bool ReturnValue = false;
            DialogResult dr = MessageBox.Show("确定删除此条信息吗？", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {                
                string paramClassValue = trvPrdouctClass.SelectedNode.Tag.ToString();
                ReturnValue = myBUProductClass.DeleteProductClass(paramClassValue);
                
                if (ReturnValue)
                {
                    MessageBox.Show("恭喜您，删除数据成功！", "恭喜", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmProductClassManager_Load(sender,e);

                }
                else
                {
                    MessageBox.Show("操作错误", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        /// <summary>
        /// 设置TreeView选中节点
        /// </summary>
        /// <param name="treeView"></param>
        /// <param name="selectStr">选中节点文本</param>
        private void SelectTreeView(TreeView treeView, string selectStr)
        {
            treeView.Focus();
            for (int i = 0; i < treeView.Nodes.Count; i++)
            {
                for (int j = 0; j < treeView.Nodes[i].Nodes.Count; j++)
                {
                    if (treeView.Nodes[i].Nodes[j].Text == selectStr)
                    {
                        trvPrdouctClass.SelectedNode = treeView.Nodes[i].Nodes[j];//选中
                        //treeView.Nodes[i].Nodes[j].Checked = true;
                        treeView.Nodes[i].Expand();//展开父级
                        return;
                    }
                }
            }
        }

    }
}
