using System;
using Tehtävä5;

namespace Tehtävä5
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 6.5f;
            float b = 4.8f;

            float summa = Laskin.Summa(a, b);


            float erotus = Laskin.Erotus(a, b);

            float kertolasku = Laskin.Kertolasku(a, b);

            float jakolasku = Laskin.Jakolasku(a, b);

            Console.WriteLine("Numeroiden " + a + " ja " + b);


            Console.WriteLine("Summa: " + summa);

            Console.WriteLine("Erotus: " + erotus);

            Console.WriteLine("Kertolasku: " + kertolasku);

            Console.WriteLine("Jakolasku: " + jakolasku);
        }
    }
}
