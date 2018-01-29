using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_05_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            char simbolis = '*';
            int plotis = 20;
            int aukstis = 15;

            // virsus
            for (int i = 0; i < plotis; i++)
            {
                Console.Write(simbolis);
            }
            Console.WriteLine();
            // vidurys
            for (int i = 0; i < aukstis - 2; i++)
            {
                Console.Write(simbolis);
                for (int j = 0; j < plotis - 2; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine(simbolis);
            }
            // apacia
            for (int i = 0; i < plotis; i++)
            {
                Console.Write(simbolis);
            }
            Console.ReadKey();
            //--------------------------------------------------
        }
    }
}
