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

namespace SESIA2
{
    public partial class Form2 : Form
    {

        string conn = @"Data Source=lab206_4\SQLEXPRESS;Initial Catalog=ekzamen2;Integrated Security=True";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ekzamen2DataSet1.catalog". При необходимости она может быть перемещена или удалена.
            this.catalogTableAdapter.Fill(this.ekzamen2DataSet1.catalog);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql_conn = new SqlConnection(conn);
            string sqlquery = "select * from [dbo].[catalog] ORDER BY Stoim  DESC ";
            sql_conn.Open();
            SqlCommand comm = new SqlCommand(sqlquery, sql_conn);
            SqlDataAdapter sdr = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            sql_conn.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sql_conn = new SqlConnection(conn);
            string sqlquery = "select * from [dbo].[catalog] ORDER BY Stoim  DESC ";
            sql_conn.Open();
            SqlCommand comm = new SqlCommand(sqlquery, sql_conn);
            SqlDataAdapter sdr = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            sql_conn.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            SqlConnection sql_conn = new SqlConnection(conn);
            string sqlquery = "select * from [dbo].[catalog]";
            sql_conn.Open();
            SqlCommand comm = new SqlCommand(sqlquery, sql_conn);
            SqlDataAdapter sdr = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            sql_conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            SqlConnection sql_conn = new SqlConnection(conn);
            string sqlquery = "select * from [dbo].[catalog]";
            sql_conn.Open();
            SqlCommand comm = new SqlCommand(sqlquery, sql_conn);
            SqlDataAdapter sdr = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            sql_conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlConnection sql_conn = new SqlConnection(conn);
            string sqlquery = "select * from [dbo].[catalog] ORDER BY Stoim ";
            sql_conn.Open();
            SqlCommand comm = new SqlCommand(sqlquery, sql_conn);
            SqlDataAdapter sdr = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            sql_conn.Close();
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            SqlConnection sql_conn = new SqlConnection(conn);
            string sqlquery = "select * from [dbo].[catalog] where Stoim Like '" + textBox3.Text + "%'";
            sql_conn.Open();
            SqlCommand comm = new SqlCommand(sqlquery, sql_conn);
            SqlDataAdapter sdr = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            sql_conn.Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            SqlConnection sql_conn = new SqlConnection(conn);
            string sqlquery = "select * from [dbo].[catalog] where Name Like '" + textBox1.Text + "%'";
            sql_conn.Open();
            SqlCommand comm = new SqlCommand(sqlquery, sql_conn);
            SqlDataAdapter sdr = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            sql_conn.Close();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            SqlConnection sql_conn = new SqlConnection(conn);
            string sqlquery = "select * from [dbo].[catalog] where Artik Like '" + textBox2.Text + "%'";
            sql_conn.Open();
            SqlCommand comm = new SqlCommand(sqlquery, sql_conn);
            SqlDataAdapter sdr = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            sql_conn.Close();
        }
    }
}
