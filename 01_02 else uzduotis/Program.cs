using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_else_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-Iveskite betkoki skaiciu-");
            Console.Write("Skaicius: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());

            if(skaicius > 0)
            {
                Console.WriteLine(skaicius + " yra teigiamas");
            }
            else if (skaicius < 0)
            {
                Console.WriteLine(skaicius + " yra neigiamas");
            }
            else
            {
                Console.WriteLine("skaicius lygus 0");
            }
        }
    }
}
