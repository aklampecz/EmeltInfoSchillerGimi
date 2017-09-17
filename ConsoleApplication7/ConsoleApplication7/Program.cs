using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] kerdesEsValaszTomb = new string[5, 2] {   { "Szia", "Szia Én a gép vagyok" }, 
                                                                { "Hogy vagy", "Jól és te?" },
                                                                 { "jól mit csinálsz", "Programozok" },
                                                                  { "Mit", "?" },
                                                                   

                                                                { "vége", "Szia jó volt veled !" } };
            string kerdes ="";
            string valasz="";
            Console.Write(".--------------------------Ez egy olyan program ami válaszol pár kérdésre-----------------. ");
            do{
            Console.Write("Kérlek írj valamit ! Ha nem tudod mit írj kérek egy \"?\" enter-t ");
             kerdes = Console.ReadLine();
             if (kerdes.Equals("?"))
             {
                 irddKiAzOsszesTudasod(kerdesEsValaszTomb);
             }
             valasz = "";
             valasz = kerdesAlapjanValasz(kerdesEsValaszTomb, kerdes, valasz);
             if (valasz.Equals(""))
             {
                 Console.WriteLine("Erre a kérdése még nem tudom a választ.Nyomj egy entert az új kérdéshez ");
                 Console.ReadLine();
                 
                }
             if (!kerdes.Equals("vége"))
             {
             Console.WriteLine(valasz);
             Console.Write("Kérlek nyomj enter az új kérdésedhez ! ");
             Console.ReadLine(); 
             } 
            }while(kerdes != "vége");
        }

        private static void irddKiAzOsszesTudasod(string[,] kerdesEsValaszTomb)
        {
            Console.WriteLine("A következőkre tudok válaszolni: ");
            for (int i = 0; i < (kerdesEsValaszTomb.Length / 2); i++)
            {
                Console.WriteLine(kerdesEsValaszTomb[i, 0]);
            }
        }

        private static string kerdesAlapjanValasz(string[,] kerdesEsValaszTomb, string kerdes, string valasz)
        {
            for (int i = 0; i < (kerdesEsValaszTomb.Length / 2); i++)
            {
                if (kerdes.Equals(kerdesEsValaszTomb[i, 0]))
                {
                    valasz = kerdesEsValaszTomb[i, 1];
                    break;
                }
            }
            return valasz;
        }
    }
}
