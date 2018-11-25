using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ConnectedLevelPartOne
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                string connectionString = ConfigurationManager.ConnectionStrings["UserConnectionString"].ConnectionString;

                connection.ConnectionString = connectionString;

                connection.Open();

                SqlCommand create = new SqlCommand();

                create.Connection = connection;

                create.CommandText = "create table Group(id int,name nvarchar(50));";

                create.ExecuteNonQuery();
            }

        }
    }
}