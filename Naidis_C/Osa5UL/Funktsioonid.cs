using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_C.Osa5UL
{
    public static class Funktsioonid
    {
        public class Toode
        {
            public string Nimi;
            public double Kalorid100g;
        }

        public class Inimene
        {
            public string Nimi;
            public int Vanus;
            public string Sugu;
            public double Pikkus;
            public double Kaal;
            public double Aktiivsus;
        }

        public static void KaloriKalkulaator()
        {
            List<Toode> tooted = new List<Toode>()
        {
            new Toode{Nimi="Õun", Kalorid100g=52},
            new Toode{Nimi="Kana", Kalorid100g=239},
            new Toode{Nimi="Riis", Kalorid100g=130}
        };

            Inimene inimene = new Inimene();

            Console.Write("Nimi: ");
            inimene.Nimi = Console.ReadLine();

            Console.Write("Vanus: ");
            inimene.Vanus = int.Parse(Console.ReadLine());

            Console.Write("Sugu (M/N): ");
            inimene.Sugu = Console.ReadLine();

            Console.Write("Pikkus (cm): ");
            inimene.Pikkus = double.Parse(Console.ReadLine());

            Console.Write("Kaal (kg): ");
            inimene.Kaal = double.Parse(Console.ReadLine());

            Console.Write("Aktiivsus (1.2-1.9): ");
            inimene.Aktiivsus = double.Parse(Console.ReadLine());

            double bmr;

            if (inimene.Sugu.ToUpper() == "M")
                bmr = 88.36 + (13.4 * inimene.Kaal) + (4.8 * inimene.Pikkus) - (5.7 * inimene.Vanus);
            else
                bmr = 447.6 + (9.2 * inimene.Kaal) + (3.1 * inimene.Pikkus) - (4.3 * inimene.Vanus);

            double kalorid = bmr * inimene.Aktiivsus;

            Console.WriteLine($"Päevane vajadus: {kalorid:F2} kcal");

            foreach (var t in tooted)
            {
                double kogus = kalorid / t.Kalorid100g * 100;
                Console.WriteLine($"{t.Nimi}: {kogus:F2} g");
            }
        }

        public static void MaardikTest()
        {
            Dictionary<string, string> maakond = new Dictionary<string, string>()
        {
            {"Harjumaa","Tallinn"},
            {"Tartumaa","Tartu"},
            {"Pärnumaa","Pärnu"}
        };

            Console.Write("Sisesta maakond või linn: ");
            string input = Console.ReadLine();

            if (maakond.ContainsKey(input))
                Console.WriteLine("Pealinn: " + maakond[input]);
            else if (maakond.ContainsValue(input))
            {
                foreach (var kv in maakond)
                    if (kv.Value == input)
                        Console.WriteLine("Maakond: " + kv.Key);
            }
            else
            {
                Console.WriteLine("Ei leitud, lisa uus.");
                Console.Write("Maakond: ");
                string m = Console.ReadLine();
                Console.Write("Linn: ");
                string l = Console.ReadLine();
                maakond[m] = l;
            }

            int correct = 0;
            Random rnd = new Random();

            var keys = maakond.Keys.ToList();

            for (int i = 0; i < 3; i++)
            {
                string k = keys[rnd.Next(keys.Count)];
                Console.Write($"Mis on {k} keskus? ");
                string ans = Console.ReadLine();

                if (ans == maakond[k])
                    correct++;
            }

            Console.WriteLine($"Tulemus: {correct * 100 / 3}%");
        }

        public class Opilane
        {
            public string Nimi;
            public List<int> Hinded;

            public double Keskmine()
            {
                return Hinded.Average();
            }
        }

        public static void Opilased()
        {
            List<Opilane> list = new List<Opilane>()
        {
            new Opilane{Nimi="Anna", Hinded=new List<int>{5,4,5}},
            new Opilane{Nimi="Mark", Hinded=new List<int>{3,4,2}},
            new Opilane{Nimi="Jaan", Hinded=new List<int>{5,5,5}}
        };

            foreach (var o in list)
                Console.WriteLine($"{o.Nimi}: {o.Keskmine():F2}");

            var best = list.OrderByDescending(x => x.Keskmine()).First();
            Console.WriteLine("Parim: " + best.Nimi);

            var sorted = list.OrderBy(x => x.Keskmine());
            Console.WriteLine("Sorteeritud:");
            foreach (var o in sorted)
                Console.WriteLine(o.Nimi);
        }

        public class Film
        {
            public string Pealkiri;
            public int Aasta;
            public string Zhanr;
        }

        public static void Filmid()
        {
            List<Film> filmid = new List<Film>()
        {
            new Film{Pealkiri="Matrix", Aasta=1999, Zhanr="Sci-Fi"},
            new Film{Pealkiri="Titanic", Aasta=1997, Zhanr="Romance"},
            new Film{Pealkiri="Avatar", Aasta=2009, Zhanr="Sci-Fi"},
            new Film{Pealkiri="Joker", Aasta=2019, Zhanr="Drama"},
            new Film{Pealkiri="Batman", Aasta=2022, Zhanr="Action"}
        };

            Console.Write("Sisesta žanr: ");
            string z = Console.ReadLine();

            var tulem = filmid.Where(f => f.Zhanr == z);
            foreach (var f in tulem)
                Console.WriteLine(f.Pealkiri);

            var uusim = filmid.OrderByDescending(f => f.Aasta).First();
            Console.WriteLine("Uusim: " + uusim.Pealkiri);

            var grupp = filmid.GroupBy(f => f.Zhanr);

            foreach (var g in grupp)
            {
                Console.WriteLine("Žanr: " + g.Key);
                foreach (var f in g)
                    Console.WriteLine(" - " + f.Pealkiri);
            }
        }

        public static void MassiivStatistika()
        {
            Console.Write("Sisesta arvud: ");
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            double max = arr.Max();
            double min = arr.Min();
            double avg = arr.Average();
            double sum = arr.Sum();

            Console.WriteLine($"Max: {max}, Min: {min}, Avg: {avg}, Sum: {sum}");

            int count = arr.Count(x => x > avg);
            Console.WriteLine("Suuremad kui keskmine: " + count);

            Array.Sort(arr);
            Console.WriteLine("Sorteeritud: " + string.Join(", ", arr));
        }

        public class Lemmikloom
        {
            public string Nimi;
            public string Liik;
            public int Vanus;
        }

        public static void Lemmikloomad()
        {
            List<Lemmikloom> list = new List<Lemmikloom>();

            for (int i = 0; i < 5; i++)
            {
                Lemmikloom l = new Lemmikloom();
                Console.Write("Nimi: ");
                l.Nimi = Console.ReadLine();
                Console.Write("Liik: ");
                l.Liik = Console.ReadLine();
                Console.Write("Vanus: ");
                l.Vanus = int.Parse(Console.ReadLine());

                list.Add(l);
            }

            Console.WriteLine("Kassid:");
            foreach (var l in list.Where(x => x.Liik == "kass"))
                Console.WriteLine(l.Nimi);

            Console.WriteLine("Keskmine vanus: " + list.Average(x => x.Vanus));

            var vanim = list.OrderByDescending(x => x.Vanus).First();
            Console.WriteLine("Vanim: " + vanim.Nimi);

            Console.Write("Otsi nime: ");
            string nimi = Console.ReadLine();

            var leitud = list.FirstOrDefault(x => x.Nimi == nimi);
            if (leitud != null)
                Console.WriteLine("Leitud: " + leitud.Nimi);
        }

        public class Valuuta
        {
            public string Nimi;
            public double Kurss;
        }

        public static void ValuutaKalkulaator()
        {
            Dictionary<string, Valuuta> val = new Dictionary<string, Valuuta>()
        {
            {"USD", new Valuuta{Nimi="USD", Kurss=1.1}},
            {"GBP", new Valuuta{Nimi="GBP", Kurss=0.85}}
        };

            Console.Write("Summa: ");
            double summa = double.Parse(Console.ReadLine());

            Console.Write("Valuuta (USD/GBP): ");
            string v = Console.ReadLine().ToUpper();

            if (val.ContainsKey(v))
            {
                double eur = summa / val[v].Kurss;
                Console.WriteLine($"EUR: {eur:F2}");

                double tagasi = eur * val[v].Kurss;
                Console.WriteLine($"{v}: {tagasi:F2}");
            }
        }
    }
}