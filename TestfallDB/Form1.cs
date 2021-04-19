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

        }

        #region Benutzerauswahl

        private void Chef_Click(object sender, EventArgs e)
        {
            try
            {
                Components dataComponents = new Components();

                SQL_Edit sqlTest = new SQL_Edit("Data Source = FASTLA0030\\TESTFALLSERVER; Initial Catalog = TestfallDatenbank; Integrated Security = True");
                MessageBox.Show("Verbindung mit Datenbank von " + Chef.Name + " war erfolgreich.", "Verbindung erfolgt", MessageBoxButtons.OK);
                sqlTest.SqlAdd("Bauteile", "Bauteil", "Marius ist klasse!");
                sqlTest.SqlToComponent("Bauteile",dataComponents);

                dataComponents.ShowDataToListView(listView1);
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
                Components dataComponents = new Components();

                SQL_Edit sqlTest = new SQL_Edit("Data Source=JEREMIAS\\SET_SERVER;Initial Catalog=TestfallDB;Integrated Security=True");
                MessageBox.Show("Verbindung mit Datenbank von " + Jerry.Name + " war erfolgreich.", "Verbindung erfolgt", MessageBoxButtons.OK);
                sqlTest.SqlToComponent("Bauteile", dataComponents);

                dataComponents.ShowDataToListView(listView1);
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
                Components dataComponents = new Components();

                SQL_Edit sqlTest = new SQL_Edit("Data Source=DESKTOP-DN676JK\\TESTFALLDATEN;Initial Catalog=TestfallDB;Integrated Security=True;MultipleActiveResultSets=True");
                sqlTest.SqlAdd("Bauteile", "Bauteil", "Marius ist klasse!");
                MessageBox.Show("Verbindung mit Datenbank von " + Grubelix.Name + " war erfolgreich.", "Verbindung erfolgt", MessageBoxButtons.OK);
                sqlTest.SqlToComponent("Bauteile", dataComponents);

                dataComponents.ShowDataToListView(listView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Verbindung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void benutzerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
