using System;

namespace Harjoitus66
{
    class Program
    {
        static void Main(string[] args)
        {



            Hämähäkki Frank = new Hämähäkki("Frank", 20, "GRRPAW");
            Hämähäkki Castle = new Hämähäkki("Castle", 60, "Shalamalekum");

            Frank.Ääni();
            Castle.Ääni();

            Koira nuf = new Koira("Saksanpaimenkoira", 6);
            Koira truffe = new Koira("Saksanpaimenkoira", 0);

            nuf.Ääni();

            Eläin.Määrä();
            Hämähäkki.Määrä();
            Koira.Määrä();
        }
    }
}