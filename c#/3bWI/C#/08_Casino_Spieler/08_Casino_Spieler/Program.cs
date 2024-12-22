using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _08_Casino_Spieler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strVorname;
            string strNachname; 
            string strAliasname;
            char cEingabe;
            int iBonusPunkte;
            string strWiederholung;
            

            CSpieler mySpieler = null;

            Console.Write("Vorname:\t");
            strVorname = Console.ReadLine();
            Console.Write("Nachname:\t");
            strNachname = Console.ReadLine();
            Console.Write("Aliasname:\t");
            strAliasname = Console.ReadLine();
            Console.WriteLine("--------------------------");


            Console.Write("Bekommt der Spieler einen Bonus? (y/n): ");
            cEingabe = Convert.ToChar(Console.ReadLine());

            if (cEingabe == 'y')
            {
                Console.Write("Bonuspunkte: ");
                try
                {
                    iBonusPunkte = Convert.ToInt32(Console.ReadLine());
                    mySpieler = new CSpieler(strVorname, strNachname, strAliasname, iBonusPunkte);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                mySpieler = new CSpieler(strVorname, strNachname, strAliasname);
            }
            
            Console.Clear();

            do
            {
                Console.WriteLine("Was möchten Sie tun?");
                Console.WriteLine("--------------------------");
                Console.WriteLine("(s) Spielen");
                Console.WriteLine("(a) Spielerausgabe\n");
               
                cEingabe = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("--------------------------");

                switch (cEingabe)
                {
                    case 's':
                        mySpieler.vSpielen();
                        break;
                    case 'a':
                        mySpieler.vSpielerAusgabe();
                        break;
                    default:
                        Console.WriteLine("Bitte geben Sie einen richtigen Wert ein!");
                        break;
                }
                Console.Write("Wiederholung? (y/n): ");
                strWiederholung = Console.ReadLine();
                Console.Clear();
            } while (strWiederholung == "y");
        }
    }
}
