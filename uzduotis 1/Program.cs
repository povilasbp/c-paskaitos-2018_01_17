using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int darbo_diena = 8; //val

            int kiek_darbuotojas_iskepa;
            int darbuotoju_skaicius;
            int duonos_savikaina; // 1 kepalo
            int duonos_kaina; // uz kiek parduoda
            int uzsakymu_skaicius; // kiek uzsakymu ta diena

            // INFO IVEDIMAS--------------------------------------------
            Console.WriteLine("-Iveskite duomenis-");
            Console.Write("Darbuotoju skaicius: ");
            darbuotoju_skaicius = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kiek duonos kepalu iskepa 1 darbuotojas per valanda: ");
            kiek_darbuotojas_iskepa = Convert.ToInt32(Console.ReadLine());
            Console.Write("Duonos savikaina: ");
            duonos_savikaina = Convert.ToInt32(Console.ReadLine());
            Console.Write("Duonos kaina parduodant: ");
            duonos_kaina = Convert.ToInt32(Console.ReadLine());
            Console.Write("Uzsakymu skaicius sia diena: ");
            uzsakymu_skaicius = Convert.ToInt32(Console.ReadLine());
            //----------------------------------------------------------

            // SPRENDIMAS-----------------------------------------------
            Console.WriteLine("-----------ATSAKYMAI-------------");
            // kiek kepykla per vieną darbo dieną spės iškepti duonos kepalų.
            int duonos_kiekis = 0; // kiek kepykla iskepa per diena duonos kepalu
            duonos_kiekis = (darbuotoju_skaicius * kiek_darbuotojas_iskepa) * darbo_diena;
            Console.WriteLine("Per diena kepykla iskepa: " + duonos_kiekis + " kepalu.");

            int savikaina = duonos_kiekis * duonos_savikaina; // visi ta diena iskeptu kepalu savikaina
            int pajamos = 0;
            if (uzsakymu_skaicius <= duonos_kiekis)
            {
                pajamos = uzsakymu_skaicius * duonos_kaina; // jei iskepem per mazai
            }
            else
                pajamos = duonos_kiekis * duonos_kaina; // jei iskepem per daug


 
            int pelnas = pajamos - savikaina; // tos dienos pelnas
            Console.WriteLine("Dienos pelnas: " + pelnas + " pinigu.");
        }
    }
}
