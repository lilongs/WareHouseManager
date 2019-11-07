using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BULayer;
using System.Drawing.Printing;
using Model;

namespace InventoryManagersystem.sys
{
    public partial class frmPermissionManage : Form
    {
        PrintDocument printDocument;
        public frmPermissionManage()
        {
            InitializeComponent();
              printDocument=new PrintDocument();
              printDocument.PrintPage += new PrintPageEventHandler (this.printDocument1_PrintPage);
        }

    
        MoRole myMoRole = new MoRole();
        BLLModelInfo myBLLModelInfo = new BLLModelInfo();
        private string paramRoleID = "1";
        private string UserName = string.Empty;
        DataTable myDt = new DataTable();
        BLIRoleInfo myBLIRoleInfo = new BLIRoleInfo();
        private int paramMaxRoleID;
        DataTable myDtN = new DataTable();
       int Mark = 0;

        #region GetRoleInfoData() 获取到角色的数据集
        /// <summary>
        /// 获取到角色的数据集
        /// </summary>
        private void GetRoleInfoData()
        {
            DataSet myDs = new DataSet();
            myDs = myBLIRoleInfo.GetAllList();
            this.dgvMain.DataSource = myDs.Tables[0];
        }
        #endregion

        #region GetMaxID() 获取最大的ID
        /// <summary>
        /// 获取最大的ID
        /// </summary>
        private void GetMaxID()
        {
            BLIRoleInfo myBLIRoleInfo = new BLIRoleInfo();
            this.paramMaxRoleID = myBLIRoleInfo.GetMaxId();
        }
        #endregion

        #region  private bool CheckRole(string paramRoleID) 权限删除的条件
        /// <summary>
        /// 权限删除的条件
        /// </summary>
        /// <param name="paramRoleID"></param>
        /// <returns></returns>
        private bool CheckRole(string paramRoleID)
        {      
            bool Returnvalue = myBLIRoleInfo.ExistsRoleID(Convert.ToInt32( paramRoleID));
            return Returnvalue;

        }
        #endregion

        #region  private void GetCombRole() 权限文本框的绑定
        /// 权限文本框的绑定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetCombRole()
        {
            myDtN = myBLIRoleInfo.GetAllList().Tables[0];
            cmbRole.ValueMember = "RoleID";
            cmbRole.DisplayMember = "RoleName";
            cmbRole.DataSource = myDtN;
        }
        #endregion

        private DataTable GetPermission(string paramRoleID)
        {
            myDt = myBLLModelInfo.GePermission(paramRoleID).Tables[0];
            return myDt;
        }
        private void BindChildrenNodes(TreeNode paramTreeNode, DataTable paramTable)
        {
            TreeNode myNode;
            paramTreeNode.Nodes.Clear();

            foreach (DataRow myDataRow in paramTable.Rows)
            {
                myNode = new TreeNode();
                if (myDataRow["ParentID"].ToString() == paramTreeNode.Tag.ToString())
                {
                    myNode.Tag = myDataRow["ID"].ToString();
                    myNode.Text = myDataRow["ModuleName"].ToString();
                    myNode.Checked = Convert.ToBoolean(myDataRow["Enable"].ToString());
                    paramTreeNode.Nodes.Add(myNode);
                    //递归绑定节点
                    BindChildrenNodes(myNode, paramTable);
                }
            }
        }
        private void BingTreeView()
        {
            //添加根节点
            TreeNode RootNode = new TreeNode();
            RootNode.Text = "权限分配";
            RootNode.Tag = "0";
            this.trView.Nodes.Add(RootNode);
            myDt = GetPermission(paramRoleID);
            //绑定子节点
            BindChildrenNodes(RootNode, myDt);

        }


        private void SetChildNodeCheck(TreeNode CurrNode, bool state)
        {
            TreeNodeCollection nodes = CurrNode.Nodes;
            if (nodes.Count > 0)
            {
                foreach (TreeNode tn in nodes)
                {
                    tn.Checked = state;
                    SetChildNodeCheck(tn, state);
                }
            }
        }

        private void SetParentNodeCheck(TreeNode CurrNode, bool state)
        {
            TreeNode parentNode = CurrNode.Parent;
            parentNode.Checked = state;
            if (!state)
            {
                foreach (TreeNode myNode in parentNode.Nodes)
                {
                    if (CurrNode == myNode)
                    {
                        continue;
                    }
                    if (myNode.Checked)
                    {
                        parentNode.Checked = true;
                        break;
                    }

                }
            }
            if (CurrNode.Parent.Parent != null)
            {
                SetParentNodeCheck(CurrNode.Parent, state);
            }
        }

