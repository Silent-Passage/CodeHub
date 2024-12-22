using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_benutzerdef_Standardkonstruktor
{
    internal class CSchiff
    {
        private float _iXKoordinate;
        public float iXKoordinate
        {
            get { return _iXKoordinate; } 
            set { _iXKoordinate = value; }
        }

        private float _iYKoordinate;

        public float iYKoordinate
        {
            get { return _iYKoordinate; }
            set { _iYKoordinate = value; }
        }

        public CSchiff()//Konstruktor: öffentlich, besitzt keinen Datentyp und hat den Namen der Klasse
        {
            this.iXKoordinate = 150; //über setter
            _iYKoordinate = 200;//Feld direkt ansprechen    
        }
        public void vAusgabe()
        {
            Console.WriteLine("Die x - Koordinate ist: " + _iXKoordinate);
            Console.WriteLine("Die y - Koordinate ist: " + _iYKoordinate);
        }
    }
}
