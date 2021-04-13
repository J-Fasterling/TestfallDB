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


        public List<Components> SqlToComponent()
        {
            command = new SqlCommand("SELECT Bauteil FROM Bauteile", connection);
            reader = command.ExecuteReader();

            Components component = new Components();
                
            while (reader.Read())
            {
                component = new Components(reader.GetString(0));
                component.ComponentList.Add(component);
            }
            return component.ComponentList;   
        }



        public List<Testcase> SqlToTestcase()
        {
            command = new SqlCommand("SELECT * FROM Testfaelle", connection);
            reader = command.ExecuteReader();

            Testcase test = new Testcase();
             
            while (reader.Read())
            {
                  test = new Testcase(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3));
                  test.TestcaseList.Add(test);
            }
            return test.TestcaseList;
        }
    }
}