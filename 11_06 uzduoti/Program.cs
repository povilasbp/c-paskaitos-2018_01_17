using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_06_uzduoti
{
    class Program
    {
        static void Main(string[] args)
        {
            var vardas = "ssfasdasd";
            var pavarde = "aasdasd";
            var amzius = 2015504;

            Ivedimas(ref vardas, ref pavarde, ref amzius);
            Isvedimas(vardas, pavarde, amzius);


        }// main pabaiga

        public static void Ivedimas(ref string vardas, ref string pavarde, ref int amzius)
        {
            Console.WriteLine("Ivestas vardas: {0}", vardas);
            Console.WriteLine("Iveskite nauja: ");
            vardas = Console.ReadLine();
            Console.WriteLine("Ivesta pavarde: {0}", pavarde);
            Console.WriteLine("Iveskite nauja: ");
            pavarde = Console.ReadLine();
            Console.WriteLine("Ivestas amzius: {0}", amzius);
            Console.WriteLine("Iveskite nauja: ");
            amzius = Convert.ToInt32(Console.ReadLine());
        }

        public static void Isvedimas(string vardas, string pavarde, int amzius)
        {
            Console.WriteLine("Vardas: {0,-10}", vardas);
            Console.WriteLine("Pavarde: {0,-10}", pavarde);
            Console.WriteLine("Amzius: {0,-10}", amzius);
        }
    }
}
