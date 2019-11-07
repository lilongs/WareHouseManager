namespace InventoryManagersystem.sys
{
    partial class frmModuleInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnResh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gdcInfo = new DevExpress.XtraTreeList.TreeList();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnResh);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 531);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 74);
            this.panel1.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(192, 18);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 36);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnResh
            // 
            this.btnResh.Location = new System.Drawing.Point(336, 18);
            this.btnResh.Name = "btnResh";
            this.btnResh.Size = new System.Drawing.Size(100, 36);
            this.btnResh.TabIndex = 1;
            this.btnResh.Text = "刷新";
            this.btnResh.UseVisualStyleBackColor = true;
            this.btnResh.Click += new System.EventHandler(this.btnResh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(40, 18);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 36);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gdcInfo
            // 
            this.gdcInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcInfo.Location = new System.Drawing.Point(0, 0);
            this.gdcInfo.Name = "gdcInfo";
            this.gdcInfo.Size = new System.Drawing.Size(876, 531);
            this.gdcInfo.TabIndex = 9;
            // 
            // frmModuleInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 605);
            this.Controls.Add(this.gdcInfo);
            this.Controls.Add(this.panel1);
            this.Name = "frmModuleInfo";
            this.Text = "系统模块管理";
            this.Load += new System.EventHandler(this.frmModuleInfo_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnResh;
        private System.Windows.Forms.Button btnAdd;
        private DevExpress.XtraTreeList.TreeList gdcInfo;
    }
}