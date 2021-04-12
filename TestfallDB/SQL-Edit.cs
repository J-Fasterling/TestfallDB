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
        public static SqlConnection connection = null;
        public static string sqlString = "";

        public void SqlConnect(string sqlString)
        {
            connection = new SqlConnection(sqlString);

            connection.Open();
        }


        public void SqlAdd(string tableName, string column, string toAdd)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = SQL_Edit.connection;
            command.CommandText = "insert into " + tableName + " values (@" + column + ")";
            command.Parameters.AddWithValue(column, toAdd);
            command.ExecuteNonQuery();
        }
    }
}