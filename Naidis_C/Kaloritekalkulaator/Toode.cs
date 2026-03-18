using System;
using System.Collections.Generic;
using System.Text;

namespace Kaloritekalkulaator
{
    class Toode
{
    public string Nimi { get; set; }
    public double Kalorid100g { get; set; }

    public Toode(string nimi, double kalorid)
    {
        Nimi = nimi;
        Kalorid100g = kalorid;
    }
}

class Inimene
{
    public string Nimi { get; set; }
    public int Vanus { get; set; }
    public string Sugu { get; set; }
    public double Pikkus { get; set; } // cm
    public double Kaal { get; set; }   // kg
    public double Aktiivsustase { get; set; }

    public double ArvutaBMR()
    {
        if (Sugu.ToLower() == "mees")
        {
            return 88.36 + (13.4 * Kaal) + (4.8 * Pikkus) - (5.7 * Vanus);
        }
        else
        {
            return 447.6 + (9.2 * Kaal) + (3.1 * Pikkus) - (4.3 * Vanus);
        }
    }

    public double PaevaneEnergia()
    {
        return ArvutaBMR() * Aktiivsustase;
    }
}
     
}