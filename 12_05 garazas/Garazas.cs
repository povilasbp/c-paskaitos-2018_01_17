using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_05_garazas
{
    class Garazas
    {
        public List<Auto> AutoSarasas { get; private set; }
        public string Pavadinimas { get; private set; }
        public string Adresas { get; private set; }
        public int MeistruSkaicius { get; private set; }

        public Garazas(string pavadinimas, string adresas, int meistruskaicius, List<Auto> autosarasas)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            MeistruSkaicius = meistruskaicius;
            AutoSarasas = autosarasas;
        }

        public void InfoGarazas()
        {
            Console.WriteLine("{0} garazas randamas {1} adresu, jame dirba {2} meistrai", Pavadinimas, Adresas, MeistruSkaicius);
            foreach (var auto in AutoSarasas)
            {
                auto.InfoAuto();
            }
        }

        public void InfoGarazas1()
        {
            Console.WriteLine("{0} garazas randamas {1} adresu, jame dirba {2} meistrai", Pavadinimas, Adresas, MeistruSkaicius);
            for (int i = 0; i < AutoSarasas.Count; i++)
            {
                Console.Write(i + 1 + " auto: ");
                AutoSarasas[i].InfoAuto();
            }
        }

        public void AtnaujintiPasirinkta()
        {
            Console.Write("Kuri automobili keisti: ");
            var kuris = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pasirinktas automobilis: ");
            AutoSarasas[kuris - 1].InfoAuto();

            Console.WriteLine("1 - atsukti rida");
            Console.WriteLine("2 - perdazyti");
            Console.WriteLine("3 - padidinti galia");

            var pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    AutoSarasas[kuris - 1].AtsuktiRida();
                    break;
                case 2:
                    AutoSarasas[kuris - 1].Perdazyti();
                    break;
                case 3:
                    break;
                default:
                    break;
            }
            Console.WriteLine("Atnaujintas automobilis: ");
            AutoSarasas[kuris - 1].InfoAuto();
        }

        public void Skaiciavimai()
        {
            Console.WriteLine("_________________________________________________________________");
            Console.WriteLine("Visa rida: {0}", TotalRida());

            Console.WriteLine("_________________________________________________________________");

        }

        public int TotalRida()
        {
            var sum = 0;
            foreach (var auto in AutoSarasas)
            {
                sum += auto.Rida;
            }
            return sum;
        }

        public Auto DidziausiaGalia()
        {
            var didziausia = AutoSarasas.First();

            return didziausia;
        }





    }
}
