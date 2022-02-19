using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UsrnmPaswrd_Provider
{
    public partial class Form1 : Form
    {
        string str = @"Data Source=LAPTOP-2OU8NEFO\SQLEXPRESS;Initial Catalog=LoginProvider;Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }

        public void insert()
        {
            try
            {
                SqlConnection ssr = new SqlConnection(str);
                ssr.Open();
                SqlCommand cmd = new SqlCommand("insert into stdInfo (sName,FatherNmae,RollNo,DOB,Course,UserName,Password)values(@Name,@FatherName,@RollNo, @DOB,@Course,@UserName,@Password)", ssr);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@FatherName", textBox2.Text);
                cmd.Parameters.AddWithValue("@RollNo", textBox3.Text);
                cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@Course", comboBox1.Text);
                cmd.Parameters.AddWithValue("@UserName", textBox4.Text);
                cmd.Parameters.AddWithValue("@Password", textBox5.Text);
                cmd.ExecuteNonQuery();
                ssr.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Error"+ex);
            }

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void stdInfo_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            insert();
        }
    }
}
