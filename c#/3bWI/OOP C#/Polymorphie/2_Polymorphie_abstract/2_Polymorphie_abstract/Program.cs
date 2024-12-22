using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Polymorphie_abstract
{
    public abstract class Gnom
    {
        public abstract void vBewegen();
    }
    public class WaldGnom : Gnom
    {
        public override void vBewegen()
        {
            Console.WriteLine("Der Waldgnom schlendert durch den Hain!");
        }
    }
    public class WasserGnom : Gnom
    {
        public override void vBewegen()
        {
            Console.WriteLine("Der Wassergnom durschwimmt den Atlantik");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration eines Arrays vom Basisdatentyp
            Gnom[] arr_Gnom = new Gnom[2];//Referenz auf die Basisklasse
            arr_Gnom[0] = new WaldGnom();
            arr_Gnom[1] = new WasserGnom();
            //arr_Gnom[2] = new Gnom();

            foreach (Gnom iten in arr_Gnom)
            {
                iten.vBewegen();
            }
            Console.Read();
        }
    }
}
