using System;

namespace Hissi7
{
    class Program
    {
        static void Main(string[] args)


        {
            Hissi hissi = new Hissi(1, 6);

            int uusiKerros;
            string i;

            Console.WriteLine("Tästä hissistä voit poistua painamalla 'ulos'.");

            while (true)


            {
                Console.WriteLine();
                Console.Write("Anna uusi kerros ({0}) < ", hissi.PalautaMinMax());

                i = Console.ReadLine();

                if (i.Equals("ulos"))
                    break;

                bool tarkistus = int.TryParse(i, out uusiKerros);

                if (tarkistus)


                {
                    hissi.Kerros = uusiKerros;
                }

                else


                {
                    Console.WriteLine("Tätä kerrosta ei ole. ");
                }

                hissi.TulostaNykyinenKerros();


            }

            Console.WriteLine("Poistuit hissistä!");
        }
    }
}