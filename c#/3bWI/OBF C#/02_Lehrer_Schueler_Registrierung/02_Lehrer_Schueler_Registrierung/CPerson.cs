using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//neu
using System.Windows.Forms; //Notwendig für die Messagebox

namespace _02_Lehrer_Schueler_Registrierung
{
    [Serializable()] //Attribut zur Speocherung der Objekte
    public class CPerson//public ist notwendig für die Speicherung im XML-Format
    {
        //Eigenschaften (Felder, Eigenschaftsmethoden)     
        public String strSchulpartner { get; set; }
        public String strVorname { get; set; }
        public String strNachname { get; set; }
        public int iJahrgang { get; set; }
        public String strWohnort { get; set; }
        public String strStraße { get; set; }
        public String strHausnummer { get; set; }

        //Konstruktoren
        public CPerson()//Benutzerdefinierter Standardkonstruktor: auch notwendig fpr die XML-Serialisierung
        {
            this.strSchulpartner = string.Empty;
            this.strVorname = string.Empty;
            this.strNachname = string.Empty;
            this.iJahrgang = int.MinValue;
            this.strWohnort = string.Empty;
            this.strStraße = string.Empty;
            this.strHausnummer = string.Empty;
        }

        //Konstruktor mit Übergabeparameter
        public CPerson(string strSchulpartnerK, string strVornameK, string strNachnameK, int iJahrgangK, string strWohnortK, string strStraßeK, string strHausnummerK)
        {
            this.strSchulpartner = strSchulpartnerK;
            this.strVorname = strVornameK;
            this.strNachname = strNachnameK;
            this.iJahrgang = iJahrgangK;
            this.strWohnort = strWohnortK;
            this.strStraße = strStraßeK;
            this.strHausnummer = strHausnummerK;
        }

        //Methode für die Ausgabe
        public void vAusgabe()
        {

            MessageBox.Show("Schulpartner:\t" + strSchulpartner + "\nVorname:\t" + strVorname + "\nNachname:\t" + strNachname + "\nJahrgang:\t" + iJahrgang + "\nWohnort:\t" + strWohnort + "\nStraße\t\t" + strStraße + "\nHausnummer:\t" + strHausnummer, "Ausgabe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
