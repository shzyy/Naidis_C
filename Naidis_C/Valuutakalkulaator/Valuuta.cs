using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_C.Valuutakalkulaator
{
    class Valuuta
    {
        public string Nimetus { get; set; }
        public double KurssEurSuhte { get; set; } 

        public Valuuta(string nimetus, double kurss)
        {
            Nimetus = nimetus;
            KurssEurSuhte = kurss;
        }
    }

    class Program
    {
        static void Main()
        {
            Dictionary<string, Valuuta> valuutad = new Dictionary<string, Valuuta>()
        {
            { "EUR", new Valuuta("EUR", 1.0) },
            { "USD", new Valuuta("USD", 1.1) },
            { "GBP", new Valuuta("GBP", 0.85) },
            { "SEK", new Valuuta("SEK", 11.0) }
        };

            Console.WriteLine("Sisesta summa:");
            double summa = double.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta valuuta (nt USD):");
            string nimi = Console.ReadLine().ToUpper();

            if (!valuutad.ContainsKey(nimi))
            {
                Console.WriteLine("Valuutat ei leitud!");
                return;
            }

            Valuuta val = valuutad[nimi];

            double eur = summa / val.KurssEurSuhte;
            Console.WriteLine($"{summa} {nimi} = {eur:F2} EUR");

            Console.WriteLine("\nSisesta EUR summa:");
            double eurSumma = double.Parse(Console.ReadLine());

            double tulemus = eurSumma * val.KurssEurSuhte;
            Console.WriteLine($"{eurSumma} EUR = {tulemus:F2} {nimi}");
        }
    }
}

