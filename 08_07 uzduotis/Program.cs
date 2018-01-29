using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_07_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite du skaicius: ");
            Console.Write("1-as skaicius: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2-as skaicius: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            int sandauga = 0;
            for(int i = 0; i < skaicius2; i++)
            {
                sandauga += skaicius1;
            }
        Console.WriteLine("Sandauga lygi "+sandauga);
        }
    }
}
