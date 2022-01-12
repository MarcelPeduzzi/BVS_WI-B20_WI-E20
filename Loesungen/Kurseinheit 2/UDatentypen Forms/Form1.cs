using System;
using System.Windows.Forms;

namespace UDatentypen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            string nachname, vorname, strasse, plz, ort;
            int alter;
            double gehalt;

            nachname = "Peduzzi";
            vorname = "Marcel";
            strasse = "Dorfstrasse 21";
            plz = "9306";
            ort = "Freidorf";
            alter = 49;
            gehalt = 5000;

            LblAnzeige.Text = "Adresse: " + "\n" + vorname + " " + nachname +
                "\n" + strasse + "\n" + plz + " " + ort + "\n" + "\n" +
                "Alter: " + alter + "\n" + "Gehalt: " + gehalt;
        }
    }
}
