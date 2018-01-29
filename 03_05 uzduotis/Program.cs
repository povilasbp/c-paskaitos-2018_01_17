using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_05_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int skaicius = 5;
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(skaicius*i);
            }
            Console.ReadKey();
        }
    }
}
