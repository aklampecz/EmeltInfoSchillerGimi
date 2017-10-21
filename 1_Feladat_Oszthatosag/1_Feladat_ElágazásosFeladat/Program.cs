using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Feladat_ElágazásosFeladat
{
    class Program
    {
        static void Main(string[] args)
        {

            int egyikSzamOsztando, masikSzamOszto, eredmeny;
            bool oszthatoAKetSzam;
            //ellenorzott beolvasas
            Console.Write("Add meg az egyik számot (Osztandó): ");
            egyikSzamOsztando = int.Parse(Console.ReadLine());
            Console.Write("Add meg a másik számot (Osztó): ");
            masikSzamOszto = int.Parse(Console.ReadLine());
            if (masikSzamOszto.Equals(0))
            {
                Console.WriteLine("Nullával nem lehet osztani valós számok számkörében");
                Console.ReadKey();
                Environment.Exit(1);
            }

            oszthatoAKetSzam = (egyikSzamOsztando % masikSzamOszto == 0);
            if (oszthatoAKetSzam)
            {   
                Console.WriteLine("Két szám osztható egymással");
                eredmeny = egyikSzamOsztando / masikSzamOszto;
                Console.Write("Az eredmény: {0}", eredmeny);
            }
            else
	        {
                Console.WriteLine("A két szám nem osztható egymással");      
	        }
           Console.ReadKey();
           
        }
    }
}
