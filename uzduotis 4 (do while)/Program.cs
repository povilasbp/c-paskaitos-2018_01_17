using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis_4__do_while_
{
    class Program
    {
        static void Main(string[] args)
        {
            int kvadratu_suma = 0;
            int suma_kvadratu = 0;

            for (int i = 1; i <= 100; i++)
            {
                kvadratu_suma += (int)Math.Pow(i, 2);
            }
            Console.WriteLine("Kvadratu suma: {0}", kvadratu_suma);

            for (int i = 1; i <= 100; i++)
            {
                suma_kvadratu += i;

            }
            suma_kvadratu = (int)Math.Pow(suma_kvadratu, 2);
            Console.WriteLine("Suma kvadratu: {0}", suma_kvadratu);
            Console.WriteLine();

            Console.WriteLine("Atsakymas {0}", suma_kvadratu - kvadratu_suma);
        }
    }
}
