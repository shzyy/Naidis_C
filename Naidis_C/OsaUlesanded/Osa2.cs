using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_C.OsaUlesanded
{
    internal class Osa2
    {
        public static void main(string[] args)
        {
            Console.WriteLine("Sisesta nimi");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere " + eesnimi + "!");

            if (eesnimi.ToLower() == "juku")
            {
                Console.WriteLine("lähme kinno");
            }
            else
            {
                Console.WriteLine("me jääme koju");
            }
            string vastus = "";
            string pilet = "";

            try
            {
                Console.WriteLine("kui vana Juku on:");
                byte vanus = byte.Parse(Console.ReadLine());
                if (vanus > 0 && vanus < 100)
                {
                    switch (vanus)
                    {
                        case <= 6:
                            pilet = "tasutapilet";
                            break;

                        case <= 14:
                            pilet = "lastepilet";
                            break;

                        case <= 65:
                            pilet = "täispilet";
                            break;

                        case <= 100:
                            pilet = "sooduspilet";
                            break;

                    }
                    vastus = $"{eesnimi.ToUpper()}, me laheme kinno, sul on vaja {pilet}";
                }
                else
                {
                    vastus = "vale andmed";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void pinginaaber()
        {
            Console.WriteLine("Sisesta esimene naabri nimi");
            string nimi1 = (Console.ReadLine());
            Console.WriteLine("Sisesta teine naabri nimi");
            string nimi2 = (Console.ReadLine());

            Console.WriteLine($"Täna pinginaabrid on {nimi1} ja {nimi2} ");

        }

        public static void kalkulaator()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Mis on põrandi pikkus");
                    float pikkus = float.Parse(Console.ReadLine());
                    Console.WriteLine("Mis in põrandi laius");
                    float laius = float.Parse(Console.ReadLine());
                    float pindala = pikkus * laius;
                    Console.WriteLine("Põrandi pindala on: {0} m²", pindala);
                    while (true)
                    {
                        Console.WriteLine("Kas sa tahad remondi teha?\n[y/n]");
                        string valik = Console.ReadLine();
                        if (valik == "y")
                        {
                            Console.WriteLine("Siis sisestage kui palju maksab 1m²:");
                            float maksus = float.Parse(Console.ReadLine());
                            maksus *= pindala;
                            Console.WriteLine($"Sinu remond maksab: {Math.Round(maksus, 2)} €");
                            return;

                        }
                        else if (valik == "n")
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Peab olema [y/n]");
                        }
                    }

                }
                catch
                {
                    Console.WriteLine("Sisestage number, mitte tekst\nVõi proovige ',' asemel '.'");
                }
            }
        }
        public static void hinnaleidmine()
        {
            Console.WriteLine("Sisesta toote soodushind::");
            double discountPrice = Convert.ToDouble(Console.ReadLine());
            double hind = discountPrice / 0.7;

            Console.WriteLine($"Toote algne hind: {hind:F2}");


        }

        public static void Sisetemperatuur()
        {
            Console.WriteLine("Sisesta temperatuur");
            double temperatuur = Convert.ToDouble(Console.ReadLine());

            if (temperatuur >= 18)
            {
                Console.WriteLine("Temperatuur on nolrmaalne");
            }
            else
            {
                Console.WriteLine("Temperatuur on väga madal");
            }
        }

        public static string pikkus()
        {
            string vastus = "";
            while (true)
            {
                try
                {
                    Console.WriteLine("Sisesta sinu pikkus:");
                    short pikkus = Convert.ToInt16(Console.ReadLine());
                    if (pikkus > 0)
                    {
                        switch (pikkus)
                        {
                            case < 170:
                                Console.WriteLine("Sa oled lühike");
                                break;
                            case < 185:
                                Console.WriteLine("Sa oled keskmne");
                                break;
                            case < 195:
                                Console.WriteLine("Sa oled Pikk");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sa ei saa olla lühikesem kui 0");
                    }
                }
                catch (System.OverflowException)
                {
                    System.Console.WriteLine("Sa oled väga pikk");
                }
            }
            return vastus;
        }

        public static void pikkus2()
        {
            while (true)
            {

                System.Console.Write("Sisestage oma sugu\n[m/n] ");
                Console.WriteLine("Sisesta M et sa oled mees");
                Console.WriteLine("Sisesta N et sa oled naine");

                string sugu = Console.ReadLine();

                if (sugu.ToLower() == "m")
                {
                    while (true)
                    {
                        try
                        {
                            System.Console.Write("Kui pikk te olete: ");
                            short pikkus = Convert.ToInt16(Console.ReadLine());
                            if (pikkus > 0)
                            {
                                switch (pikkus)
                                {
                                    case < 170:
                                        Console.WriteLine("Sa oled lühike");
                                        break;
                                    case < 185:
                                        Console.WriteLine("Sa oled keskmne");
                                        break;
                                    case < 195:
                                        Console.WriteLine("Sa oled Pikk");
                                        break;
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Sa ei saa olla lühikesem kui 0");
                            }
                        }
                        catch (System.OverflowException)
                        {
                            System.Console.WriteLine("Sa oled väga pikk");
                        }
                    }
                }
                else if (sugu.ToLower() == "n")
                {
                    while (true)
                    {
                        try
                        {
                            System.Console.Write("Kui pikk te olete: ");
                            short pikkus = Convert.ToInt16(Console.ReadLine());
                            if (pikkus > 0)
                            {
                                switch (pikkus)
                                {
                                    case < 160:
                                        Console.WriteLine("Sa oled lühike");
                                        break;
                                    case < 175:
                                        Console.WriteLine("Sa oled keskmne");
                                        break;
                                    case 185:
                                        Console.WriteLine("Sa oled Pikk");
                                        break;
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Sa ei saa olla lühikesem kui 0");
                            }
                        }
                        catch (System.OverflowException)
                        {
                            System.Console.WriteLine("Sa oled väga pikk");
                        }
                    }
                }
            }

        }
        public static void Poeostukorv(string[] args)
        {
            double summa = 0;

            double piimHind = 1.20;
            double saiHind = 0.80;
            double leibHind = 1.00;

            Console.Write("Kas soovid osta piima? (jah/ei): ");
            string piim = Console.ReadLine().ToLower();

            if (piim == "jah")
            {
                summa += piimHind;
            }

            Console.Write("Kas soovid osta saia? (jah/ei): ");
            string sai = Console.ReadLine().ToLower();

            if (sai == "jah")
            {
                summa += saiHind;
            }

            Console.Write("Kas soovid osta leiba? (jah/ei): ");
            string leib = Console.ReadLine().ToLower();

            if (leib == "jah")
            {
                summa += leibHind;
            }

            Console.WriteLine("\nOstukorvi kogumaksumus on: " + summa + " eurot");

            Console.ReadLine();
        }
    }
}



    

