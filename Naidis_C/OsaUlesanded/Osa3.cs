using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_C.OsaUlesanded
{
    internal class Osa3
    {
        public static int[] GenereeriRuudud(int min, int max)
        {
            Random rnd = new Random();

            int n = rnd.Next(min, max + 1);
            int m = rnd.Next(min, max + 1);

            int start = Math.Min(n, m);
            int end = Math.Max(n, m);

            int[] ruudud = new int[end - start + 1];

            for (int i = 0; i < ruudud.Length; i++)
            {
                int arv = start + i;
                ruudud[i] = arv * arv;
            }

            return ruudud;
        }

        static void Main()
        {
            int[] tulemused = Osa3.GenereeriRuudud(1, 10);

            int arv = 1;
            foreach (var r in tulemused)
            {
                Console.WriteLine($"{arv} -> {r}");
                arv++;
            }
        }
    
    static Tuple<double, double, double> AnaluusiArve(double[] arvud)
        {
            double summa = 0;
            double korrutis = 1;

            foreach (double a in arvud)
            {
                summa += a;
                korrutis *= a;
            }

            double keskmine = summa / arvud.Length;

            return Tuple.Create(summa, keskmine, korrutis);
        }
        class Inimene
        {
            public string Nimi;
            public int Vanus;
        }

        static Tuple<int, double, Inimene, Inimene> Statistika(List<Inimene> inimesed)
        {
            int summa = 0;

            Inimene vanim = inimesed[0];
            Inimene noorim = inimesed[0];

            foreach (var i in inimesed)
            {
                summa += i.Vanus;

                if (i.Vanus > vanim.Vanus)
                    vanim = i;

                if (i.Vanus < noorim.Vanus)
                    noorim = i;
            }

            double keskmine = (double)summa / inimesed.Count;

            return Tuple.Create(summa, keskmine, vanim, noorim);
        }
        static void KuniMarksOnani(string marksona, string fraas)
        {
            List<string> sisendid = new List<string>();
            string input;

            do
            {
                Console.WriteLine(fraas);
                input = Console.ReadLine();

                sisendid.Add(input);

            } while (input != marksona);

            Console.WriteLine("Sisestused:");

            foreach (var s in sisendid)
                Console.WriteLine(s);
        }
        static void ArvaArv()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 101);

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Arva arv: ");
                int guess = int.Parse(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("Õige!");
                    return;
                }
                else if (guess > number)
                    Console.WriteLine("Liiga suur");
                else
                    Console.WriteLine("Liiga väike");
            }

            Console.WriteLine("Katseid pole rohkem!");
        }
        static int SuurimNeliarv(int[] arvud)
        {
            Array.Sort(arvud);
            Array.Reverse(arvud);

            int result = 0;

            foreach (int a in arvud)
            {
                if (a < 0 || a > 9)
                {
                    Console.WriteLine("Vale number!");
                    return 0;
                }

                result = result * 10 + a;
            }

            return result;
        }
        static void GenereeriKorrutustabel(int read, int veerud)
        {
            int[,] tabel = new int[read, veerud];

            for (int i = 0; i < read; i++)
            {
                for (int j = 0; j < veerud; j++)
                {
                    tabel[i, j] = (i + 1) * (j + 1);
                    Console.Write(tabel[i, j].ToString().PadLeft(4));
                }

                Console.WriteLine();
            }
        }

    }
}



