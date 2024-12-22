using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Erste_Klasse
{
    class Program
    {
        //Deklaration der Klasse

        public class CGnom //öffentlich (publix): wenn die Klasse in Form einer Bibliothek veröffentlicht werden soll
                           //alternativ wäre der Modifizierer "internal": Die Klasse ist nur innerhalb der Anwenung sichtbar
        {
            public Double dGroesse;
            //Deklaration eines Feldes (Membervariable = Mitglied dieser Klasse, Eigenschaft)
            //public: Variable (Eigenschaft) ist  uneingeschränkt sichtbar
            public Int16 iIQ;

            //Deklaration und Definition der Methode (Memberfunktion)

            public void vAnzeige()//void: keine Rückgabewert
            {
                Console.WriteLine("Größte:\t" + dGroesse + "m");
                Console.WriteLine("IQ:\t" + iIQ);
            }
        }
        static void Main(string[] args)
        {
            //zweizeilige Erstellung eines Objekts
            CGnom My_CGnom1; //Deklaration der Objektvaraible => Speicherplatz wird reserviert
            My_CGnom1 = new CGnom();//mit new wird der Gnoml ins Leben gerufen

            //einzeiliges Erzeugen eines Objekt: gängige Variante
            CGnom My_CGnom2 = new CGnom();

            //Veränderung der Eigenschaften (Felder)
            My_CGnom1.dGroesse = 1.20;
            My_CGnom1.iIQ = 90;
            My_CGnom2.dGroesse = 1.35;
            My_CGnom2.iIQ = 82;
            //Anzeigen der Daten durch den Aufruf der Methode
            My_CGnom1.vAnzeige();
            Console.WriteLine();
            My_CGnom2.vAnzeige();
            Console.ReadLine();//Entspricht system("pause);
            //Eingabe von Werten
            Console.WriteLine("Geben Sie bitte einen neuen Wert für die Größe des Gnoms ein!");
            try
            {
                My_CGnom1.dGroesse = Convert.ToDouble((Console.ReadLine()));
                My_CGnom1.vAnzeige();
                Console.WriteLine(My_CGnom2.dGroesse);//direkter Zugriff auf eine Eigenschaft (Feld)
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
