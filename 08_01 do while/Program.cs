using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_01_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-saskaitos likutis\n2-papildyti saskaita\n3-informacija\n4-baigti\n");

            int likutis = 0;
            int pasirinkimas;
            int papildymas = 0;

            var random = new Random();
            int atsitiktinis = random.Next(1000, 5000);

            do
            {
                Console.Write("Pasirinkite veiksma: ");
                pasirinkimas = Convert.ToInt32(Console.ReadLine());
                if(pasirinkimas == 1)
                {
                    Console.WriteLine("Saskaitos likutis: {0} eur.\n", likutis);
                }
                else if(pasirinkimas == 2)
                {
                    Console.Write("Irasykite suma, kiek papildyti saskaita: ");
                    papildymas = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Vykdoma operacija, prasome palaukti...");
                    System.Threading.Thread.Sleep(atsitiktinis); // random laika nuo [1sec - 5sec) miega
                    Console.WriteLine("\nSaskaita papildyta.\n");
                    likutis += papildymas;
                }
                else if(pasirinkimas == 3)
                {
                    Console.WriteLine("1-saskaitos likutis\n2-papildyti saskaita\n3-informacija\n4-baigti\n");
                }
                else if(pasirinkimas < 1)
                {
                    Console.WriteLine("Tokio veiksmo nera.\n");
                }

            } while (pasirinkimas < 4);
            Console.WriteLine("Atsijungete nuo sistemos...");
        }
    }
}
