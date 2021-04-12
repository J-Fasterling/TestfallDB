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
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dataSet1.DataTable". Sie können sie bei Bedarf verschieben oder entfernen.
           // this.dataTableTableAdapter.Fill(this.dataSet1.DataTable);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dataSet1.DataTable1". Sie können sie bei Bedarf verschieben oder entfernen.
            //this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "testfallDBDataSet.Bauteile". Sie können sie bei Bedarf verschieben oder entfernen.




        }

        #region Benutzerauswahl

        private void Chef_Click(object sender, EventArgs e)
        {
            try
            {
                SQL_Edit sqlTest = new SQL_Edit();
                sqlTest.SqlConnect("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jonas\\source\\repos\\TestfallDB\\TestfallDB\\TestDatenbank_JonasF.mdf;Integrated Security=True");
                MessageBox.Show("Verbindung mit Datenbank von " + Chef.Name + " war erfolgreich.", "Verbindung erfolgt", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Verbindung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Jerry_Click(object sender, EventArgs e)
        {
            try
            {
                SQL_Edit sqlTest = new SQL_Edit();
                sqlTest.SqlConnect("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Jeremias\\Source\\Repos\\TestfallDB\\TestfallDB\\TestDatenbank_Jeremias.mdf;Integrated Security=True");
                MessageBox.Show("Verbindung mit Datenbank von " + Chef.Name + " war erfolgreich.", "Verbindung erfolgt", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Verbindung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Grubelix_Click(object sender, EventArgs e)
        {
            try
            {
                SQL_Edit sqlTest = new SQL_Edit();
                sqlTest.SqlConnect("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\mariu\\Source\\Repos\\TestfallDB\\TestfallDB\\TestDatenbank_Marius.mdf;Integrated Security=True;Connect Timeout=30");
                MessageBox.Show("Verbindung mit Datenbank von " + Chef.Name + " war erfolgreich.", "Verbindung erfolgt", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Verbindung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
