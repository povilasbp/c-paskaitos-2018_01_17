using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_02_studentai
{
    class Grupe
    {
        public List<Studentas> Studentai { get; set; } = new List<Studentas>();
        //public Grupe()
        //{
        //    Studentai = new List<Studentas>();
        //}

        public Grupe()
        {
            Studentai.Add(new Studentas("Jonas", "Jonaitis", 184, 27, 'v'));
            Studentai.Add(new Studentas("Povilas", "Bukelis", 185, 24, 'v'));
            Studentai.Add(new Studentas("Petras", "Petraitis", 180, 30, 'v'));
            Studentai.Add(new Studentas("Dalia", "Grybauskaite", 162, 55, 'm'));
            Studentai.Add(new Studentas("Arvydas", "Sabonis", 223, 62, 'v'));
        }

        public void GrupesInfo()
        {
            Console.WriteLine("Grupe: ");
            foreach (var item in Studentai)
            {
                item.StudentoInfo();
            }

            Console.WriteLine("________________________________________________________");
            Console.WriteLine("Skaiciavimai: ");

            var zemiausias = ZemiausiaStudentas();
            Console.Write("Zemiausias: ");
            zemiausias.StudentoInfo();
            // ZemiausiaStudentas().StudentoInfo();
            // taip iskvietus butu tas pats, nes metodas grazina objekta

            Console.Write("Vyriausias: ");
            VyriausiaStudentas().StudentoInfo();

            KiekMoteru();
        }

        // grupes klaseje nauji metodai
        // zemiausias studentas

        public Studentas ZemiausiaStudentas()
        {
            var zemiausias = Studentai.First();
            foreach (var studentas in Studentai)
            {
                if(zemiausias.UgisCM > studentas.UgisCM) // tikrina pagal objekto kintamaji
                {
                    zemiausias = studentas; // grazina objekta
                }
            }

            return zemiausias;
        }
        // vyriausias studentas

        public Studentas VyriausiaStudentas()
        {
            var vyriausias = Studentai.First();
            foreach (var studentas in Studentai)
            {
                if (vyriausias.Amzius < studentas.Amzius) // tikrina pagal objekto kintamaji
                {
                    vyriausias = studentas; // grazina objekta
                }
            }

            return vyriausias;
        }
        // kiek moteru

        public void KiekMoteru()
        {
            int kiek = 0;
            foreach (var item in Studentai)
            {
                if(item.Lytis == 'm' || item.Lytis == 'M')
                {
                    kiek++;
                }
            }

            Console.WriteLine("Moteru skaicius: {0}", kiek);
            int kiekVyru = Studentai.Count - kiek;
            Console.WriteLine("Vyru skaicius: {0}", kiekVyru);
        }
        // kiek vyru
        // amziu vidurkis


    }
}
