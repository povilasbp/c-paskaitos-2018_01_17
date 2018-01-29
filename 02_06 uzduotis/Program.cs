using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_06_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            string marke = "Audi";
            string modelis = "100";
            int metai = 1995;
            int rida = 435018;

            Console.WriteLine("{0} {1} ({2})m. rida - {3} km.", marke, modelis, metai, rida);
            Console.ReadKey();
        }
    }
}
