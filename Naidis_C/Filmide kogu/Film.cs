using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_C.Filmide_kogu
{
    class Film
    {
        public string Pealkiri { get; set; }
        public int Aasta { get; set; }
        public string Zanr { get; set; }

        public Film(string pealkiri, int aasta, string zanr)
        {
            Pealkiri = pealkiri;
            Aasta = aasta;
            Zanr = zanr;
        }
    }

    class Program
    {
        static void Main()
        {
            List<Film> filmid = new List<Film>()
        {
            new Film("Inception", 2010, "Sci-Fi"),
            new Film("Titanic", 1997, "Romance"),
            new Film("The Matrix", 1999, "Sci-Fi"),
            new Film("Avengers: Endgame", 2019, "Action"),
            new Film("The Notebook", 2004, "Romance")
        };

            Console.Write("Sisesta žanr: ");
            string zanr = Console.ReadLine();

            var zanriFilmid = LeiaZanriJargi(filmid, zanr);

            Console.WriteLine("\nSelle žanri filmid:");
            foreach (var f in zanriFilmid)
            {
                Console.WriteLine($"{f.Pealkiri} ({f.Aasta})");
            }

            var uusim = LeiaUusimFilm(filmid);
            Console.WriteLine($"\nUusim film: {uusim.Pealkiri} ({uusim.Aasta})");

            var grupid = GrupeeriZanriJargi(filmid);

            Console.WriteLine("\nFilmid žanrite kaupa:");
            foreach (var grupp in grupid)
            {
                Console.WriteLine($"\n{grupp.Key}:");
                foreach (var f in grupp.Value)
                {
                    Console.WriteLine($"{f.Pealkiri} ({f.Aasta})");
                }
            }
        }

        static List<Film> LeiaZanriJargi(List<Film> filmid, string zanr)
        {
            return filmid
                .Where(f => f.Zanr.Equals(zanr, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        static Film LeiaUusimFilm(List<Film> filmid)
        {
            return filmid.OrderByDescending(f => f.Aasta).First();
        }

        static Dictionary<string, List<Film>> GrupeeriZanriJargi(List<Film> filmid)
        {
            return filmid
                .GroupBy(f => f.Zanr)
                .ToDictionary(g => g.Key, g => g.ToList());
        }
    }
}