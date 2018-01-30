using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_04_Seima
{
    class Zmogus
    {
        public string Vardas { get; private set; }
        public string Pavarde { get; private set; }
        public int UgisCM { get; private set; }
        public int Amzius { get; private set; }
        public string Lytis { get; private set; }

        public Zmogus()
        {
            Ivedimas();
        }

        public Zmogus(string vardas, string pavarde, int ugis, int amzius, string lytis)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            UgisCM = ugis;
            Amzius = amzius;
            Lytis = lytis;
        }

        public void InfoZmogus()
        {
            string lytis_tekstas = "";
            if (Lytis == "v" || Lytis == "V" || Lytis == "vyr" || Lytis == "Vyr")
                lytis_tekstas = "vyras";
            else if (Lytis == "m" || Lytis == "M" || Lytis == "mot" || Lytis == "Mot")
                lytis_tekstas = "moteris";
            else
                lytis_tekstas = "-";

            Console.WriteLine("{0,-8} {1,-8} {2,4} {3,4} {4,6}", Vardas, Pavarde, UgisCM, Amzius, lytis_tekstas);
        }

        public void Ivedimas()
        {
            Console.WriteLine("Iveskite duomenis:");
            Console.Write("vardas: ");
            Vardas = Console.ReadLine();
            Console.Write("pavarde: ");
            Pavarde = Console.ReadLine();
            Console.Write("ugis: ");
            UgisCM = Convert.ToInt32(Console.ReadLine());
            Console.Write("amzius: ");
            Amzius = Convert.ToInt32(Console.ReadLine());
            Console.Write("lytis: ");
            Lytis = Console.ReadLine();
            Console.ReadLine();
        }

    }
}
