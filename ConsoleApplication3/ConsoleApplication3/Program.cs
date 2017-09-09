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
            //string[] karakterekTomb = new string[5];
            int[] array1 = new int[5];
            Console.WriteLine("Adjál meg nekem 10 számot :) ");
            for (int i = 0; i < 5; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
                //karakterekTomb[i] = Console.ReadLine();
            }
            Console.WriteLine("Én mint a számítógép most kiírom amit te irtál :)");
            Console.ReadLine();
            foreach (var e in array1)
            {
                
                Console.WriteLine("Ezt irtad te :) = " + e);
            }

            Console.ReadKey();
        }
    }
}
