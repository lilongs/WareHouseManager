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
    public partial class frmProductUnit : Form
    {
        public frmProductUnit()
        {
            InitializeComponent();
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmProductUnitAdd myFrmPUA = new frmProductUnitAdd();
            DialogResult dr = new DialogResult();
            dr = myFrmPUA.ShowDialog();
            if (dr == DialogResult.OK)
            {
                  btnRefresh_Click(sender, e);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string parmaUnitName = this.txtBoxUnitSearch.Text;
            DataTable myDt = new DataTable();
            BUProductUnit myBUProductUnit = new BUProductUnit();
            myDt = myBUProductUnit.GetUnitInfo(parmaUnitName);
            if (myDt.Rows.Count == 0)
            {
                MessageBox.Show ("对不起，您输入的计量单位不存在.请确认输入的查询单位是否正确","温馨提示！",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            this.gdcInfo.DataSource = myDt;

        }
        private void btnDelProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.gdvInfo.SelectedRowsCount == 0)
                {
                    MessageBox.Show("请选择要删除的信息！");
                    return;
                }
                int[] indexArr = this.gdvInfo.GetSelectedRows();
                bool ReturnValue = false;
                BUProductUnit myBUProductUnit = new BUProductUnit();
                DialogResult dr = MessageBox.Show("确定删除此条信息吗？", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    for (int i = 0; i < indexArr.Count(); i++)
                    {

                        string paramUnitId = this.gdvInfo.GetDataRow(indexArr[i])["product_unit_id"].ToString();
                        ReturnValue = myBUProductUnit.UnitDelete(paramUnitId);
                    }
                    if (ReturnValue)
                    {
                        MessageBox.Show("恭喜您，删除数据成功！", "恭喜", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnRefresh_Click(sender, e);

                    }
                    else
                    {
                        MessageBox.Show("操作错误或该类别已在使用!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnSearch_Click(sender,e);
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {

            int count = this.gdvInfo.SelectedRowsCount;
            if (count == 0)
            {
                MessageBox.Show("请先搜索/刷新并选择需要修改的用户行", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string paramUnitName = this.gdvInfo.GetFocusedRowCellValue("product_unit_name").ToString();
            string paramRemark = this.gdvInfo.GetFocusedRowCellValue("remark").ToString();
            int paramUnitCode = Convert.ToInt32(this.gdvInfo.GetFocusedRowCellValue("product_unit_id"));

            frmProductUnitModify MyFrmUnitModify = new frmProductUnitModify(paramUnitName,paramRemark,paramUnitCode);
            //MyFrmUnitModify.Tag = this.Tag;
            DialogResult dr = MyFrmUnitModify.ShowDialog();
            if (dr == DialogResult.OK)
            {
                btnRefresh_Click(sender,e);
            }

        }

        private void frmProductUnit_Load(object sender, EventArgs e)
        {
            btnSearch_Click(sender,e);
        }
    }
}
