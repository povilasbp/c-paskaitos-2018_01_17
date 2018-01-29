using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite savo amziu: ");
            int amzius = Convert.ToInt32(Console.ReadLine());

            if (amzius >= 18)
            {
                Console.WriteLine("Jus galite balsuoti!");
            }
            else
            {
                Console.WriteLine("Jums dar nera 18 metu, todel negalite balsuoti!");
            }
            Console.ReadKey();
        }
    }
}
