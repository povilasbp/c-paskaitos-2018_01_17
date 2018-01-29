using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_04_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite kiek studentu pazymiu norite ivesti: ");
            int kiek = Convert.ToInt32(Console.ReadLine());
            int pazymys;
            var sarasas = new List<int>();

            for(int i = 0; i < kiek; i++)
            {
                Console.Write("Iveskite {0}-aji pazymi: ", i+1);
                pazymys = Convert.ToInt32(Console.ReadLine());
                sarasas.Add(pazymys);
            }
            // isvedam duomenis
            Console.WriteLine("Ivestu pazymiu sarasas: ");
            foreach (var item in sarasas)
            {
                Console.Write(item + " ");
            }
            //--------------------------------------------------
            //2.1 rasti didziausia pazymi
            Console.WriteLine("Didziausias pazymys: {0}", sarasas.Max());
            //2.2 rasti maziausia pazymi
            Console.WriteLine("Maziausias pazymys: {0}", sarasas.Min());
            //2.3 rasti vidurki
            Console.WriteLine("Vidurkis: {0}", Math.Round(sarasas.Average(),2));
            //2.4 isvesti atsitiktini skaiciu is saraso
            var atsitiktinisObj = new Random();
            int random = atsitiktinisObj.Next(0, sarasas.Count);
            Console.WriteLine("Atsitiktinis pazymys: {0}", sarasas[random]);
        }
    }
}
