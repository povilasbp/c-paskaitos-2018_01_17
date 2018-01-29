using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_04_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            int skaicius3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} + {2} = {3}", skaicius1, skaicius2, skaicius3, skaicius1+skaicius2+skaicius3);
            Console.WriteLine("{0} - {1} - {2} = {3}", skaicius1, skaicius2, skaicius3, skaicius1 - skaicius2 - skaicius3);
            Console.WriteLine("{0} * {1} * {2} = {3}", skaicius1, skaicius2, skaicius3, skaicius1 * skaicius2 * skaicius3);
            Console.WriteLine("{0} / {1} / {2} = {3}", skaicius1, skaicius2, skaicius3, (double)skaicius1 / skaicius2 / skaicius3);

            Console.ReadKey();
        }
    }
}
