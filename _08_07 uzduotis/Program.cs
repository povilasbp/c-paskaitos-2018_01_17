using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_07_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            for (int i = 0; i < 100; i++)
            {
                suma += i;
            }
            Console.WriteLine("Skaiciu nuo 0 iki 100 suma lygi " + suma);
        }
    }
}
