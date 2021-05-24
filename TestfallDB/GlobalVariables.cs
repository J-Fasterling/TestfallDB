using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestfallDB
{
    class GlobalVariables
    {
        public List<Testcase> listToTest = new List<Testcase>();

        public List<int> velocityList = new List<int>();

        public List<Testcase> allTestcases = new List<Testcase>();

        public List<Components> allComponents = new List<Components>();

        #region erstellen der Fahrzeugkonfigurationen
        public List<Components> up = new List<Components>
        {
            new Components("Kopfairbag"),
            new Components("ABS"),
            new Components("ESC")
        };

        public List<Components> Polo = new List<Components>
        {
            new Components("Kopfairbag"),
            new Components("ABS"),
            new Components("ESC"),
            new Components("Fernlichtassistent"),
            new Components("Parksensoren")
        };

        public List<Components> Golf = new List<Components>
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


        public List<Components> Touareg = new List<Components>
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

        public bool is0Included = false;
        public bool is7Included = false;
        public bool is30Included = false;
        public bool is50Included = false;
        public bool is100Included = false;
        public bool is130Included = false;



        #region fill ListView
        private void fillDataTable(List<Testcase> lTestcases, DataTable dt)
        {
            foreach (var testcase in lTestcases)
            {
                dt.Rows.Add(testcase.Nr, testcase.Testname, testcase.Precondition, testcase.Velocity, testcase.ExpectedResult);
            }
        }


        private void fillListView(DataView dv, ListView list)
        {
            list.Items.Clear();
            foreach (DataRow row in dv.ToTable().Rows)
            {
                list.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString() }));
            }
        }

        public void ShowDataToListView(ListView list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Nr.");
            dt.Columns.Add("Testname");
            dt.Columns.Add("Vorbedingung");
            dt.Columns.Add("Geschwindigkeit");
            dt.Columns.Add("Erwartetes Resultat");

            fillDataTable(this.listToTest, dt);
            DataView dv = new DataView(dt);
            fillListView(dv, list);
        }
        #endregion
    }
}
