using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_05_garazas
{
    class Auto
    {
        public string Marke { get; private set; }
        public string Modelis { get; private set; }
        public int Metai { get; private set; }
        public int Rida { get; private set; }
        public int GaliaKW { get; private set; }
        public double DarbinisTuris { get; private set; }
        public string Spalva { get; private set; }

        public Auto() { }

        public Auto(string marke, string modelis, int metai, int rida, int galia, double darbinisturis, string spalva)
        {
            Marke = marke;
            Modelis = modelis;
            Metai = metai;
            Rida = rida;
            GaliaKW = galia;
            DarbinisTuris = darbinisturis;
            Spalva = spalva;
        }

        public void InfoAuto()
        {
            Console.WriteLine("{0,-6} {1,-6} {2,-6} {3,-8} {4,-6} {5,-6} {6,-5}", Marke, Modelis, Metai, Rida, GaliaKW, DarbinisTuris, Spalva);
        }

        // atsukti rida
        public void AtsuktiRida()
        {
            char ar_atsukti = ' ';
            bool ar_testi = true;
            int naujaRida = Rida;
            Console.WriteLine("Rida dabar: {0}", Rida);
            Console.Write("Ar norite atsukti rida? t/n ");
            while (ar_testi)
            {
                ar_atsukti = Convert.ToChar(Console.ReadLine());
                if (ar_atsukti == 't' || ar_atsukti == 'T')
                {
                    Console.WriteLine("Nauja rida: ");
                    naujaRida = Convert.ToInt32(Console.ReadLine());
                    Rida = naujaRida;
                    Console.WriteLine("Rida pakeista!");
                    InfoAuto();
                    ar_testi = false;
                }
                else if (ar_atsukti == 'n' || ar_atsukti == 'N')
                {
                    Console.WriteLine("Rida nepakeista\n");
                    ar_testi = false;
                }
                else
                    Console.Write("Blogai ivestas veiksmas! t/n ");
                ar_testi = true;
            }
        }
        // perdazyti

        public void Perdazyti()
        {
            char ar_atsukti = ' ';
            bool ar_testi = true;
            string naujaSpalva = Spalva;
            Console.WriteLine("Spalva dabar: {0}", Spalva);
            Console.Write("Ar norite perdazyti? t/n ");
            while (ar_testi)
            {
                ar_atsukti = Convert.ToChar(Console.ReadLine());
                if (ar_atsukti == 't' || ar_atsukti == 'T')
                {
                    Console.WriteLine("Nauja spalva: ");
                    naujaSpalva = Console.ReadLine();
                    Spalva = naujaSpalva;
                    Console.WriteLine("Spalva pakeista!");
                    InfoAuto();
                    ar_testi = false;
                }
                else if (ar_atsukti == 'n' || ar_atsukti == 'N')
                {
                    Console.WriteLine("Spalva nepakeista!\n");
                    ar_testi = false;
                }
                else
                    Console.Write("Blogai ivestas veiksmas! t/n ");
                ar_testi = true;
            }
        }
        // pakelti galia

        public void PakeltiGalia()
        {
            char ar_atsukti = ' ';
            bool ar_testi = true;
            int naujaRida = Rida;
            Console.WriteLine("Galia dabar: {0}", GaliaKW);
            Console.Write("Ar norite pakelti galia? t/n ");
            while (ar_testi)
            {
                ar_atsukti = Convert.ToChar(Console.ReadLine());
                if (ar_atsukti == 't' || ar_atsukti == 'T')
                {
                    Rida = naujaRida + 10;
                    Console.WriteLine("Galia pakelta +10kw!");
                    InfoAuto();
                    ar_testi = false;
                }
                else if (ar_atsukti == 'n' || ar_atsukti == 'N')
                {
                    Console.WriteLine("Galia nepakeista\n");
                    ar_testi = false;
                }
                else
                    Console.Write("Blogai ivestas veiksmas! t/n ");
                ar_testi = true;
            }

        }
    }
}