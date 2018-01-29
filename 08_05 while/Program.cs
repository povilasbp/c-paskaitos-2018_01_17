using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_05_while
{
    class Program
    {
        static void Main(string[] args)
        {

            int skaicius;
            Console.Write("Iveskite skaiciu: ");
            skaicius = Convert.ToInt32(Console.ReadLine());


            while (skaicius % 9 != 0)
            {
                Console.Write("Iveskite skaiciu: ");
                skaicius = Convert.ToInt32(Console.ReadLine());
            }
                Console.WriteLine("Ivedete skaiciu, kuris dalinasi is 9!");

        }
    }
}
