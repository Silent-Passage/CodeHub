using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Konstruktor_mit_Parameterliste
{
    internal class CBankkunde
    {
        private Double _dblGuthaben;
		public Double dblGuthaben
		{
			get { return _dblGuthaben; }
			set { _dblGuthaben = value; }
		}

		private Double _fZinssatz;

		public Double fZinssatz
		{
			get { return _fZinssatz; }
			set { _fZinssatz = value; }
		}

		//Konstruktor mit Übergabeparameter

		public CBankkunde(Double dblZinssatzK, Double dblGuthabenK)
		{
			this._fZinssatz = dblZinssatzK;//Zuweisung des Wertes zum Feld
			this._dblGuthaben = dblGuthabenK;//Zuweisung des Wertes zum Feld
		}

		//Überladen eines Konstruktors

		public CBankkunde(Double dblGuthabenK)
		{
			this._fZinssatz = 0.125f;//f "sagt" dem Compiler, dass es sich um einen float Wert handelt, ansonsten Fehlermeldung
			this._dblGuthaben = dblGuthabenK;
		}

		public void vAusgabe()
		{
			Console.WriteLine("Das Guthaben des Kunden ist: {0}", this._dblGuthaben);
			Console.WriteLine("Der Zinssatz für dieses Konto beträgt: {0}", this._fZinssatz);
		}

	} 
}
