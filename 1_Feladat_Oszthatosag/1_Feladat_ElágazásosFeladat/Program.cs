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
            Boolean oszthatoAKetSzam;
            // 2. lépés ellenorzott beolvasas kell
            Boolean vanOlyanSzamAmiNemFelelMeg;
            vanOlyanSzamAmiNemFelelMeg = true;// Most VAN mivel még egyszám sincs tehát nem felel meg semmi!
            do
            {
                Console.Write("Add meg az egyik számot (Osztandó): ");
                egyikSzamOsztando = int.Parse(Console.ReadLine());
                Console.Write("Add meg a másik számot (Osztó): ");
                masikSzamOszto = int.Parse(Console.ReadLine());
                if (egyikSzamOsztando < 0 || masikSzamOszto <= 0)
                {
                    vanOlyanSzamAmiNemFelelMeg = true;
                    Console.WriteLine("A feladat szerint Pozitiv számok kellenek és az osztó nem lehet nulla, valós számok osztása számkörében");
                }
                else
                {
                    vanOlyanSzamAmiNemFelelMeg = false;
                }
            } while (vanOlyanSzamAmiNemFelelMeg);


            //2. lépés mivel van beolvasás vizsgálat nem kell ez a feltétel most
            //if (masikSzamOszto.Equals(0))
            //{
            //    Console.WriteLine("Nullával nem lehet osztani valós számok számkörében");
            //    Console.ReadKey();
            //    Environment.Exit(1);
            //}

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
