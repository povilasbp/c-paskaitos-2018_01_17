using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_06_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int skaicius = 53;
            int antras_skaicius = skaicius % 10;
            int pirmas_skaicius = (skaicius - antras_skaicius) / 10;

            Console.WriteLine("Musu skaicius: {0}", skaicius);
            Console.WriteLine("1 skaicius: {0}", pirmas_skaicius);
            Console.WriteLine("2 skaicius: {0}", antras_skaicius);

            Console.WriteLine("{0} * {1} = {2}", pirmas_skaicius, antras_skaicius, pirmas_skaicius * antras_skaicius);
            Console.ReadKey();
        }
    }
}
