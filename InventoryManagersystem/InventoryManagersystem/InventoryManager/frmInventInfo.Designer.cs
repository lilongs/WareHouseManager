namespace InventoryManagersystem.InventoryManager
{
    partial class frmInventInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventInfo));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.combLocation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combStoreHouse_ID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProduct_ID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gdcInfo = new DevExpress.XtraGrid.GridControl();
            this.gdvInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sales_Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.combLocation);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.combStoreHouse_ID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.lblProductName);
            this.groupBox2.Controls.Add(this.txtProduct_ID);
            this.groupBox2.Controls.Add(this.txtProductName);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(891, 55);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询";
            // 
            // combLocation
            // 
            this.combLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combLocation.FormattingEnabled = true;
            this.combLocation.Location = new System.Drawing.Point(252, 23);
            this.combLocation.Name = "combLocation";
            this.combLocation.Size = new System.Drawing.Size(113, 20);
            this.combLocation.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "库房编码";
            // 
            // combStoreHouse_ID
            // 
            this.combStoreHouse_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combStoreHouse_ID.FormattingEnabled = true;
            this.combStoreHouse_ID.Location = new System.Drawing.Point(74, 23);
            this.combStoreHouse_ID.Name = "combStoreHouse_ID";
            this.combStoreHouse_ID.Size = new System.Drawing.Size(113, 20);
            this.combStoreHouse_ID.TabIndex = 4;
            this.combStoreHouse_ID.SelectedValueChanged += new System.EventHandler(this.combStoreHouse_ID_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "库房编码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "物料编码";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(732, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(549, 26);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(53, 12);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "物料名称";
            // 
            // txtProduct_ID
            // 
            this.txtProduct_ID.Location = new System.Drawing.Point(430, 22);
            this.txtProduct_ID.Name = "txtProduct_ID";
            this.txtProduct_ID.Size = new System.Drawing.Size(113, 21);
            this.txtProduct_ID.TabIndex = 1;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(608, 22);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(118, 21);
            this.txtProductName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gdcInfo);
            this.groupBox1.Location = new System.Drawing.Point(0, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(891, 257);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "物料基本信息";
            // 
            // gdcInfo
            // 
            this.gdcInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcInfo.Location = new System.Drawing.Point(3, 17);
            this.gdcInfo.MainView = this.gdvInfo;
            this.gdcInfo.Name = "gdcInfo";
            this.gdcInfo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.gdcInfo.Size = new System.Drawing.Size(885, 237);
            this.gdcInfo.TabIndex = 7;
            this.gdcInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvInfo});
            // 
            // gdvInfo
            // 
            this.gdvInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn10,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.Sales_Quantity,
            this.gridColumn2});
            this.gdvInfo.GridControl = this.gdcInfo;
            this.gdvInfo.Name = "gdvInfo";
            this.gdvInfo.OptionsFind.AlwaysVisible = true;
            this.gdvInfo.OptionsView.ShowFooter = true;
            this.gdvInfo.OptionsView.ShowGroupPanel = false;
            this.gdvInfo.Tag = "销售出库";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "入库单号";
            this.gridColumn4.FieldName = "order_no";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "仓库编码";
            this.gridColumn1.FieldName = "store_house_id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "货架号";
            this.gridColumn3.FieldName = "location_no";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "产品编码";
            this.gridColumn5.FieldName = "product_id";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "产品名称";
            this.gridColumn6.FieldName = "product_name";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "产品规格";
            this.gridColumn7.FieldName = "product_spec";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "产品类别";
            this.gridColumn8.FieldName = "product_class_name";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 6;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "产品单位";
            this.gridColumn9.FieldName = "product_unit_name";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 7;
            // 
            // Sales_Quantity
            // 
            this.Sales_Quantity.Caption = "库存数量";
            this.Sales_Quantity.FieldName = "quantity";
            this.Sales_Quantity.Name = "Sales_Quantity";
            this.Sales_Quantity.OptionsColumn.AllowEdit = false;
            this.Sales_Quantity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Sales_Quantity", "出库总数量={0}")});
            this.Sales_Quantity.Visible = true;
            this.Sales_Quantity.VisibleIndex = 9;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "库存单价";
            this.gridColumn2.FieldName = "price";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 10;
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
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(270, 333);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(116, 32);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "-选择出货";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "供应商名称";
            this.gridColumn10.FieldName = "name";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 8;
            // 
            // frmInventInfo
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 383);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInventInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "出货选择";
            this.Load += new System.EventHandler(this.frmInventInfo_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox combStoreHouse_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProduct_ID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelect;
        private DevExpress.XtraGrid.GridControl gdcInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvInfo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn Sales_Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private System.Windows.Forms.ComboBox combLocation;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
    }
}