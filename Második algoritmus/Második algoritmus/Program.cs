using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Második_algoritmus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem adjon meg egy számot:");
            int a = int.Parse(Console.ReadLine());
            int n = 0;
            while (a > 0)
            {
                if (a>20) n++;
                Console.Write("Kérem adjon meg egy számot: ");
                a = int.Parse(Console.ReadLine());
            }
            Console.Write("Húsznál nagyobb számok száma: {0}", n);
            Console.ReadLine();
        }
    }
}
