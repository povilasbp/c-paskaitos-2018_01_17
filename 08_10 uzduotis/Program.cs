﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_10_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            int suma = 0;
            for (int i = 30; i < 60; i++)
            {
                if (i % 2 != 0)
                    suma += i;
            }
            Console.WriteLine("Nelyginiu skaiciu nuo 30 iki 60 suma lygi " + suma);
        }
    }
}
