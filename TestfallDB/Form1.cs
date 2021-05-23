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
        GlobalVariables gGlobal = new GlobalVariables();

        public Form1(string sUser)
        {
            InitializeComponent();

            //Stellt Verbindung mit Datenbank des ausgewählten Users her
            switch (sUser)
            {
                case "JFasterling":
                    sqlServer = new SQL_Edit("Data Source = FASTLA0030\\TESTFALLSERVER; Initial Catalog = TestfallDatenbank; Integrated Security = True; MultipleActiveResultSets=True");
                    connectToData();
                    break;

                case "JDiekamp":
                    sqlServer = new SQL_Edit("Data Source=JEREMIAS\\SET_SERVER;Initial Catalog=TestfallDB;Integrated Security=True; MultipleActiveResultSets=True");
                    connectToData();
                    break;

                case "MGrubel":
                    sqlServer = new SQL_Edit("Data Source=DESKTOP-DN676JK\\TESTFALLDATEN;Initial Catalog=TestfallDB;Integrated Security=True;MultipleActiveResultSets=True");
                    connectToData();
                    break;

                default:
                    MessageBox.Show("Fehler beim herstellen der Datenbankverbindung", "Verbindungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void connectToData()
        {
            try
            {
                sqlServer.SqlToComponent("Bauteile", gGlobal);
                sqlServer.SqlToTestcase("Testfaelle", gGlobal);

                gGlobal.ShowDataToListView(listView2);
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
                    testSerializer.Serialize(fs, gGlobal.allTestcases);
                    fs.Close();
                }    
           }
           catch (Exception ex)
           {
                MessageBox.Show(ex.Message);
           }
        }


        /// <summary>
        /// Speichert Bauteildaten der Datenbank in externer Xml-Datei
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
                    testSerializer.Serialize(fs, gGlobal.allComponents);
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
                        gGlobal.allTestcases = (List<Testcase>)testDeserializer.Deserialize(sReader);
                        fileStream.Close();

                        sqlServer.deleteAllData("Testfaelle");

                        foreach (Testcase test in gGlobal.allTestcases)
                        {
                            sqlServer.AddTest(test.Testname, test.Precondition, test.Velocity, test.ExpectedResult);
                        }
                        //connectToData();
                        gGlobal.ShowDataToListView(listView2);
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
            //Abfrage, ob die eigene Datenbank überschrieben werden soll
            DialogResult result = MessageBox.Show("Beim Laden der Datei werden Ihre bisherigen Datenbankdatein überschrieben. Wollen SIe trotzdem fortfahren?",
                    "Achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                try
                {
                    XmlSerializer compDeserializer = new XmlSerializer(typeof(List<Components>));
                    OpenFileDialog file = new OpenFileDialog();

                    //FileDialog um Xml Datei zu suchen
                    file.InitialDirectory = "c:\\";
                    file.Filter = "xml files (*.xml)|*.xml";
                    file.FilterIndex = 2;
                    file.RestoreDirectory = true;

                    if (file.ShowDialog() == DialogResult.OK)
                    {
                        var fileStream = file.OpenFile();

                        StreamReader sReader = new StreamReader(fileStream);
                        gGlobal.allComponents.Clear();
                        gGlobal.allComponents = (List<Components>)compDeserializer.Deserialize(sReader);
                        fileStream.Close();

                        sqlServer.deleteAllData("Bauteile");

                        foreach (Components comp in gGlobal.allComponents)
                        {
                            sqlServer.AddComp("Bauteil", comp.Component);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void benutzerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.menuStrip1.ForeColor = Color.Black;
        }

        private void listView2_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(listView2.SelectedItems.Count > 0)
            {
                label_Precondition.Text = e.Item.SubItems[2].Text;
                label_Result.Text = e.Item.SubItems[4].Text;
                label_Velocity.Text = e.Item.SubItems[3].Text + " km/h";
            }
        }

        private void button_NIO_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                listView2.FocusedItem.BackColor = Color.Red;
            }
        }

        private void button_NR_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                listView2.FocusedItem.BackColor = Color.Gray;
            }
        }

        private void button_IO_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                listView2.FocusedItem.BackColor = Color.Green;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkAllCheckboxes();
        }

        private void checkBox_30_CheckedChanged(object sender, EventArgs e)
        {
            checkAllCheckboxes();
        }

        private void checkBox_50_CheckedChanged(object sender, EventArgs e)
        {
            checkAllCheckboxes();
        }

        private void checkBox_100_CheckedChanged(object sender, EventArgs e)
        {
            checkAllCheckboxes();
        }

        private void checkBox_150_CheckedChanged(object sender, EventArgs e)
        {
            checkAllCheckboxes();
        }

        private void fillTestOverview(bool isIncluded, int velocity, CheckBox check)
        {
            if (check.Checked && !isIncluded)
            {
                gGlobal.listToTest.AddRange(sqlServer.sortByVelocity(velocity));
                gGlobal.ShowDataToListView(listView2);
                isIncluded = true;
            }
        }


        private void checkAllCheckboxes()
        {
            gGlobal.listToTest.Clear();

            fillTestOverview(gGlobal.is0Included, 0, checkBox_0);
            fillTestOverview(gGlobal.is30Included, 30, checkBox_30);
            fillTestOverview(gGlobal.is50Included, 50, checkBox_50);
            fillTestOverview(gGlobal.is100Included, 100, checkBox_100);
            fillTestOverview(gGlobal.is130Included, 130, checkBox_130);
        }
    }
}
