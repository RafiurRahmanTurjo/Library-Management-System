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
    public partial class viewemp : Form
    {
        public viewemp()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewemp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.loginTable' table. You can move, or remove it, as needed.
            this.loginTableTableAdapter.Fill(this.masterDataSet.loginTable);
            // TODO: This line of code loads data into the 'masterDataSet.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.masterDataSet.books);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            employeeHome eh = new employeeHome();
            eh.Show();        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HV6CT48;Initial Catalog=master;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "insert into loginTable (username,pass) values ('" + textBox3.Text + "','" + textBox2.Text + "');";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Account Created Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HV6CT48;Initial Catalog=master;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "Update loginTable SET username = '" + textBox3.Text + "',pass = '" + textBox2.Text + "' where id ='" + textBox1.Text + "';";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Account Successfully Updated !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HV6CT48;Initial Catalog=master;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "Delete From loginTable where id = '" + textBox1.Text + "';";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Account Deleted Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
