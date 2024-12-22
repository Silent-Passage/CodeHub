using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_impliziter_Standardkonstruktor
{
    class CPunkt
    {
        private int _iXKoordinate;//Feld

        public int iXKoordinate//Eigenschaftsmethode
        {
            get { return _iXKoordinate; }//getter
            set { _iXKoordinate = value; }//setter
        }

        private int _iYKoordinate;

        public int iYKoordinate//Eigenschaftsmethode
        {
            get { return _iYKoordinate; }//getter
            set { _iYKoordinate = value; }//setter
        }
    }

}
