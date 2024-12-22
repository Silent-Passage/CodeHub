using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Statische_Methode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CCar My_Car = new CCar(); //Für die statische Methode muss man kein Objekt erzeugen für eine nicht statische Methode schon
            Console.WriteLine("Bitte geben Sie eine PS Zahl an: ");
            Console.WriteLine(CCar.PSToKW(Convert.ToDouble(Console.ReadLine()))); //Aufruf der statischen Methode
            Console.WriteLine("kW");
            My_Car.Abfahren(); //Für den Aufruf einer Instanz- (Objekt-) Methode benötigt man ein objekt
            Console.ReadLine();
        }
    }
}
