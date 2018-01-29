using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_01_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite teigiama skaiciu: ");
            Console.Write("skaicius: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());

            while(skaicius > 0)
            {
                Console.Write(skaicius + " ");
                skaicius--;
            }
        }
    }
}
