using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_01_uzduotis
{
    class Program
    {
        // TEMA: dienu temperaturos
        /*
         * kuriam sarasa
         * metodai:
         * -ivedimas
         * -isvedimas
         * skaiciaivimai (min, max, suma, vidurkis)
         * -visu skaiciavmu isvedimui
         * -atrinkimui i nauja sarasa
         */

        static void Main(string[] args)
        {
            Program p = new Program();
            var temperaturos = new List<int>();
            p.Ivedimas(temperaturos);
            p.Isvedimas(temperaturos, "Pradiniai duomenys:");
            p.SkaiciavimuIsvedimas(temperaturos);


        }

        public void Ivedimas(List<int> Sarasas)
        {
            bool ar_testi = true;
            string reiksme;
            int skaicius;
            var num = 1;
            Console.WriteLine("--  Norint baigti spauskite ENTER  --");
            Console.WriteLine("Iveskite duomenis: ");
            while (ar_testi)
            {
                Console.Write("{0}-oji temperatura: ", num++);
                reiksme = Console.ReadLine();

                var tinka = int.TryParse(reiksme, out skaicius);
                if (tinka == true)
                {
                    Sarasas.Add(skaicius);
                }
                else
                {
                    ar_testi = false;
                }
            }
        }

        public void Isvedimas(List<int> Sarasas, string komentaras)
        {
            for (int i = 0; i < Sarasas.Count; i++)
                Console.Write("-----");
            Console.WriteLine();
            Console.WriteLine(komentaras + " ");

            foreach (var item in Sarasas)
            {
                Console.Write("[{0}] ", item);
            }

            Console.WriteLine();
            for (int i = 0; i < Sarasas.Count; i++)
                Console.Write("-----");
            Console.WriteLine();
        }

        public void SkaiciavimuIsvedimas(List<int> Sarasas)
        {
            for (int i = 0; i < Sarasas.Count; i++)
                Console.Write("-----");
            Console.WriteLine();
            Console.WriteLine("Skaiciavimai:");

            Console.WriteLine("Maziausia reiksme: {0}", Sarasas.Min());
            Console.WriteLine("Didziausia reiksme: {0}", Sarasas.Max());
            Console.WriteLine("Reiksmiu suma: {0}", Sarasas.Sum());
            Console.WriteLine("Vidurkis: {0}", Math.Round(Sarasas.Average(), 2));

            for (int i = 0; i < Sarasas.Count; i++)
                Console.Write("-----");
            Console.WriteLine();

        }


    }
}
