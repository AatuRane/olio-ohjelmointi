using System;

namespace Harjoitus_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas kiuas = new Kiuas();

            kiuas.Nimi = "Harvia";
            kiuas.TulostaData();

            kiuas.KiuasOnOff(true);
            kiuas.NäytäTila();
            kiuas.MuutaLämpötilaa(115);
            kiuas.MuutaKosteutta(25);
            kiuas.TulostaData();

        }
    }
}