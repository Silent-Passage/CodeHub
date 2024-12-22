using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Reise_nach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CReisender CReisender = new CReisender();

            Console.WriteLine("Mit der Angabe Ihres Namens und Ihres momentanen aufenthaltsorts melden Sie sich für eine Weltreise an!");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Bitte geben Sie den Vorname des Reisenden ein: ");
            CReisender.strVorname = Console.ReadLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Bitte geben Sie den Nachname des Reisenden ein: ");
            CReisender.strNachname = Console.ReadLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Bitte geben Sie den Aufenthaltsort des Reisenden ein: ");
            CReisender.strAufenthaltsort = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"Die Daten des Reisenden sind:");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Vorname: {CReisender.strVorname}");
            Console.WriteLine($"Nachname: {CReisender.strNachname}");
            Console.WriteLine($"Aufenthaltsort: {CReisender.strAufenthaltsort}");
            Console.WriteLine("-----------------------------------------------");

            string strWiederholung;

            do
            {
                Console.Write("Geben Sie das Reiseziel des Reisenden ein: ");
                string strReiseziel = Console.ReadLine();

                if (CReisender.bKontrolle(strReiseziel))
                {
                    Console.Clear();
                    Console.WriteLine("Reiseziel und Aufenthaltsort sind gleich. Die Reise ist nicht möglich.");
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine($"Die Daten des Reisenden sind:");
                    Console.WriteLine($"Vorname: {CReisender.strVorname}");
                    Console.WriteLine($"Nachname: {CReisender.strNachname}");
                    Console.WriteLine($"Aufenthaltsort: {CReisender.strAufenthaltsort}");
                    
                }
                else
                {
                    Console.Clear();
                    CReisender.strAufenthaltsort = strReiseziel;
                    Console.WriteLine("Reiseziel wurde erreicht! Sie sind nun in " + strReiseziel);
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine($"Die Daten des Reisenden sind:");
                    Console.WriteLine($"Vorname: {CReisender.strVorname}");
                    Console.WriteLine($"Nachname: {CReisender.strNachname}");
                    Console.WriteLine($"Aufenthaltsort: {CReisender.strAufenthaltsort}");

                }

                Console.WriteLine("-----------------------------------------------");
                
                Console.Write("Möchten Sie ein neues Reiseziel eingeben? (J/n): ");
                strWiederholung = Console.ReadLine();
                Console.Clear();

            } while (strWiederholung == "j");

            Console.ReadLine();
        }
    }
}

    



