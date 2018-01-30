using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_04_Seima
{
    class Program
    {
        static void Main(string[] args)
        {
            //var zmogus1 = new Zmogus();
            //zmogus1.InfoZmogus();

            //var zmogus2 = new Zmogus("Jonas", "Jonaitis", 192, 32, "v");
            //zmogus2.InfoZmogus();

            // 1 pavyzdys
            var seima1 = new Seima("Kaunas", new List<Zmogus>
            {
                new Zmogus("Petras", "Petraitis", 205, 35, "v"),
                new Zmogus("Tomas", "Tomaitis", 192, 40, "v"),
            });
            seima1.InfoSeima();

            // 2 pavyzdys
            var seima2 = new List<Zmogus>
            {
                new Zmogus("Antanas", "Antanaitis", 215, 45, "v"),
                new Zmogus("Laimonas", "Tomaitis", 182, 42, "v"),

            };
            seima2[0].InfoZmogus();

            // 3 pavyzdys
            var seima3 = new Seima();
            seima3.InfoSeima();
        }
    }
}
