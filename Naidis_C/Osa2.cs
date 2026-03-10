using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_C
{
    internal class Osa2
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Tere Tulemast!");
            //1. küsime kasutajalt nime
            Console.WriteLine("sisesta oma eesnimi: ");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere, " + eesnimi + "!");

            // 2. Teeme valiku: KUI nimi on Juku, kutsume külla. MUIDU ütleme, et meid pole kodus.
            // .ToLower() muudab sisestatud nime väikesteks tähtedeks, et vältida vigu (nt "JUKU" vs "juku")

            if (eesnimi.ToLower() == "juku")
            {
                Console.WriteLine("Tule minu juurde külla!");
            }
            else
            {
                Console.WriteLine("Täna mind kodus pole!");
            }

            // 3. Matemaatiline tehe kasutaja sisendiga

            Console.WriteLine("\nTeeme veidi matemaatikat");
            Console.Write("Sisesta esimine arv:");
            int arv1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta teine arv:");
            int arv2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Arvude {arv1} ja {arv2} korrutis võrdub {arv1 * arv2}");

            Console.ReadLine(); //Hoiav konsooliakna lahti

        }

        public static string Kuu_nimetus(int kuu_nr)
        {
            //Kontrollime muutujat 'kuu_nr'
            string kuu = "";

            switch (kuu_nr)
            {
                case 1: kuu = "Jaanuar"; break; // 'break' lõpetab switch ploki töö
                case 2: kuu = "Veebruar"; break;
                case 3: kuu = "Märts"; break;
                case 4: kuu = "Aprill"; break;
                case 5: kuu = "Mai"; break;
                case 6: kuu = "Juuni"; break;
                case 7: kuu = "Juuli"; break;
                case 8: kuu = "August"; break;
                case 9: kuu = "September"; break;
                case 10: kuu = "Oktoober"; break;
                case 11: kuu = "November"; break;
                case 12: kuu = "Detsember"; break;

                // 'default' käivitub siis, kui ükski ülaltoodud 'case' ei sobinud (nt number oli 15)
                default:
                    kuu = "Tundmatu kuu";
                    break;
            }
            return kuu;
        }

        public static string Hooaeg(int kuu_nr)
        {
            string hoo = "";

            //Kui kuu on 1 või 2 või 12
            if (kuu_nr == 1 || kuu_nr == 2 || kuu_nr == 12)
            {
                hoo = "Talv";
            }
            // MUIDU KUI kuu on suurem kui 2 NING väiksem kui 6 (ehk 3, 4, 5)
            else if (kuu_nr > 2 && kuu_nr < 6)
            {
                hoo = "kevad";
            }
            // MUIDU KUI kuu on 6, 7 või 8
            else if (kuu_nr > 5 && kuu_nr < 9)
            {
                hoo = "suvi";
            }
            // MUIDU KUI kuu on 9, 10 või 11
            else if (kuu_nr > 8 && kuu_nr < 12)
            {
                hoo = "sügis";
            }
            // KÕIKIDEL MUUDEL JUHTUDEL
            else
            {
                hoo = "Tundumatu hooaeg";
            }

            return hoo;

        }

    }
}

