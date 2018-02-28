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
    public partial class ReaderM : Form
    {
        public ReaderM()
        {
            InitializeComponent();
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
            comm.CommandText = "insert into Reader values(@rdID,@rdType,@rdName,@rdDept,@rdQQ,@rdBorrowQty)";
            comm.Parameters.AddWithValue("@rdID", txtrdID.Text);
            comm.Parameters.AddWithValue("@rdType", txtrdType.Text);
            comm.Parameters.AddWithValue("@rdName", txtrdName.Text);
            comm.Parameters.AddWithValue("@rdDept", txtrdDept.Text);
            comm.Parameters.AddWithValue("@rdQQ", txtrdQQ.Text);
            comm.Parameters.AddWithValue("@rdBorrowQty", txtrdBorrowQty.Text);
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
                comm.CommandText = "delete from Reader where rdID = @rdID";
                comm.Parameters.AddWithValue("@rdID", txtrdID.Text);
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
            comm.CommandText = "update Reader set rdID=@rdID,rdType=@rdType,rdName=@rdName,rdDept=@rdDept,rdQQ=@rdQQ,rdBorrowQty=@rdBorrowQty where rdID=@rdID";
            comm.Parameters.AddWithValue("@rdID", txtrdID.Text);
            comm.Parameters.AddWithValue("@rdType", txtrdType .Text);
            comm.Parameters.AddWithValue("@rdName", txtrdName.Text);
            comm.Parameters.AddWithValue("@rdDept", txtrdDept.Text);
            comm.Parameters.AddWithValue("@rdQQ", txtrdQQ.Text);
            comm.Parameters.AddWithValue("@rdBorrowQty",txtrdBorrowQty.Text);
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
            comm.CommandText = "select rdID 读者编号,rdType 读者类别号,rdName 读者姓名,rdDept 读者单位,rdQQ 读者QQ,rdBorrowQty 已借书数量 from Reader";
            SqlDataAdapter sda = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgvReader.DataSource = ds.Tables[0];

            txtrdID.DataBindings.Clear();
            txtrdType.DataBindings.Clear();
            txtrdName.DataBindings.Clear();
            txtrdDept.DataBindings.Clear();
            txtrdQQ.DataBindings.Clear();
            txtrdBorrowQty.DataBindings.Clear();

            txtrdID.DataBindings.Add("Text", ds.Tables[0], "读者编号");
            txtrdType.DataBindings.Add("Text", ds.Tables[0], "读者类别号");
            txtrdName.DataBindings.Add("Text", ds.Tables[0], "读者姓名");
            txtrdDept.DataBindings.Add("Text", ds.Tables[0], "读者单位");
            txtrdQQ.DataBindings.Add("Text", ds.Tables[0], "读者QQ");
            txtrdBorrowQty.DataBindings.Add("Text", ds.Tables[0], "已借书数量");
            conn.Close();
        }
        private void ReaderM_Load(object sender, EventArgs e)
        {
            DataBind();
        }

    }
}
