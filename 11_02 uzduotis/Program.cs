using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Skaiciavimas();


        }

        public void Skaiciavimas()
        {
            double skaicius1;
            double skaicius2;
            int veiksmas;
            int veiksmas2;
            char matematinis_veiksmas;
            bool ar_testi = true;

            Console.WriteLine("Iveskite du skaicius: ");
            while (ar_testi)
            {
                Console.Write("1-as skaicius: ");
                skaicius1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2-as skaicius: ");
                skaicius2 = Convert.ToInt32(Console.ReadLine());

                bool ar_testi1 = true;
                while (ar_testi1)
                {
                    Console.WriteLine(" ------------------------------");
                Console.WriteLine("| 1 - sudeti                  |");
                Console.WriteLine("| 2 - atimti                  |");
                Console.WriteLine("| 3 - sudauginti              |");
                Console.WriteLine("| 4 - padalinti               |");
                Console.WriteLine("| 5 - Is naujo vesti skaicius |");
                    Console.WriteLine(" ------------------------------");
                    Console.Write("Iveskite veiksma: ");
                    veiksmas = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("-------------------------------");

                    switch (veiksmas)
                    {
                        case 1:
                            matematinis_veiksmas = '+';
                            Console.WriteLine("*** Atsakymas: {0} {1} {2} = {3}", skaicius1, matematinis_veiksmas, skaicius2, (skaicius1 + skaicius2));
                            Console.WriteLine("1 - kitas veiksmas");
                            Console.WriteLine("2 - is naujo vesti skaicius");
                            Console.WriteLine("3 - baigti darba");
                            Console.WriteLine("-------------------------------");
                            Console.Write("Iveskite veiksma: ");
                            veiksmas2 = Convert.ToInt32(Console.ReadLine());
                            switch (veiksmas2)
                            {
                                case 1:
                                    ar_testi1 = true;
                                    break;
                                case 2:
                                    Skaiciavimas();
                                    break;
                                case 3:
                                    ar_testi1 = false;
                                    ar_testi = false;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 2:
                            matematinis_veiksmas = '-';
                            Console.WriteLine("*** Atsakymas: {0} {1} {2} = {3}", skaicius1, matematinis_veiksmas, skaicius2, (skaicius1 - skaicius2));
                            Console.WriteLine("1 - kitas veiksmas");
                            Console.WriteLine("2 - is naujo vesti skaicius");
                            Console.WriteLine("3 - baigti darba");
                            Console.WriteLine("-------------------------------");
                            Console.Write("Iveskite veiksma: ");
                            veiksmas2 = Convert.ToInt32(Console.ReadLine());
                            switch (veiksmas2)
                            {
                                case 1:
                                    ar_testi1 = true;
                                    break;
                                case 2:
                                    Skaiciavimas();
                                    break;
                                case 3:
                                    ar_testi1 = false;
                                    ar_testi = false;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 3:
                            matematinis_veiksmas = '*';
                            Console.WriteLine("*** Atsakymas: {0} {1} {2} = {3}", skaicius1, matematinis_veiksmas, skaicius2, (skaicius1 * skaicius2));
                            Console.WriteLine("1 - kitas veiksmas");
                            Console.WriteLine("2 - is naujo vesti skaicius");
                            Console.WriteLine("3 - baigti darba");
                            Console.WriteLine("-------------------------------");
                            Console.Write("Iveskite veiksma: ");
                            veiksmas2 = Convert.ToInt32(Console.ReadLine());
                            switch (veiksmas2)
                            {
                                case 1:
                                    ar_testi1 = true;
                                    break;
                                case 2:
                                    Skaiciavimas();
                                    break;
                                case 3:
                                    ar_testi1 = false;
                                    ar_testi = false;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 4:
                            matematinis_veiksmas = '/';
                            Console.WriteLine("*** Atsakymas: {0} {1} {2} = {3}", skaicius1, matematinis_veiksmas, skaicius2, (double)(skaicius1 / skaicius2));
                            Console.WriteLine("1 - kitas veiksmas");
                            Console.WriteLine("2 - is naujo vesti skaicius");
                            Console.WriteLine("3 - baigti darba");
                            Console.WriteLine("-------------------------------");
                            Console.Write("Iveskite veiksma: ");
                            veiksmas2 = Convert.ToInt32(Console.ReadLine());
                            switch (veiksmas2)
                            {
                                case 1:
                                    ar_testi1 = true;
                                    break;
                                case 2:
                                    Skaiciavimas();
                                    break;
                                case 3:
                                    ar_testi1 = false;
                                    ar_testi = false;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 5:
                            Skaiciavimas();
                            break;
                        default:
                            break;
                    }
                }
            }
            Console.WriteLine("Programa baige darba................................");


        }

    }
}
