using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-Iveskite tris skaicius-");
            Console.Write("Iveskite 1-aji skaiciu: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite 2-aji skaiciu: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite 3-aji skaiciu: ");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());


            if (skaicius1 > skaicius2)
            {
                Console.Write("1.1:   ");
                Console.WriteLine(skaicius1 + " yra daugiau uz " + skaicius2);
            }
            else if (skaicius1 < skaicius2)
            {
                Console.Write("1.1:   ");
                Console.WriteLine(skaicius1 + " yra maziau uz " + skaicius2);
            }
            if (skaicius2 > skaicius3)
            {
                Console.Write("1.2:   ");
                Console.WriteLine(skaicius2 + " yra daugiau uz " + skaicius3);
            }
            else if (skaicius2 < skaicius3)
            {
                Console.Write("1.2:   ");
                Console.WriteLine(skaicius2 + " yra maziau uz " + skaicius3);
            }
            if (skaicius3 > skaicius1)
            {
                Console.Write(  "1.3:   ");
                Console.WriteLine(skaicius3 + " yra daugiau uz " + skaicius1);
            }
            else if (skaicius3 < skaicius1)
            {
                Console.Write("1.3:   ");
                Console.WriteLine(skaicius3 + " yra maziau uz " + skaicius1);
            }
            if (skaicius1 == skaicius2 && skaicius2 == skaicius3)
            {
                Console.Write("1.4:   ");
                Console.WriteLine("skaiciai lygus");
            }
            else
            {
                Console.Write("1.4:   ");
                Console.WriteLine("skaiciai nelygus");
            }
        }

    }
}
