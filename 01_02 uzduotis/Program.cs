using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite egzamino rezultata: ");
            int rez = Convert.ToInt32(Console.ReadLine());

            if(rez == 100)
            {
                Console.WriteLine(rez + " yra lygus 100");
            }
            else if (rez >= 80)
            {
                Console.WriteLine(rez + " yra lygus arba daugiau uz 80");
            }
            else if (rez >= 50)
            {
                Console.WriteLine(rez + " yra lygus arba daugiau uz 50");
            }
            else if (rez >= 20)
            {
                Console.WriteLine(rez + " yra lygus arba daugiau uz 20");
            }
            else if (rez < 20)
            {
                Console.WriteLine(rez + " yra mazesnis uz 20");
            }

            Console.ReadKey();
        }
    }
}