        private void GetAllTreeNodes(TreeNodeCollection nodes)
        {
            string paramRoleID = this.paramRoleID;
            string paramModuleID = string.Empty;
            string paramModuleName = string.Empty;
            bool Enable;
            foreach (TreeNode td in nodes)
            {
                Enable = td.Checked;
                paramModuleName = td.Text;
                paramModuleID = td.Tag.ToString();

                myMoRole.RoleID = paramRoleID;
                myMoRole.ModuleID = paramModuleID;
                myMoRole.Enable = Convert.ToInt32(Enable);
                if (myBLIRoleInfo.updateRole(myMoRole) > 0)
                {
                    Mark++;
                }
                if (td.Nodes.Count > 0)
                {
                    GetAllTreeNodes(td.Nodes);
                }
            }

        }

        private void frmPermissionManage_Load(object sender, EventArgs e)
        {
            GetCombRole();
            GetRoleInfoData();//1、加载角色值
        }

        private void btnRoleSure_Click(object sender, EventArgs e)
        {
            string paramRoleName = this .txtRoleID.Text.Trim ();
            DataSet myDs = new DataSet();
            myDs = myBLIRoleInfo.GetList(paramRoleName);
            this.dgvMain.DataSource = myDs.Tables[0];
        }

        private void btnRoleAdd_Click(object sender, EventArgs e)
        {
            GetMaxID();
            frmRoleInfo myfrmRoleInfo = new frmRoleInfo(this.paramMaxRoleID);
            if (myfrmRoleInfo.ShowDialog() == DialogResult.Yes)
            {
                frmPermissionManage_Load(sender, e);
            }
        }

