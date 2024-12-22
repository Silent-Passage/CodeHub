using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Datenkapselung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CPerson MY_Person = new CPerson();
            //Eingabe Alter
            Console.WriteLine("Bitte geben Sie das Alter der zu registrierenden Person ein:");
            
            MY_Person.iAlter = Convert.ToInt16(Console.ReadLine());//Setter wird aufgerufen

            Console.WriteLine("-----------------------------------------------");

            Console.ReadLine();
            Console.WriteLine("Das Alter der registrierten Person ist {0}!", MY_Person.iAlter);//Getter wird aufgerufen

            //My_Person.vAusgabe();
            Console.ReadLine();
        }
    }
}
