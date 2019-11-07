namespace InventoryManagersystem.InventoryManager
{
    partial class frmStockPile
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockPile));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.combLocation = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtPruductName = new System.Windows.Forms.TextBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.sbtnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.combSpplier = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combStoreHouse_ID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnEnterStock = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gdCInvent = new DevExpress.XtraGrid.GridControl();
            this.gdvInvent = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdCInvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvInvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.combLocation);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dateEdit1);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.txtPruductName);
            this.groupBox3.Controls.Add(this.btnAll);
            this.groupBox3.Controls.Add(this.sbtnRefresh);
            this.groupBox3.Controls.Add(this.btnExcel);
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.combSpplier);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtQuantity);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.combStoreHouse_ID);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtPrice);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(998, 123);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "选择产品";
            // 
            // combLocation
            // 
            this.combLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combLocation.FormattingEnabled = true;
            this.combLocation.Location = new System.Drawing.Point(302, 20);
            this.combLocation.Name = "combLocation";
            this.combLocation.Size = new System.Drawing.Size(159, 20);
            this.combLocation.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "货架号";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(544, 53);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit1.Properties.EditFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.dateEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit1.Properties.Mask.EditMask = "yyyy-MM-dd HH:mm:ss";
            this.dateEdit1.Size = new System.Drawing.Size(198, 20);
            this.dateEdit1.TabIndex = 26;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(72, 86);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 23);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Tag = "";
            this.btnAdd.Text = "+加入清单";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPruductName
            // 
            this.txtPruductName.Location = new System.Drawing.Point(544, 19);
            this.txtPruductName.Name = "txtPruductName";
            this.txtPruductName.ReadOnly = true;
            this.txtPruductName.Size = new System.Drawing.Size(160, 21);
            this.txtPruductName.TabIndex = 24;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(710, 19);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(32, 23);
            this.btnAll.TabIndex = 23;
            this.btnAll.Text = "+";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // sbtnRefresh
            // 
            this.sbtnRefresh.Location = new System.Drawing.Point(199, 86);
            this.sbtnRefresh.Name = "sbtnRefresh";
            this.sbtnRefresh.Size = new System.Drawing.Size(75, 23);
            this.sbtnRefresh.TabIndex = 22;
            this.sbtnRefresh.Tag = "";
            this.sbtnRefresh.Text = "刷新";
            this.sbtnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(419, 86);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 20;
            this.btnExcel.Tag = "";
            this.btnExcel.Text = "导出";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(302, 86);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(89, 23);
            this.btnPrint.TabIndex = 19;
            this.btnPrint.Tag = "销售出库";
            this.btnPrint.Text = "打印";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "入库时间";
            // 
            // combSpplier
            // 
            this.combSpplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combSpplier.FormattingEnabled = true;
            this.combSpplier.Location = new System.Drawing.Point(805, 20);
            this.combSpplier.Name = "combSpplier";
            this.combSpplier.Size = new System.Drawing.Size(181, 20);
            this.combSpplier.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "入库数量";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(72, 52);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(147, 21);
            this.txtQuantity.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "物料名称";
            // 
            // combStoreHouse_ID
            // 
            this.combStoreHouse_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combStoreHouse_ID.FormattingEnabled = true;
            this.combStoreHouse_ID.Location = new System.Drawing.Point(72, 20);
            this.combStoreHouse_ID.Name = "combStoreHouse_ID";
            this.combStoreHouse_ID.Size = new System.Drawing.Size(147, 20);
            this.combStoreHouse_ID.TabIndex = 8;
            this.combStoreHouse_ID.SelectedValueChanged += new System.EventHandler(this.combStoreHouse_ID_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "库房编码";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(758, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "供应商";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "入库单价";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(299, 52);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(162, 21);
            this.txtPrice.TabIndex = 6;
            // 
            // btnEnterStock
            // 
            this.btnEnterStock.Location = new System.Drawing.Point(50, 36);
            this.btnEnterStock.Name = "btnEnterStock";
            this.btnEnterStock.Size = new System.Drawing.Size(75, 23);
            this.btnEnterStock.TabIndex = 21;
            this.btnEnterStock.Tag = "";
            this.btnEnterStock.Text = "+批量入库";
            this.btnEnterStock.Click += new System.EventHandler(this.btnEnterStock_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gdCInvent);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(998, 383);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "入库单";
            // 
            // gdCInvent
            // 
            this.gdCInvent.ContextMenuStrip = this.contextMenuStrip1;
            this.gdCInvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdCInvent.Location = new System.Drawing.Point(3, 17);
            this.gdCInvent.MainView = this.gdvInvent;
            this.gdCInvent.Name = "gdCInvent";
            this.gdCInvent.Size = new System.Drawing.Size(992, 363);
            this.gdCInvent.TabIndex = 9;
            this.gdCInvent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvInvent});
            // 
            // gdvInvent
            // 
            this.gdvInvent.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn12,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn7,
            this.gridColumn8,
            this.gdcQuantity,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gdvInvent.GridControl = this.gdCInvent;
            this.gdvInvent.Name = "gdvInvent";
            this.gdvInvent.OptionsFind.AlwaysVisible = true;
            this.gdvInvent.OptionsView.ShowFooter = true;
            this.gdvInvent.OptionsView.ShowGroupPanel = false;
            this.gdvInvent.Tag = "销售出库";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "仓库编码";
            this.gridColumn1.FieldName = "storeHouseId";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 85;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "产品编码";
            this.gridColumn5.FieldName = "productId";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 85;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "产品名称";
            this.gridColumn6.FieldName = "productName";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 85;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "产品规格";
            this.gridColumn9.FieldName = "productSpec";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            this.gridColumn9.Width = 85;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "产品类别";
            this.gridColumn10.FieldName = "productClassName";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 5;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "产品单位";
            this.gridColumn11.FieldName = "productUnitName";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 6;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "供应商编码";
            this.gridColumn7.FieldName = "supplierId";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 7;
            this.gridColumn7.Width = 85;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "供应商名称";
            this.gridColumn8.FieldName = "name";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 8;
            this.gridColumn8.Width = 85;
            // 
            // gdcQuantity
            // 
            this.gdcQuantity.Caption = "入库数量";
            this.gdcQuantity.FieldName = "quantity";
            this.gdcQuantity.Name = "gdcQuantity";
            this.gdcQuantity.OptionsColumn.AllowEdit = false;
            this.gdcQuantity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "quantity", "共计={0}")});
            this.gdcQuantity.Visible = true;
            this.gdcQuantity.VisibleIndex = 9;
            this.gdcQuantity.Width = 85;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "入库单价";
            this.gridColumn2.FieldName = "price";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 10;
            this.gridColumn2.Width = 85;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "总金额";
            this.gridColumn3.FieldName = "totalPrice";
            this.gridColumn3.MinWidth = 150;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "totalPrice", "总金额={0}")});
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 11;
            this.gridColumn3.Width = 150;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "入库时间";
            this.gridColumn4.FieldName = "stockInDate";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 12;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnEnterStock);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 435);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(998, 71);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "入库操作";
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "货架号";
            this.gridColumn12.FieldName = "locationNo";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 26);
            // 
            // DeleteMenuItem
            // 
            this.DeleteMenuItem.Name = "DeleteMenuItem";
            this.DeleteMenuItem.Size = new System.Drawing.Size(136, 22);
            this.DeleteMenuItem.Text = "删除当前行";
            this.DeleteMenuItem.Click += new System.EventHandler(this.DeleteMenuItem_Click);
            // 
            // frmStockPile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 506);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStockPile";
            this.Text = "采购入库";
            this.Load += new System.EventHandler(this.frmStockPile_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdCInvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvInvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox combStoreHouse_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combSpplier;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraGrid.GridControl gdCInvent;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvInvent;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gdcQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private DevExpress.XtraEditors.SimpleButton btnEnterStock;
        private DevExpress.XtraEditors.SimpleButton sbtnRefresh;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.TextBox txtPruductName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private System.Windows.Forms.ComboBox combLocation;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenuItem;
    }
}