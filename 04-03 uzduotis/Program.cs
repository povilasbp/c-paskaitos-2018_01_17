using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_03_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite koki nors skaiciu: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skaciaus {0} kvadratas yra: {1}", skaicius, Math.Pow(skaicius,2));
        }
    }
}
