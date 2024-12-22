using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Vererbung_Methode_abstrakt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verusch der Instanziirung der Basisklasse (erstellen eine Objekts)
            //CLuftfahrzeug My_CLuftfahrzeug = new CLuftfahrzeug();
            CFlugzeug My_CFlugzeug = new CFlugzeug();

            My_CFlugzeug.vStarten();
            Console.WriteLine("************************************************");
            //Nicht abstrakte Methode wurde von der Overklasse einfach übernommen
            My_CFlugzeug.vLanden();
            Console.ReadLine();

        }
    }
}
