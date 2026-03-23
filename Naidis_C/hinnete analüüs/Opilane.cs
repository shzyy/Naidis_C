using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_C.hinnete_analüüs
{
    internal class Opilane
    {
        public string Nimi { get; set; }
        public List<int> Hinded { get; set; }

        public opilane(string nimi, List<int> hinded)
        {
            Nimi = nimi;
            Hinded = hinded;
        }

        public double Keskmine()
        {
            return Hinded.Average();
        }
    }

    class Program
    {
        static void Main()
        {
            List<Opilane> opilased = new List<Opilane>()
        {
            new Opilane("Mari", new List<int> { 5, 4, 5, 3 }),
            new Opilane("Jaan", new List<int> { 3, 4, 2, 5 }),
            new Opilane("Kati", new List<int> { 5, 5, 4, 5 })
        };

            Console.WriteLine("Õpilaste keskmised hinded:");

            foreach (var opilane in opilased)
            {
                Console.WriteLine($"{opilane.Nimi}: {opilane.Keskmine():F2}");
            }

            var parim = opilased.OrderByDescending(o => o.Keskmine()).First();

            Console.WriteLine($"\nParim õpilane: {parim.Nimi} ({parim.Keskmine():F2})");

            Console.WriteLine("\nÕpilased sorteeritult (kõrgeimast madalaimani):");

            var sorteeritud = opilased.OrderByDescending(o => o.Keskmine());

            foreach (var opilane in sorteeritud)
            {
                Console.WriteLine($"{opilane.Nimi}: {opilane.Keskmine():F2}");
            }
        }
    }
}

