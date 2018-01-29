using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int skaicius1 = 5;
            int skaicius2 = 6;

            Console.WriteLine(skaicius1 + "+" + skaicius2 + "=" + (skaicius1 + skaicius2));
            Console.WriteLine(skaicius1 + "-" + skaicius2 + "=" + (skaicius1 - skaicius2));
            Console.WriteLine(skaicius1 + "*" + skaicius2 + "=" + (skaicius1 * skaicius2));
            Console.WriteLine(skaicius1 + "/" + skaicius2 + "=" + (double)skaicius1 / skaicius2);
            Console.ReadKey();
        }
    }
}
