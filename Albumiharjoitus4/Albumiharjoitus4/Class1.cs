using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä4
{
    internal class Albumi
    {
        public string Artisti;
        public string Nimi;
        public string Genre;
        public int Kappalemäärä;
        public int Hinta;

        public List<string> kappale = new List<string>();

        public void Kappalelisäys(string kappaleet)
        {
            kappale.Add(kappaleet);
        }

        public void albumitulostus()
        {
            Console.WriteLine("Albumi:");


            Console.WriteLine("- Artisti: " + Artisti);

            Console.WriteLine("- Albumin nimi: " + Nimi);

            Console.WriteLine("- Genre: " + Genre);

            Console.WriteLine("- Kappaleiden määrä: " + Kappalemäärä);

            Console.WriteLine("- Hinta: " + Hinta + " euroa");
        }

        public void biisitulostus()
        {
            Console.WriteLine("\n--- " + kappale[0] + " 3:34");

            Console.WriteLine("--- " + kappale[1] + " 4:29");

            Console.WriteLine("--- " + kappale[2] + " 6:17");

            Console.WriteLine("--- " + kappale[3] + " 3:33");

            Console.WriteLine("--- " + kappale[4] + " 4:39");
        }

    }
}
