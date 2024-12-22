using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ArrayList_Einfuehrung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Datencontainer
            //Collection-Initializer: Elemente hinzufügen
            ArrayList ArrListe = new ArrayList() { 1, 2, 3, 4, };
            String strName = String.Empty;
            Boolean blnVar = false;
            CPerson My_Person1 = new CPerson();
            CPerson My_Person = new CPerson();

            My_Person.strVorname = "Max";
            My_Person.strNachname = "Mustermann";
            //Befüllen einer ArrayList: der Datentyp in einem Array ist immer object!
            //Daher muss jeder andere Datentyp in ein Object umgewandelt werden
            ArrListe.Add(true);
            ArrListe.Add(1.2345);
            ArrListe.Add("Das ist eine Zeichenkette");
            ArrListe.Add(My_Person);
            //Auslesen einer ArrayList mit notwendiger Datentypumwandlung
            //Das ist der wesentliche Nachteil der Arraylist
            blnVar = (Boolean)ArrListe[4];
            strName = (String)ArrListe[6];
            My_Person1 = (CPerson)ArrListe[7];
            //Löschen eines Elementes
            //mit Remove
            ArrListe.Remove("Das ist eine Zeichenkette");
            //mit RemoveAt(Index)
            ArrListe.RemoveAt(6);//Beim löschen des Objekts My_Person muss berücksichtigt
            //werden, dass ein Element davor schon gelöscht wurde!
            //mit RemoveRange(Startindex, Anzahl der zu löschenden Elemente) können mehrere
            //zusammenhängende Elemente gelöscht werden
            ArrListe.RemoveRange(1, 2);
            foreach (object Item in ArrListe)
            {
                Console.WriteLine(Item.ToString());
            }
            Console.ReadKey();


        }
    }
}
