using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_04_while
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekstas = "";
            string zodis = "";

            while(zodis != "exit" && zodis != "Exit")
            {
                Console.Write("Iveskite zodi arba exit: ");
                zodis = Console.ReadLine();
                if(zodis != "exit" && zodis != "Exit")
                tekstas += zodis + " ";
            }
            Console.WriteLine(tekstas);
            Console.WriteLine();
        }
    }
}
