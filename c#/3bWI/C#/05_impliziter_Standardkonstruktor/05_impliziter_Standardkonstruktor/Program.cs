using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_impliziter_Standardkonstruktor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CPunkt My_CPunkt = new CPunkt();//Erstellen eines Objekts; mit Speicherplatzreservierung

            Console.WriteLine("Die x - Koordinate lautet: {0}", My_CPunkt.iXKoordinate);
            Console.WriteLine("Die y - Koordinate lautet: " + My_CPunkt.iYKoordinate.ToString());
            //.ToString() = Explizite Umwandlung in eine Zeichenkette
            Console.WriteLine();
            Console.WriteLine("Die Werte wurden vom impliziten parameterlosen Standarkonstruktor zugewiesen");

            Console.ReadLine();
        }
    }
}
