using System;
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
            // pradiniai duomenys
            int kiek = 1;
            string isvedimas;
            //------------------------

            Console.WriteLine("Norint baigti ivedineti, iveskite 0");
            for (int i = 0; i < kiek; i++)
            {
                Console.Write("Iveskite skaiciu: ");
                int skaicius = Convert.ToInt32(Console.ReadLine());
                int[] masyvas = new int[kiek];
                masyvas[i] = skaicius;
                kiek++; // didina masyva
                //isvedimas = Convert.ToString(Console.ReadLine("{0} ", masyvas[i]));
                if (skaicius == 0)
                    i = kiek + 1; // baigia for cikla
            }


        }
    }
}
