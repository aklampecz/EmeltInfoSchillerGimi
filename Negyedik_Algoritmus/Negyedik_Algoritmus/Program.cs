using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negyedik_Algoritmus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem adjon meg egy számot:");
            int a = int.Parse(Console.ReadLine());
            string m = "nincs";
            while (a > 0)
            {
                if (a > 30) m = "van";
                Console.Write("Kérem adjon meg egy számot: ");
                a = int.Parse(Console.ReadLine());
            }
            Console.Write("Van-e 30-nál nagyobb szám a sorozatban: {0}.", m);
            Console.ReadLine();
        }
    }
}
