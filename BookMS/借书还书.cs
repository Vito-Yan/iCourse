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
    public partial class BorrowAndReturn : Form
    {
        public BorrowAndReturn()
        {
            InitializeComponent();
        }

        private void BorrowBook_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=.;database=booksDB;integrated security=True");
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "exec usp_BorrowBook @rdID,@bkID";
            comm.Parameters.AddWithValue("@rdID", txtrdID.Text);
            comm.Parameters.AddWithValue("@bkID", txtbkID.Text); 
            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("借书成功！");
            }
            catch (Exception ex)
            {

                MessageBox.Show("借书失败！" + ex.Message);
            }
        }

        private void ReturnBook_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=.;database=booksDB;integrated security=True");
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "exec usp_ReturnBook @rdID,@bkID";
            comm.Parameters.AddWithValue("@rdID", txtrdID.Text);
            comm.Parameters.AddWithValue("@bkID", txtbkID.Text);

            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("还书成功！");
            }
            catch (Exception ex)
            {

                MessageBox.Show("还书失败！" + ex.Message);
            }
        }

        private void BorrowAndReturn_Load(object sender, EventArgs e)
        {
        
        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }

        private void Borrow_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=.;database=booksDB;integrated security=True");
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "select rdID 读者编号,bkID 书号,DateBorrow 借书日期,DateLendPlan 应还日期,DateLendAct 实际还书日期 from Borrow";
            SqlDataAdapter sda = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgvBorrow.DataSource = ds.Tables[0];
            conn.Close();  
        }

    }
}
