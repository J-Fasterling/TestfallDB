using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace TestfallDB
{
    public partial class Form1 : Form
    {
        SQL_Edit sqlServer;
        Components dataComponents = new Components();
        Testcase dataTestcases = new Testcase();

        public Form1(string sUser)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            switch (sUser)
            {
                case "JFasterling":
                    sqlServer = new SQL_Edit("Data Source = FASTLA0030\\TESTFALLSERVER; Initial Catalog = TestfallDatenbank; Integrated Security = True; MultipleActiveResultSets=True");
                    connectToData(sqlServer);
                    break;

                case "JDiekamp":
                    sqlServer = new SQL_Edit("Data Source=JEREMIAS\\SET_SERVER;Initial Catalog=TestfallDB;Integrated Security=True; MultipleActiveResultSets=True");
                    connectToData(sqlServer);
                    break;

                case "MGrubel":
                    sqlServer = new SQL_Edit("Data Source=DESKTOP-DN676JK\\TESTFALLDATEN;Initial Catalog=TestfallDB;Integrated Security=True;MultipleActiveResultSets=True");
                    connectToData(sqlServer);
                    break;

                default:
                    MessageBox.Show("Fehler beim herstellen der Datenbankverbindung", "Verbindungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Benutzerauswahl

        private void connectToData(SQL_Edit sqlCon)
        {
            try
            {
                sqlCon.deleteAllData("Bauteile");
                sqlCon.deleteAllData("Testfaelle");
                sqlCon.SqlAdd("Bauteile", "Bauteil", "Test");

                sqlCon.SqlToComponent("Bauteile", dataComponents);
                sqlCon.SqlToTestcase("Testfaelle", dataTestcases);

                dataComponents.ShowDataToListView(listView1);
                dataTestcases.ShowDataToListView(listView2);
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Wenn Sie jetzt fortfahren wird Ihre Datenbank Vorlage für alle anderen Datenbanken. Wollen Sie trotzdem fortfahren?",
                "Achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    XmlSerializer testSerializer = new XmlSerializer(typeof(List<Testcase>));
                    XmlSerializer compSerializer = new XmlSerializer(typeof(List<Components>));

                    Stream sWriteTest = File.OpenWrite("Testcases_Backup");
                    Stream sWriteComp = File.OpenWrite("Components_Backup");

                    testSerializer.Serialize(sWriteTest, dataTestcases.TestcaseList);
                    compSerializer.Serialize(sWriteComp, dataComponents.ComponentList);

                    sWriteTest.Close();
                    sWriteComp.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
