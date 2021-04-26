using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace TestfallDB
{
    class SQL_Edit
    {
        public SqlConnection Connection { get; set; }
        public SqlCommand Command { get; set; }
        public SqlDataReader Reader { get; set; }

        public SQL_Edit() { }


        public SQL_Edit(string sqlString)
        {
            this.Connection = new SqlConnection(sqlString);
            Connection.Open();
        }

        public void SqlConnect(string sqlString)
        {
            Connection = new SqlConnection(sqlString);
            Connection.Open();
        }


        public void SqlAdd(string tableName, string column, string toAdd)
        {
            Command = new SqlCommand("insert into " + tableName + " values (@" + column + ")", Connection);
            Command.Parameters.AddWithValue("@" + column, toAdd);
            Command.BeginExecuteNonQuery();
        }


        public void SqlToComponent(string table,Components cComponents)
        {
            Command = new SqlCommand("SELECT Bauteil FROM " + table, Connection);
            Reader = Command.ExecuteReader();
            int num = 1;

            Components component = new Components();

            try
            {
                while (Reader.Read())
                {
                    component = new Components(Reader.GetString(0), num);
                    num++;
                    cComponents.ComponentList.Add(component);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //return component.ComponentList;   
        }


        public void SqlToTestcase(string table,Testcase tTestcase)
        {
            Command = new SqlCommand("SELECT * FROM " + table, Connection);
            Reader = Command.ExecuteReader();
            int num = 1;

            Testcase testcase = new Testcase();

            try
            {
                while (Reader.Read())
                {
                    testcase = new Testcase(num, Reader.GetString(1), Reader.GetString(2), Reader.GetInt32(3), Reader.GetString(4));
                    num++;
                    tTestcase.TestcaseList.Add(testcase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //return test.TestcaseList;
        }

    }
}