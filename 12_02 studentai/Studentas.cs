using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_02_studentai
{
    class Studentas
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public int UgisCM { get; set; }
        public int Amzius { get; set; }
        public char Lytis { get; set; }

        public Studentas()
        {
        }

        public Studentas(string vardas, string pavarde, int ugis, int amzius, char lytis)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            UgisCM = ugis;
            Amzius = amzius;
            Lytis = lytis;
        }

        public void StudentoInfo()
        {
            string lyt = "";
            if (Lytis == 'v' || Lytis == 'V')
            { lyt = "vyras"; }
            else if (Lytis == 'm' || Lytis == 'M')
            { lyt = "moteris"; }
            else
                lyt = "-";
            Console.WriteLine("{0,-9} {1,-9} {2,4}cm. {3,4}m. {4,7}", Vardas, Pavarde, UgisCM, Amzius, lyt);
        }
    }
}
