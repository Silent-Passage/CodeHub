using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Statische_Klasse
{
    class CMathOperationen
    {
        public static Double dblAddition(params Double[] arr_dblValues) //Mit dem Schlüsselwort params kann eine beliebige
                                                                        //Anzahl an Übergabeparameter an die Funktion übergeben werden
        {
            Double dblSumme = 0;
            foreach (Double item in arr_dblValues)
            {
                dblSumme += item;
            }
            return dblSumme;
        }
        //Hü: Multiplikation


        public static Double dblMultiplikation(params Double[] arr_dblValues) //Mit dem Schlüsselwort params kann eine beliebige
                                                                              //Anzahl an Übergabeparameter an die Funktion übergeben werden
        {
            Double dblProdukt = 0;
            foreach (Double item in arr_dblValues)
            {
                dblProdukt *= item;
            }
            return dblProdukt;
        }
    }
}