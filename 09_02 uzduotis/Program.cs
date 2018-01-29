using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Duomenu ivedimas
            Console.WriteLine("Iveskite 1 savaites, kiekvienos dienos temperatura");
            int[] temperaturos = new int[7];
            int diena = 1;
            for (int i = 0; i < temperaturos.Length; i++)
            {
                diena = i + 1;
                Console.Write("{0}-a diena: ", diena);
                temperaturos[i] = Convert.ToInt32(Console.ReadLine());
            }
            //------------------------------------------------------------------
            // Isvedam visos savaites temperaturas
            Console.WriteLine("\nVisos savaites temperaturos: ");
            foreach (int temp in temperaturos)
            {
                Console.Write("{0} ", temp);
            }
            //------------------------------------------------------------------
            // Zemiausia temperatura
            int zemiausia = temperaturos[0];
            foreach (var temp in temperaturos)
            {
                if (zemiausia > temp)
                    zemiausia = temp;
            }
            Console.WriteLine("\nZemiausia temperatura: {0}", zemiausia);
            //------------------------------------------------------------------
            // Auksciausia temperatura
            int auksciausia = temperaturos[0];
            foreach (var temp in temperaturos)
            {
                if (auksciausia < temp)
                    auksciausia = temp;
            }
            Console.WriteLine("Auksciausia temperatura: {0}", auksciausia);
            //------------------------------------------------------------------
            Console.WriteLine("Temperaturu vidurkis: {0}", (float)temperaturos.Average());
            //------------------------------------------------------------------
            Console.WriteLine("Temperaturos mazesnes uz vidurki: ");
            int diena1 = 0;
            foreach (var temp in temperaturos)
            {
                    diena1++;
                if(temp < temperaturos.Average())
                {
                    Console.WriteLine("{0}-a diena: {1}", diena1, temp);
                }
            }
            //------------------------------------------------------------------
            Console.WriteLine("Temperaturos didesnes uz vidurki: ");
            int diena2 = 0;
            foreach (var temp in temperaturos)
            {
                diena2++;
                if (temp > temperaturos.Average())
                {
                    Console.WriteLine("{0}-a diena: {1}", diena2, temp);
                }
            }
            //------------------------------------------------------------------
        }
    }
}
