using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestfallDB
{
    [Serializable()]
    public class Components
    {
        public string Component { get; set; }
        public int Nr { get; set; }


        public List<Components> ComponentList = new List<Components>();


        public Components() { }

        public Components(string component, int nr)
        {
            this.Component = component;
            this.Nr = nr;
        }


        private void fillDataTable(List<Components> lComponents, DataTable dt)
        {
            foreach (var component in lComponents)
            {
                dt.Rows.Add(component.Nr, component.Component);
            }
        }


        private void fillListView(DataView dv, ListView list)
        {
            list.Items.Clear();
            foreach (DataRow row in dv.ToTable().Rows)
            {
                list.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString() }));
            }
        }


        public void ShowDataToListView(ListView list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Nr.");
            dt.Columns.Add("Bauteil");

            fillDataTable(this.ComponentList, dt);
            DataView dv = new DataView(dt);
            fillListView(dv, list);
        }
    }
}
