using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Statische_Methode
{
    internal class CCar
    {
        private String _strStandort;//Instanzeigenschaft

		public String strStandort
		{
			get { return strStandort; }
			set { strStandort = value; }
		}

		public void Abfahren()//Instanzmethode
		{
			Console.WriteLine("Das Auto hat seinen Standort verlassen!");
			Console.WriteLine(PSToKW(56).ToString()); //Statische Methode, kann von einer "normalen" methode aus aufgerufen werden
		}
		public static Double PSToKW(Double dPS)
		{
			return dPS / 1.35962;
			//Von einer statischen MEthode aus kann kein nicht statisches Elemnt der Klasse erreicht werden
			//Abfahren(); Beweis der Regek 2
			//_strStandort;
		}

	}
}
