﻿namespace InventoryManagersystem
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.textUserName = new System.Windows.Forms.TextBox();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblErr = new System.Windows.Forms.Label();
            this.cmsSLQ = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsSQLset = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cmsSLQ.SuspendLayout();
            this.SuspendLayout();
            // 
            // textUserName
            // 
            this.textUserName.Font = new System.Drawing.Font("宋体", 15F);
            this.textUserName.Location = new System.Drawing.Point(402, 230);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(270, 30);
            this.textUserName.TabIndex = 1;
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Font = new System.Drawing.Font("宋体", 15F);
            this.textBoxPwd.Location = new System.Drawing.Point(403, 282);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.Size = new System.Drawing.Size(269, 30);
            this.textBoxPwd.TabIndex = 2;
            this.textBoxPwd.UseSystemPasswordChar = true;
            this.textBoxPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPwd_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(19)))), ((int)(((byte)(40)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(402, 332);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(132, 44);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "登陆";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.BackColor = System.Drawing.Color.Transparent;
            this.lblErr.ForeColor = System.Drawing.Color.Red;
            this.lblErr.Location = new System.Drawing.Point(400, 392);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(0, 12);
            this.lblErr.TabIndex = 3;
            // 
            // cmsSLQ
            // 
            this.cmsSLQ.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSQLset});
            this.cmsSLQ.Name = "cmsSLQ";
            this.cmsSLQ.Size = new System.Drawing.Size(137, 26);
            // 
            // tsSQLset
            // 
            this.tsSQLset.Name = "tsSQLset";
            this.tsSQLset.Size = new System.Drawing.Size(136, 22);
            this.tsSQLset.Text = "配置数据库";
            this.tsSQLset.Click += new System.EventHandler(this.tsSQLset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(222)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(283, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 14);
            this.label1.TabIndex = 4;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(976, 588);
            this.ContextMenuStrip = this.cmsSLQ;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblErr);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textBoxPwd);
            this.Controls.Add(this.textUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录--欢迎使用仓库管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.cmsSLQ.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.TextBox textBoxPwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblErr;
        private System.Windows.Forms.ContextMenuStrip cmsSLQ;
        private System.Windows.Forms.ToolStripMenuItem tsSQLset;
        private System.Windows.Forms.Label label1;
    }
}