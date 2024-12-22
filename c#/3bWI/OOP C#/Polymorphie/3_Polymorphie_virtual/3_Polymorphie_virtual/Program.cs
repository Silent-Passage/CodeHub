using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Polymorphie_virtual
{
    public class Gnom
    {
        public virtual void vBewegen()
        {
            Console.WriteLine("Der Gnom bewegt sich!");
        }
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
            Console.WriteLine("Der Wassergnom durschwimmt den Atlantik!");
        }
    }
    public class FlussGnom : WasserGnom
    {
        //OVERRIDE GEHT NICHT MEHR WENN wenn einmal in der Basisklasse mit new überdeckt wurde!
        public override void vBewegen()
        {
            Console.WriteLine("Der Flussgnom springt den Wasserfall hinunter!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration eines Arrays von Basisdatentyp
            Gnom[] arr_Gnom = new Gnom[4];
            arr_Gnom[0] = new Gnom();
            arr_Gnom[1] = new WaldGnom();
            arr_Gnom[2] = new WasserGnom();
            arr_Gnom[3] = new FlussGnom();

            foreach (Gnom item in arr_Gnom)
            {
                item.vBewegen();
            }
            Console.Read();
        }
    }
}
