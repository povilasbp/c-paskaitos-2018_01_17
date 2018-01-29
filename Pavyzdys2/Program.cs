using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavyzdys2
{
    class Program
    {
        static void Main(string[] args)
        {
            var nuvaziuotiKilometrazai = new List<int>();
            Program programa = new Program();

            // duomenu suvedimui
            programa.Ivedimas(nuvaziuotiKilometrazai);
            // duomenu isvedimui
            programa.Isvedimas(nuvaziuotiKilometrazai, "Pradiniai duomenys");
            programa.Skaiciavimai(nuvaziuotiKilometrazai);

            List<int> atrinkti = programa.Atrinkimas(nuvaziuotiKilometrazai);
            programa.Isvedimas(atrinkti, "Atrinkti duomenys: ");

        }// main pabaiga
       
        public void Ivedimas(List<int> Sarasas)
        {
            var dar = true;
            int aja = 0;

            while(dar)
            {
                Console.Write("Iveskite {0}-aja rida: ", aja+1);
                var km = Convert.ToInt32(Console.ReadLine());
                Sarasas.Add(km);

                Console.Write("Norite kartoti? t/n");
                var kartoti = Console.ReadLine();
                if(kartoti != "t")
                {
                    dar = false;
                }
            }
        }
        //---------ISVEDIMAS-----------------------------------------------------------
        public void Isvedimas(List<int> sarasas, string komentaras)
        {
            int aja = 1;
            Console.WriteLine("--------------------------------");
            Console.WriteLine(komentaras);
            foreach (var item in sarasas)
            {
                Console.WriteLine("{0}-oji rida: {1} km.", aja++, item);
            }
            Console.WriteLine("--------------------------------");
        }
        //--------------------------------------------------------------------------------
        public int Suma(List<int> sarasas)
        {
            return sarasas.Sum();
        }

        public int Min(List<int> sarasas)
        {
            return sarasas.Min();
        }

        public int Max(List<int> sarasas)
        {
            return sarasas.Max();
        }

        public double Vidurkis(List<int> sarasas)
        {
            return (double)Suma(sarasas) / sarasas.Count;
        }

        public void Skaiciavimai(List<int> sarasas)
        {
            Console.WriteLine("Suma: {0}", Suma(sarasas));
            Console.WriteLine("Min: {0}", Min(sarasas));
            Console.WriteLine("Max: {0}", Max(sarasas));
            Console.WriteLine("Vidurkis: {0}", Vidurkis(sarasas));
            //Skaiciavimai(sarasas);
        }

        public List<int> Atrinkimas(List<int> pradiniai)
        {
            // daugiau nei 300k, laikysim jau kaip graba
            var atrinkti = new List<int>();
            foreach (var item in pradiniai)
            {
                if(item > 300000)
                {
                    atrinkti.Add(item);
                }
            }
            return atrinkti;
        }

    }// class pabaiga
}
