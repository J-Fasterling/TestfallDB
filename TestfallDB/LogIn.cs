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
    public partial class Login : Form
    {
        internal class user
        {
            //Name des Users
            public string name { get; set; }
            //Passwort des Users
            public string password { get; set; }

            public user(string sName, string sPassword)
            {
                this.name = sName;
                this.password = sPassword;
            }
        }

        Form1 startform;

        //erstellen der Benutzerkonten
        user chef = new user("JFasterling", "JFasterling");
        user jerry = new user("JDiekamp", "Jonas=Chef");
        user grubelix = new user("MGrubel", "Jonas=Chef");

        public Login()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //beendet die gesamte Anwendung
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //kontrolliert den Benutzernamen und das dazugehörige Passwort
            switch (textBox_User.Text)
            {
                case "JFasterling":
                    if (textBox_Pas.Text == chef.password)
                    {
                        startform = new Form1(chef.name);
                        startform.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Das Passwort war falsch! Bitte überprüfen Sie Ihre Eingabe.", "Falsches Passwort", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "JDiekamp":
                    if (textBox_Pas.Text == jerry.password)
                    {
                        startform = new Form1(jerry.name);
                        startform.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Das Passwort war falsch! Bitte überprüfen Sie Ihre Eingabe.", "Falsches Passwort", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "MGrubel":
                    if (textBox_Pas.Text == grubelix.password)
                    {
                        startform = new Form1(grubelix.name);
                        startform.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Das Passwort war falsch! Bitte überprüfen Sie Ihre Eingabe.", "Falsches Passwort", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                default:
                    MessageBox.Show("Dieser Benutzer existiert nicht.", "Fehlerhafte Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            //Eingabe mit der Enter-Taste bestätigen
            if (e.KeyCode == Keys.Enter)
            {
                this.button1.PerformClick();
            }
        }

        private void textBox_User_Click(object sender, EventArgs e)
        {
            //TextBox Text wird beim Draufklicken gelöscht
            textBox_User.Clear();
        }

        private void textBox_Pas_Click(object sender, EventArgs e)
        {
            //TextBox Text wird beim Draufklicken gelöscht
            textBox_Pas.Clear();
        }
    }
}
