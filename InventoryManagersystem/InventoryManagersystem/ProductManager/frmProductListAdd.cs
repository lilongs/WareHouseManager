using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BULayer;
using DevExpress.Utils;
using Common;

namespace InventoryManagersystem.ProductManager
{
    public partial class frmProductListAdd : Form
    {
        BUProductList myBUProductListAdd = new BUProductList();
        string ProductClassID = string.Empty;
        string ProductClassName = string.Empty;

        string paramProductID_2 = string.Empty;
        public frmProductListAdd()
        {
            InitializeComponent();
        }

        public frmProductListAdd(string paramProductID, string ProductClassId,string paramProductClassName, string paramProductName, string paramProductSpec,string paramUnitName, string paramEmployeeName, string paramRemark)
        {
            InitializeComponent();
            btnSaveNew.Visible = false;
            this.paramProductID_2 = paramProductID;
            this.txtBoxProductID.Text = paramProductID;
            this.txtBoxProductID.Enabled=false;
            this.txtBoxProductName.Text = paramProductName;
            this.txtBoxProductName.Focus();
            this.txtBoxSpec.Text = paramProductSpec;
            this.txtRemark.Text = paramRemark;
            this.ProductClassID = ProductClassId;
            this.comBProductClass.Text = paramProductClassName;
        }


        public void SetUnitComb()
        {
            DataTable myUnitDt = new DataTable();
            BUProductUnit bUProductUnit = new BUProductUnit();
            myUnitDt = bUProductUnit.GetUnitInfo(string.Empty);
            comBoxUnit.DataSource = myUnitDt;
            comBoxUnit.DisplayMember = "product_unit_name";
            comBoxUnit.ValueMember = "product_unit_id";
        }

