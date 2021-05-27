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
    public class SQL_Edit
    {
        //Verbindung zu der Datenbank
        public SqlConnection Connection { get; set; }
        //Sql Befehl
        public SqlCommand Command { get; set; }
        //DataReader
        public SqlDataReader Reader { get; set; }

        public SQL_Edit() { }


        public SQL_Edit(string sqlString)
        {
            this.Connection = new SqlConnection(sqlString);
            Connection.Open();
        }

        /// <summary>
        /// stellt eine Verbindung mit der Datebank her
        /// </summary>
        /// <param name="sqlString"></param>
        public void SqlConnect(string sqlString)
        {
            Connection = new SqlConnection(sqlString);
            Connection.Open();
        }


        /// <summary>
        /// SQL Befehl um ein Bauteil zur Bauteildatenbank hinzuzufügen
        /// </summary>
        /// <param name="column"></param>
        /// <param name="toAdd"></param>
        public void AddComp(string column, string toAdd)
        {
            Command = new SqlCommand("INSERT INTO Bauteile VALUES (@" + column + ")", Connection);
            Command.Parameters.AddWithValue("@" + column, toAdd);
            Command.BeginExecuteNonQuery();
        }


        /// <summary>
        /// SQL Befehl um ein Testfall zur Testfalldatenbank hinzuzufügen
        /// </summary>
        /// <param name="name"></param>
        /// <param name="precondition"></param>
        /// <param name="velocity"></param>
        /// <param name="expectResult"></param>
        public void AddTest(string name, string precondition, int velocity, string expectResult)
        {
            Command = new SqlCommand("INSERT INTO Testfaelle VALUES ('" + name + "', '" + precondition + "', '" + velocity + "', '" + expectResult + "')", Connection);
            Reader = Command.ExecuteReader();
        }


        /// <summary>
        /// SQL Befehl der Daten der Bauteildatenbank in eine Liste überführt
        /// </summary>
        /// <param name="table"></param>
        /// <param name="globals"></param>
        public void SqlToComponent(string table, GlobalVariables globals)
        {
            Command = new SqlCommand("SELECT Bauteil FROM " + table, Connection);
            Reader = Command.ExecuteReader();
            int num = 1;

            try
            {
                //solange der Reader Daten aus der Datenbank erhällt
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


        /// <summary>
        /// SQL Befehl der Daten der Testfalldatenbank in eine Liste überführt
        /// </summary>
        /// <param name="table"></param>
        /// <param name="globals"></param>
        public void SqlToTestcase(string table, GlobalVariables globals)
        {
            Command = new SqlCommand("SELECT * FROM " + table, Connection);
            Reader = Command.ExecuteReader();
            int num = 1;

            try
            {
                //solange der Reader Daten aus der Datenbank erhällt
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


        /// <summary>
        /// löscht den gesamten Inhalt der Datenbank
        /// </summary>
        /// <param name="table"></param>
        public void deleteAllData(string table)
        {
            Command = new SqlCommand("DELETE FROM " + table, Connection);
            Reader = Command.ExecuteReader();
        }


        /// <summary>
        /// speichert Testfälle einer bestimmten Geschwindigkeit in eine Liste
        /// </summary>
        /// <param name="velocity"></param>
        /// <returns></returns>
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


        /// <summary>
        /// speichert Testfälle bestimmter Bauteile und bestimmter Geschwindigkeiten in einer Liste
        /// </summary>
        /// <param name="carConfiguration"></param>
        /// <param name="velocity"></param>
        /// <returns></returns>
        public List<Testcase> sortByComponentsAndVelocity(List<Components> carConfiguration, List<int> velocity)
        {
            List<Testcase> tempList = new List<Testcase>();

            try
            {
                //Sortierung für jedes Bauteil
                foreach (Components comp in carConfiguration)
                {
                    //sortierung für jede Geschwindigkeit
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


        /// <summary>
        /// erzeugt die Liste der Fahrzeugspezifischen Testfälle
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        public List<Testcase> createCarSpecificList(CarConfiguration car)
        {
            List<Testcase> tempList = new List<Testcase>();

            try
            {
                //für jedes Bauteil der Fahrzeugkonfiguration
                foreach (Components comp in car.ConfigurationList)
                {
                    Command = new SqlCommand("SELECT * FROM Testfaelle WHERE Testname = '" + comp.Component + "'", Connection);
                    Reader = Command.ExecuteReader();
                    int num = 1;

                    while (Reader.Read())
                    {
                        car.toTest++;
                        tempList.Add(new Testcase(num, Reader.GetString(1), Reader.GetString(2), Reader.GetInt32(3), Reader.GetString(4)));
                        num++;
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