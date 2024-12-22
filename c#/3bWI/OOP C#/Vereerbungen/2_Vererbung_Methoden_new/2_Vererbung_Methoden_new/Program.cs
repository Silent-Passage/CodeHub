using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _2_Vererbung_Methoden_new.CLuftfahrzeug;

namespace _2_Vererbung_Methoden_new
{
    class Program
    {
        static void Main(string[] args)
        {
            CLuftfahrzeug My_Luftfahrzeug = new CLuftfahrzeug();
            My_Luftfahrzeug.vStarten();

            CHubschrauber My_Hubschrauber = new CHubschrauber();
            My_Hubschrauber.vStarten();

            Console.ReadLine();
        }
    }
}
