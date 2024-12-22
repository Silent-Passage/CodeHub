using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Vererbung_Methode_Virtual
{
    public class CLuftfahrzeug
    {
        public virtual void vStarten()
        {
            Console.WriteLine("Luftfahrzeug startet!");
        }
    }

    //1.Möglichkeit: Übernahme der Methode
    public class CHubschrauber : CLuftfahrzeug
    {

    }

    //2.Möglichkeit: Überdecken der Methode mit new
    public class CLuftschiff : CLuftfahrzeug
    {
        public new void vStarten() 
        {
            Console.WriteLine("Das Luftschiff hebt ab!");
        }
    }

    public class CBallon : CLuftschiff
    {
        //Eine mit new überdeckte Methode kann nur wieder mit new modifizierte werden.
        //Die Methode mit override überschreiben funktioniert nicht mehr
        public new void vStarten()
        {
            Console.WriteLine("Der Ballon fährt ab!");
            //Mit base kann auf die Methode der Oberklasse zugegriffen werden
            base.vStarten();
        }
    }

    //3. Möglichkeit: Überschreiben der Methode mit override
    public class CRakete : CLuftfahrzeug
    {
        public override void vStarten()
        {
            Console.WriteLine("3, 2, 1.........Lift off");
        }
    }

    //Zusätzliche Überladen der geerbten Methode
    //Überladen: Methode mit gleichen Rückgabewert
    public class CBemannteRakete : CRakete
    {
        //Versiegelte Methode kann weiter vererbt, aber nicht mehr überschrieben werden
        //public override void vStarten()
        //{
        //    Console.WriteLine("3, 2, 1.........Lift off");
        //}

        //Die vererbte Methode der Basisklasse steht aber immer noch zur Verfügung
        public void vStarten(int iAnzahlAstronauten)
        {
            Console.WriteLine(iAnzahlAstronauten + " Astronauten sind zugestiegen");
        }
    }
}
