using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_03_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite bet koki teigiama skaiciu: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            // 3.2
            if (skaicius >= 0)
            {
                Console.WriteLine("Teisingai! Ivedete teigiama skaiciu.");
            }
            //3.1
            else
                Console.WriteLine("Ivedete neigiama skaiciu!");

            //3.3
            if (skaicius % 2 == 0)
            {
                Console.WriteLine("Ivestas skaicius lyginis!");
            }
            else
            {
                Console.WriteLine("Ivestas skaicius nelyginis!");
            }
            //3.4
            if (skaicius % 4 == 0)
            {
                Console.WriteLine("Ivestas skaicius dalinasi is 4");
            }
            else
                Console.WriteLine("Ivestas skaicius nesidalina is 4");
            //3.5
            if (skaicius > 10)
            {
                Console.WriteLine("Ivestas skaicius didesnis uz 10");
            }
            else
            {
                Console.WriteLine("Ivestas skaicius mazesnis uz 10");
            }

            Console.ReadKey();
        }

    }
}
