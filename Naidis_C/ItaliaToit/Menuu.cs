using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_C
{
    public class Menuu
    {
        public string Nimetus { get; set; }
        public List<string> Koostisosad { get; set; }
        public double Hind { get; set; }
        // Konstruktor, et luua Menuu objekt
        public Menuu(string nimetus, List<string> koostisosad, double hind)
        {
            Nimetus = nimetus;
            Koostisosad = koostisosad;
            Hind = hind;
        }
        // meetod, mis teeb objektist tekstirea
        //Tulemus: "Nimetus;Koostisosad1,Koostisosad2,...;Hind"
        //Näiteks: "Pizza;Tomat,Juust,Peperoni;12.99"
        public string VormidaFailijaokrea()
        {
            string ained = string.Join(",", Koostisosad);
            return $"{Nimetus}; {ained}; {Hind}";
        }
    }
}

