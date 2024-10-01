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
    public partial class managerLogin : Form
    {
        public managerLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   

            this.Hide();
            homepage hp = new homepage();
            hp.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HV6CT48;Initial Catalog=master;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from managerLogin where username ='" + textBox1.Text + "'and pass =  '" + textBox2.Text + "'; ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int a = 10;
            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                managerHome mh = new managerHome();
                mh.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
