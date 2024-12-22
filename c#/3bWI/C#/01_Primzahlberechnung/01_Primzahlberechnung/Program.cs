using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Primzahlberechnung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 iZahl = 0;
            Boolean blnPrimzahl = true;
            String strWiederholung = "";

            do
            {
                Console.Title = "Primzahlenbereich by Raphael";
                Console.WriteLine("Bitte geben Sie eine natürliche Zahl ein:\n");
                try
                {
                    iZahl = Convert.ToInt32(Console.ReadLine());
                    if (iZahl <= 1)
                    {
                        Console.WriteLine("Bitte geben Sie eine natürliche Zahl größer als 1 ein!");
                    }
                    else
                    {
                        for (Int32 i = 2; i < iZahl; i++)
                        {
                            if (iZahl % i == 0)
                            {
                                blnPrimzahl = false;
                                break;
                            }
                        }

                        if (blnPrimzahl)
                        {
                            Console.WriteLine("Die Zahl " + iZahl + " ist eine Primzahl!");
                        }
                        else
                        {
                            Console.WriteLine("Die Zahl " + iZahl + " ist keine Primzahl!");
                        }
                    }
                }
                catch (Exception ex) //Exceptionobjekt (=Ausnahmeobjekt) Exception Klassenname; ex Objekt
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Bitte geben Sie eine natürliche Zahl ein!");
                }




                Console.WriteLine("\nWollen Sie das Programm wiederholen? y/n");

                strWiederholung = Console.ReadLine();
                blnPrimzahl = true;
                Console.Clear();

            } while (strWiederholung == "y");
            
        }
    }
}
