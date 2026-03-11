using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_C
{
    internal class MainPage
    {
        public static void Main(string[] args)
        {
            bool tootab = true;
            ItaaliaFunktsioonid.LaeAndmedFailist();
            while (true)
                Console.WriteLine("Tere tulemast Itaalia restorani");
            Console.WriteLine("1. Laemine anmeid failist ");
            Console.WriteLine("2. Menüü vaatmine ");
            Console.WriteLine("3. Uue toidu lisamine");
            Console.WriteLine("4. Amdmete salvestamine");
            int valik = int.Parse(Console.ReadLine());
            switch (valik)
            {
                case 1:
                    ItaaliaFunktsioonid.LaeAndmedFailist();
                    break;
                case 2:
                    ItaaliaFunktsioonid.ItaaliaRestoran();
                    break;
                case 3:
                    ItaaliaFunktsioonid.LisaUusToit();
                    break;
                case 4:
                    ItaaliaFunktsioonid.SalvestAndmedFaili();
                    break;
                case 5:
                    ItaaliaFunktsioonid.KustutaToit();
                case 6:
                    ItaaliaFunktsioonid.ToiduInformatsioon();
                    break;

            }
        }



    }
}