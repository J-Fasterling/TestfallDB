using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestfallDB
{
    class Testcase
    {
        public int Nr { get; set; }
        public string Testname { get; set; }
        public string Precondition { get; set; }
        public int Velocity { get; set; }
        public string ExpectedResult { get; set; }       


        public List<Testcase> TestcaseList = new List<Testcase>();


        public Testcase() { }
        public Testcase(int nr, string name, string precondition, int velocity, string result)
        {
            this.Nr = nr;
            this.Testname = name;
            this.Precondition = precondition;
            this.Velocity = velocity;
            this.ExpectedResult = result;           
        }
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

            fillDataTable(this.TestcaseList, dt);
            DataView dv = new DataView(dt);
            fillListView(dv, list);
        }
    }
}
