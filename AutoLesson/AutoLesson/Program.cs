using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AutoLesson
{
    class Program
    {

        

        static void Main(string[] args)
        {
            DataSet data = new DataSet("ShopDb");

            DataTable table = new DataTable("Orders");
           
            table.Columns.AddRange(new DataColumn[] {
               
                new DataColumn
                {
                    ColumnName = "Name",
                    AllowDBNull = false,
                    Unique = false,
                    DataType = typeof(string)                   
                },             
                 new DataColumn
                {
                    ColumnName = "Id",
                    AllowDBNull = false,
                    AutoIncrement = true,
                    AutoIncrementSeed = 1,
                    AutoIncrementStep = 1,
                    Unique = true,
                    DataType = typeof(int)
                }
            });         

            data.Tables.Add(table);
            
            ////

            table = new DataTable("Customers");

            table.Columns.AddRange(new DataColumn[] {

                new DataColumn
                {
                    ColumnName = "Name",
                    AllowDBNull = false,
                    Unique = false,
                    DataType = typeof(string)
                },
                new DataColumn
                {
                    ColumnName = "Phone",
                    AllowDBNull = false,
                    DataType = typeof(string),
                    Unique = true
                },
                 new DataColumn
                {
                    ColumnName = "Id",
                    AllowDBNull = false,
                    AutoIncrement = true,
                    AutoIncrementSeed = 1,
                    AutoIncrementStep = 1,
                    Unique = true,
                    DataType = typeof(int)
                }
            });

            data.Tables.Add(table);

            /////

            table = new DataTable("Employees");

            table.Columns.AddRange(new DataColumn[] {

                new DataColumn
                {
                    ColumnName = "Name",
                    AllowDBNull = false,
                    Unique = false,
                    DataType = typeof(string)
                },
                new DataColumn
                {
                    ColumnName = "Salary",
                    AllowDBNull = false,
                    DataType = typeof(int),
                    Unique = false
                },
                 new DataColumn
                {
                    ColumnName = "Id",
                    AllowDBNull = false,
                    AutoIncrement = true,
                    AutoIncrementSeed = 1,
                    AutoIncrementStep = 1,
                    Unique = true,
                    DataType = typeof(int)
                }
            });

            data.Tables.Add(table);

            /////

            table = new DataTable("OrderDetails");

            table.Columns.AddRange(new DataColumn[] {

                new DataColumn
                {
                    ColumnName = "Price",
                    AllowDBNull = false,
                    Unique = false,
                    DataType = typeof(int)
                },
                new DataColumn
                {
                    ColumnName = "OrderTime",
                    AllowDBNull = false,
                    DataType = typeof(string),
                    Unique = false
                },
                 new DataColumn
                {
                    ColumnName = "Id",
                    AllowDBNull = false,
                    AutoIncrement = true,
                    AutoIncrementSeed = 1,
                    AutoIncrementStep = 1,
                    Unique = true,
                    DataType = typeof(int)
                }
            });

            data.Tables.Add(table);

            /////

            table = new DataTable("Products");

            table.Columns.AddRange(new DataColumn[] {

                new DataColumn
                {
                    ColumnName = "Name",
                    AllowDBNull = false,
                    Unique = false,
                    DataType = typeof(string)
                },
                new DataColumn
                {
                    ColumnName = "Price",
                    AllowDBNull = false,
                    DataType = typeof(string),
                    Unique = false
                },
                 new DataColumn
                {
                    ColumnName = "Id",
                    AllowDBNull = false,
                    AutoIncrement = true,
                    AutoIncrementSeed = 1,
                    AutoIncrementStep = 1,
                    Unique = true,
                    DataType = typeof(int)
                }
            });

            data.Tables.Add(table);
        }
    }
}
