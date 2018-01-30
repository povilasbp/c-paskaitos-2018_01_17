using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_04_Seima
{
    class Seima
    {
        public string Adresas { get; private set; }
        public List<Zmogus> SeimosSar { get; private set; } = new List<Zmogus>();

        //public Seima()
        //{
        //    SeimosSar = new List<Zmogus>();
        //}

        public Seima()
        {
            Ivedimas();
        }

        public Seima(string adresas, List<Zmogus> zmones)
        {
            Adresas = adresas;
            SeimosSar = zmones;
        }

        public void InfoSeima()
        {
            Console.WriteLine("Seima gyvena adresu {0}", Adresas);

            foreach (var zmogus in SeimosSar)
            {
                zmogus.InfoZmogus();
            }
        }

        public void Ivedimas()
        {
            Console.Write("Iveskite adresa: ");
            Adresas = Console.ReadLine();
            // klausti kiek zmoniu suvesti
            // for ciklas kiek reikia
            // kurti tuscia zmogaus objekta naudojant () - tuscia konstruktoriu
            // zmogaus objekta ikelti i zmoniu sarasa

            Console.Write("Kiek zmoniu vesite: ");
            var kiek = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kiek; i++)
            {
                Zmogus zmog = new Zmogus();
                SeimosSar.Add(zmog);
            }
            
        }

    }
}
