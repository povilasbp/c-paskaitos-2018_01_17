using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_03_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-Iveskite sios dienos oro temperatura-");
            Console.Write("Oro temperatura: ");
            int temp = Convert.ToInt32(Console.ReadLine());

            //if (rez == 100)
            //{
            //    Console.WriteLine(rez + " yra lygus 100");
            //}
            //else if (rez >= 80)
            //{
            //    Console.WriteLine(rez + " yra lygus arba daugiau uz 80");
            //}
            //else if (rez >= 50)
            //{
            //    Console.WriteLine(rez + " yra lygus arba daugiau uz 50");
            //}
            //else if (rez >= 20)
            //{
            //    Console.WriteLine(rez + " yra lygus arba daugiau uz 20");
            //}
            //else if (rez < 20)
            //{
            //    Console.WriteLine(rez + " yra mazesnis uz 20");
            //}

            Console.ReadKey();
        }
    }
}
