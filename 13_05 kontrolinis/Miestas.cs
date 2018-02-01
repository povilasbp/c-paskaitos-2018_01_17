using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_05_kontrolinis
{
    class Miestas
    {
        public string Pavadinimas { get; private set; }
        public int GyventojuSkaicius { get; private set; }
        public int Plotas { get; private set; } // kv.km

        public Miestas(string eilute)
        {
            var isskaidytasKintamasis = eilute.Split(',');
            Pavadinimas = isskaidytasKintamasis[0];
            GyventojuSkaicius = Convert.ToInt32(isskaidytasKintamasis[1]);
            Plotas = Convert.ToInt32(isskaidytasKintamasis[2]);
        }
    }
}
