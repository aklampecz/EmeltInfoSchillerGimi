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
            string[,] kerdesEsValaszTomb = new string[3, 2] {   { "Szia", "Szia Én a gép vagyok" }, 
                                                                { "és te", "Én a gép vagyok" },
                                                                { "vége", "Szia Örültem Viszlát !" } };
            string kerdes ="";
            string valasz="";
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
             Console.WriteLine(valasz);
             Console.Write("Kélek nyomj enter az új kérdésedhez ! ");
             Console.ReadLine();
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
