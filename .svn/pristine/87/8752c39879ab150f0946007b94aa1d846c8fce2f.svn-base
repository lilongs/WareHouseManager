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
    public partial class frmProductAdd : Form
    {
        public frmProductAdd()
        {
            InitializeComponent();
        }

        BUCheckResult myBUCheckResult = new BUCheckResult();
        public void SetProductComb()
        {
            DataTable myPudtClass = new DataTable();
            myPudtClass = myBUCheckResult.GetProductList();
            comBoxProductClass.DataSource = myPudtClass;
            comBoxProductClass.ValueMember = "ProductClassID";
            comBoxProductClass.DisplayMember = "ProductClassName";
          
        }

        public void SetUnitComb()
        {
            DataTable myUnitDt = new DataTable();
            myUnitDt = myBUCheckResult.GetProductUnit();
            comBoxUnit.DataSource = myUnitDt;
            comBoxUnit.DisplayMember = "ProductUnitName";
            comBoxUnit.ValueMember = "ProductUnitID";
        }
        private void frmProductAdd_Load(object sender, EventArgs e)
        {
            SetProductComb();
            SetUnitComb();
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comBoxProductClass.SelectedValue.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmProductClassAdd MyfrmPCA = new frmProductClassAdd();
            MyfrmPCA.ShowDialog();

        }
    }
}
