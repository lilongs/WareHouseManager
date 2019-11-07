namespace InventoryManagersystem
{
    partial class frmUserMamager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserMamager));
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.btnUserDel = new System.Windows.Forms.Button();
            this.btnUserMod = new System.Windows.Forms.Button();
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.lblSearchUser = new System.Windows.Forms.Label();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.lalPhone = new System.Windows.Forms.Label();
            this.btnReflash = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gdcInfo = new DevExpress.XtraGrid.GridControl();
            this.gdvInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.Location = new System.Drawing.Point(27, 31);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(75, 23);
            this.btnUserAdd.TabIndex = 1;
            this.btnUserAdd.Text = "添加用户";
            this.btnUserAdd.UseVisualStyleBackColor = true;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // btnUserDel
            // 
            this.btnUserDel.Location = new System.Drawing.Point(126, 31);
            this.btnUserDel.Name = "btnUserDel";
            this.btnUserDel.Size = new System.Drawing.Size(75, 23);
            this.btnUserDel.TabIndex = 1;
            this.btnUserDel.Text = "删除用户";
            this.btnUserDel.UseVisualStyleBackColor = true;
            this.btnUserDel.Click += new System.EventHandler(this.btnUserDel_Click);
            // 
            // btnUserMod
            // 
            this.btnUserMod.Location = new System.Drawing.Point(217, 31);
            this.btnUserMod.Name = "btnUserMod";
            this.btnUserMod.Size = new System.Drawing.Size(75, 23);
            this.btnUserMod.TabIndex = 1;
            this.btnUserMod.Text = "修改用户";
            this.btnUserMod.UseVisualStyleBackColor = true;
            this.btnUserMod.Click += new System.EventHandler(this.btnUserMod_Click);
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.Location = new System.Drawing.Point(78, 33);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(150, 21);
            this.txtBoxUser.TabIndex = 2;
            // 
            // lblSearchUser
            // 
            this.lblSearchUser.AutoSize = true;
            this.lblSearchUser.Location = new System.Drawing.Point(28, 38);
            this.lblSearchUser.Name = "lblSearchUser";
            this.lblSearchUser.Size = new System.Drawing.Size(47, 12);
            this.lblSearchUser.TabIndex = 3;
            this.lblSearchUser.Text = "用户名:";
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Location = new System.Drawing.Point(443, 34);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(75, 23);
            this.btnSearchUser.TabIndex = 1;
            this.btnSearchUser.Text = "搜索";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(296, 34);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(128, 21);
            this.txtBoxPhone.TabIndex = 2;
            // 
            // lalPhone
            // 
            this.lalPhone.AutoSize = true;
            this.lalPhone.Location = new System.Drawing.Point(244, 38);
            this.lalPhone.Name = "lalPhone";
            this.lalPhone.Size = new System.Drawing.Size(47, 12);
            this.lalPhone.TabIndex = 3;
            this.lalPhone.Text = "手机号:";
            // 
            // btnReflash
            // 
            this.btnReflash.Location = new System.Drawing.Point(314, 31);
            this.btnReflash.Name = "btnReflash";
            this.btnReflash.Size = new System.Drawing.Size(75, 23);
            this.btnReflash.TabIndex = 1;
            this.btnReflash.Text = "数据刷新";
            this.btnReflash.UseVisualStyleBackColor = true;
            this.btnReflash.Click += new System.EventHandler(this.btnReflash_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSearchUser);
            this.groupBox1.Controls.Add(this.lalPhone);
            this.groupBox1.Controls.Add(this.btnSearchUser);
            this.groupBox1.Controls.Add(this.txtBoxUser);
            this.groupBox1.Controls.Add(this.txtBoxPhone);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1097, 69);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReflash);
            this.groupBox2.Controls.Add(this.btnUserAdd);
            this.groupBox2.Controls.Add(this.btnUserDel);
            this.groupBox2.Controls.Add(this.btnUserMod);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 633);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1097, 81);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gdcInfo);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1097, 564);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据";
            // 
            // gdcInfo
            // 
            this.gdcInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcInfo.Location = new System.Drawing.Point(3, 17);
            this.gdcInfo.MainView = this.gdvInfo;
            this.gdcInfo.Name = "gdcInfo";
            this.gdcInfo.Size = new System.Drawing.Size(1091, 544);
            this.gdcInfo.TabIndex = 1;
            this.gdcInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvInfo});
            // 
            // gdvInfo
            // 
            this.gdvInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn7,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gdvInfo.GridControl = this.gdcInfo;
            this.gdvInfo.Name = "gdvInfo";
            this.gdvInfo.OptionsFind.AlwaysVisible = true;
            this.gdvInfo.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "用户名";
            this.gridColumn1.FieldName = "username";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "电话";
            this.gridColumn2.FieldName = "telephone";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "邮件";
            this.gridColumn3.FieldName = "email";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "住址";
            this.gridColumn4.FieldName = "address";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "创建时间";
            this.gridColumn5.FieldName = "createtime";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "用户角色";
            this.gridColumn6.FieldName = "RoleName";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "真实姓名";
            this.gridColumn7.FieldName = "realname";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            // 
            // frmUserMamager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 714);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUserMamager";
            this.Text = "用户管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUserMamager_FormClosing);
            this.Load += new System.EventHandler(this.frmUserMamager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.Button btnUserDel;
        private System.Windows.Forms.Button btnUserMod;
        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.Label lblSearchUser;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.Label lalPhone;
        private System.Windows.Forms.Button btnReflash;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.GridControl gdcInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvInfo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    }
}