using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_03_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int skaicius1;
            int skaicius2;
            bool testi = true;
            char ar_testi;

            while(testi)
            {
                // ivedimas
                Console.Write("1-as skaicius: ");
                skaicius1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2-as skaicius: ");
                skaicius2 = Convert.ToInt32(Console.ReadLine());
                //------------------------------------------------

                // skaiciavimas ir isvedimas
                Console.WriteLine("{0} + {1} = {2}",skaicius1,skaicius2,skaicius1+skaicius2);
                Console.WriteLine("{0} - {1} = {2}", skaicius1, skaicius2, skaicius1 - skaicius2);
                Console.WriteLine("{0} * {1} = {2}", skaicius1, skaicius2, skaicius1 * skaicius2);
                Console.WriteLine("{0} / {1} = {2}", skaicius1, skaicius2, skaicius1 / skaicius2);
                //----------------------------------------------------------------------------------

                // patikrinimas ar testi;
                Console.Write("Testi toliau? y/n");
                ar_testi = Convert.ToChar(Console.ReadLine());
                if(ar_testi == 't' || ar_testi == 'T')
                {
                    testi = true;
                }
                else if (ar_testi == 'n' || ar_testi == 'N')
                {
                    Console.WriteLine("Programa baige darba...");
                    testi = false;
                }
                //--------------------------------------------

            }
        }
    }
}
