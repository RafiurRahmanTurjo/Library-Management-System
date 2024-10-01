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
    public partial class createAccount : Form
    {
        public createAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            homepage hp = new homepage();
           hp.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HV6CT48;Initial Catalog=master;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "insert into loginTable (username,pass) values ('"+textBox1.Text+"','"+textBox2.Text+"');";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Account Created Successfully !!","Success", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }
    }
}
