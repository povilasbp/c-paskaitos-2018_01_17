using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_01_uzduotis
{
    class Automobilis
    {
        // prop + tabtab
        // private _pavPav
        // public Pav

        public string Spalva { get; set; }
        public string Marke { get; set; }
        public string Modelis { get; set; }
        public int Rida { get; set; }
        public int Pavaros { get; set; }
        public double DarbinisTuris { get; set; }
        public int GaliaKw { get; set; }

        // ctor + tabtab
        public Automobilis()
        {

        }

        public Automobilis(string marke, string modelis, string spalva, double darbinisTuris, int galia, int pavaros, int rida)
        {
            Marke = marke;
            Modelis = modelis;
            Spalva = spalva;
            DarbinisTuris = darbinisTuris;
            GaliaKw = galia;
            Pavaros = pavaros;
            Rida = rida;
        }

        public void Ivesti(string marke, string modelis, string spalva, double darbinisTuris, int galia, int pavaros, int rida)
        {
            Marke = marke;
            Modelis = modelis;
            Spalva = spalva;
            DarbinisTuris = darbinisTuris;
            GaliaKw = galia;
            Pavaros = pavaros;
            Rida = rida;
        }

        public void Info()
        {
            Console.WriteLine("{0,-9} {1,-9} {2,-9} {3,9} {4,9} {5,8} {6,9}", Marke, Modelis, Spalva, DarbinisTuris, GaliaKw, Pavaros, Rida);
        }

        public void IvestiKonsoleje()
        {
            Console.Write("Iveskite marke: ");
            Marke = Console.ReadLine();
            Console.Write("Iveskite modeli: ");
            Modelis = Console.ReadLine();
            Console.Write("Iveskite spalva: ");
            Spalva = Console.ReadLine();
            Console.Write("Iveskite darbini turi: ");
            //string darbTuris = Console.ReadLine();
           // double darbTurisSk;

           DarbinisTuris = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite galia: ");
            GaliaKw = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite pavaras: ");
            Pavaros = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite rida: ");
            Rida = Convert.ToInt32(Console.ReadLine());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // rankiniu budu
            Automobilis automobilis = new Automobilis();
            automobilis.Marke = "Tesla";
            automobilis.Modelis = "X";
            automobilis.Spalva = "balta";
            automobilis.DarbinisTuris = 0.0;
            automobilis.Rida = 10500;
            automobilis.Pavaros = 8;
            automobilis.GaliaKw = 504;

            // metodas
            var automobilis1 = new Automobilis();
            automobilis1.Ivesti("Audi", "A4", "Juoda", 2.7, 150, 7, 285000);

            // konstruktorius
            var auto1 = new Automobilis("VW", "Golf", "Melyna", 1.6, 77, 5, 266054);

            // kitoks variantas
            var auto2 = new Automobilis
            {
                Marke = "Lada",
                Modelis = "2105",
                Spalva = "pilka",
                DarbinisTuris = 1.6,
                Rida = 20000,
                Pavaros = 5,
                GaliaKw = 44
            };

            // isvedimas
            Console.WriteLine("{0,-9} {1,-9} {2,-9} {3,7} {4,7} {5,4} {6,4}\n", "Marke:", "Modelis:", "Spalva:", "DarbinisTuris:", "GaliaKw:", "Pavaros:", "Rida:");
            auto2.Info();
            automobilis.Info();
            automobilis1.Info();
            auto1.Info();
            Console.WriteLine("______________________________________________________________________");


            // sarasas
            List<Automobilis> Autos = new List<Automobilis>();
            Autos.Add(new Automobilis("VW", "Multivan", "Raudona", 2.5, 100, 5, 500000));
            Autos.Add(new Automobilis("MB", "S-class", "Juoda", 3.0, 160, 6, 255012));

            Console.WriteLine("{0,-9} {1,-9} {2,-9} {3,7} {4,7} {5,4} {6,4}\n", "Marke:", "Modelis:", "Spalva:", "DarbinisTuris:", "GaliaKw:", "Pavaros:", "Rida:");
            for (int i = 0; i < Autos.Count; i++)
            {
                Autos[i].Info();
            }


            // ivedam konsolej

            Automobilis autok = new Automobilis();

            autok.IvestiKonsoleje();
            

            


        }
    }
}
