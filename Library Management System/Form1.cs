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
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            createAccount ca = new createAccount();
            ca.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {   
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HV6CT48;Initial Catalog=master;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from loginTable where username ='" + txtUsername.Text + "'and pass =  '" + txtPassword.Text + "'; ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            
            if (ds.Tables[0].Rows.Count != 0 )
            {
                this.Hide();
                menu mn = new menu();
                mn.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            managerLogin ml = new managerLogin();
            ml.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            employeeLogin el = new employeeLogin();
            el.Show();
        }
    } 
}

