using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite koki nors simboli: ");
            char simbolis = Convert.ToChar(Console.ReadLine());

            int plotis = 3;
            int aukstis = 3;

            for(int i = 0; i < aukstis; i++)
            {
                for(int j = 0; j < plotis; j++)
                {
                    Console.Write(simbolis);
                }
                Console.WriteLine();
            }
        }
    }
}
