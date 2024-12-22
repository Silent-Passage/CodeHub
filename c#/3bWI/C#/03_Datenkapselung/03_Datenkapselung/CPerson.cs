using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Datenkapselung
{
    internal class CPerson
    {
        //Erstellen einer Eigenschaft mit propfull
        //kurze Variante: prob

        private string _strVorname;//Feld ist nur noch innerhalb der Klasse sichtbar! => Datenkapselung

        public string strVorname //Eigenschaftsmethode: Container für Setter und Getter
        {
            get { return _strVorname; }//auslesen des Feldes "getter"
            set { _strVorname = value; }//setzen des Wertes "setter"
        }
        public String strNachname { get; set; } //kurze Schreibweise prop

        private Int16 _iAlter;

        public Int16 iAlter
        {
            get 
            {
                return _iAlter;
            }
            set
            {
                if (value >= 0 && value <= 130)
                {
                    _iAlter = value;
                    Console.WriteLine("Das Alter der Person wurde gespeichert!");
                }
                else
                {
                    Console.WriteLine("Unzulässige Wert!");
                }
            }
        }
        public void vAusgabe()
        {

        }
    }

}
