using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Polymorphie_new
{
    public class Gnom //Basisklasse
    {
        public void vBewegen()
        {
            Console.WriteLine("Der Gnom bewegt sich!");
        }
    }
    public class WaldGnom : Gnom
    {
        public new void vBewegen()
        {
            Console.WriteLine("Der Waldgnom schlendert durch den Hain!");
        }
    }
    public class WasserGnom : Gnom
    {
        public new void vBewegen()
        {
            Console.WriteLine("Der Wassergnom durchschwimmt den Atlantik!");
        }
    }
    class Programm
    {
        static void Main(string[] args) 
        {
            //Deklaration eines Arrays vom Datentyp der Basisklasse
            Gnom[] arr_Gnom = new Gnom[3];//Drei Elemente im Array
            arr_Gnom[0] = new Gnom();
            arr_Gnom[1] = new WaldGnom();
            arr_Gnom[2] = new WasserGnom();

            foreach(Gnom item in arr_Gnom) 
            { 
                item.vBewegen();
            }
            Console.Read();
        }
    }
}
