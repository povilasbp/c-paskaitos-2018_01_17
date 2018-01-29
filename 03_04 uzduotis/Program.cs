using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_04_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int veiksmas1 = -1 + 4 * 6;
            int veiksmas2 = (35 + 5) % 7;
            int veiksmas3 = 14 + -4 * 6 / 11;
            int veiksmas4 = 2 + 15 / 6 * 1 - 7 % 2;

            Console.WriteLine("{0}, {1}, {2}, {3}.", veiksmas1, veiksmas2, veiksmas3, veiksmas4);
            Console.ReadKey();
        }
    }
}
