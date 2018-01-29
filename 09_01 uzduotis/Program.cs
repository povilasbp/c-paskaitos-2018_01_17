using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentu_pazymiai = new int[100];
            string[] automobiliu_markes = new string[50];
            char[] lotyniska_abecele = new char[26];


            // 2 uzduotis
            int ascIndeksas = 97;
            for(int i = 0; i < lotyniska_abecele.Length; i++)
            {
                lotyniska_abecele[i] = (char)ascIndeksas;
                ascIndeksas++;
                Console.Write(lotyniska_abecele[i]);
            }
            Console.WriteLine("\n");
            //------------------------------------------------


            Console.WriteLine("Nariu skaicius: {0}", lotyniska_abecele.Length);
            Console.WriteLine("Pirmas narys: {0}", lotyniska_abecele.First());
            Console.WriteLine("Paskutinis narys: {0}", lotyniska_abecele.Last());

        }
    }
}
