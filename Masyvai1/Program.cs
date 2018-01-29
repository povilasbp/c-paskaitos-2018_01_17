using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masyvai1
{
    class Program
    {
        static void Main(string[] args)
        {

            // rasti visu skaiciu [10-100] reziu, kurie dalinasi is 3 suma
            int suma = 0;
            for(int i = 30; i <= 100; i++)
            {
                if(i%3 == 0)
                {
                    suma += i;
                }
            }
            Console.WriteLine("Suma: {0}", suma);
        }
    }
}
