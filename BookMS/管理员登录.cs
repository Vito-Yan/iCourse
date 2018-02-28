using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace WindowsFormsApplication2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            string User = UserName.Text;
            string Pwd = PassWord.Text;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "server=.;database=booksDB;integrated security=True";
            try
            {
                conn.Open();
                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "select * from Admin where UserName='" + User + "'";
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    string password = reader.GetString(reader.GetOrdinal("PassWord"));
                    if (Pwd == password)
                    {
                        MessageBox.Show("登陆成功！");
                        new Thread(() => Application.Run(new Menu())).Start();
                        this.Close();
                        //this.Hide(); 
                        //Form M = new Management();
                        //M.Show();
                    }
                    else
                    {
                        MessageBox.Show("密码错误！");
                        UserName.Text = " ";
                        PassWord.Text = " ";
                    }
                }
                else
                {
                    MessageBox.Show("用户不存在！");
                    UserName.Text = " ";
                    PassWord.Text = " ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
