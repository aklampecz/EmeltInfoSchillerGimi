using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] karakterekTomb = new string[200];
            //int[] array1 = new int[5];
            Console.WriteLine("Adjál meg nekem 5 számot :) ");
            int tombszamlalo = 0; 
            while (Console.ReadLine() != "a") {
                karakterekTomb[tombszamlalo]= Console.ReadLine();
                tombszamlalo++;
            }
            //for (int i = 0; i < 5; i++)
            //{
            //    //array1[i] = int.Parse(Console.ReadLine());
            //    karakterekTomb[i] = Console.ReadLine();
            //}
            Console.WriteLine("Én mint a számítógép most kiírom amit te irtál :)");
            Console.ReadLine();
            int tombelemekSzama = tombszamlalo;
            tombszamlalo = 0;
            foreach (var e in karakterekTomb)
            {
                if (tombszamlalo != tombelemekSzama)
                {
                    Console.WriteLine("Ezt irtad te :) = " + e);
                }
                else
                {
                    break;
                }
                tombszamlalo++;
            }

            Console.ReadKey();
        }
    }
}
