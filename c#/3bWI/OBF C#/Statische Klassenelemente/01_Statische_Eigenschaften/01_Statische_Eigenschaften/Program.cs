using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Statische_Eigenschaften
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String strInput = "";
            List<CMerchantShip> My_MerchantShipList = new List<CMerchantShip>();//Entspricht einem Vector in C++
            //CMerchantShip My_MerchantShip = null;

            do
            {
                Console.WriteLine("Wollen Sie ein Handelsschiff bauen (j/n)\n");
                strInput = Console.ReadLine();
                if (strInput == "j")
                {
                    //My_MerchantShip = new CMerchantShip();
                    My_MerchantShipList.Add(new CMerchantShip());
                }
            } while (strInput == "j");
            //CMerchantShip = Klassenbezieher
            if(CMerchantShip.iMerchantShipCounter == 0)//Aufruf der Klasseneigenschaft (statische Eigenschaft
            {
                Console.WriteLine("Sie können ohne Schiff leider keinen Handel betreiben");
            }
            if (CMerchantShip.iMerchantShipCounter == 1)//Aufruf der Klassen Eigenschaft (statische Eigenschaft)
            {
                Console.WriteLine("Sie sind stolzer Besitzer eines Handelsschiffs");
            }
            else
            {
                Console.WriteLine("Sie sind stolzer Besitzer einer Handelsflotte mit {0} Handelsschiffen", CMerchantShip.iMerchantShipCounter);
            }
            My_MerchantShipList[My_MerchantShipList.Count - 1] = null; //Hier wird das letzte Handelsschiff in der Liste "zerstört"

            GC.Collect(); //Gargabe Collector
            
            Console.ReadLine();
        }

    }
}
