using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Vererbung_Methode_abstrakt
{
    public abstract class CLuftfahrzeug
    {
        //Abstrakte Methode
        public abstract void vStarten();

        //Nicht abstrakte Methode
        public void vLanden()
        {
            Console.WriteLine("Das Luftfahrzeug ist geldandet");
        }
    }

    public class CFlugzeug : CLuftfahrzeug
    {
        //Überschreibten eienr abstrakten Methode
        public override void vStarten()
        {
            Console.WriteLine("Das Flugzeug startet!");        
        }
    }
}
