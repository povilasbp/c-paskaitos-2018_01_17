using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_05_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var sarasas = new List<string>
            {
                "I", "love", "c#", "language" 
            };

            // isvedam teksta
            foreach (var item in sarasas)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // trumpiausias zodis
            string trumpiausias = sarasas[0];
            foreach (var zodis in sarasas)
            {
                if(trumpiausias.Length > zodis.Length)
                {
                    trumpiausias = zodis;
                }
            }
            Console.WriteLine("Trumpiausias zodis: {0}", trumpiausias);
            //-----------------------------------------------------------------
            // ilgiausias zodis
            string ilgiausias = sarasas[0];
            foreach (var zodis in sarasas)
            {
                if (ilgiausias.Length < zodis.Length)
                {
                    ilgiausias = zodis;
                }
            }
            Console.WriteLine("Ilgiausias zodis: {0}", ilgiausias);
        }
    }
}
