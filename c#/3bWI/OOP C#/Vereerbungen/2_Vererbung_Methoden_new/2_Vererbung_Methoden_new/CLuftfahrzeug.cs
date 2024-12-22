using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Vererbung_Methoden_new
{
    internal class CLuftfahrzeug
    {
        protected string _strHersteller;

		public string strHersteller
		{
			get { return _strHersteller; }
			set { _strHersteller = value; }
		}
		//Methode

		public void vStarten()
		{
			Console.WriteLine("Das Luftfahrzeug startet!");
		}
		//Mit new überdecken

		public class CHubschrauber : CLuftfahrzeug
		{
			//Zusätzliche Eigenschaft
			private double _dRotordurchmesser;

			public double dRotordurchmesser
			{
				get { return _dRotordurchmesser; }
				set { _dRotordurchmesser = value; }
			}
			//Überdecken der Methode mit new (gleicher Name, gleiche Parameterliste)

			public new void vStarten()
			{
				Console.WriteLine("Der Hubschrauber hebt ab!");
			}

		}

	}
}
