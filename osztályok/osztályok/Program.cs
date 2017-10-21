using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace osztályok
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Alapmuveletek alapmuveletekValtozo= new Alapmuveletek();

            Console.WriteLine("Összeadás: " + alapmuveletekValtozo.Osszead(10,30));
            Console.WriteLine("kivon " + alapmuveletekValtozo.Kivon(10, 30));
            Console.WriteLine("szoroz: " + alapmuveletekValtozo.Szoroz(10, 30));
            Console.WriteLine("oszt: " + alapmuveletekValtozo.Oszt(10, 30));
            int tempValtozo = 0;
            tempValtozo = osszegzesEgytolTizig(alapmuveletekValtozo, tempValtozo);
            Console.WriteLine("összeg " + tempValtozo);

        /*    FileStream file = new FileStream(@"D:\MyFile.txt", FileMode.Create);
            file.*/
            Console.ReadKey();
        }

        private static int osszegzesEgytolTizig(Alapmuveletek alapmuveletekValtozo, int tempValtozo)
        {

            for (int i = 1; i < 11; i++)
            {
                tempValtozo = alapmuveletekValtozo.Osszead(tempValtozo, i);
            }
            return tempValtozo;
        }
    }
}
