using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Statische_Eigenschaften
{
    internal class CMerchantShip
    {
        private static Int32 _iMerchantShipCounter;

        public static int iMerchantShipCounter 
        { 
           get { return _iMerchantShipCounter; }//Von außen sollte der Zähler nicht manipulierbar sein, daher nur der Getter
        }

        //Konstruktor

        public CMerchantShip() 
        {
            _iMerchantShipCounter++;
            Console.WriteLine("Das Handelsschiff wurde fertiggestellt!");
        }

        //Destruktor

        ~CMerchantShip() 
        {
            _iMerchantShipCounter--;
            Console.WriteLine("Die Anzahl der Schiffe wurde um 1 reduziert");
        }
    }
}
