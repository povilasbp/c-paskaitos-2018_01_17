using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_04_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine("Skaicius {0} LYGINIS", i);
                }
                else
                    Console.WriteLine("Skaicius {0}", i);

            }
        }
    }
}
