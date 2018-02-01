using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_05_kontrolinis
{
    class Salis
    {
        public string Pavadinimas { get; private set; }
        public string Zemynas { get; private set; }
        public List<Miestas> MiestuSarasas = new List<Miestas>();


        public Salis(string failas)
        {
            //failas = @"C:\Users\Povilas\Desktop\Lietuva.csv";

            string[] VisasFailas = File.ReadAllLines(failas);
            Pavadinimas = VisasFailas[0];
            Zemynas = VisasFailas[1];


            for (int i = 2; i < VisasFailas.Length; i++)
            {
                Miestas miest = new Miestas(VisasFailas[i]);
                MiestuSarasas.Add(miest);
            }
        }

        public int MiestuSkaicius()
        {
            int miestuSkaicius = 0;
            foreach (var miestas in MiestuSarasas)
            {
                miestuSkaicius++;
            }
            return miestuSkaicius;
        }
    }
}
