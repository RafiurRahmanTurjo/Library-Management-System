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
    public partial class viewmng : Form
    {
        public viewmng()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HV6CT48;Initial Catalog=master;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "insert into employeeLogin (username,pass) values ('" + textBox3.Text + "','" + textBox2.Text + "');";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Account Created Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HV6CT48;Initial Catalog=master;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "Delete From employeeLogin where id = '" + textBox1.Text + "';";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Account Deleted Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HV6CT48;Initial Catalog=master;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "Update employeeLogin SET username = '" + textBox3.Text + "',pass = '"+ textBox2.Text + "' where id ='" + textBox1.Text + "';";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Account Successfully Updated !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            managerHome mh = new managerHome();
            mh.Show();
        }
    }
}
