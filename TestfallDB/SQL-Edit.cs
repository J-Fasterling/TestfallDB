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


        public void AddComp(string column, string toAdd)
        {
            Command = new SqlCommand("INSERT INTO Bauteile VALUES (@" + column + ")", Connection);
            Command.Parameters.AddWithValue("@" + column, toAdd);
            Command.BeginExecuteNonQuery();
        }


        public void AddTest(string name, string precondition, int velocity, string expectResult)
        {
            Command = new SqlCommand("INSERT INTO Testfaelle VALUES ('" + name + "', '" + precondition + "', '" + velocity + "', '" + expectResult + "')", Connection);
            Reader = Command.ExecuteReader();
        }


        public void SqlToComponent(string table, GlobalVariables globals)
        {
            Command = new SqlCommand("SELECT Bauteil FROM " + table, Connection);
            Reader = Command.ExecuteReader();
            int num = 1;

            try
            {
                while (Reader.Read())
                {
                    globals.allComponents.Add(new Components(Reader.GetString(0), num));
                    num++;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void SqlToTestcase(string table, GlobalVariables globals)
        {
            Command = new SqlCommand("SELECT * FROM " + table, Connection);
            Reader = Command.ExecuteReader();
            int num = 1;

            try
            {
                while (Reader.Read())
                {
                    globals.allTestcases.Add(new Testcase(num, Reader.GetString(1), Reader.GetString(2), Reader.GetInt32(3), Reader.GetString(4)));
                    num++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public void deleteAllData(string table)
        {
            Command = new SqlCommand("DELETE FROM " + table, Connection);
            Reader = Command.ExecuteReader();
        }


        public List<Testcase> sortByVelocity(int velocity)
        {
            List<Testcase> tempList = new List<Testcase>();

            try
            {
                Command = new SqlCommand("SELECT * FROM Testfaelle WHERE Geschwindigkeit = '" + velocity.ToString() + "'", Connection);
                Reader = Command.ExecuteReader();
                int num = 1;

                while (Reader.Read())
                {
                    tempList.Add(new Testcase(num, Reader.GetString(1), Reader.GetString(2), Reader.GetInt32(3), Reader.GetString(4)));
                    num++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return tempList;
        }


        public List<Testcase> sortByComponentsAndVelocity(List<Components> carConfiguration, List<int> velocity)
        {
            List<Testcase> tempList = new List<Testcase>();

            try
            {
                foreach (Components comp in carConfiguration)
                {
                    foreach (int v in velocity)
                    {
                        Command = new SqlCommand("SELECT * FROM Testfaelle WHERE Testname = '" + comp.Component + "' AND Geschwindigkeit = '" + v.ToString() + "'", Connection);
                        Reader = Command.ExecuteReader();
                        int num = 1;

                        while (Reader.Read())
                        {
                            tempList.Add(new Testcase(num, Reader.GetString(1), Reader.GetString(2), Reader.GetInt32(3), Reader.GetString(4)));
                            num++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return tempList;
        }
    }
}