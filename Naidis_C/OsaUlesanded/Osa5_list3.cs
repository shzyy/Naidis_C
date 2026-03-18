using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Naidis_C.OsaUlesanded
{
    internal class Osa5_list3
    {
        public static void list3()
        {
            //List on üldine kogum, mis võimaldab salvestada erinevat tüüpi objekte
            List<Person> people = new List<Person>();
            people.Add(new Person() {Name = "Kadi"});
            people.Add(new Person() {Name = "Mirje"});


            Person lisa = new Person() { Name = "Lisa" };
            foreach (Person p in people)
                Console.WriteLine(p.Name);

          //kustutame Lisa nemiga objekti listi
            people.Remove(Lisa);
            //näitab, et Lisa nimega objekti listis ei olnudki, sest 
            foreach (Person p in people)
                Console.WriteLine(p.Name);
            people.RemoveAT(0);
            people.Insert(0, "Anna-Liis");
            people.Insert(1, "Mari");
            people.Sort();
            foreach (string p in people)
                Console.WriteLine(p);

            people.Sort((a, b) => a.Length.CompareTo(b.Length));
            foreach (string p in people)
                Console.WriteLine(p);
        }
        
    }
}
