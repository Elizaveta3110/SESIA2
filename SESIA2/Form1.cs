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
    public partial class Form1 : Form
    {

        string conn_string = @"Data Source=lab206_4\SQLEXPRESS;Initial Catalog=ekzamen2;Integrated Security=True";
        string login, password;



        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login = textBox1.Text;
            password = textBox2.Text;


            SqlConnection sql_conn = new SqlConnection(conn_string);
            string sqlquery = "select Role from [dbo].[User$] where login= '" + login + "' AND password = '" + password + "'";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sql_conn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);

            if (dt.Rows.Count > 0)
            {

                if (dt.Rows[0].ItemArray[0].ToString() == "Клиент")
                {
                    Form2 f = new Form2();
                    f.Show();
                    this.Hide();
                }
                if (dt.Rows[0].ItemArray[0].ToString() == "Администратор")
                {
                    Form2 f = new Form2();
                    f.Show();
                    this.Hide();
                }
                if (dt.Rows[0].ItemArray[0].ToString() == "Менеджер")
                {
                    Form2 f = new Form2();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неправильный логин либо пароль");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();
        }

        public Form1()
            {
                InitializeComponent();

            }
        }
    }



