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
    public partial class frmProductUnitAdd : Form
    {
        public frmProductUnitAdd()
        {
            InitializeComponent();
        }

        private void btnAddProductUnit_Click(object sender, EventArgs e)
        {
            try
            {
                BUUnitAdd myBUUnitadd = new BUUnitAdd();

                string paramRemark = this.txtBoxRemark.Text.ToString();
                string paramUnitName = this.txtBoxProductUnitName.Text.ToString();
                bool isValue = myBUUnitadd.CheckUnitValue(paramUnitName);

                if (paramUnitName == string.Empty || paramUnitName.Trim() == "") 
                {
                    MessageBox.Show("请输入正确计量单位！","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

                if (!isValue)
                {

                    bool returnValue = myBUUnitadd.CheckUnitAdd(paramUnitName, paramRemark);

                    if (returnValue)
                    {
                        MessageBox.Show("恭喜您，数据添加成功！", "恭喜", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show("计量单位重复！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {

                MessageBox.Show("添加失败");
                this.DialogResult = DialogResult.No;
            }
            
        }
       
          

        private void frmProductUnitAdd_Load(object sender, EventArgs e)
        {
            this.txtBoxProductUnitCode.Text = "此编码自动生成";
        }

        }
 }


