using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_01_else_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-Iveskite du skaicius-");
            Console.Write("1-asis: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2-asis: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            if(skaicius1 > skaicius2)
            {
                Console.WriteLine(skaicius1 + " yra didesnis");
            }
            else if(skaicius1 < skaicius2)
            {
                Console.WriteLine(skaicius2 + " yra didesnis");
            }
            else
            {
                Console.WriteLine("skaiciai lygus");
            }
            Console.ReadKey();
        }
    }
}
