using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        }
        static void Main(string[] args)
        {
            Namas n1 = new Namas("Taikos", 10);
            Namas n2 = new Namas();

            Console.WriteLine($"{n1.gatve} {n1.numeris}");
            Console.WriteLine($"{n2.gatve} {n2.numeris}");
        }
    }
}

