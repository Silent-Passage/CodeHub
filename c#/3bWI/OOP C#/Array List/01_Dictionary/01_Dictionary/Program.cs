using System;
using System.Collections;
using System.Collections.Generic;//wird für das Ditionary gebraucht
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//In diesem Projekt werden verschiedene grundlegende Methoden und Programmiertechniken mit einem Dictionary gezeigt

namespace _01_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Füllen des Dictionary bei der Erstellung des Objekts
            Dictionary<String, String> My_Dictionary = new Dictionary<string, string>()
            {
                //key   Value
                { "0987", "Malcolm Young"},
                { "1357", "Brian Johnson"},
                { "8642", "Angus Young"},
                { "3175", "Phil Rudd"},
                { "8646", "Cliff William"}
            };
            //Füllen des Dictionarys mit Add()
            My_Dictionary.Add("1234", "John Bonham");
            My_Dictionary.Add("6789", "Jimmy Page");
            My_Dictionary.Add("4567", "Robert Plant");
            My_Dictionary.Add("5432", "John Paul Jones");

            //Ausgabe aller Daten
            foreach (KeyValuePair<String, String> item in My_Dictionary)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }

            Console.WriteLine("\nEinzelnes Element mit einem Key ausgeben");
            Console.ReadLine();
            Console.WriteLine(My_Dictionary["6789"]);
            Console.WriteLine();

            //Der Key soll eingegeben werden, um eine falsche Eingabe zu behandeln soll das ganze in einem Try und catch abgefangen werden.
            String strKey = "";
            int s = 0;
            try
            {
                Console.WriteLine("Bitte geben Sie den Key ein: ");
                strKey = Console.ReadLine();
                Console.WriteLine(My_Dictionary[strKey]);
                int i = 1 / s;
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("\nZu diesem angegebenen Schlüssel gibt es keinen Eintrag!");
            }
            catch (DivideByZeroException My_Ex)
            {
                Console.WriteLine(My_Ex.Message);
            }
            finally
            {
                Console.WriteLine("finally wird immer ausgeführt!");
            }

            Console.ReadLine();
        }
    }
}
