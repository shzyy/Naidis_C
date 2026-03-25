using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_C.Osa5UL
{
    internal class StartPage
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n=== MENÜÜ ===");
                Console.WriteLine("1 - Kalorite kalkulaator");
                Console.WriteLine("2 - Maakonnad ja pealinnad");
                Console.WriteLine("3 - Õpilased");
                Console.WriteLine("4 - Filmid");
                Console.WriteLine("5 - Massiivi statistika");
                Console.WriteLine("6 - Lemmikloomad");
                Console.WriteLine("7 - Valuutakalkulaator");
                Console.WriteLine("0 - Välju");

                string valik = Console.ReadLine();

                switch (valik)
                {
                    case "1": Funktsioonid.KaloriKalkulaator(); break;
                    case "2": Funktsioonid.MaardikTest(); break;
                    case "3": Funktsioonid.Opilased(); break;
                    case "4": Funktsioonid.Filmid(); break;
                    case "5": Funktsioonid.MassiivStatistika(); break;
                    case "6": Funktsioonid.Lemmikloomad(); break;
                    case "7": Funktsioonid.ValuutaKalkulaator(); break;
                    case "0": return;
                }
            }
        }
    }
}