        private void btnRoleUpdate_Click(object sender, EventArgs e)
        {
            int Count = this.dgvMain.SelectedRows.Count;
            if (Count == 0)
            {
                MessageBox.Show("请选择行");
                return;
            }
            string paramIRoleInfoID = this.dgvMain.SelectedRows[0].Cells["RoleID"].Value.ToString();
            frmRoleInfo myfrmRoleInfo = new frmRoleInfo(paramIRoleInfoID);
            if (myfrmRoleInfo.ShowDialog() == DialogResult.Yes)
            {
                frmPermissionManage_Load(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Count = this.dgvMain.SelectedRows.Count;
            if (Count == 0)
            {
                MessageBox.Show("请选择需要删除的行");
                return;
            }
            string paramIRoleInfoID = this.dgvMain.SelectedRows[0].Cells["RoleID"].Value.ToString();
          
            BLIRoleInfo myBLIRoleInfo = new BLIRoleInfo();
            if (CheckRole(paramIRoleInfoID))
            {
                MessageBox.Show("【" + paramIRoleInfoID + "】权限已被分配！不能被删除！");
                return;
            }
            if (MessageBox.Show("确定删除编号【" + paramIRoleInfoID + "】的权限信息吗？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                myBLIRoleInfo.Delete(Convert.ToInt32(paramIRoleInfoID));
              
                MessageBox.Show("操作成功！");
                frmPermissionManage_Load(sender, e);
            }
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            paramRoleID = this.cmbRole.SelectedValue.ToString();
            if (paramRoleID.Length == 0)
            {
                return;
            }
            this.trView.Nodes.Clear();
            //BLIRoleInfo myBLIRoleInfo = new BLIRoleInfo();
            //DataSet myDS = new DataSet();
            //myDS = myBLIRoleInfo.GetRoleList(paramUserType);
           // paramRoleID = paramUserType;

            //----------重新绑定权限树------------//
            BingTreeView();
            this.trView.ExpandAll();
        }

        private void trView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.ByMouse)
            {
                SetChildNodeCheck(e.Node, e.Node.Checked);
                if (e.Node.Parent != null)
                {
                    SetParentNodeCheck(e.Node, e.Node.Checked);
                }
            }
        }

        private void btnSetRole_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable MyModelInfo = new DataTable();
                BLLModelInfo myBLModule = new BLLModelInfo();
                MoRole MoIRole = new MoRole();
                BLIRoleInfo myBLIRole = new BLIRoleInfo();
                int paramUpdate = 0;//记录加载次数

                MyModelInfo = myBLModule.GetModuleIDList().Tables[0];
                //开始循环现有的权限值（即共计多少个角色）
                for (int i = 0; i < myDtN.Rows.Count; i++)
                {
                    //循环计算是否有该角色的数据

                    for (int j = 0; j < MyModelInfo.Rows.Count; j++)
                    {
                        //第一步：去查找该角色是否有该模块权限，有则PSS,无则Update
                        if (!myBLModule.Exists(myDtN.Rows[i]["RoleID"].ToString(), MyModelInfo.Rows[j]["ID"].ToString()))
                        {
                            MoIRole.RoleID = myDtN.Rows[i]["RoleID"].ToString();
                            MoIRole.ModuleID = MyModelInfo.Rows[j]["ID"].ToString();
                            MoIRole.Enable = 0;
                            myBLIRole.Add(MoIRole);
                        }
                    }
                }
                if (paramUpdate == 0)
                {

                    this.Cursor = Cursors.Default;
                    MessageBox.Show("权限已是最新，不需要加载", "温馨提示！");

                }
                if (paramUpdate > 0)
                {

                    this.Cursor = Cursors.Default;
                    MessageBox.Show("已成功加载['" + paramUpdate + "']项权限值", "温馨提示！");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (trView.Nodes.Count > 0)
            {
                GetAllTreeNodes(this.trView.Nodes);
                if (Mark > 0)
                {
                    MessageBox.Show("权限处理成功！");
                }
            }
        }

        private void btnReflash_Click(object sender, EventArgs e)
        {
            frmPermissionManage_Load(sender, e);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //打印预览
           PrintPreviewDialog ppd = new PrintPreviewDialog();
           PrintDocument pd = new PrintDocument();
           //设置边距
            Margins margin = new Margins(20, 20, 20, 20);
           pd.DefaultPageSettings.Margins = margin;
            ////纸张设置默认
            PaperSize pageSize = new PaperSize("First custom size", 800, 600);
            pd.DefaultPageSettings.PaperSize = pageSize;
            //打印事件设置
            pd.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            ppd.Document = pd;
            ppd.ShowDialog();
            try
            {
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "打印出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pd.PrintController.OnEndPrint(pd, new PrintEventArgs());
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            string date ="2017-06-05"; //当前日期
            string flowId ="流水号"; //流水号
            string UserId = "123";
            string payDate = "2017-06-29" ;//应收年月
            string adminId = "";  //操作员编号
            string baseExpense = ""; ; //应交基本费用
            string fine = ""; ;  //罚款数目
            string upExpense = ""; ;  //上月上余
            string actualExpense = ""; ;  //实际应交费用
            string chineseExpense = "";  //实际应交费用的中文大写

            //读取图片模板
            Image temp = Image.FromFile(@"moban.jpg");
            GetResultIntoImage(ref temp, UserId, flowId, date, baseExpense, fine, upExpense, actualExpense, chineseExpense, payDate, adminId);
            int x = e.MarginBounds.X;
            int y = e.MarginBounds.Y;
            int width = temp.Width;
            int height = temp.Height;
            Rectangle destRect = new Rectangle(x, y, width, height);
            e.Graphics.DrawImage(temp, destRect, 0, 0, temp.Width, temp.Height, System.Drawing.GraphicsUnit.Pixel);
        }
        private void GetResultIntoImage(
         ref Image temp,
         string userId,
         string flowId,
         string currentDate,
         string baseExpense,
         string fine,
         string upExpense,
         string actualExpense,
         string chineseExpense,
         string payDate,
         string adminName)
        {
            //读取图片模板
            Graphics g = Graphics.FromImage(temp);

            Font f = new Font("宋体", 12);
            Brush b = new SolidBrush(Color.Black);

            //填充数据到图片模板（位置要在制作图片模板的时候度量好）
            g.DrawImage(temp, 0, 0, temp.Width, temp.Height);
            g.DrawString(userId, f, b, 168, 105);
            g.DrawString(UserName, f, b, 166, 134);
            g.DrawString(flowId, f, b, 535, 105);
            g.DrawString(currentDate, f, b, 535, 134);
            g.DrawString(baseExpense, f, b, 219, 202);
            g.DrawString(fine, f, b, 372, 202);
            g.DrawString(upExpense, f, b, 486, 202);
            g.DrawString(actualExpense, f, b, 596, 202);
            g.DrawString(chineseExpense, f, b, 196, 238);
            g.DrawString(payDate, f, b, 176, 269);
            g.DrawString(adminName, f, b, 497, 298);

            g.Dispose();
        }
    }
}
