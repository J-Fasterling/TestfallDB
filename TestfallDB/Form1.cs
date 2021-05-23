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

            //Stellt Verbindung mit Datenbank des ausgewählten Users her
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

        private void connectToData(SQL_Edit sqlCon)
        {
            try
            {
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


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Die gesamte Anwendung wird geschlossen
            Application.Exit();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {  
           try
           {
                XmlSerializer testSerializer = new XmlSerializer(typeof(List<Testcase>));
                SaveFileDialog saveStream = new SaveFileDialog();

                saveStream.Title = "Speichern der Datenbankdatein";
                saveStream.FileName = "TestfallXmlData";
                saveStream.DefaultExt = ".xml";
                saveStream.ShowDialog();

                if (saveStream.FileName != "")
                {
                    FileStream fs = (FileStream)saveStream.OpenFile();
                    testSerializer.Serialize(fs, dataTestcases.TestcaseList);
                    fs.Close();
                }    
           }
           catch (Exception ex)
           {
                MessageBox.Show(ex.Message);
           }
        }


        /// <summary>
        /// Speichert Daten der DAtenbank in externer Xml-Datei
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ladenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer testSerializer = new XmlSerializer(typeof(List<Components>));
                SaveFileDialog saveStream = new SaveFileDialog();

                saveStream.Title = "Speichern der Datenbankdatein";
                saveStream.FileName = "BauteilXmlData";
                saveStream.DefaultExt = ".xml";
                saveStream.ShowDialog();

                if (saveStream.FileName != "")
                {
                    FileStream fs = (FileStream)saveStream.OpenFile();
                    testSerializer.Serialize(fs, dataTestcases.TestcaseList);
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Laedt Testfaelle in die Datenbank
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testfälleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Beim Laden der Datei werden Ihre bisherigen Datenbankdatein überschrieben. Wollen SIe trotzdem fortfahren?",
                    "Achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                try
                {
                    XmlSerializer testDeserializer = new XmlSerializer(typeof(List<Testcase>));
                    OpenFileDialog file = new OpenFileDialog();

                    file.InitialDirectory = "c:\\";
                    file.Filter = "xml files (*.xml)|*.xml";
                    file.FilterIndex = 2;
                    file.RestoreDirectory = true;

                    if (file.ShowDialog() == DialogResult.OK)
                    {
                        var fileStream = file.OpenFile();

                        StreamReader sReader = new StreamReader(fileStream);
                        dataTestcases.TestcaseList = (List<Testcase>)testDeserializer.Deserialize(sReader);
                        fileStream.Close();

                        sqlServer.deleteAllData("Testfaelle");

                        foreach (Testcase test in dataTestcases.TestcaseList)
                        {
                            sqlServer.SqlAdd("Testfaelle", "Testname", test.Testname);
                            sqlServer.SqlAdd("Testfaelle", "Vorbedingung", test.Precondition);
                            sqlServer.SqlAdd("Testfaelle", "Geschwindigkeit", test.Velocity.ToString());
                            sqlServer.SqlAdd("Testfaelle", "Erwartetes Resultat", test.ExpectedResult);
                        }
                        sqlServer.SqlToComponent("Bauteile", dataComponents);
                        dataTestcases.ShowDataToListView(listView2);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        /// <summary>
        /// Laedt Bauteile in die Datenbank
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bauteileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Beim Laden der Datei werden Ihre bisherigen Datenbankdatein überschrieben. Wollen SIe trotzdem fortfahren?",
                    "Achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                try
                {
                    XmlSerializer compDeserializer = new XmlSerializer(typeof(List<Components>));
                    OpenFileDialog file = new OpenFileDialog();

                    file.InitialDirectory = "c:\\";
                    file.Filter = "xml files (*.xml)|*.xml";
                    file.FilterIndex = 2;
                    file.RestoreDirectory = true;

                    if (file.ShowDialog() == DialogResult.OK)
                    {
                        var fileStream = file.OpenFile();

                        StreamReader sReader = new StreamReader(fileStream);
                        dataTestcases.TestcaseList = (List<Testcase>)compDeserializer.Deserialize(sReader);
                        fileStream.Close();


                        sqlServer.deleteAllData("Bauteile");

                        foreach (Components comp in dataComponents.ComponentList)
                        {
                            sqlServer.SqlAdd("Bauteile", "Bauteil", comp.Component);
                        }
                        sqlServer.SqlToTestcase("Testfaelle", dataTestcases);
                        dataComponents.ShowDataToListView(listView1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