        private void frmProductAdd_Load(object sender, EventArgs e)
        {
            this.txtEmployeeName.Text = this.Tag.ToString();
            SetUnitComb();
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            try
            {
                BUProductList myBUProductListadd = new BUProductList();

                string paramProductID = this.txtBoxProductID.Text.Trim();
                string paramProductClassID = this.ProductClassID;
                string paramProductName = this.txtBoxProductName.Text.Trim();
                string paramProductSpec = this.txtBoxSpec.Text.Trim();
                string paramUnitID = this.comBoxUnit.SelectedValue.ToString();
                string paramEmployeeName = this.txtEmployeeName.Text.ToString();
                string paramRemark = this.txtRemark.Text.ToString();
                string paramProductName_s = string.Empty;

                bool isValue = myBUProductListadd.IsExistsProduct(paramProductID);

                if (paramProductName == "" || paramProductID=="")
                {
                    MessageBox.Show("请输入正确商品名和编码！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!isValue)
                {
                    bool returnValue = myBUProductListadd.CheckProductAdd(paramProductID, paramProductClassID,paramProductName,paramProductSpec,paramUnitID,paramEmployeeName,paramRemark);
                    if (returnValue)
                    {
                        MessageBox.Show("恭喜您，数据添加成功！", "恭喜", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBoxProductID.Text = string.Empty;
                        txtBoxProductName.Text = string.Empty;
                        txtBoxSpec.Text = string.Empty;
                        txtRemark.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("商品编码重复！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("添加失败");
            }
        }        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string paramProductID = this.txtBoxProductID.Text.Trim();
            string paramProductClassID = this.ProductClassID;
            string paramProductName = this.txtBoxProductName.Text.Trim();
            string paramProductSpec = this.txtBoxSpec.Text.Trim();
            string paramUnitID = this.comBoxUnit.SelectedValue.ToString();
            string paramEmployeeName = this.txtEmployeeName.Text.ToString();
            string paramRemark = this.txtRemark.Text.ToString();
            string paramProductName_s = string.Empty;

            if (paramProductID_2.Length == 0)
            {
                try
                {
                    BUProductList myBUProductList = new BUProductList();
                    bool isValue = myBUProductList.IsExistsProduct(paramProductID);
                    if (paramProductName == "" || paramProductID == "")
                    {
                        MessageBox.Show("请输入正确商品名和编码！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (!isValue)
                    {
                        bool returnValue = myBUProductList.CheckProductAdd(paramProductID, paramProductClassID, paramProductName, paramProductSpec, paramUnitID, paramEmployeeName, paramRemark);
                        if (returnValue)
                        {
                            MessageBox.Show("恭喜您，数据添加成功！", "恭喜", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        MessageBox.Show("商品名称重复！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("添加失败");
                }
            }
            else
            {
                bool isModifyProductListOK = myBUProductListAdd.UpdateProductList(paramProductID, paramProductClassID, paramProductName, paramProductSpec, paramUnitID, paramEmployeeName, paramRemark);
                if (isModifyProductListOK)
                {
                    MessageBox.Show("修改成功");
                    this.DialogResult = DialogResult.OK;

                }
                else
                {
                    MessageBox.Show("更新失败");
                    this.DialogResult = DialogResult.OK;
                }

            }

        }

        private void btnBatchAdd_Click(object sender, EventArgs e)
        {
            string paramProductName = string.Empty;
            string paramProductCode = string.Empty;
            if (comBProductClass.Text.Length == 0)
            {
                MessageBox.Show("产品类别不能为空！");
                return;
            }
            OpenFileDialog theDlg = new OpenFileDialog();
            theDlg.Title = "请选择文件";
            theDlg.Filter = "数据(*.xlsx)|*.xlsx|数据(*.xls)|*.xls";
            theDlg.DefaultExt = ".xlsx";
            if (theDlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            string theFile = theDlg.FileName;
            string strCom = string.Empty;
            WaitDialogForm wdf = null;
            List<string> thelstCom = new List<string>();
            string strError = string.Empty;
            string IndexCount = "0";

            try
            {
                wdf = new WaitDialogForm("正在导入数据,请稍后....", "温馨提示");               
                DataTable dtData=null;
                if (Environment.Is64BitOperatingSystem)
                {
                    dtData = CreateXmlForData.ExecleToDataSet(theFile, 1).Copy();                    
                }
                else
                {
                    dtData = KSRCommonUtils.GetExcelData(theFile, "Sheet1").Tables[0];
                }
                if (dtData.Rows.Count > 0)
                {
                    IndexCount = "0";
                    wdf.Caption = "共" + dtData.Rows.Count.ToString() + "条数据,正在导入第" + IndexCount + "条数据,请稍后....";
                    DataTable dtTemp = myBUProductListAdd.GetProductInfoByName(string.Empty,string.Empty);
                    for (int i = 0; i < dtData.Rows.Count; i++)
                    {
                        if(!myBUProductListAdd.IsExistsProduct(dtData.Rows[i][0].ToString()))
                        {

                            dtTemp.Clear();
                            DataRow dr = dtTemp.NewRow();
                            IndexCount = (i + 1).ToString();
                            wdf.Caption = "共" + dtData.Rows.Count.ToString() + "条数据,正在导入第" + IndexCount + "条数据,请稍后....";
                            try
                            {
                                int ResultRow = 0;
                                dr["product_id"] = "'" + dtData.Rows[i][0].ToString() + "'";
                                dr["product_name"] = "'" + dtData.Rows[i][1].ToString() + "'";
                                dr["product_spec"] = "'" + dtData.Rows[i][2].ToString() + "'";
                                BUProductClass bUProductClass = new BUProductClass();
                                dr["product_class_id"] = bUProductClass.GetProductClassByName(dtData.Rows[i][3].ToString()).Rows[0]["product_class_id"].ToString(); ;
                                BUProductUnit bUBUProductUnit = new BUProductUnit();
                                dr["product_unit_id"] = bUBUProductUnit.GetUnitInfo(dtData.Rows[i][4].ToString()).Rows[0]["product_unit_id"].ToString();
                                dr["createby"] = "'" + txtEmployeeName.Text.ToString() + "'";
                                dr["create_date"] = "'" + DateTime.Now.ToString("yyyy-MM-dd") + "'";
                                dr["remark"] = "'" + dtData.Rows[i][5].ToString() + "'";
                                dtTemp.Rows.Add(dr);

                                ResultRow = myBUProductListAdd.Excel_InsertProductList(dtTemp, i, dtData.Rows.Count);
                                MessageBox.Show("导入成功");
                                this.DialogResult = DialogResult.OK;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(dtData.Rows[i][0].ToString() + dtData.Rows[i][1].ToString() + ":" + ex.Message);
                                wdf.Close();
                                return;
                            }
                        }
                    }
                }
                else
                {
                    wdf.Close();
                    MessageBox.Show("记录为空"); ;
                }
            }
            finally
            {
                if (wdf != null)
                    wdf.Close();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmProlist_All myfrmProlist_All = new frmProlist_All();
            if (myfrmProlist_All.ShowDialog() == DialogResult.Yes)
            {
                this.ProductClassID = myfrmProlist_All.ProductClassID;
                this.ProductClassName = myfrmProlist_All.ProductClassName;
                this.comBProductClass.Text = ProductClassName;
            }
        } 
    }
}
