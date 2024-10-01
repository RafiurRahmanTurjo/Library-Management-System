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
    public partial class managerHome : Form
    {
        public managerHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            homepage hp = new homepage();
            hp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HV6CT48;Initial Catalog=master;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("Select id,username from loginTable;", con);
            cmd.Connection = con;
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void managerHome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet1.employeeLogin' table. You can move, or remove it, as needed.
            this.employeeLoginTableAdapter.Fill(this.masterDataSet1.employeeLogin);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HV6CT48;Initial Catalog=master;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("Select * from books;",con);
            cmd.Connection = con;
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HV6CT48;Initial Catalog=master;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("Select id,username from employeeLogin where username = '"+ textBox1.Text+"';", con);
            cmd.Connection = con;
            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Results Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HV6CT48;Initial Catalog=master;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("Select id,username from employeeLogin;", con);
            cmd.Connection = con;
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewmng vm = new viewmng();
            vm.Show();
        }
    }
}
