using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_C
{
    class Lemmikloom
    {
        public string Nimi { get; set; }
        public string Liik { get; set; }
        public int Vanus { get; set; }

        public Lemmikloom(string nimi, string liik, int vanus)
        {
            Nimi = nimi;
            Liik = liik;
            Vanus = vanus;
        }
    }

    class Program
    {
        static void Main()
        {
            List<Lemmikloom> loomad = new List<Lemmikloom>();

            Console.WriteLine("Sisesta vähemalt 5 lemmiklooma:\n");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Nimi: ");
                string nimi = Console.ReadLine();

                Console.Write("Liik (kass/koer jne): ");
                string liik = Console.ReadLine();

                Console.Write("Vanus: ");
                int vanus = int.Parse(Console.ReadLine());

                loomad.Add(new Lemmikloom(nimi, liik, vanus));
                Console.WriteLine();
            }

            Console.WriteLine("Kõik kassid:");
            KuvaKassid(loomad);

            double keskmine = KeskmineVanus(loomad);
            Console.WriteLine($"\nKeskmine vanus: {keskmine:F2}");

            var vanim = VanimLoom(loomad);
            Console.WriteLine($"\nVanim loom: {vanim.Nimi} ({vanim.Vanus} a)");

            Console.Write("\nSisesta nimi otsimiseks: ");
            string otsing = Console.ReadLine();

            var leitud = OtsiNimeJargi(loomad, otsing);

            if (leitud != null)
            {
                Console.WriteLine($"Leitud: {leitud.Nimi}, {leitud.Liik}, {leitud.Vanus} a");
            }
            else
            {
                Console.WriteLine("Looma ei leitud.");
            }
        }

        static void KuvaKassid(List<Lemmikloom> loomad)
        {
            foreach (var l in loomad)
            {
                if (l.Liik.Equals("kass", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{l.Nimi} ({l.Vanus} a)");
                }
            }
        }

        static double KeskmineVanus(List<Lemmikloom> loomad)
        {
            return loomad.Average(l => l.Vanus);
        }

        static Lemmikloom VanimLoom(List<Lemmikloom> loomad)
        {
            return loomad.OrderByDescending(l => l.Vanus).First();
        }

        static Lemmikloom OtsiNimeJargi(List<Lemmikloom> loomad, string nimi)
        {
            return loomad.FirstOrDefault(l =>
                l.Nimi.Equals(nimi, StringComparison.OrdinalIgnoreCase));
        }
    }
}