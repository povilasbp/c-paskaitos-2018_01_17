using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_03_mano_sugalvota
{
    class Zmogus
    {
        public string Vardas { get; set; }
        public int Amzius { get; set; }
        public double Ugis { get; set; }
        public double Svoris { get; set; }

        public Zmogus(){}

        public Zmogus(string vardas, int amzius, double ugis, double svoris)
        {
            Vardas = vardas;
            Amzius = amzius;
            Ugis = ugis;
            Svoris = svoris;
        }

        public void InfoZmogus()
        {
            Console.WriteLine("{0} {1} {2}cm {3}kg", Vardas, Amzius, Ugis, Svoris);
        }
    }
}
