using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_08_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            for (int i = 20; i < 50; i += 2)
            {
                suma += i;
            }
            Console.WriteLine("Skaiciu nuo 20 iki 50 suma lygi " + suma);

            // ARBA

            Console.WriteLine();
            int suma1 = 0;
            for (int i1 = 20; i1 < 50; i1++)
            {
                if (i1 % 2 == 0)
                    suma1 += i1;
            }
            Console.WriteLine("Skaiciu nuo 20 iki 50 suma lygi " + suma1);
        }

    }
}
