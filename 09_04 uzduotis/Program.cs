using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_04_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            double misrus = 8.5;

            int[] keliones = {180, 185, 380, 12, 2, 28, 54, 182, 190, 11}; // 10 kelioniu

            int viso_kilometru = keliones.Sum();
            double kuras = (double)(viso_kilometru / 100) * misrus;

            Console.WriteLine("Viso nuvaziuota: {0} km", viso_kilometru);
            Console.WriteLine("Sunaudota kuro: {0} litru", kuras);
        }
    }
}
