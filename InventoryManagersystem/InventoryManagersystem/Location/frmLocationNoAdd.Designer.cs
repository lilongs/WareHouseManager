namespace InventoryManagersystem.Location
{
    partial class frmLocationNoAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocationNoAdd));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLocationNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSure = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.combStoreHouse_ID = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combStoreHouse_ID);
            this.groupBox1.Controls.Add(this.txtLocationNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基础信息";
            // 
            // txtLocationNo
            // 
            this.txtLocationNo.Location = new System.Drawing.Point(104, 101);
            this.txtLocationNo.Name = "txtLocationNo";
            this.txtLocationNo.Size = new System.Drawing.Size(237, 21);
            this.txtLocationNo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "货架号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "仓库编号:";
            // 
            // btnSure
            // 
            this.btnSure.Location = new System.Drawing.Point(251, 269);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(75, 25);
            this.btnSure.TabIndex = 0;
            this.btnSure.Text = "确认";
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(358, 270);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "取消";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // combStoreHouse_ID
            // 
            this.combStoreHouse_ID.FormattingEnabled = true;
            this.combStoreHouse_ID.Location = new System.Drawing.Point(104, 59);
            this.combStoreHouse_ID.Name = "combStoreHouse_ID";
            this.combStoreHouse_ID.Size = new System.Drawing.Size(237, 20);
            this.combStoreHouse_ID.TabIndex = 3;
            // 
            // frmLocationNoAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 317);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSure);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLocationNoAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "仓库信息维护";
            this.Load += new System.EventHandler(this.frmLocationNoAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtLocationNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combStoreHouse_ID;
    }
}