using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_05_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite rezius:" );
            Console.Write("pradzia: ");
            int pradzia = Convert.ToInt32(Console.ReadLine());
            Console.Write("pabaiga: ");
            int pabaiga = Convert.ToInt32(Console.ReadLine());

            if(pradzia > pabaiga)
            {
                Console.WriteLine("Ivesti reziai negalimi!");
            }
            else
            {
                for (int i = pradzia; i < pabaiga; i++)
                {
                    Console.WriteLine("{0} {1}", i, Math.Pow(i,2));
                }
            }
            Console.ReadKey();
        }
    }
}
