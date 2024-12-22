using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_benutzerdef_Standardkonstruktor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CSchiff My_CSchiff = new CSchiff();
            CSchiff My_CSchiff2 = new CSchiff();

            //1.Variante
            Console.WriteLine("Die x-Koordinate des Schiffs = {0}", My_CSchiff.iXKoordinate);
            Console.WriteLine("Die y-Koordinate des Schiffs = {0}", My_CSchiff.iYKoordinate);
            Console.ReadLine();

            //2.Variante
            My_CSchiff2.vAusgabe();

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
