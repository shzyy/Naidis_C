using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_C
{
    internal class Osa4
    {
        
            public static void tekstisisestamine()
            {
                try
                {
                    string path = @"/Users/opilane/Desktop/Fail.txt"; //@"..\..\..\Kuud.txt"
                    StreamWriter text = new StreamWriter(path, true); // true = lisa lõppu
                    Console.WriteLine("Sisesta mingi tekst: ");
                    string lause = Console.ReadLine();
                    text.WriteLine(lause);
                    text.Close();
                }
                catch (Exception)
                {
                    Console.WriteLine("Mingi viga failiga");
                }
            }
            public static void Tekstilugemine()
            {
                try
                {
                    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt");
                    StreamReader text = new StreamReader(path);
                    string laused = text.ReadToEnd();
                    text.Close();
                    Console.WriteLine(laused);
                }
                catch (Exception)
                {
                    Console.WriteLine("Mingi viga failiga, ei saa faili lugeda");
                }
            }
            public static void Ridade_lugemine(string file)
            {
                List<string> kuude_list = new List<string>();
                try
                {
                    string path = @$"..\..\..\{file}";
                    ;
                    foreach (string rida in File.ReadAllLines(path))
                    {
                        kuude_list.Add(rida);
                    }
                    foreach (string i in kuude_list) Console.WriteLine(i);
                }
                catch (Exception)
                {
                    Console.WriteLine("Viga failiga");
                }

            }
            public static List<string> Ridade_lugemine_listiks(string file)
            {

                List<string> kuude_list = new List<string>();
                try
                {

                    string path = @$"..\..\..\{file}";
                    foreach (string rida in File.ReadAllLines(path))
                    {
                        kuude_list.Add(rida);

                    }


                }

                catch (Exception)
                {
                    Console.WriteLine("Viga failiga!");
                }
                return kuude_list;


            }
            public static void listi_muutmine(string file)
            {
                List<string> kuude_list = Ridade_lugemine_listiks(file);

                foreach (string kuu in kuude_list)
                {
                    Console.WriteLine(kuu);
                }

                // Eemalda "Juuni"
                kuude_list.Remove("Juuni");

                // Muuda esimest elementi
                if (kuude_list.Count > 0)
                    kuude_list[0] = "Veeel kuuu";

                Console.WriteLine("--------------Kustutasime juuni-----------");

                foreach (string kuu in kuude_list)
                {
                    Console.WriteLine(kuu);
                }
            }
            public static void Otsing(string file)
            {
                List<string> kuude_list = Ridade_lugemine_listiks(file);
                Console.WriteLine("Sisesta kuu nimi, mida otsida:");
                string otsitav = Console.ReadLine();

                if (kuude_list.Contains(otsitav))
                    Console.WriteLine("Kuu " + otsitav + " on olemas.");
                else
                    Console.WriteLine("Sellist kuud pole.");
            }
            public static void Listisalvestamine(string file)
            {
                List<string> kuude_list = Ridade_lugemine_listiks(file);
                string path = @$"..\..\..\{file}";
                File.WriteAllLines(path, kuude_list);
                Console.WriteLine("Andmed on salvestatud.");
            }

        }
}
