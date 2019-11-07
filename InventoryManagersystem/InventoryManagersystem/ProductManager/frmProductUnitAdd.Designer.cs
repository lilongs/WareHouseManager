namespace InventoryManagersystem.ProductManager
{
    partial class frmProductUnitAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductUnitAdd));
            this.lblProductUnitCode = new System.Windows.Forms.Label();
            this.txtBoxProductUnitCode = new System.Windows.Forms.TextBox();
            this.lblProductUnitName = new System.Windows.Forms.Label();
            this.txtBoxProductUnitName = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtBoxRemark = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddProductUnit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProductUnitCode
            // 
            this.lblProductUnitCode.AutoSize = true;
            this.lblProductUnitCode.Location = new System.Drawing.Point(12, 32);
            this.lblProductUnitCode.Name = "lblProductUnitCode";
            this.lblProductUnitCode.Size = new System.Drawing.Size(77, 12);
            this.lblProductUnitCode.TabIndex = 0;
            this.lblProductUnitCode.Text = "计量单位编码";
            // 
            // txtBoxProductUnitCode
            // 
            this.txtBoxProductUnitCode.Location = new System.Drawing.Point(95, 29);
            this.txtBoxProductUnitCode.Name = "txtBoxProductUnitCode";
            this.txtBoxProductUnitCode.ReadOnly = true;
            this.txtBoxProductUnitCode.Size = new System.Drawing.Size(131, 21);
            this.txtBoxProductUnitCode.TabIndex = 1;
            // 
            // lblProductUnitName
            // 
            this.lblProductUnitName.AutoSize = true;
            this.lblProductUnitName.Location = new System.Drawing.Point(247, 32);
            this.lblProductUnitName.Name = "lblProductUnitName";
            this.lblProductUnitName.Size = new System.Drawing.Size(77, 12);
            this.lblProductUnitName.TabIndex = 0;
            this.lblProductUnitName.Text = "计量单位名称";
            // 
            // txtBoxProductUnitName
            // 
            this.txtBoxProductUnitName.Location = new System.Drawing.Point(330, 28);
            this.txtBoxProductUnitName.Name = "txtBoxProductUnitName";
            this.txtBoxProductUnitName.Size = new System.Drawing.Size(61, 21);
            this.txtBoxProductUnitName.TabIndex = 1;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(12, 62);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(53, 12);
            this.lblRemark.TabIndex = 0;
            this.lblRemark.Text = "备    注";
            // 
            // txtBoxRemark
            // 
            this.txtBoxRemark.Location = new System.Drawing.Point(71, 62);
            this.txtBoxRemark.Multiline = true;
            this.txtBoxRemark.Name = "txtBoxRemark";
            this.txtBoxRemark.Size = new System.Drawing.Size(320, 62);
            this.txtBoxRemark.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProductUnitName);
            this.groupBox1.Controls.Add(this.txtBoxRemark);
            this.groupBox1.Controls.Add(this.lblRemark);
            this.groupBox1.Controls.Add(this.lblProductUnitCode);
            this.groupBox1.Controls.Add(this.txtBoxProductUnitCode);
            this.groupBox1.Controls.Add(this.txtBoxProductUnitName);
            this.groupBox1.Location = new System.Drawing.Point(39, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 140);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnAddProductUnit);
            this.groupBox2.Location = new System.Drawing.Point(37, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 72);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(210, 31);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "退出";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddProductUnit
            // 
            this.btnAddProductUnit.Location = new System.Drawing.Point(85, 31);
            this.btnAddProductUnit.Name = "btnAddProductUnit";
            this.btnAddProductUnit.Size = new System.Drawing.Size(75, 23);
            this.btnAddProductUnit.TabIndex = 6;
            this.btnAddProductUnit.Text = "确认";
            this.btnAddProductUnit.UseVisualStyleBackColor = true;
            this.btnAddProductUnit.Click += new System.EventHandler(this.btnAddProductUnit_Click);
            // 
            // frmProductUnitAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 252);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProductUnitAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加计量单位";
            this.Load += new System.EventHandler(this.frmProductUnitAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProductUnitCode;
        private System.Windows.Forms.TextBox txtBoxProductUnitCode;
        private System.Windows.Forms.Label lblProductUnitName;
        private System.Windows.Forms.TextBox txtBoxProductUnitName;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtBoxRemark;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddProductUnit;
    }
}