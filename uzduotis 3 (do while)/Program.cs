﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int skaicius = 2; // skaicius kurio ieskom
            bool testi = true;
            int kiek = 1; // kai kintamasis kiek bus lygus 20 (nes is 20 skaiciu turi dalintis), tada stabdom programa ir isvedam atsakyma
            while (skaicius > 0) // kol skaicius teigiamas
            {
                for (int i = 1; i <= 20; i++)
                {
                    if (skaicius % i != 0)
                    {
                        //Console.WriteLine(skaicius + " nesidalina is " + i + " nes liekana yra " + skaicius%i);
                        //System.Threading.Thread.Sleep(1);
                        testi = false;
                        kiek = 1; // kai nesidalina, kiek nuresetinam iki 1
                        break;
                    }
                    else
                    {
                        //Console.WriteLine("---" + skaicius + " dalinasi is " + i + " liekana " + skaicius%i );
                        kiek++; // jei dalinasi, kiek padidinam +1
                    }
                    if (kiek == 20) // tikrinam ar skaicius dalinasi is visu 20 skaiciu
                    {
                        testi = false;
                        Console.WriteLine("Atsakymas: " + skaicius); // isvedam atsakyma
                        skaicius = -1; // nutraukiam while cikla priskirdami -1 reiksme, nes while tikrina ar skaicius daugia uz 0
                    }
                }
                skaicius++; // didinam skaiciu, kurio ieskom
            }
        }
    }
}
