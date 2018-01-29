using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_06__optional__while
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomObj = new Random();
            int atsitiktinis_skaicius = randomObj.Next(10);

            Console.WriteLine(atsitiktinis_skaicius);
            Console.WriteLine();
            Console.WriteLine("Bandykite atspeti slapta skaiciu");
            Console.WriteLine("Nuo 0 iki 10");
            int skaicius = Convert.ToInt32(Console.ReadLine());

            while (skaicius != atsitiktinis_skaicius)
            {
                if(skaicius > atsitiktinis_skaicius)
                {
                    Console.WriteLine("Atsitiktinis skaicius mazesnis!");
                    skaicius = Convert.ToInt32(Console.ReadLine());
                }
                else if (skaicius < atsitiktinis_skaicius)
                {
                    Console.WriteLine("Atsitiktinis skaicius didesnis!");
                    skaicius = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Atspejote!!!");
            Console.ReadKey();
        }
    }
}
