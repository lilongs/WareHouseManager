namespace InventoryManagersystem.sys
{
    partial class frmRoleInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoleInfo));
            this.gdpInfo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRoleID = new System.Windows.Forms.TextBox();
            this.btnSure = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.gdpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gdpInfo
            // 
            this.gdpInfo.Controls.Add(this.label3);
            this.gdpInfo.Controls.Add(this.txtRemark);
            this.gdpInfo.Controls.Add(this.txtRoleName);
            this.gdpInfo.Controls.Add(this.label2);
            this.gdpInfo.Controls.Add(this.label1);
            this.gdpInfo.Controls.Add(this.txtRoleID);
            this.gdpInfo.Location = new System.Drawing.Point(43, 23);
            this.gdpInfo.Name = "gdpInfo";
            this.gdpInfo.Size = new System.Drawing.Size(434, 233);
            this.gdpInfo.TabIndex = 0;
            this.gdpInfo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "角色描述:";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(110, 119);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(301, 79);
            this.txtRemark.TabIndex = 7;
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(110, 79);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(301, 21);
            this.txtRoleName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "角色名称:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "权限编号:";
            // 
            // txtRoleID
            // 
            this.txtRoleID.Location = new System.Drawing.Point(110, 35);
            this.txtRoleID.Name = "txtRoleID";
            this.txtRoleID.ReadOnly = true;
            this.txtRoleID.Size = new System.Drawing.Size(172, 21);
            this.txtRoleID.TabIndex = 3;
            // 
            // btnSure
            // 
            this.btnSure.Location = new System.Drawing.Point(292, 284);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(75, 23);
            this.btnSure.TabIndex = 1;
            this.btnSure.Text = "确定";
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(402, 284);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 1;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // frmRoleInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 330);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSure);
            this.Controls.Add(this.gdpInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRoleInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "角色信息管理";
            this.Load += new System.EventHandler(this.frmRoleInfo_Load);
            this.gdpInfo.ResumeLayout(false);
            this.gdpInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gdpInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRoleID;
        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.Button btnCancle;
    }
}