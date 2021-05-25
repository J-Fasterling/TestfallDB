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
        public CarConfiguration Up = new CarConfiguration();
        public CarConfiguration Polo = new CarConfiguration();
        public CarConfiguration Golf = new CarConfiguration();
        public CarConfiguration Touareg = new CarConfiguration();

        #endregion

        public bool is0Included = false;
        public bool is7Included = false;
        public bool is30Included = false;
        public bool is50Included = false;
        public bool is100Included = false;
        public bool is130Included = false;


        public GlobalVariables()
        {
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

        }

        #region fill ListView
        private void fillDataTable(List<Testcase> lTestcases, DataTable dt)
        {
            foreach (var testcase in lTestcases)
            {
                dt.Rows.Add(testcase.Nr, testcase.Testname, testcase.Precondition, testcase.Velocity, testcase.ExpectedResult);
            }
        }


        private void fillListView(DataView dv, ListView list, List<Testcase> lTestcases)
        {
            list.Items.Clear();
            int cnt = 0;
            foreach (DataRow row in dv.ToTable().Rows)
            {
                var item = new ListViewItem(new String[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString() });
                
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
                //item.UseItemStyleForSubItems = false;

                list.Items.Add(item);

            }
        }

        public void ShowDataToListView(ListView list, CarConfiguration car)
        {
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
