using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TestfallDB
{
    class SQL_Edit
    {
        public SQL_Edit() { }

        public SQL_Edit(string sqlString)
        {
            this.connection = new SqlConnection(sqlString);
        }
        

        public SqlConnection connection { get; set; }
        public SqlCommand command { get; set; }
        public SqlDataReader reader { get; set; }


        public void SqlConnect(string sqlString)
        {
            connection = new SqlConnection(sqlString);

            connection.Open();
        }


        public void SqlAdd(string tableName, string column, string toAdd)
        {
            command.Connection = connection;
            command.CommandText = "insert into " + tableName + " values (@" + column + ")";
            command.Parameters.AddWithValue(column, toAdd);
            command.ExecuteNonQuery();
        }


        public void SqlToComponent(Components component)
        {
            using (command = new SqlCommand("SELECT Bauteil FROM Bauteile", connection))
            {
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        component = new Components(reader.GetString(0));
                        component.ComponentList.Add(component);
                    }
                }
            }
        }



        public void SqlToTestcase(Testcase test)
        {
            using (command = new SqlCommand("SELECT * FROM Testfaelle", connection))
            {
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        test = new Testcase(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3));
                        test.TestcaseList.Add(test);
                    }
                }
            }
        }
    }
}