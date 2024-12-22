using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Vererbung_Methode_Virtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CLuftfahrzeug My_CLuftfahrzeug = new CLuftfahrzeug();//Objekt der Basisklasse
            CHubschrauber My_CHubschrauber = new CHubschrauber();
            CLuftschiff My_CLuftschiff = new CLuftschiff();
            CBallon My_CBallon = new CBallon();
            CRakete My_CRakete = new CRakete();
            CBemannteRakete My_CBemannteRakete = new CBemannteRakete();

            //My_CLuftfahrzeug.vStarten();
            //My_CHubschrauber.vStarten();
            //My_CLuftschiff.vStarten();
            //My_CBallon.vStarten();
            //My_CRakete.vStarten();
            //My_CBemannteRakete.vStarten();
            //My_CBemannteRakete.vStarten(8);

            Console.ReadLine();
        }
    }
}
