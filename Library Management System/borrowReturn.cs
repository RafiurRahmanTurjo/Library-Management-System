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

namespace Library_Management_System
{
    public partial class borrowReturn : Form
    {
        public borrowReturn()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HV6CT48;Initial Catalog=master;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("Select Book_Name from books where Book_Name = '" + textBox1.Text + "';", con);
            cmd.Connection = con;
            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                cmd.CommandText = "insert into borrow(Book_Name,Author,Publish) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "');" +
          "Delete from books where Book_Name ='" + textBox1.Text + "' ; ";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Borrowed !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                MessageBox.Show("No Book Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu mn = new menu();
            mn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HV6CT48;Initial Catalog=master;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("Select Book_Name from borrow where Book_Name = '" + textBox1.Text + "';", con);
            cmd.Connection = con;
            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                cmd.CommandText = "insert into books(Book_Name,Author,Publish) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "');" +
          "Delete from borrow where Book_Name ='" + textBox1.Text + "' ; ";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Returned !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                MessageBox.Show("No Book Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
