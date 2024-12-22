using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Konstruktor_mit_Parameterliste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float fZinssatzE = 0;
            Double dblGuthabenE = 0;
            CBankkunde My_CBankkunde = null;//0 Pointer
            try
            {
                Console.WriteLine("Bitte geben Sie das Startguthaben des Kunden:");
                dblGuthabenE = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Wollen Sie eine bestimmten Zinssatz eingeben (y/n)?");

                if (Console.ReadLine() == "y")
                {
                    Console.WriteLine("Bitte geben Sie den Zinssatz für den Kunden an:");
                    fZinssatzE = (float)Convert.ToDouble(Console.ReadLine());//(float) Datentypumwandlung
                    My_CBankkunde = new CBankkunde(fZinssatzE, dblGuthabenE);//Bankkunde wird erstellt
                }
                else
                {
                    My_CBankkunde = new CBankkunde(dblGuthabenE);
                }
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }

            My_CBankkunde.vAusgabe();

            Console.ReadKey();
        }
    }
}
