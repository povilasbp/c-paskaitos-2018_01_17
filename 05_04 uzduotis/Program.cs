using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_04_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-Iveskite penkis savo pazymius-");
            Console.Write("1-as: ");
            int paz1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2-as: ");
            int paz2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3-as: ");
            int paz3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("4-as: ");
            int paz4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("5-as: ");
            int paz5 = Convert.ToInt32(Console.ReadLine());

            double vidurkis = (double)(paz1 + paz2 + paz3 + paz4 + paz5) / 5;

            Console.Write("Pazymiu vidurkis yra: {0}", vidurkis);

            if(vidurkis > 5)
            {
                Console.Write(" ir yra didesnis uz 5\n");
            }
            else if (vidurkis < 5)
            {
                Console.Write(" ir yra mazesnis uz 5\n");
            }

            Console.ReadKey();
        }
    }
}
