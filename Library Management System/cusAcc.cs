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
    public partial class cusAcc : Form
    {
        public cusAcc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HV6CT48;Initial Catalog=master;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from loginTable where username ='" +textBox1.Text + "'and pass =  '" + textBox3.Text + "'; ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds);
            
            if (ds.Tables[0].Rows.Count != 0)
            {
                cmd.CommandText = "update loginTable set username ='" + textBox2.Text + "', pass ='" + textBox4.Text + "' where username ='" + textBox1.Text + "'and pass =  '" + textBox3.Text + "' ; ";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Updated !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                MessageBox.Show("Username or Password Doesn't Match !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu mn = new menu();
            mn.Show();
        }
    }
}
