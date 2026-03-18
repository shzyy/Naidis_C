using System.Xml.Linq;

namespace Kaloritekalkulaator
{
    internal class Program
    {
        
            static void Main()
            {
                List<Toode> tooted = new List<Toode>()
        {
            new Toode("Õun", 52),
            new Toode("Kana", 239),
            new Toode("Riis", 130),
            new Toode("Šokolaad", 546),
            new Toode("Kartul", 77)
        };

                Console.Write("Sisesta nimi: ");
                string nimi = Console.ReadLine();

                Console.Write("Vanus: ");
                int vanus = int.Parse(Console.ReadLine());

                Console.Write("Sugu (mees/naine): ");
                string sugu = Console.ReadLine();

                Console.Write("Pikkus (cm): ");
                double pikkus = double.Parse(Console.ReadLine());

                Console.Write("Kaal (kg): ");
                double kaal = double.Parse(Console.ReadLine());

                Console.WriteLine("Aktiivsustase:");
                Console.WriteLine("1.2 - vähe aktiivne");
                Console.WriteLine("1.375 - kerge aktiivsus");
                Console.WriteLine("1.55 - mõõdukas");
                Console.WriteLine("1.725 - väga aktiivne");
                Console.Write("Vali: ");
                double aktiivsus = double.Parse(Console.ReadLine());

                Inimene inimene = new Inimene()
                {
                    Nimi = nimi,
                    Vanus = vanus,
                    Sugu = sugu,
                    Pikkus = pikkus,
                    Kaal = kaal,
                    Aktiivsustase = aktiivsus
                };

                double paevaneKalor = inimene.PaevaneEnergia();

                Console.WriteLine($"\n{nimi}, sinu päevane energiavajadus on: {paevaneKalor:F2} kcal\n");

                Console.WriteLine("Toidusoovitused:");
                foreach (var toode in tooted)
                {
                    double grammid = (paevaneKalor / toode.Kalorid100g) * 100;
                    Console.WriteLine($"{toode.Nimi}: {grammid:F0} g päevas");
                }
            }
        }
    }