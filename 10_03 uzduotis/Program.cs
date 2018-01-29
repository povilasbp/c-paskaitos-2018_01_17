using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_03_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var atsitiktinisObj = new Random();
            int random = atsitiktinisObj.Next(1, 100); // sugeneravo random saraso dydi

            var sarasas = new List<int>();

            // surasom random skaicius i random dydzio sarasa
            for(int i = 0; i < random; i++)
            {
                random = atsitiktinisObj.Next(1, 100); // generuoja random reiksmes
                sarasas.Add(random); // idedam i sarasa random reiksme
                Console.WriteLine(random);
            }
            //---------------------------------------------------

            //1.1 rasti maziausia skaiciu
            Console.WriteLine("Maziausias skaicius: {0}", sarasas.Min());
            //1.2 rasti didziausia skaiciu
            Console.WriteLine("Didziausias skaicius: {0}", sarasas.Max());
            //1.3 rasti vidurki
            Console.WriteLine("Vidurkis: {0}", Math.Round(sarasas.Average(),2));
            //1.4 kiek skaiciu yra zemesni uz vidurki
            int kiek = 0;
            int vidurkis = (int)sarasas.Average();
            foreach (var item in sarasas)
            {
                if(item < vidurkis)
                {
                    kiek++;
                }
            }
            Console.WriteLine("Kiek mazesniu uz {0}: {1}", Math.Round(sarasas.Average(),2),kiek);
            //1.5 lyginiu skaiciu suma
            int suma = 0;
            foreach (var item in sarasas)
            {
                if(item %2 == 0)
                {
                    suma += item;
                }
            }
            Console.WriteLine("Lyginiu skaiciu suma: {0}", suma);
        }
    }
}
