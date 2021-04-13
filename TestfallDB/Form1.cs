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
                SQL_Edit sqlTest = new SQL_Edit();
                sqlTest.SqlConnect("Data Source=FASTLA0030\\TESTFALLSERVER;Initial Catalog=TestfallDatenbank;Integrated Security=True");
                MessageBox.Show("Verbindung mit Datenbank von " + Chef.Name + " war erfolgreich.", "Verbindung erfolgt", MessageBoxButtons.OK);
                sqlTest.SqlAdd("Bauteile", "Bauteil", "Test");
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
                MessageBox.Show("Verbindung mit Datenbank von " + Jerry.Name + " war erfolgreich.", "Verbindung erfolgt", MessageBoxButtons.OK);
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
                sqlTest.SqlConnect("Data Source=DESKTOP-DN676JK\\TESTFALLDATEN;Initial Catalog=TestfallDB;Integrated Security=True");
                sqlTest.SqlAdd("Bauteile", "Bauteil", "Marius ist klasse!");
                MessageBox.Show("Verbindung mit Datenbank von " + Grubelix.Name + " war erfolgreich.", "Verbindung erfolgt", MessageBoxButtons.OK);
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
    }
}
