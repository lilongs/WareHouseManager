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
        BUProductManagerResult MyPms = new BUProductManagerResult();
        public frmProductClassManager()
        {
            InitializeComponent();
        }

        private void brnSearch_Click(object sender, EventArgs e)
        {
            string paramProductClassName = this.txtBoxProductName.Text.ToString();
            string paramProductClassCode = this.txtBoxProductCode.Text.ToString();
            bool isNotNull = MyPms.CheckProductClass(paramProductClassName,paramProductClassCode);
            if (isNotNull)
            {
                this.dataGridView1.DataSource = MyPms.GetProductClassTbl(paramProductClassName, paramProductClassCode);
            }
            else
            {
                MessageBox.Show("查无记录");
            }

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
           // DateTime dt = DateTime.Now;
            //MessageBox.Show(dt.AddDays(-7).ToString("yyyy-MM-dd HH:mm:ss"));
           // MessageBox.Show(dt.AddDays(0).ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
