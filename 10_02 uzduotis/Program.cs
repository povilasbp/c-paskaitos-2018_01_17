using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var pinigai = new List<int>
            {
                650, 99, 87, 85, 364, 85, 365, 789,
                74, 522, 889, 999, 14, 41

            };

            // isvedam sarasa

            int stulpelis = 1;
            Console.WriteLine("Visi pinigai: ");
            foreach (var skaicius in pinigai)
            {
                if(stulpelis == 9)
                {
                    Console.WriteLine();
                    stulpelis = 1;
                }
                Console.Write(skaicius + " ");
                stulpelis++;
            }

            // rasti min, max, average
            // atrinkti i kita sarasa mazesnius uz vidurki
            // atrinkti i kita sarasa lyginius skaicius
            // atrinkti i kita sarasa skaicius, esancius tarp 30 ir max

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Maziausia reiksme: {0}", pinigai.Min());
            Console.WriteLine("Didziausia reiksme: {0}", pinigai.Max());
            Console.WriteLine("Vidurkis: {0}", Math.Round(pinigai.Average(),2));

            // atrinkimas1
            var sarasas1 = new List<int>();

            foreach (var pinigas in pinigai)
            {
                if(pinigas < pinigai.Average())
                {
                    sarasas1.Add(pinigas);
                }
            }
            Console.WriteLine("\nMazesni uz vidurki: ");
            foreach (var pinigas in sarasas1)
            {
                Console.Write(pinigas + " ");
            }

            // atrinkimas2
            var sarasas2 = new List<int>();

            foreach (var pinigas in pinigai)
            {
                if (pinigas % 2 == 0)
                {
                    sarasas2.Add(pinigas);
                }
            }
            Console.WriteLine("\nLyginiai skaiciai: ");
            foreach (var pinigas in sarasas2)
            {
                Console.Write(pinigas + " ");
            }

            // atrinkimas3
            var sarasas3 = new List<int>();

            foreach (var pinigas in pinigai)
            {
                if (pinigas > 30 && pinigas < pinigai.Max())
                {
                    sarasas3.Add(pinigas);
                }
            }
            Console.WriteLine("\nTarp 30 ir {0}: ", pinigai.Max());
            foreach (var pinigas in sarasas3)
            {
                Console.Write(pinigas + " ");
            }

        }
    }
}
