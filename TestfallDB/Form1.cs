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

            //Stellt Verbindung mit Datenbank des eingeloggten Users her
            switch (sUser)
            {
                case "JFasterling":
                    sqlServer = new SQL_Edit("Data Source = FASTLA0030\\TESTFALLSERVER; Initial Catalog = TestfallDatenbank; Integrated Security = True; MultipleActiveResultSets=True");
                    connectToData();
                    break;

                case "JDiekamp":
                    sqlServer = new SQL_Edit("Data Source=JEREMIAS\\SET_SERVER;Initial Catalog=TestfallDB;Integrated Security=True; MultipleActiveResultSets=True");
                    connectToData();
                    SaveToolStripMenuItem.Enabled = false;
                    testfallHinzufügenToolStripMenuItem.Enabled = false;
                    break;

                case "MGrubel":
                    sqlServer = new SQL_Edit("Data Source=DESKTOP-DN676JK\\TESTFALLDATEN;Initial Catalog=TestfallDB;Integrated Security=True;MultipleActiveResultSets=True");
                    connectToData();
                    SaveToolStripMenuItem.Enabled = true;
                    testfallHinzufügenToolStripMenuItem.Enabled = true;
                    break;

                default:
                    MessageBox.Show("Fehler beim herstellen der Datenbankverbindung", "Verbindungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            //erzeugt die Fahrzeugspezifischen Testfälle
            gGlobal.Up.CarspecificTests = sqlServer.createCarSpecificList(gGlobal.Up);
            gGlobal.Polo.CarspecificTests = sqlServer.createCarSpecificList(gGlobal.Polo);
            gGlobal.Golf.CarspecificTests = sqlServer.createCarSpecificList(gGlobal.Golf);
            gGlobal.Touareg.CarspecificTests = sqlServer.createCarSpecificList(gGlobal.Touareg);
        }

        public Form1() {}

        /// <summary>
        /// speichert die Daten der Datenbanken in Listen
        /// </summary>
        private void connectToData()
        {
            try
            {
                sqlServer.SqlToComponent("Bauteile", gGlobal);
                sqlServer.SqlToTestcase("Testfaelle", gGlobal);
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

        #region Laden/Speichern der Datenbank
        /// <summary>
        /// Datenbankdatein werden per Xml serialisiert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer testSerializer = new XmlSerializer(typeof(List<Testcase>));
                SaveFileDialog saveStream = new SaveFileDialog();

                //SaveFileDialog bearbeiten
                saveStream.Title = "Speichern der Datenbankdatein";
                saveStream.FileName = "TestfallXmlData";
                saveStream.DefaultExt = ".xml";
                saveStream.ShowDialog();

                if (saveStream.FileName != "")
                {
                    //speichert die Daten an den gewünschten ort
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
        /// Datenbankdatein werden per Xml serialisiert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ladenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer testSerializer = new XmlSerializer(typeof(List<Components>));
                SaveFileDialog saveStream = new SaveFileDialog();

                //SaveFileDialog bearbeiten
                saveStream.Title = "Speichern der Datenbankdatein";
                saveStream.FileName = "BauteilXmlData";
                saveStream.DefaultExt = ".xml";
                saveStream.ShowDialog();

                if (saveStream.FileName != "")
                {
                    //speichert die Daten an den gewünschten ort
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

                    //FileDialog bearbeiten
                    file.InitialDirectory = "c:\\";
                    file.Filter = "xml files (*.xml)|*.xml";
                    file.FilterIndex = 2;
                    file.RestoreDirectory = true;

                    if (file.ShowDialog() == DialogResult.OK)
                    {
                        var fileStream = file.OpenFile();

                        //Liest Daten aus Xml in Liste
                        StreamReader sReader = new StreamReader(fileStream);
                        gGlobal.allTestcases = (List<Testcase>)testDeserializer.Deserialize(sReader);
                        fileStream.Close();

                        //löscht vorhandenen Datenbankinhalt
                        sqlServer.deleteAllData("Testfaelle");

                        //speichert Daten in der Datenbank
                        foreach (Testcase test in gGlobal.allTestcases)
                        {
                            sqlServer.AddTest(test.Testname, test.Precondition, test.Velocity, test.ExpectedResult);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        /// <summary>
        /// Lädt Bauteile in die Datenbank
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

                    //FileDialog bearbeiten
                    file.InitialDirectory = "c:\\";
                    file.Filter = "xml files (*.xml)|*.xml";
                    file.FilterIndex = 2;
                    file.RestoreDirectory = true;

                    if (file.ShowDialog() == DialogResult.OK)
                    {
                        var fileStream = file.OpenFile();

                        //Liest Daten aus Xml in Liste
                        StreamReader sReader = new StreamReader(fileStream);
                        gGlobal.allComponents.Clear();
                        gGlobal.allComponents = (List<Components>)compDeserializer.Deserialize(sReader);
                        fileStream.Close();

                        //löscht vorhandenen Datenbankinhalt
                        sqlServer.deleteAllData("Bauteile");

                        //speichert Daten in der Datenbank
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
        #endregion

        /// <summary>
        /// gesamte Anwenung schliessen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// gibt ausgewählten Testfall in Labels aus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView2_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                label_Precondition.Text = e.Item.SubItems[2].Text;
                label_Result.Text = e.Item.SubItems[4].Text;
                label_Velocity.Text = e.Item.SubItems[3].Text + " km/h";
            }
        }


        /// <summary>
        /// setzt den Status des Testfalls beim erneuten Laden der Konfiguration
        /// </summary>
        /// <param name="status"></param>
        private void setStatus(Testcase.TestStatus status)
        {
            //nach Konfiguration suchen
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Up":
                    //setzt den Status aus der Fahrzeugspezifischen Testfallliste
                    gGlobal.Up.testcasesToShow[int.Parse(listView2.FocusedItem.SubItems[0].Text) - 1].Status = status;
                    compareStatus(gGlobal.Up, (int.Parse(listView2.FocusedItem.SubItems[0].Text) - 1));

                    //wird Testfall zum ersten mal getestet, wird die Statusleiste erhöht
                    if(gGlobal.Up.testcasesToShow[int.Parse(listView2.FocusedItem.SubItems[0].Text) - 1].alreadyTested == false)
                    {
                        gGlobal.Up.testCnt++;
                        gGlobal.Up.testcasesToShow[int.Parse(listView2.FocusedItem.SubItems[0].Text) - 1].alreadyTested = true;
                        toolStripProgressBar1.Value = gGlobal.Up.testCnt;
                    }
                    break;

                case "Polo":
                    //setzt den Status aus der Fahrzeugspezifischen Testfallliste
                    gGlobal.Polo.testcasesToShow[int.Parse(listView2.FocusedItem.SubItems[0].Text) - 1].Status = status;
                    compareStatus(gGlobal.Polo, (int.Parse(listView2.FocusedItem.SubItems[0].Text) - 1));

                    //wird Testfall zum ersten mal getestet, wird die Statusleiste erhöht
                    if (gGlobal.Polo.testcasesToShow[int.Parse(listView2.FocusedItem.SubItems[0].Text) - 1].alreadyTested == false)
                    {
                        gGlobal.Polo.testCnt++;
                        gGlobal.Polo.testcasesToShow[int.Parse(listView2.FocusedItem.SubItems[0].Text) - 1].alreadyTested = true;
                        toolStripProgressBar1.Value = gGlobal.Polo.testCnt;
                    }
                    break;

                case "Golf":
                    //setzt den Status aus der Fahrzeugspezifischen Testfallliste
                    gGlobal.Golf.testcasesToShow[int.Parse(listView2.FocusedItem.SubItems[0].Text) - 1].Status = status;
                    compareStatus(gGlobal.Golf, (int.Parse(listView2.FocusedItem.SubItems[0].Text) - 1));

                    //wird Testfall zum ersten mal getestet, wird die Statusleiste erhöht
                    if (gGlobal.Golf.testcasesToShow[int.Parse(listView2.FocusedItem.SubItems[0].Text) - 1].alreadyTested == false)
                    {
                        gGlobal.Golf.testCnt++;
                        gGlobal.Golf.testcasesToShow[int.Parse(listView2.FocusedItem.SubItems[0].Text) - 1].alreadyTested = true;
                        toolStripProgressBar1.Value = gGlobal.Golf.testCnt;
                    }
                    break;

                case "Touareg":
                    //setzt den Status aus der Fahrzeugspezifischen Testfallliste
                    gGlobal.Touareg.testcasesToShow[int.Parse(listView2.FocusedItem.SubItems[0].Text) - 1].Status = status;
                    compareStatus(gGlobal.Touareg, (int.Parse(listView2.FocusedItem.SubItems[0].Text) - 1));

                    //wird Testfall zum ersten mal getestet, wird die Statusleiste erhöht
                    if (gGlobal.Touareg.testcasesToShow[int.Parse(listView2.FocusedItem.SubItems[0].Text) - 1].alreadyTested == false)
                    {
                        gGlobal.Touareg.testCnt++;
                        gGlobal.Touareg.testcasesToShow[int.Parse(listView2.FocusedItem.SubItems[0].Text) - 1].alreadyTested = true;
                        toolStripProgressBar1.Value = gGlobal.Touareg.testCnt;
                    }
                    break;
            }
        }


        /// <summary>
        /// Setzt den Status der angezeigten Testfälle auf Fahrzeugspezifische Testfälle
        /// </summary>
        /// <param name="car"></param>
        /// <param name="index"></param>
        private void compareStatus(CarConfiguration car, int index)
        {
            foreach(Testcase test in car.CarspecificTests)
            {
                if(test.ExpectedResult == car.testcasesToShow[index].ExpectedResult)
                {
                    test.Status = car.testcasesToShow[index].Status;
                }
            }
        }

        #region Testfall validieren

        /// <summary>
        /// Testfall ist ungültig und wird rot angezeigt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_NIO_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                listView2.FocusedItem.BackColor = Color.Red;

                setStatus(Testcase.TestStatus.n_i_O);
            }
        }


        /// <summary>
        /// Testfall ist nicht durchführbar und wird auf Grau gesetzt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_NR_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                listView2.FocusedItem.BackColor = Color.Gray;

                setStatus(Testcase.TestStatus.n_D);
            }
        }


        /// <summary>
        /// Testfall ist bestanden und wird auf grün gesetzt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_IO_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                listView2.FocusedItem.BackColor = Color.Green;

                setStatus(Testcase.TestStatus.i_O);
            }
        }
        #endregion

        #region checkBoxen
        //beim wählen einer neuen Geschwindigkeit wird eine neue testliste erzeugt
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkAllCheckboxes();
        }
        private void checkBox_7_CheckedChanged(object sender, EventArgs e)
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

        //beim Ausählen aller Geschwindigkeiten werden alle ausgewählt und ausgegraut
        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            checkBox_0.Checked = checkBox2.Checked;
            checkBox_0.Enabled = !checkBox2.Checked;

            checkBox_7.Checked = checkBox2.Checked;
            checkBox_7.Enabled = !checkBox2.Checked;

            checkBox_30.Checked = checkBox2.Checked;
            checkBox_30.Enabled = !checkBox2.Checked;

            checkBox_50.Checked = checkBox2.Checked;
            checkBox_50.Enabled = !checkBox2.Checked;

            checkBox_100.Checked = checkBox2.Checked;
            checkBox_100.Enabled = !checkBox2.Checked;

            checkBox_130.Checked = checkBox2.Checked;
            checkBox_130.Enabled = !checkBox2.Checked;
        }
        #endregion

        /// <summary>
        /// fügt Geschwindigkeit zur Geschwindigkeitsliste hinzu
        /// </summary>
        /// <param name="isIncluded"></param>
        /// <param name="velocity"></param>
        /// <param name="check"></param>
        private void fillTestOverview(bool isIncluded, int velocity, CheckBox check)
        {
            if (check.Checked && !isIncluded)
            {
                gGlobal.velocityList.Add(velocity);

                isIncluded = true;
            }
        }

        /// <summary>
        /// überprüft jede Checkbox, ob sie ausgewählt ist und fügt deren Geschwindigkeit zur Geschwindigkeitslist hinzu
        /// </summary>
        private void checkAllCheckboxes()
        {
            gGlobal.velocityList.Clear();

            fillTestOverview(gGlobal.is0Included, 0, checkBox_0);
            fillTestOverview(gGlobal.is7Included, 7, checkBox_7);
            fillTestOverview(gGlobal.is30Included, 30, checkBox_30);
            fillTestOverview(gGlobal.is50Included, 50, checkBox_50);
            fillTestOverview(gGlobal.is100Included, 100, checkBox_100);
            fillTestOverview(gGlobal.is130Included, 130, checkBox_130);

            if (comboBox1.Text != "")
            {
                checkCarConfiguration();
            }
        }

        /// <summary>
        /// neue Fahrzeugtestfälle anzeigen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)

        {
            checkCarConfiguration();
        }


        /// <summary>
        /// sucht nach ausgewählter Fahrzeugkonfiguration und zeigt diese an
        /// </summary>
        protected void checkCarConfiguration()
        {    
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "Up":
                        fillCarspecificList(gGlobal.Up);
                        toolStripProgressBar1.Maximum = gGlobal.Up.toTest;
                        toolStripProgressBar1.Value = gGlobal.Up.testCnt;
                        break;

                    case "Polo":
                        fillCarspecificList(gGlobal.Polo);
                        toolStripProgressBar1.Maximum = gGlobal.Polo.toTest;
                        toolStripProgressBar1.Value = gGlobal.Polo.testCnt;
                        break;

                    case "Golf":
                        fillCarspecificList(gGlobal.Golf);
                        toolStripProgressBar1.Maximum = gGlobal.Golf.toTest;
                        toolStripProgressBar1.Value = gGlobal.Golf.testCnt;
                        break;

                    case "Touareg":
                        fillCarspecificList(gGlobal.Touareg);
                        toolStripProgressBar1.Maximum = gGlobal.Touareg.toTest;
                        toolStripProgressBar1.Value = gGlobal.Touareg.testCnt;
                        break;
                }
        }


        /// <summary>
        /// erzeugt die relevanten Testfälle für das Fahrzeug und zeigt diese an
        /// </summary>
        /// <param name="car"></param>
        private void fillCarspecificList(CarConfiguration car)
        {
            car.testcasesToShow = sqlServer.sortByComponentsAndVelocity(car.ConfigurationList, gGlobal.velocityList);

            int cnt = 1;
            foreach (Testcase test in car.testcasesToShow)
            {
                compareStatusBack(car, test);
                test.Nr = cnt;
                cnt++;
            }
            gGlobal.ShowDataToListView(listView2, car);
        }


        /// <summary>
        /// der Status eines Testfalls wird auf seinen vorher gesetzten Status zurückgesetzt
        /// </summary>
        /// <param name="car"></param>
        /// <param name="testcase"></param>
        private void compareStatusBack(CarConfiguration car, Testcase testcase)
        {
            foreach(Testcase test in car.CarspecificTests)
            {
                if(test.ExpectedResult == testcase.ExpectedResult)
                {
                    testcase.Status = test.Status;
                }
            }
        }


        /// <summary>
        /// zeigt das Fenster mit den Informationen über die Entwickler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Information info = new Information();
            info.Show();
        }

        /// <summary>
        /// zeigt das Fenster mit den hinzufügen eines neuen Testfalls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testfallHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            neuerTestfall newTest = new neuerTestfall(sqlServer, gGlobal);
            newTest.Show();
        }
    }
}
