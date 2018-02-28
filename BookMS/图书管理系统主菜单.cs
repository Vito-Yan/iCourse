using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ReaderTypeM().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BookM().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ReaderM().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BorrowAndReturn().Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Out_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
