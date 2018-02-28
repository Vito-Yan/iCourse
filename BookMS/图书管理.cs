using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class BookM : Form
    {
        public BookM()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=.;database=booksDB;integrated security=True");
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "insert into Book values(@bkID,@bkName,@bkAuthor,@bkPress,@bkPrice,@bkStatus)";
            comm.Parameters.AddWithValue("@bkID", txtbkID.Text);
            comm.Parameters.AddWithValue("@bkName", txtbkName.Text);
            comm.Parameters.AddWithValue("@bkAuthor", txtbkAuthor.Text);
            comm.Parameters.AddWithValue("@bkPress", txtbkPress.Text);
            comm.Parameters.AddWithValue("@bkPrice", txtbkPrice.Text);
            comm.Parameters.AddWithValue("@bkStatus", txtbkStatus.Text);
            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("插入成功！");
                DataBind();
            }
            catch (Exception ex)
            {

                MessageBox.Show("插入失败！" + ex.Message);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=.;database=booksDB;integrated security=True");
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "select bkID 书号,bkName 书名,bkAuthor 作者,bkPress 出版社,bkPrice 单价,bkStatus 状态 from Book where bkName like + @bkName + '%'  ";  
            comm.Parameters.AddWithValue("@bkName", txtbkName.Text);
            SqlDataAdapter sda = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgvBook.DataSource = ds.Tables[0];
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要删除吗?", "确定", messButton);
            if (dr == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection("server=.;database=booksDB;integrated security=True");
                conn.Open();
                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "delete from Book where bkID = @bkID";
                comm.Parameters.AddWithValue("@bkID", txtbkID.Text);
                try
                {
                    comm.ExecuteNonQuery();
                    MessageBox.Show("删除成功！");
                    DataBind();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("删除失败！" + ex.Message);
                }
            }
        }

        private void Alter_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=.;database=booksDB;integrated security=True");
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "update Book set bkID=@bkID,bkName=@bkName,bkAuthor=@bkAuthor,bkPress=@bkPress,bkPrice=@bkPrice,bkStatus=@bkStatus where bkID=@bkID";
            comm.Parameters.AddWithValue("@bkID", txtbkID.Text);
            comm.Parameters.AddWithValue("@bkName", txtbkName.Text);
            comm.Parameters.AddWithValue("@bkAuthor", txtbkAuthor.Text);
            comm.Parameters.AddWithValue("@bkPress", txtbkPress.Text);
            comm.Parameters.AddWithValue("@bkPrice", txtbkPrice.Text);
            comm.Parameters.AddWithValue("@bkStatus", txtbkStatus.Text);
            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("更新成功！");
                DataBind();
            }
            catch (Exception ex)
            {

                MessageBox.Show("更新失败！" + ex.Message);
            }
        }

        private void DataBind()
        { 
            SqlConnection conn = new SqlConnection("server=.;database=booksDB;integrated security=True");
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "select bkID 书号,bkName 书名,bkAuthor 作者,bkPress 出版社,bkPrice 单价,bkStatus 状态 from Book";
            SqlDataAdapter sda = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgvBook.DataSource = ds.Tables[0];

            txtbkID.DataBindings.Clear();
            txtbkName.DataBindings.Clear();
            txtbkAuthor.DataBindings.Clear();
            txtbkPress.DataBindings.Clear();
            txtbkPrice.DataBindings.Clear();
            txtbkStatus.DataBindings.Clear();

            txtbkID.DataBindings.Add("Text", ds.Tables[0], "书号");
            txtbkName.DataBindings.Add("Text", ds.Tables[0], "书名");
            txtbkAuthor.DataBindings.Add("Text", ds.Tables[0], "作者");
            txtbkPress.DataBindings.Add("Text", ds.Tables[0], "出版社");
            txtbkPrice.DataBindings.Add("Text",ds.Tables[0],"单价");
            txtbkStatus.DataBindings.Add("Text",ds.Tables[0],"状态");
            conn.Close();
        }
        private void BookM_Load(object sender, EventArgs e)
        {
            DataBind();
        }
    }
}
