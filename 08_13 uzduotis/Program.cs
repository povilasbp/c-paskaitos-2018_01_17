using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_13_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kiek fibonačiaus skaičių išvesti į ekraną: ");
            int kiek = Convert.ToInt32(Console.ReadLine());

            int skaicius1 = 0;
            int skaicius2 = 1;
            int skaicius3;

            Console.Write("{0} ", skaicius1);
            Console.Write("{0} ", skaicius2);

            for(int i = 0; i < kiek-2; i++)
            {
                skaicius3 = skaicius1 + skaicius2;
                skaicius1 = skaicius2;
                skaicius2 = skaicius3;
                Console.Write("{0} ", skaicius3);
            }
        }
    }
}
