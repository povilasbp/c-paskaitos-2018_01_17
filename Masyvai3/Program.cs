using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masyvai3
{
    class Program
    {
        static void Main(string[] args)
        {
            // leisti vartotojui pasirinkti kiek duomenu suvesti 
            // siuos duomenis sukelti i masyva
            // rasti vidurki, min, max, suma, 
            // atlikti atrinkima i kita masyva duomenu, kurie tenkina salyga: viska kas daugiau uz vidurki
            // abieju masyvu duomenis isvesti.
            // naujo masyvo vidurkis

            int kiek;
            Console.Write("Iveskite kiek duomenu norite ivesti: ");
            kiek = Convert.ToInt32(Console.ReadLine());
            var temperaturos = new int[kiek];
            for(int i = 0; i < kiek; i++)
            {
                Console.Write("Iveskite {0}-aja temperatura: ", i+1);
                temperaturos[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("--------------------------");
            //vidurkis
            int suma = 0;
            foreach (var temp in temperaturos)
            {
                suma += temp;
            }
            double vidurkis = suma / temperaturos.Length;
            Console.WriteLine("Vidurkis: {0}", Math.Round(vidurkis,2));
            //suma
            Console.WriteLine("\nSuma: {0}", suma);
            // maziausia temperatura
            int maziausia = temperaturos[0];
            for(int i = 0; i < temperaturos.Length; i++)
            {
                if (maziausia > temperaturos[i])
                    maziausia = temperaturos[i];
            }
            Console.WriteLine("\nMaziausia temperatura: {0}", maziausia);
            // didziausiatemperatura
            int didziausia = temperaturos[0];
            for (int i = 0; i < temperaturos.Length; i++)
            {
                if (didziausia < temperaturos[i])
                    didziausia = temperaturos[i];
            }
            Console.WriteLine("\nDidziausia temperatura: {0}", didziausia);

            // atrinkimas i kita masyva
            int temp1_kiek = 0;
            foreach (var temp in temperaturos)
            {
                if(temp > vidurkis)
                {
                    temp1_kiek++;
                }

            }
            Console.WriteLine("\nKiek didesniu uz vidurki {0}", temp1_kiek);
            Console.WriteLine("--------------------------");


            int[] temperaturos1 = new int[temp1_kiek];
            int indeksas = 0;
            for (int i = 0; i < kiek; i++)
            {
                if(temperaturos[i] > vidurkis)
                {
                    temperaturos1[indeksas] = temperaturos[i];
                    indeksas++;
                }
            }
            // isvedam masyva
            Console.WriteLine("1 masyvo temperaturos: ");
            foreach (var temp in temperaturos)
            {
                Console.Write("{0} ", temp);
            }

            // isvedam nauja masyva
            Console.WriteLine("\n2 masyvo temperaturos: ");
            foreach (var temp in temperaturos1)
            {
                Console.Write(temp + " ");
            }
            Console.WriteLine();
        }
    }
}
