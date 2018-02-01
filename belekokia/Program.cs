using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace belekokia
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new List<int> { };
            skaiciai.Add(5);
            skaiciai.Add(3);
            skaiciai.Add(8);
            Console.WriteLine(skaiciai[2]);
        }
    }
}
