using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-Iveskite tris sveikuosius skaicius-");
            Console.Write("Iveskite 1-aji skaiciu: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite 2-aji skaiciu: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite 3-aji skaiciu: ");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());


            //1.1
            if (skaicius1 == skaicius2)
            {
                Console.WriteLine("{0} ir {1} yra lygus!", skaicius1, skaicius2);
            }
            else
                Console.WriteLine("{0} ir {1} nera lygus!", skaicius1, skaicius2);

            //1.2
            if (skaicius2 == skaicius3)
            {
                Console.WriteLine("{0} ir {1} yra lygus!", skaicius2, skaicius3);
            }
            else
                Console.WriteLine("{0} ir {1} nera lygus!", skaicius2, skaicius3);

            //1.3
            if (skaicius1 > skaicius2)
            {
                Console.WriteLine("{0} yra daugiau uz {1}!", skaicius1, skaicius2);
            }
            else
                Console.WriteLine("{0} yra maziau uz {1}!", skaicius1, skaicius2);

            //1.4
            if (skaicius2 > skaicius3 * 2)
            {
                Console.WriteLine("{0} yra daugiau uz {1}!", skaicius2, skaicius3 * 2);
            }
            else
                Console.WriteLine("{0} yra maziau uz {1}!", skaicius2, skaicius3 * 2);

            //1.5
            if (skaicius1 % 2 == 0)
            {
                Console.WriteLine("{0} yra lyginis!", skaicius1);
            }
            else
                Console.WriteLine("{0} nera lyginis!", skaicius1);

            //1.6
            if (skaicius2 % 2 != 0)
            {
                Console.WriteLine("{0} yra nelyginis!", skaicius2);
            }
            else
                Console.WriteLine("{0} nera nelyginis!", skaicius2);

            //1.7
            if (skaicius3 > 0)
            {
                Console.WriteLine("{0} yra daugiau uz 0!", skaicius3);
            }
            else
                Console.WriteLine("{0} yra maziau uz 0!", skaicius3);

            //1.8
            if (skaicius3 < 0)
            {
                Console.WriteLine("{0} yra maziau uz 0!", skaicius3);
            }
            else
                Console.WriteLine("{0} nera maziau uz 0!", skaicius3);
            Console.ReadKey();
        }
    }
}
