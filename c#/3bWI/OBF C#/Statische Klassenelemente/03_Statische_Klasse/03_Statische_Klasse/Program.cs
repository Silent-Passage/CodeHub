using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Statische_Klasse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Funktionsweise des Schlüsselwortes params
            Console.WriteLine("Das Ergebnis der Additon lautet: " + CMathOperationen.dblAddition(-4, 7, 6).ToString());
            Console.WriteLine("Das Ergebnis der Additon lautet: " + CMathOperationen.dblAddition(6, 7, 78, 6).ToString());
            Console.WriteLine("Das Ergebnis der Multiplikation lautet: " + CMathOperationen.dblMultiplikation(-4, 7, 6).ToString());

            List<Double> dblListWerte = new List<double>();
            Boolean blnBeenden = false;
            Console.WriteLine("Geben SIe bitte Ihre Werte ein, die addiert werden sollen:");
            Console.WriteLine("Zum Abbrechen der Eingabe geben Sie 'a' ein.");

            do
            {
                try
                {
                    dblListWerte.Add(Convert.ToDouble(Console.ReadLine()));
                }
                catch
                {
                    Console.WriteLine("Sie haben die Eingabe beendet!");
                    blnBeenden = true;
                }
            } while (blnBeenden == false);
            //Aufruf der statischen Methode
            Console.WriteLine("Das Ergebnis der Addition lautet: " + CMathOperationen.dblAddition(dblListWerte.ToArray()).ToString());
            Console.ReadKey();

        }
    }
}