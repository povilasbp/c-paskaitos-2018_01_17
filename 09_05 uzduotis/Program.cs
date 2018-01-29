using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_05_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // i masyva ideda 10 fibonaciaus skaiciu

            int skaicius1 = 0;
            int skaicius2 = 1;
            int skaicius3;
            int kiek_fibonacio_skaiciu = 10;

            int[] fibonacio_masyvas = new int[kiek_fibonacio_skaiciu];

            Console.Write(skaicius1 + " ");
            Console.Write(skaicius2 + " ");
            fibonacio_masyvas[0] = skaicius1;
            fibonacio_masyvas[1] = skaicius2;

            for (int i = 0; i < kiek_fibonacio_skaiciu-2; i++) // -2, nes pirmus 2 skaicius irasom i masyva
            {
                skaicius3 = skaicius1 + skaicius2;
                fibonacio_masyvas[i] = skaicius3;
                skaicius1 = skaicius2;
                skaicius2 = skaicius3;
            }

        }
    }
}
