namespace InventoryManagersystem.sys
{
    partial class frmClosing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClosing));
            this.rdbHide = new System.Windows.Forms.RadioButton();
            this.rdbClose = new System.Windows.Forms.RadioButton();
            this.chkRember = new System.Windows.Forms.CheckBox();
            this.btnSure = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbHide
            // 
            this.rdbHide.AutoSize = true;
            this.rdbHide.Location = new System.Drawing.Point(61, 52);
            this.rdbHide.Name = "rdbHide";
            this.rdbHide.Size = new System.Drawing.Size(95, 16);
            this.rdbHide.TabIndex = 0;
            this.rdbHide.TabStop = true;
            this.rdbHide.Text = "隐藏至任务栏";
            this.rdbHide.UseVisualStyleBackColor = true;
            // 
            // rdbClose
            // 
            this.rdbClose.AutoSize = true;
            this.rdbClose.Location = new System.Drawing.Point(207, 52);
            this.rdbClose.Name = "rdbClose";
            this.rdbClose.Size = new System.Drawing.Size(71, 16);
            this.rdbClose.TabIndex = 0;
            this.rdbClose.TabStop = true;
            this.rdbClose.Text = "退出系统";
            this.rdbClose.UseVisualStyleBackColor = true;
            // 
            // chkRember
            // 
            this.chkRember.AutoSize = true;
            this.chkRember.Location = new System.Drawing.Point(74, 90);
            this.chkRember.Name = "chkRember";
            this.chkRember.Size = new System.Drawing.Size(132, 16);
            this.chkRember.TabIndex = 1;
            this.chkRember.Text = "记住选择，不再提示";
            this.chkRember.UseVisualStyleBackColor = true;
            this.chkRember.CheckedChanged += new System.EventHandler(this.chkRember_CheckedChanged);
            // 
            // btnSure
            // 
            this.btnSure.Location = new System.Drawing.Point(131, 127);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(75, 23);
            this.btnSure.TabIndex = 2;
            this.btnSure.Text = "确定";
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(229, 127);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 2;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // frmClosing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 176);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSure);
            this.Controls.Add(this.chkRember);
            this.Controls.Add(this.rdbClose);
            this.Controls.Add(this.rdbHide);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClosing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统退出提示";
            this.Load += new System.EventHandler(this.frmClosing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbHide;
        private System.Windows.Forms.RadioButton rdbClose;
        private System.Windows.Forms.CheckBox chkRember;
        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.Button btnCancle;
    }
}