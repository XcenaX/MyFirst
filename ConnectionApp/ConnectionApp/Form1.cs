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

namespace ConnectionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string connectionString = "Data Source=PCLENOVO;Initial Catalog=MyDB;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            if(sqlConnection.State == System.Data.ConnectionState.Open)
            {
                bool login = false;
                string testInsert = "select * from Test where username='"+txtID.Text.ToString()+"' and password='"+txtName.Text.ToString()+"'";
                SqlCommand sqlCommand = new SqlCommand(testInsert,sqlConnection);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                if(dataReader.Read())
                {
                    login = true;
                }
                dataReader.Close();
                sqlConnection.Close();
                if(login==true)
                {
                    MessageBox.Show("Connection successfull");
                }
                else
                {
                    MessageBox.Show("Error occured");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
