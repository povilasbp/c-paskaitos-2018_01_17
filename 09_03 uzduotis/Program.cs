using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pazymiai = { 10,9,10,8,5,3,7,7,6,5,6,8,7,10,8,10,7,5,4,2,8,10,7,8,9,5}; // 26 reiksmiu
            Console.WriteLine("Visi studentu pazymiai: ");
            int stulpelis = 0;
            foreach (var paz in pazymiai)
            {
                if(stulpelis == 11)
                {
                    Console.WriteLine();
                    stulpelis = 0;
                }
                Console.Write(paz + " ");
                stulpelis++;
            }
            Console.WriteLine();


            // Ieskom geriausio-------------------------------------
            int geriausias = 0;
            foreach (var paz in pazymiai)
            {
                if(geriausias < paz)
                {
                    geriausias = paz;
                }
            }
            Console.WriteLine("Geriausias pazymys: {0}", geriausias);
            //--------------------------------------------------------
            // Kiek mokiniu gavo 10 ----------------------------------
            // Kiek mokiniu gavo maziau nei 4 ------------------------
            // Pazymiu vidurkis --------------------------------------
            int kiek_gavo_10 = 0;
            int kiek_gavo_maziau_4 = 0;
            foreach (var paz in pazymiai)
            {
                if(paz == 10)
                {
                    kiek_gavo_10++;
                }
                if(paz < 4)
                {
                    kiek_gavo_maziau_4++;
                }
            }
            Console.WriteLine("10-tukus gavo {0} mokiniai", kiek_gavo_10);
            Console.WriteLine("Maziau 4-is gavo {0} mokiniai", kiek_gavo_maziau_4);
            Console.WriteLine("Pazymiu vidurkis: {0}", pazymiai.Sum() / pazymiai.Length);
            //--------------------------------------------------------


        }
    }
}