using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsrnmPaswrd_Provider
{
    public partial class Login : Form
    {
        string str = @"Data Source=LAPTOP-2OU8NEFO\SQLEXPRESS;Initial Catalog=LoginProvider;Integrated Security=True;";
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection ssr = new SqlConnection(str);
            ssr.Open();
            SqlCommand cmd = new SqlCommand("Select * From stdInfo where UserName ='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", ssr);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                label4.Text = "sucess";
                Form1 fm = new Form1();
                fm.Show();
                this.Hide();
            }
            else
            {
                label4.Text = "Failure";
            }
            ssr.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
