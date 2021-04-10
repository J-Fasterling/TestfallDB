using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestfallDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dataSet1.DataTable2". Sie können sie bei Bedarf verschieben oder entfernen.
            try
            {
                this.dataTable2TableAdapter.Fill(this.dataSet1.DataTable2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dataSet1.DataTable1". Sie können sie bei Bedarf verschieben oder entfernen.
            //this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1);

        }


    }
}
