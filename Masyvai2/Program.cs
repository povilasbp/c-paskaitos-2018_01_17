using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masyvai2
{
    class Program
    {
        static void Main(string[] args)
        {
            // sudeti i masyva skaicius, kurie dalinasi is 5 ir patenka i rezius [30-150]

            int[] masyvas = new int[120];
            int indeksas = 0;
            for(int i = 30; i <= 150; i++)
            {
                if(i % 5 == 0)
                {
                    masyvas[indeksas] = i;
                    indeksas++;
                }
            }
           for(int i = 0; i < indeksas; i++)
            {
                Console.Write(masyvas[i] + " ");
            }

            // rasti skaiciu suma, vidurki, didziausia, maziausia, skaicius
            // is turimo masyvo
            // sumos paieska

            int suma = 0;

            for(int i = 0; i < indeksas; i++)
            {
                suma += masyvas[i];
            }
            Console.WriteLine("Suma lygi {0}", suma);

            double vidurkis = (double)suma / indeksas;
            Console.WriteLine("Vidurkis lygus {0}", vidurkis);

            var didziausias = masyvas[indeksas-1];
            Console.WriteLine("Didziausias skaicius: {0}", didziausias);
            var maziausias = masyvas[0];
            Console.WriteLine("Maziausias skaicius: {0}", maziausias);
        }
    }
}
