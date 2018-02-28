namespace WindowsFormsApplication2
{
    partial class BookM
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
            this.txtbkID = new System.Windows.Forms.TextBox();
            this.txtbkPrice = new System.Windows.Forms.TextBox();
            this.txtbkPress = new System.Windows.Forms.TextBox();
            this.txtbkAuthor = new System.Windows.Forms.TextBox();
            this.txtbkName = new System.Windows.Forms.TextBox();
            this.BackMenu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbkStatus = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Alter = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "书号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "书名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "作者";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "出版社";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "单价";
            // 
            // txtbkID
            // 
            this.txtbkID.Location = new System.Drawing.Point(34, 41);
            this.txtbkID.Name = "txtbkID";
            this.txtbkID.Size = new System.Drawing.Size(100, 21);
            this.txtbkID.TabIndex = 23;
            // 
            // txtbkPrice
            // 
            this.txtbkPrice.Location = new System.Drawing.Point(34, 197);
            this.txtbkPrice.Name = "txtbkPrice";
            this.txtbkPrice.Size = new System.Drawing.Size(100, 21);
            this.txtbkPrice.TabIndex = 24;
            // 
            // txtbkPress
            // 
            this.txtbkPress.Location = new System.Drawing.Point(34, 158);
            this.txtbkPress.Name = "txtbkPress";
            this.txtbkPress.Size = new System.Drawing.Size(100, 21);
            this.txtbkPress.TabIndex = 25;
            // 
            // txtbkAuthor
            // 
            this.txtbkAuthor.Location = new System.Drawing.Point(34, 119);
            this.txtbkAuthor.Name = "txtbkAuthor";
            this.txtbkAuthor.Size = new System.Drawing.Size(100, 21);
            this.txtbkAuthor.TabIndex = 26;
            // 
            // txtbkName
            // 
            this.txtbkName.Location = new System.Drawing.Point(34, 80);
            this.txtbkName.Name = "txtbkName";
            this.txtbkName.Size = new System.Drawing.Size(100, 21);
            this.txtbkName.TabIndex = 27;
            // 
            // BackMenu
            // 
            this.BackMenu.BackColor = System.Drawing.SystemColors.Control;
            this.BackMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(106)))));
            this.BackMenu.Location = new System.Drawing.Point(34, 287);
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.Size = new System.Drawing.Size(100, 34);
            this.BackMenu.TabIndex = 28;
            this.BackMenu.Text = "返回主菜单";
            this.BackMenu.UseVisualStyleBackColor = false;
            this.BackMenu.Click += new System.EventHandler(this.BackMenu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 12);
            this.label6.TabIndex = 29;
            this.label6.Text = "状态(1:在馆,0:不在馆)";
            // 
            // txtbkStatus
            // 
            this.txtbkStatus.Location = new System.Drawing.Point(34, 236);
            this.txtbkStatus.Name = "txtbkStatus";
            this.txtbkStatus.Size = new System.Drawing.Size(100, 21);
            this.txtbkStatus.TabIndex = 30;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("宋体", 18F);
            this.Add.Location = new System.Drawing.Point(34, 357);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(78, 37);
            this.Add.TabIndex = 31;
            this.Add.Text = "添加";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // dgvBook
            // 
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(179, 26);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowTemplate.Height = 23;
            this.dgvBook.Size = new System.Drawing.Size(437, 295);
            this.dgvBook.TabIndex = 32;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("宋体", 18F);
            this.Search.Location = new System.Drawing.Point(196, 357);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(78, 37);
            this.Search.TabIndex = 33;
            this.Search.Text = "查询";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("宋体", 18F);
            this.Delete.Location = new System.Drawing.Point(359, 357);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(76, 37);
            this.Delete.TabIndex = 34;
            this.Delete.Text = "删除";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Alter
            // 
            this.Alter.Font = new System.Drawing.Font("宋体", 18F);
            this.Alter.Location = new System.Drawing.Point(541, 357);
            this.Alter.Name = "Alter";
            this.Alter.Size = new System.Drawing.Size(75, 37);
            this.Alter.TabIndex = 35;
            this.Alter.Text = "修改";
            this.Alter.UseVisualStyleBackColor = true;
            this.Alter.Click += new System.EventHandler(this.Alter_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // BookM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 416);
            this.Controls.Add(this.Alter);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.txtbkStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BackMenu);
            this.Controls.Add(this.txtbkName);
            this.Controls.Add(this.txtbkAuthor);
            this.Controls.Add(this.txtbkPress);
            this.Controls.Add(this.txtbkPrice);
            this.Controls.Add(this.txtbkID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookM";
            this.Text = "图书管理";
            this.Load += new System.EventHandler(this.BookM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
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
        private System.Windows.Forms.TextBox txtbkID;
        private System.Windows.Forms.TextBox txtbkPrice;
        private System.Windows.Forms.TextBox txtbkPress;
        private System.Windows.Forms.TextBox txtbkAuthor;
        private System.Windows.Forms.TextBox txtbkName;
        private System.Windows.Forms.Button BackMenu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbkStatus;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Alter;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}