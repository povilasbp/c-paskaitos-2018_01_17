using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_05_kontrolinis
{
    class Pasaulis
    {
        public List<Salis> SaliuSarasas = new List<Salis>();


        public Miestas DaugiausiaiGyventoju()
        {
            Miestas daugiausiai = SaliuSarasas[0].MiestuSarasas[0];

            for (int i = 0; i < SaliuSarasas.Count; i++)
            {
                for (int j = 0; j < SaliuSarasas[i].MiestuSarasas.Count; j++)
                {
                    if (daugiausiai.GyventojuSkaicius < SaliuSarasas[i].MiestuSarasas[j].GyventojuSkaicius)
                    {
                        daugiausiai = SaliuSarasas[i].MiestuSarasas[j];
                    }
                }
            }
            return daugiausiai;
        }

        public Salis DaugiausiaiMiestu()
        {
            Salis daugiausia = SaliuSarasas.First();

            foreach (var salis in SaliuSarasas)
            {
                if (daugiausia.MiestuSkaicius() < salis.MiestuSkaicius())
                {
                    daugiausia = salis;
                }
            }
            return daugiausia;
        }

    }
}
