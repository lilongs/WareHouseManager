namespace InventoryManagersystem.Location
{
    partial class frmLocationNoMange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocationNoMange));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSearchUser = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtInventID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUserDel = new System.Windows.Forms.Button();
            this.btnUserMod = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gdcInfo = new DevExpress.XtraGrid.GridControl();
            this.gdvInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSearchUser);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtInventID);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1280, 75);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // lblSearchUser
            // 
            this.lblSearchUser.AutoSize = true;
            this.lblSearchUser.Location = new System.Drawing.Point(28, 38);
            this.lblSearchUser.Name = "lblSearchUser";
            this.lblSearchUser.Size = new System.Drawing.Size(53, 12);
            this.lblSearchUser.TabIndex = 3;
            this.lblSearchUser.Text = "仓库名称";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(321, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtInventID
            // 
            this.txtInventID.Location = new System.Drawing.Point(87, 33);
            this.txtInventID.Name = "txtInventID";
            this.txtInventID.Size = new System.Drawing.Size(228, 21);
            this.txtInventID.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnUserDel);
            this.groupBox2.Controls.Add(this.btnUserMod);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 522);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1280, 82);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(35, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUserDel
            // 
            this.btnUserDel.Location = new System.Drawing.Point(226, 31);
            this.btnUserDel.Name = "btnUserDel";
            this.btnUserDel.Size = new System.Drawing.Size(75, 25);
            this.btnUserDel.TabIndex = 1;
            this.btnUserDel.Text = "删除";
            this.btnUserDel.UseVisualStyleBackColor = true;
            this.btnUserDel.Click += new System.EventHandler(this.btnUserDel_Click);
            // 
            // btnUserMod
            // 
            this.btnUserMod.Location = new System.Drawing.Point(130, 31);
            this.btnUserMod.Name = "btnUserMod";
            this.btnUserMod.Size = new System.Drawing.Size(75, 25);
            this.btnUserMod.TabIndex = 1;
            this.btnUserMod.Text = "修改";
            this.btnUserMod.UseVisualStyleBackColor = true;
            this.btnUserMod.Click += new System.EventHandler(this.btnUserMod_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gdcInfo);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1280, 447);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据集";
            // 
            // gdcInfo
            // 
            this.gdcInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcInfo.Location = new System.Drawing.Point(3, 17);
            this.gdcInfo.MainView = this.gdvInfo;
            this.gdcInfo.Name = "gdcInfo";
            this.gdcInfo.Size = new System.Drawing.Size(1274, 427);
            this.gdcInfo.TabIndex = 0;
            this.gdcInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvInfo});
            // 
            // gdvInfo
            // 
            this.gdvInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gdvInfo.GridControl = this.gdcInfo;
            this.gdvInfo.Name = "gdvInfo";
            this.gdvInfo.OptionsFind.AlwaysVisible = true;
            this.gdvInfo.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "仓库编号";
            this.gridColumn1.FieldName = "store_house_id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "货架号";
            this.gridColumn2.FieldName = "location_no";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // frmLocationNoMange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 604);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLocationNoMange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "库位管理";
            this.Load += new System.EventHandler(this.frmLocationMange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSearchUser;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUserDel;
        private System.Windows.Forms.Button btnUserMod;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtInventID;
        private DevExpress.XtraGrid.GridControl gdcInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvInfo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}