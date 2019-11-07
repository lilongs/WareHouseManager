namespace InventoryManagersystem.ProductManager
{
    partial class frmSup_All
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSup_All));
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSelect = new System.Windows.Forms.Button();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.lblname = new System.Windows.Forms.Label();
            this.gdCItem = new DevExpress.XtraGrid.GridControl();
            this.gdvItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdCItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "供应商名称";
            this.gridColumn6.FieldName = "name";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(308, 23);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 9;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "地址";
            this.gridColumn1.FieldName = "address";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "供应商编码";
            this.gridColumn5.FieldName = "supplier_id";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemComboBox1.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(416, 32);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(89, 12);
            this.lblname.TabIndex = 13;
            this.lblname.Text = "选中后双击即可";
            // 
            // gdCItem
            // 
            this.gdCItem.Location = new System.Drawing.Point(15, 67);
            this.gdCItem.MainView = this.gdvItem;
            this.gdCItem.Name = "gdCItem";
            this.gdCItem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.gdCItem.Size = new System.Drawing.Size(654, 281);
            this.gdCItem.TabIndex = 12;
            this.gdCItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvItem});
            this.gdCItem.DoubleClick += new System.EventHandler(this.gdCItem_DoubleClick);
            // 
            // gdvItem
            // 
            this.gdvItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn1});
            this.gdvItem.GridControl = this.gdCItem;
            this.gdvItem.Name = "gdvItem";
            this.gdvItem.OptionsFind.AlwaysVisible = true;
            this.gdvItem.OptionsView.ShowFooter = true;
            this.gdvItem.OptionsView.ShowGroupPanel = false;
            this.gdvItem.Tag = "销售出库";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(68, 23);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(198, 21);
            this.txtSupplierName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "物料:";
            // 
            // frmSup_All
            // 
            this.AcceptButton = this.btnSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 370);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.gdCItem);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSup_All";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "供应商查询";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdCItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.Button btnSelect;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private System.Windows.Forms.Label lblname;
        private DevExpress.XtraGrid.GridControl gdCItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvItem;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label label1;
    }
}