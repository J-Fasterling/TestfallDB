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
    public partial class neuerTestfall : Form1
    {
        //Objekt der sqlEdit Klasse
        private SQL_Edit sqlServer;
        //Objekt der GlobalVariables Klasse
        private GlobalVariables gGlobal;
        public neuerTestfall(SQL_Edit sql, GlobalVariables global)
        {
            InitializeComponent();
            sqlServer = sql;
            gGlobal = global;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //schliesst das Fenster
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //fügt den Testfall hinzu und "kontrolliert, ob er zu den Fahrzeugkonfigurationen passt
            if(!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(comboBox1.Text) && !String.IsNullOrEmpty(comboBox2.Text))
            {
                sqlServer.AddTest(comboBox1.Text, textBox1.Text, int.Parse(comboBox2.Text), textBox3.Text);
                gGlobal.Up.CarspecificTests = sqlServer.createCarSpecificList(gGlobal.Up);
                gGlobal.Polo.CarspecificTests = sqlServer.createCarSpecificList(gGlobal.Polo);
                gGlobal.Golf.CarspecificTests = sqlServer.createCarSpecificList(gGlobal.Golf);
                gGlobal.Touareg.CarspecificTests = sqlServer.createCarSpecificList(gGlobal.Touareg);

                //schliesst das Fenster
                this.Hide();
            }
            else
            {
                MessageBox.Show("Es wurden zu wenig Werte übergeben. \nErgänzen Sie die fehlenden Werte, um den Testfall hinzuzufügen.", "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
