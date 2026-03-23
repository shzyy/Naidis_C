using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_C.massiivistatistika
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Sisesta arvud (eralda tühikuga):");
            string sisend = Console.ReadLine();

            double[] arvud = Tekstist_arvud(sisend);

            AnaluusiArvud(arvud);
        }

        // Funktsioon: teisendab teksti arvude massiiviks
        static double[] Tekstist_arvud(string tekst)
        {
            return tekst
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x))
                .ToArray();
        }

        // Funktsioon: analüüs
        static void AnaluusiArvud(double[] arvud)
        {
            double max = arvud.Max();
            double min = arvud.Min();
            double keskmine = arvud.Average();
            double summa = arvud.Sum();

            Console.WriteLine($"\nMax: {max}");
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Keskmine: {keskmine:F2}");
            Console.WriteLine($"Summa: {summa}");

            int suuremad = arvud.Count(x => x > keskmine);
            Console.WriteLine($"Arve, mis on suuremad kui keskmine: {suuremad}");

            // BONUS: sorteerimine
            Array.Sort(arvud);

            Console.WriteLine("\nSorteeritud arvud:");
            foreach (var a in arvud)
            {
                Console.Write(a + " ");
            }
        }
    }
}

