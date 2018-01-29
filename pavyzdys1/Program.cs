using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pavyzdys1
{
    class Matematika
    {
        public static int Suma(int a, int b)
        {
            return a + b;
        }

        public static int Skirtumas(int a, int b)
        {
            return a - b;
        }

        public static int Daugyba(int a, int b)
        {
            return a * b;
        }

        public static double Dalyba(int a, int b)
        {
            return a / b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Pasisveikinti();
            //Atsisveikinti();
            //Program p = new Program();
            //p.Pinigai();
            //p.Automobilis();

            Matematika matieka = new Matematika();

            int suma = Matematika.Suma(1,2);
            int skirtumas = Matematika.Skirtumas(1,2);
            int sandauga = Matematika.Daugyba(1,2);
            double dalyba = Matematika.Dalyba(1,2);
            Console.WriteLine("Suma: {0}", suma);
            Console.WriteLine("Skirtumas: {0}", skirtumas);
            Console.WriteLine("Sandauga: {0}", sandauga);
            Console.WriteLine("Dalyba: {0}", dalyba);
        }
        public static void Pasisveikinti()
        {
            Console.WriteLine("Jusu vardas: ");
            Console.WriteLine("Labas, " + Console.ReadLine());
        }

        public static void Atsisveikinti()
        {
            Console.WriteLine("Viso gero");
        }

        public void Pinigai()
        {
            Console.WriteLine("Pasakykite ka daro pinigai");
            var pinigai = Console.ReadLine();
            Console.WriteLine("aciu, jusu atsakymas priimtas, jis yra: ");
            Console.WriteLine(pinigai);
        }

        public void Automobilis()
        {
            Console.WriteLine("ka vairuojate?");
            var auto = Console.ReadLine();
            if(auto == "kamaz")
            {
                Console.WriteLine("nice");
            }
        }
    }
}
