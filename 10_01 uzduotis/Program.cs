using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sarasas;

            sarasas = sarasas = new List<int>();
            sarasas = sarasas = new List<int> { 1, 2, 3, 4 };

            var pazymiai = new List<int>();

            Console.WriteLine("Iveskite pazymius, o noredami sustabdyti parasykite -1");
            int pazymys;
            do
            {
                pazymys = Convert.ToInt32(Console.ReadLine());
                if(pazymys != -1)
                {
                    pazymiai.Add(pazymys);
                }
            } while (pazymys != -1);

            Console.WriteLine("Visi pazymiai: ");
            foreach (var paz in pazymiai)
            {
                Console.Write(paz + " ");
            }
            Console.WriteLine();
        }
    }
}
