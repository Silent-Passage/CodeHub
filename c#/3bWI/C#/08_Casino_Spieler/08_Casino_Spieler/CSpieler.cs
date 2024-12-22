using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Casino_Spieler
{
    internal class CSpieler
    {
        //Eigenschaften

        private int _iPunkte;
        public int iPunkte
        {
            get { return _iPunkte; }
            set { _iPunkte = value; }
        }

        private string _strVorname;
        public string strVorname
        {
            get { return _strVorname; }
            set { _strVorname = value; }
        }

        private string _strNachname;
        public string strNachname
        {
            get { return _strNachname; }
            set { _strNachname = value; }
        }

        private string _strAliasname;
        public string strAliasname
        {
            get { return _strAliasname; }
            set { _strAliasname = value; }
        }

        //Konstruktoren (überladene) -> spezielle Methode
        public CSpieler(string strVornameK, string strNachnameK, string strAliasnameK)
        {
            this._strVorname = strVornameK;
            this._strNachname = strNachnameK;
            this._strAliasname = strAliasnameK;
            this._iPunkte = 0;
        }

        public CSpieler(string strVornameK, string strNachnameK, string strAliasnameK, int iPunkteK)
        {
            this._strVorname = strVornameK;
            this._strNachname = strNachnameK;
            this._strAliasname = strAliasnameK;
            this._iPunkte = iPunkteK;
        }

        //Methoden
        public void vSpielen()
        {
            Random rnd = new Random();
            int iPunkte = rnd.Next(-30, 30 + 1);

            _iPunkte += iPunkte;
            Console.WriteLine("Spieler " + strAliasname + " hat " + iPunkte + " Punkte erhalten");
        }

        public void vSpielerAusgabe()
        {
            Console.WriteLine("Spieler:\t{0}", strAliasname);
            Console.WriteLine("Punkte:\t\t{0}", iPunkte);
        }
    }
}
