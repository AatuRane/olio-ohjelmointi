using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus66
{
    class Hämähäkki : Eläin
    {
        private string Hämähäkinääni { get; set; }

        public override int MaxIkä { get => maxIkä; set => maxIkä = value; }



        private static int määrä = 0;

        public Hämähäkki(string _nimi, int _ikä, string _ääni)


        {
            MaxIkä = 20;

            Nimi = _nimi;
            Ikä = _ikä;
            Hämähäkinääni = _ääni;

            määrä++;

            Console.WriteLine("Hämähäkin luotu nimi: " + Nimi);
        }

        public static new void Määrä()


        {
            Console.WriteLine("Hämähäkkeja on  " + määrä + " kappaletta");
        }

        public override void Ääni()


        {
            Console.WriteLine(Nimi + " sanoo: " + Hämähäkinääni);
        }
    }
}
