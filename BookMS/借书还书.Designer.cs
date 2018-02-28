namespace WindowsFormsApplication2
{
    partial class BorrowAndReturn
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
            this.txtrdID = new System.Windows.Forms.TextBox();
            this.txtbkID = new System.Windows.Forms.TextBox();
            this.BorrowBook = new System.Windows.Forms.Button();
            this.ReturnBook = new System.Windows.Forms.Button();
            this.Borrow = new System.Windows.Forms.Button();
            this.BackMenu = new System.Windows.Forms.Button();
            this.dgvBorrow = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "读者编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "书号";
            // 
            // txtrdID
            // 
            this.txtrdID.Location = new System.Drawing.Point(43, 50);
            this.txtrdID.Name = "txtrdID";
            this.txtrdID.Size = new System.Drawing.Size(100, 21);
            this.txtrdID.TabIndex = 2;
            // 
            // txtbkID
            // 
            this.txtbkID.Location = new System.Drawing.Point(43, 98);
            this.txtbkID.Name = "txtbkID";
            this.txtbkID.Size = new System.Drawing.Size(100, 21);
            this.txtbkID.TabIndex = 3;
            // 
            // BorrowBook
            // 
            this.BorrowBook.Font = new System.Drawing.Font("宋体", 9F);
            this.BorrowBook.Location = new System.Drawing.Point(43, 155);
            this.BorrowBook.Name = "BorrowBook";
            this.BorrowBook.Size = new System.Drawing.Size(100, 39);
            this.BorrowBook.TabIndex = 4;
            this.BorrowBook.Text = "借书";
            this.BorrowBook.UseVisualStyleBackColor = true;
            this.BorrowBook.Click += new System.EventHandler(this.BorrowBook_Click);
            // 
            // ReturnBook
            // 
            this.ReturnBook.Location = new System.Drawing.Point(43, 233);
            this.ReturnBook.Name = "ReturnBook";
            this.ReturnBook.Size = new System.Drawing.Size(100, 39);
            this.ReturnBook.TabIndex = 5;
            this.ReturnBook.Text = "还书";
            this.ReturnBook.UseVisualStyleBackColor = true;
            this.ReturnBook.Click += new System.EventHandler(this.ReturnBook_Click);
            // 
            // Borrow
            // 
            this.Borrow.BackColor = System.Drawing.SystemColors.Control;
            this.Borrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(106)))));
            this.Borrow.Location = new System.Drawing.Point(227, 275);
            this.Borrow.Name = "Borrow";
            this.Borrow.Size = new System.Drawing.Size(100, 34);
            this.Borrow.TabIndex = 30;
            this.Borrow.Text = "借阅情况";
            this.Borrow.UseVisualStyleBackColor = false;
            this.Borrow.Click += new System.EventHandler(this.Borrow_Click);
            // 
            // BackMenu
            // 
            this.BackMenu.BackColor = System.Drawing.SystemColors.Control;
            this.BackMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(106)))));
            this.BackMenu.Location = new System.Drawing.Point(453, 275);
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.Size = new System.Drawing.Size(100, 34);
            this.BackMenu.TabIndex = 31;
            this.BackMenu.Text = "返回主菜单";
            this.BackMenu.UseVisualStyleBackColor = false;
            this.BackMenu.Click += new System.EventHandler(this.BackMenu_Click);
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrow.Location = new System.Drawing.Point(168, 35);
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.RowTemplate.Height = 23;
            this.dgvBorrow.Size = new System.Drawing.Size(418, 181);
            this.dgvBorrow.TabIndex = 32;
            // 
            // BorrowAndReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 361);
            this.Controls.Add(this.dgvBorrow);
            this.Controls.Add(this.BackMenu);
            this.Controls.Add(this.Borrow);
            this.Controls.Add(this.ReturnBook);
            this.Controls.Add(this.BorrowBook);
            this.Controls.Add(this.txtbkID);
            this.Controls.Add(this.txtrdID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BorrowAndReturn";
            this.Text = "借书还书";
            this.Load += new System.EventHandler(this.BorrowAndReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtrdID;
        private System.Windows.Forms.TextBox txtbkID;
        private System.Windows.Forms.Button BorrowBook;
        private System.Windows.Forms.Button ReturnBook;
        private System.Windows.Forms.Button Borrow;
        private System.Windows.Forms.Button BackMenu;
        private System.Windows.Forms.DataGridView dgvBorrow;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}