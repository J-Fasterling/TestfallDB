using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestfallDB
{
    public class GlobalVariables
    {
        //Liste mit Geschwindigkeite, die es zu testen gilt
        public List<int> velocityList = new List<int>();
        //Liste in welche alle Tesstfälle der Datenbank geladen werden
        public List<Testcase> allTestcases = new List<Testcase>();
        //Liste in welche alle Bauteile der Datenbank geladen werden
        public List<Components> allComponents = new List<Components>();

        #region erstellen der Fahrzeugkonfigurationen
        //Erstellen der Fahzeugkonfigurations Klassen
        public CarConfiguration Up = new CarConfiguration();
        public CarConfiguration Polo = new CarConfiguration();
        public CarConfiguration Golf = new CarConfiguration();
        public CarConfiguration Touareg = new CarConfiguration();

        #endregion

        //boolwert, ob eine Geschwindigkeit getestet wird
        public bool is0Included = false;
        public bool is7Included = false;
        public bool is30Included = false;
        public bool is50Included = false;
        public bool is100Included = false;
        public bool is130Included = false;


        public GlobalVariables()
        {
            #region Befüllen der Fahzeugkonfigurationen
            //Befüllen der Fahrzeugkonfigurationen
            Up.ConfigurationList = new List<Components>
            {
                new Components("Kopfairbag"),
                new Components("ABS"),
                new Components("ESC")
            };

            Polo.ConfigurationList = new List<Components>
            {
                new Components("Kopfairbag"),
            new Components("ABS"),
            new Components("ESC"),
            new Components("Fernlichtassistent"),
            new Components("Parksensoren")
            };

            Golf.ConfigurationList = new List<Components>
            {
                new Components("Kopfairbag"),
            new Components("ABS"),
            new Components("ESC"),
            new Components("Fernlichtassistent"),
            new Components("Parksensoren"),
            new Components("Launch Control"),
            new Components("GRA"),
            new Components("ACC"),
            new Components("Notbremsfunktion")
            };

            CarConfiguration touareg = new CarConfiguration();
            Touareg.ConfigurationList = new List<Components>
            {
                new Components("Kopfairbag"),
            new Components("ABS"),
            new Components("ESC"),
            new Components("Fernlichtassistent"),
            new Components("Parksensoren"),
            new Components("Launch Control"),
            new Components("GRA"),
            new Components("ACC"),
            new Components("Notbremsfunktion"),
            new Components("Spurhalteassistent"),
            new Components("Totwinkelassistent"),
            new Components("Rueckfahrkamera")
            };
            #endregion
        }

        #region fill ListView

        /// <summary>
        /// fügt einem DataTable alle Elemente der Liste zu
        /// </summary>
        /// <param name="lTestcases"></param>
        /// <param name="dt"></param>
        private void fillDataTable(List<Testcase> lTestcases, DataTable dt)
        {
            foreach (var testcase in lTestcases)
            {
                dt.Rows.Add(testcase.Nr, testcase.Testname, testcase.Precondition, testcase.Velocity, testcase.ExpectedResult);
            }
        }


        /// <summary>
        /// Tranfereiert die Daten einer Liste in einen ListView
        /// </summary>
        /// <param name="dv"></param>
        /// <param name="list"></param>
        /// <param name="lTestcases"></param>
        private void fillListView(DataView dv, ListView list, List<Testcase> lTestcases)
        {
            list.Items.Clear();
            int cnt = 0;

            foreach (DataRow row in dv.ToTable().Rows)
            {
                //erzeugt ein neues ListViewItem mit den Daten
                var item = new ListViewItem(new String[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString() });
                
                //überprüft den Status der zu ergänzenden Elemente und passt die Farbe der ListView an
                switch (lTestcases[cnt].Status)
                {
                    case Testcase.TestStatus.i_O:
                        item.SubItems[0].BackColor = System.Drawing.Color.Green;
                        break;

                    case Testcase.TestStatus.n_i_O:
                        item.SubItems[0].BackColor = System.Drawing.Color.Red;
                        break;

                    case Testcase.TestStatus.n_D:
                        item.SubItems[0].BackColor = System.Drawing.Color.Gray;
                        break;

                    case Testcase.TestStatus.notTested:
                        item.SubItems[0].BackColor = System.Drawing.Color.White;
                        break;
                }
                cnt++;
                list.Items.Add(item);
            }
        }


        /// <summary>
        /// Erstellt einen DataTable, welcher in der ListView angezeigt werden kann
        /// </summary>
        /// <param name="list"></param>
        /// <param name="car"></param>
        public void ShowDataToListView(ListView list, CarConfiguration car)
        {
            //befüllt den DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Nr.");
            dt.Columns.Add("Testname");
            dt.Columns.Add("Vorbedingung");
            dt.Columns.Add("Geschwindigkeit");
            dt.Columns.Add("Erwartetes Resultat");

            fillDataTable(car.testcasesToShow, dt);
            DataView dv = new DataView(dt);
            fillListView(dv, list, car.testcasesToShow);
        }
        #endregion
    }
}
