namespace WindowsFormsApplication2
{
    partial class ReaderTypeM
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
            this.Search = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Alter = new System.Windows.Forms.Button();
            this.BackMenu = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtrdType = new System.Windows.Forms.TextBox();
            this.txtcanLendDay = new System.Windows.Forms.TextBox();
            this.txtcanLendQty = new System.Windows.Forms.TextBox();
            this.txtrdTypeName = new System.Windows.Forms.TextBox();
            this.booksDBDataSet = new WindowsFormsApplication2.booksDBDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("宋体", 18F);
            this.Search.Location = new System.Drawing.Point(184, 330);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(78, 37);
            this.Search.TabIndex = 12;
            this.Search.Text = "查询";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("宋体", 18F);
            this.Delete.Location = new System.Drawing.Point(363, 330);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(76, 37);
            this.Delete.TabIndex = 13;
            this.Delete.Text = "删除";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Alter
            // 
            this.Alter.Font = new System.Drawing.Font("宋体", 18F);
            this.Alter.Location = new System.Drawing.Point(535, 330);
            this.Alter.Name = "Alter";
            this.Alter.Size = new System.Drawing.Size(75, 37);
            this.Alter.TabIndex = 14;
            this.Alter.Text = "修改";
            this.Alter.UseVisualStyleBackColor = true;
            // 
            // BackMenu
            // 
            this.BackMenu.BackColor = System.Drawing.SystemColors.Control;
            this.BackMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(106)))));
            this.BackMenu.Location = new System.Drawing.Point(26, 258);
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.Size = new System.Drawing.Size(100, 34);
            this.BackMenu.TabIndex = 15;
            this.BackMenu.Text = "返回主菜单";
            this.BackMenu.UseVisualStyleBackColor = false;
            this.BackMenu.Click += new System.EventHandler(this.BackMenu_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.booksDBDataSet;
            this.bindingSource1.Position = 0;
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // dgvBook
            // 
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(173, 20);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowTemplate.Height = 23;
            this.dgvBook.Size = new System.Drawing.Size(437, 272);
            this.dgvBook.TabIndex = 16;
            this.dgvBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("宋体", 18F);
            this.Add.Location = new System.Drawing.Point(26, 330);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(78, 37);
            this.Add.TabIndex = 17;
            this.Add.Text = "添加";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "类别号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "类别名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "可借书数量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "可借书天数";
            // 
            // txtrdType
            // 
            this.txtrdType.Location = new System.Drawing.Point(26, 35);
            this.txtrdType.Name = "txtrdType";
            this.txtrdType.Size = new System.Drawing.Size(100, 21);
            this.txtrdType.TabIndex = 22;
            // 
            // txtcanLendDay
            // 
            this.txtcanLendDay.Location = new System.Drawing.Point(26, 209);
            this.txtcanLendDay.Name = "txtcanLendDay";
            this.txtcanLendDay.Size = new System.Drawing.Size(100, 21);
            this.txtcanLendDay.TabIndex = 23;
            // 
            // txtcanLendQty
            // 
            this.txtcanLendQty.Location = new System.Drawing.Point(26, 155);
            this.txtcanLendQty.Name = "txtcanLendQty";
            this.txtcanLendQty.Size = new System.Drawing.Size(100, 21);
            this.txtcanLendQty.TabIndex = 24;
            // 
            // txtrdTypeName
            // 
            this.txtrdTypeName.Location = new System.Drawing.Point(26, 95);
            this.txtrdTypeName.Name = "txtrdTypeName";
            this.txtrdTypeName.Size = new System.Drawing.Size(100, 21);
            this.txtrdTypeName.TabIndex = 25;
            // 
            // booksDBDataSet
            // 
            this.booksDBDataSet.DataSetName = "booksDBDataSet";
            this.booksDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReaderTypeM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 403);
            this.Controls.Add(this.txtrdTypeName);
            this.Controls.Add(this.txtcanLendQty);
            this.Controls.Add(this.txtcanLendDay);
            this.Controls.Add(this.txtrdType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.BackMenu);
            this.Controls.Add(this.Alter);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Search);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.Name = "ReaderTypeM";
            this.Text = " 读者类别管理";
            this.Load += new System.EventHandler(this.ReaderTypeM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Alter;
        private System.Windows.Forms.Button BackMenu;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtrdType;
        private System.Windows.Forms.TextBox txtcanLendDay;
        private System.Windows.Forms.TextBox txtcanLendQty;
        private System.Windows.Forms.TextBox txtrdTypeName;
        private booksDBDataSet booksDBDataSet;
    }
}