using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_C
{
    internal class Maakonnadjapealinnad
    {
        static void Main()
        {
            Dictionary<string, string> maakonnad = new Dictionary<string, string>()
        {
            { "Harjumaa", "Tallinn" },
            { "Tartumaa", "Tartu" },
            { "Pärnumaa", "Pärnu" },
            { "Ida-Virumaa", "Jõhvi" }
        };

            while (true)
            {
                Console.WriteLine("\nVali tegevus:");
                Console.WriteLine("1 - Leia pealinn maakonna järgi");
                Console.WriteLine("2 - Leia maakond pealinna järgi");
                Console.WriteLine("3 - Lisa uus andmepaar");
                Console.WriteLine("4 - Mäng");
                Console.WriteLine("0 - Välju");

                string valik = Console.ReadLine();

                if (valik == "0") break;

                switch (valik)
                {
                    case "1":
                        Console.Write("Sisesta maakonna nimi: ");
                        string maakond = Console.ReadLine();

                        if (maakonnad.ContainsKey(maakond))
                        {
                            Console.WriteLine($"Pealinn: {maakonnad[maakond]}");
                        }
                        else
                        {
                            Console.WriteLine("Andmeid pole. Lisa need!");
                        }
                        break;

                    case "2":
                        Console.Write("Sisesta pealinna nimi: ");
                        string linn = Console.ReadLine();

                        bool leitud = false;
                        foreach (var paar in maakonnad)
                        {
                            if (paar.Value.Equals(linn, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine($"Maakond: {paar.Key}");
                                leitud = true;
                                break;
                            }
                        }

                        if (!leitud)
                        {
                            Console.WriteLine("Andmeid pole. Lisa need!");
                        }
                        break;

                    case "3":
                        Console.Write("Sisesta maakond: ");
                        string uusMaakond = Console.ReadLine();

                        Console.Write("Sisesta pealinn: ");
                        string uusLinn = Console.ReadLine();

                        if (!maakonnad.ContainsKey(uusMaakond))
                        {
                            maakonnad.Add(uusMaakond, uusLinn);
                            Console.WriteLine("Lisatud!");
                        }
                        else
                        {
                            Console.WriteLine("See maakond on juba olemas.");
                        }
                        break;

                    case "4":
                        Mäng(maakonnad);
                        break;

                    default:
                        Console.WriteLine("Vale valik!");
                        break;
                }
            }
        }

        static void Mäng(Dictionary<string, string> maakonnad)
        {
            Random rnd = new Random();
            int küsimused = 5;
            int õiged = 0;

            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>(maakonnad);

            for (int i = 0; i < küsimused; i++)
            {
                var paar = list[rnd.Next(list.Count)];

                if (rnd.Next(2) == 0)
                {
                    Console.Write($"Mis on maakonna {paar.Key} pealinn? ");
                    string vastus = Console.ReadLine();

                    if (vastus.Equals(paar.Value, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Õige!");
                        õiged++;
                    }
                    else
                    {
                        Console.WriteLine($"Vale! Õige vastus: {paar.Value}");
                    }
                }
                else
                {
                    Console.Write($"Milline maakond kuulub linnale {paar.Value}? ");
                    string vastus = Console.ReadLine();

                    if (vastus.Equals(paar.Key, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Õige!");
                        õiged++;
                    }
                    else
                    {
                        Console.WriteLine($"Vale! Õige vastus: {paar.Key}");
                    }
                }
            }

            double protsent = (double)õiged / küsimused * 100;
            Console.WriteLine($"\nTulemus: {protsent}%");
        }
    }
}