namespace InventoryManagersystem.OfficeSupplies
{
    partial class frmSuppliesUpdate
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
            this.txtLocation = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.combStatus = new System.Windows.Forms.ComboBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtKeeper = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnSure = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtRemark = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeeper.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(122, 57);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(175, 20);
            this.txtLocation.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(46, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "流转位置：";
            // 
            // combStatus
            // 
            this.combStatus.FormattingEnabled = true;
            this.combStatus.Items.AddRange(new object[] {
            "使用中",
            "闲置",
            "已出售"});
            this.combStatus.Location = new System.Drawing.Point(122, 106);
            this.combStatus.Name = "combStatus";
            this.combStatus.Size = new System.Drawing.Size(175, 20);
            this.combStatus.TabIndex = 30;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(46, 110);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 14);
            this.labelControl8.TabIndex = 29;
            this.labelControl8.Text = "使用状态：";
            // 
            // txtKeeper
            // 
            this.txtKeeper.Location = new System.Drawing.Point(122, 155);
            this.txtKeeper.Name = "txtKeeper";
            this.txtKeeper.Size = new System.Drawing.Size(175, 20);
            this.txtKeeper.TabIndex = 32;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(29, 164);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(77, 14);
            this.labelControl7.TabIndex = 31;
            this.labelControl7.Text = "保管/领取人：";
            // 
            // btnSure
            // 
            this.btnSure.Location = new System.Drawing.Point(85, 299);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(75, 23);
            this.btnSure.TabIndex = 33;
            this.btnSure.Text = "确认";
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(222, 299);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(122, 204);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Properties.AutoHeight = false;
            this.txtRemark.Size = new System.Drawing.Size(175, 71);
            this.txtRemark.TabIndex = 36;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(70, 208);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(36, 14);
            this.labelControl10.TabIndex = 35;
            this.labelControl10.Text = "备注：";
            // 
            // frmSuppliesUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 343);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.btnSure);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtKeeper);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.combStatus);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.labelControl2);
            this.Name = "frmSuppliesUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "办公用品流转";
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeeper.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtLocation;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox combStatus;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtKeeper;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnSure;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.TextEdit txtRemark;
        private DevExpress.XtraEditors.LabelControl labelControl10;
    }
}