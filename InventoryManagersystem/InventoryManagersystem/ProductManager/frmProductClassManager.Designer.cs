﻿namespace InventoryManagersystem.ProductManager
{
    partial class frmProductClassManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductClassManager));
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxProductName = new System.Windows.Forms.TextBox();
            this.brnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trvPrdouctClass = new System.Windows.Forms.TreeView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "商品类别:";
            // 
            // txtBoxProductName
            // 
            this.txtBoxProductName.Location = new System.Drawing.Point(89, 24);
            this.txtBoxProductName.Name = "txtBoxProductName";
            this.txtBoxProductName.Size = new System.Drawing.Size(169, 21);
            this.txtBoxProductName.TabIndex = 1;
            // 
            // brnSearch
            // 
            this.brnSearch.Image = ((System.Drawing.Image)(resources.GetObject("brnSearch.Image")));
            this.brnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnSearch.Location = new System.Drawing.Point(292, 22);
            this.brnSearch.Name = "brnSearch";
            this.brnSearch.Size = new System.Drawing.Size(61, 23);
            this.brnSearch.TabIndex = 2;
            this.brnSearch.Text = "查询";
            this.brnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.brnSearch.UseVisualStyleBackColor = true;
            this.brnSearch.Click += new System.EventHandler(this.brnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.brnSearch);
            this.groupBox1.Controls.Add(this.txtBoxProductName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1121, 57);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(43, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+ 增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnModify);
            this.groupBox3.Controls.Add(this.btnDel);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 492);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1121, 77);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "操作";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(154, 32);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 25);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(266, 32);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 25);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "- 删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1121, 435);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trvPrdouctClass);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 415);
            this.panel1.TabIndex = 1;
            // 
            // trvPrdouctClass
            // 
            this.trvPrdouctClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvPrdouctClass.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trvPrdouctClass.Location = new System.Drawing.Point(0, 0);
            this.trvPrdouctClass.Name = "trvPrdouctClass";
            this.trvPrdouctClass.Size = new System.Drawing.Size(1115, 415);
            this.trvPrdouctClass.TabIndex = 0;
            // 
            // frmProductClassManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 569);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductClassManager";
            this.Text = "商品分类管理";
            this.Load += new System.EventHandler(this.frmProductClassManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxProductName;
        private System.Windows.Forms.Button brnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView trvPrdouctClass;
    }
}