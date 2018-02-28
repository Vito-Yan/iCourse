namespace WindowsFormsApplication2
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.简易图书管理系统 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.PassWord = new System.Windows.Forms.TextBox();
            this.SignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 简易图书管理系统
            // 
            this.简易图书管理系统.AutoSize = true;
            this.简易图书管理系统.Dock = System.Windows.Forms.DockStyle.Fill;
            this.简易图书管理系统.Font = new System.Drawing.Font("宋体", 28F);
            this.简易图书管理系统.Location = new System.Drawing.Point(0, 0);
            this.简易图书管理系统.Name = "简易图书管理系统";
            this.简易图书管理系统.Size = new System.Drawing.Size(321, 38);
            this.简易图书管理系统.TabIndex = 0;
            this.简易图书管理系统.Text = "简易图书管理系统";
            this.简易图书管理系统.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 0;
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F);
            this.label1.Location = new System.Drawing.Point(124, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "账号：";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 18F);
            this.label3.Location = new System.Drawing.Point(124, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码：";
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("宋体", 18F);
            this.UserName.Location = new System.Drawing.Point(212, 121);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(155, 35);
            this.UserName.TabIndex = 3;
            // 
            // PassWord
            // 
            this.PassWord.Font = new System.Drawing.Font("宋体", 18F);
            this.PassWord.Location = new System.Drawing.Point(212, 198);
            this.PassWord.Name = "PassWord";
            this.PassWord.PasswordChar = '*';
            this.PassWord.Size = new System.Drawing.Size(155, 35);
            this.PassWord.TabIndex = 4;
            this.PassWord.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // SignIn
            // 
            this.SignIn.Font = new System.Drawing.Font("宋体", 18F);
            this.SignIn.Location = new System.Drawing.Point(128, 317);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(75, 34);
            this.SignIn.TabIndex = 5;
            this.SignIn.Text = "登录";
            this.SignIn.UseVisualStyleBackColor = true;
            this.SignIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 412);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.简易图书管理系统);
            this.Name = "Login";
            this.Text = "管理员登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 简易图书管理系统;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox PassWord;
        private System.Windows.Forms.Button SignIn;
    }
}

