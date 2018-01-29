using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_01_uzduotis
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

            switch (skaicius1)
            {
                case 1:
                    Console.WriteLine("1.1: {0}",skaicius1+skaicius2+skaicius3);
                    break;
                case 2:
                    Console.WriteLine("1.2: {0}", skaicius1 - skaicius3);
                    break;
                case 3:
                    Console.WriteLine("1.3: {0}", skaicius2 * skaicius3);
                    break;
                default:
                    Console.WriteLine("{0} nera lygus nei 1, nei 2, nei 3", skaicius1);
                    break;
            }
        }
    }
}
