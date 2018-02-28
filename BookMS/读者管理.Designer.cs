namespace WindowsFormsApplication2
{
    partial class ReaderM
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtrdID = new System.Windows.Forms.TextBox();
            this.txtrdType = new System.Windows.Forms.TextBox();
            this.txtrdQQ = new System.Windows.Forms.TextBox();
            this.txtrdDept = new System.Windows.Forms.TextBox();
            this.txtrdName = new System.Windows.Forms.TextBox();
            this.txtrdBorrowQty = new System.Windows.Forms.TextBox();
            this.BackMenu = new System.Windows.Forms.Button();
            this.dgvReader = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Alter = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "类别号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "姓名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "单位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "QQ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "已借书数量";
            // 
            // txtrdID
            // 
            this.txtrdID.Location = new System.Drawing.Point(39, 46);
            this.txtrdID.Name = "txtrdID";
            this.txtrdID.Size = new System.Drawing.Size(100, 21);
            this.txtrdID.TabIndex = 6;
            // 
            // txtrdType
            // 
            this.txtrdType.Location = new System.Drawing.Point(39, 85);
            this.txtrdType.Name = "txtrdType";
            this.txtrdType.Size = new System.Drawing.Size(100, 21);
            this.txtrdType.TabIndex = 7;
            // 
            // txtrdQQ
            // 
            this.txtrdQQ.Location = new System.Drawing.Point(39, 202);
            this.txtrdQQ.Name = "txtrdQQ";
            this.txtrdQQ.Size = new System.Drawing.Size(100, 21);
            this.txtrdQQ.TabIndex = 8;
            // 
            // txtrdDept
            // 
            this.txtrdDept.Location = new System.Drawing.Point(39, 163);
            this.txtrdDept.Name = "txtrdDept";
            this.txtrdDept.Size = new System.Drawing.Size(100, 21);
            this.txtrdDept.TabIndex = 9;
            // 
            // txtrdName
            // 
            this.txtrdName.Location = new System.Drawing.Point(39, 124);
            this.txtrdName.Name = "txtrdName";
            this.txtrdName.Size = new System.Drawing.Size(100, 21);
            this.txtrdName.TabIndex = 10;
            // 
            // txtrdBorrowQty
            // 
            this.txtrdBorrowQty.Location = new System.Drawing.Point(39, 241);
            this.txtrdBorrowQty.Name = "txtrdBorrowQty";
            this.txtrdBorrowQty.Size = new System.Drawing.Size(100, 21);
            this.txtrdBorrowQty.TabIndex = 11;
            // 
            // BackMenu
            // 
            this.BackMenu.BackColor = System.Drawing.SystemColors.Control;
            this.BackMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(106)))));
            this.BackMenu.Location = new System.Drawing.Point(39, 292);
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.Size = new System.Drawing.Size(100, 34);
            this.BackMenu.TabIndex = 29;
            this.BackMenu.Text = "返回主菜单";
            this.BackMenu.UseVisualStyleBackColor = false;
            this.BackMenu.Click += new System.EventHandler(this.BackMenu_Click);
            // 
            // dgvReader
            // 
            this.dgvReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReader.Location = new System.Drawing.Point(184, 31);
            this.dgvReader.Name = "dgvReader";
            this.dgvReader.RowTemplate.Height = 23;
            this.dgvReader.Size = new System.Drawing.Size(437, 295);
            this.dgvReader.TabIndex = 33;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("宋体", 18F);
            this.Add.Location = new System.Drawing.Point(39, 349);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(78, 37);
            this.Add.TabIndex = 34;
            this.Add.Text = "添加";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("宋体", 18F);
            this.Search.Location = new System.Drawing.Point(210, 349);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(78, 37);
            this.Search.TabIndex = 35;
            this.Search.Text = "查询";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("宋体", 18F);
            this.Delete.Location = new System.Drawing.Point(377, 349);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(76, 37);
            this.Delete.TabIndex = 36;
            this.Delete.Text = "删除";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Alter
            // 
            this.Alter.Font = new System.Drawing.Font("宋体", 18F);
            this.Alter.Location = new System.Drawing.Point(546, 349);
            this.Alter.Name = "Alter";
            this.Alter.Size = new System.Drawing.Size(75, 37);
            this.Alter.TabIndex = 37;
            this.Alter.Text = "修改";
            this.Alter.UseVisualStyleBackColor = true;
            this.Alter.Click += new System.EventHandler(this.Alter_Click);
            // 
            // ReaderM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 420);
            this.Controls.Add(this.Alter);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dgvReader);
            this.Controls.Add(this.BackMenu);
            this.Controls.Add(this.txtrdBorrowQty);
            this.Controls.Add(this.txtrdName);
            this.Controls.Add(this.txtrdDept);
            this.Controls.Add(this.txtrdQQ);
            this.Controls.Add(this.txtrdType);
            this.Controls.Add(this.txtrdID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReaderM";
            this.Text = "读者管理";
            this.Load += new System.EventHandler(this.ReaderM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtrdID;
        private System.Windows.Forms.TextBox txtrdType;
        private System.Windows.Forms.TextBox txtrdQQ;
        private System.Windows.Forms.TextBox txtrdDept;
        private System.Windows.Forms.TextBox txtrdName;
        private System.Windows.Forms.TextBox txtrdBorrowQty;
        private System.Windows.Forms.Button BackMenu;
        private System.Windows.Forms.DataGridView dgvReader;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Alter;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}