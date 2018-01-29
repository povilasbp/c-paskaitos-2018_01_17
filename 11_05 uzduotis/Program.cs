using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_05_uzduotis
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
            double skaicius1 = 0;
            double skaicius2 = 0;
            int veiksmas;
            int veiksmas2 = 0;
            char matematinis_veiksmas = ' ';
            bool ar_testi = true;

            Console.WriteLine("Iveskite du skaicius: ");
            while (ar_testi)
            {
                IvestiSkaicius(ref skaicius1, ref skaicius2);

                bool ar_testi1 = true;
                while (ar_testi1)
                {
                    IsvestiVeiksmus();
                    Console.Write("Iveskite veiksma: ");
                    veiksmas = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("-------------------------------");

                    switch (veiksmas)
                    {
                        case 1:
                           Veiksmas(skaicius1, skaicius2, '+', ref veiksmas2);
                            break;
                        case 2:
                            Veiksmas(skaicius1, skaicius2, '-', ref veiksmas2);
                            break;

                        case 3:
                            Veiksmas(skaicius1, skaicius2, '*', ref veiksmas2);
                            break;
                        case 4:
                            Veiksmas(skaicius1, skaicius2, '/', ref veiksmas2);
                            break;
                        case 5:
                            Skaiciavimas();
                            break;
                        default:
                            break;
                    }
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
                }
            }
            Console.WriteLine("Programa baige darba................................");


        }
        public static void IsvestiVeiksmus()
        {
            Console.WriteLine(" --------------------------------");
            Console.WriteLine("| {0,-30}|", "1 - sudeti");
            Console.WriteLine("| {0,-30}|", "2 - atimti");
            Console.WriteLine("| {0,-30}|", "3 - sudauginti");
            Console.WriteLine("| {0,-30}|", "4 - padalinti");
            Console.WriteLine("| {0,-30}|", "5 - Is naujo vesti skaiciu");
            Console.WriteLine(" -------------------------------");
        }

        public static void IvestiSkaicius(ref double a, ref double b)
        {
            Console.Write("1-as skaicius: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("2-as skaicius: ");
            b = Convert.ToDouble(Console.ReadLine());
        }

        public static void Veiksmas(double skaicius1, double skaicius2, char matematinis_veiksmas, ref int veiksmas2)
        {
            double atsakymas = Atsakymas(skaicius1, skaicius2, matematinis_veiksmas);

            Console.WriteLine("*** Atsakymas: {0} {1} {2} = {3}", skaicius1, matematinis_veiksmas, skaicius2, atsakymas);
            Console.WriteLine("1 - kitas veiksmas");
            Console.WriteLine("2 - is naujo vesti skaicius");
            Console.WriteLine("3 - baigti darba");
            Console.WriteLine("-------------------------------");
            Console.Write("Iveskite veiksma: ");
            veiksmas2 = Convert.ToInt32(Console.ReadLine());
        }

        public static double Atsakymas(double skaicius1, double skaicius2, char veiksmas)
        {
            switch (veiksmas)
            {
                case '+':
                    return skaicius1 + skaicius2;
                case '-':
                    return skaicius1 - skaicius2;
                case '*':
                    return skaicius1 * skaicius2;
                case '/':
                    return Math.Round(skaicius1 / skaicius2, 2);
                default:
                    return 0;
            }
        }

    }
}
