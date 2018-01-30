using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_05_garazas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Auto a1 = new Auto("Audi", "A4", 2005, 200000, 120, 2.5, "juoda");

            //a1.InfoAuto();

            //a1.AtsuktiRida();

            var garazas = new Garazas("Pas Petra", "Kaunas", 5, new List<Auto>
            {
                new Auto("Audi", "A4", 2005, 200000, 120, 2.5, "juoda"),
                new Auto("MB", "S-class", 2009, 150000, 150, 3.0, "juoda"),
                new Auto("BMW", "X5", 2004, 300000, 130, 3.0, "pilka")
            });

            garazas.InfoGarazas1();
            // garazas.AtnaujintiPasirinkta();
            garazas.Skaiciavimai();

           


        }
    }
}
