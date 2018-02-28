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
    public partial class ReaderTypeM : Form
    {
        public ReaderTypeM()
        {
            InitializeComponent();
        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            new Menu().Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=.;database=booksDB;integrated security=True");
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "insert into ReaderType values(@rdType,@rdTypeName,@canLendQty,@canLendDay)";
            comm.Parameters.AddWithValue("@rdType", txtrdType.Text);
            comm.Parameters.AddWithValue("@rdTypeName", txtrdTypeName.Text);
            comm.Parameters.AddWithValue("@canLendQty", txtcanLendQty.Text);
            comm.Parameters.AddWithValue("@canLendDay", txtcanLendDay.Text);
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
            DataBind();
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
                comm.CommandText = "delete from ReaderType where rdType = @rdType";
                comm.Parameters.AddWithValue("@rdType", txtrdType.Text);
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
            comm.CommandText = "update ReaderType set rdType=@rdType,rdTypeName=@rdTypeName,canLendQty=@canLendQty,canLendDay=@canLendDay where rdType=@rdType";
            comm.Parameters.AddWithValue("@rdType", txtrdType.Text);
            comm.Parameters.AddWithValue("@rdTypeName", txtrdTypeName.Text);
            comm.Parameters.AddWithValue("@canLendQty", txtcanLendQty.Text);
            comm.Parameters.AddWithValue("@canLendDay", txtcanLendDay.Text);
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
            comm.CommandText = "select rdType 类别号,rdTypeName 类别名称,canLendQty 可借数量,canLendDay 可借天数 from ReaderType";
            SqlDataAdapter sda = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgvBook.DataSource = ds.Tables[0];

            txtrdType.DataBindings.Clear();
            txtrdTypeName.DataBindings.Clear();
            txtcanLendQty.DataBindings.Clear();
            txtcanLendDay.DataBindings.Clear();

            txtrdType.DataBindings.Add("Text", ds.Tables[0], "类别号");
            txtrdTypeName.DataBindings.Add("Text", ds.Tables[0], "类别名称");
            txtcanLendQty.DataBindings.Add("Text", ds.Tables[0], "可借数量");
            txtcanLendDay.DataBindings.Add("Text", ds.Tables[0], "可借天数");
            conn.Close();
        }

        private void ReaderTypeM_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

    }
}
