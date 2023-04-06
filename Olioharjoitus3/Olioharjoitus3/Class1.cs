using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_3
{
    class Kiuas
    {
        public string Nimi { get; set; }
        private bool Tila { get; set; }
        private int Lämpötila { get; set; }
        private int Kosteus { get; set; }


        public void TulostaData()


        {
            Console.WriteLine("Kiukaan tiedot ");

            
            Console.WriteLine("Nimi: " + Nimi);


            Console.WriteLine("Tila: " + NäytäTila());


            Console.WriteLine("Lämpötila: " + Lämpötila + " Celsius");


            Console.WriteLine("Kosteus: " + Kosteus + "%");


            Console.WriteLine();
        }

        public string NäytäTila()


        {
            string nykyinenTila = "Pois Päältä";

            if (Tila == true)
            {
                nykyinenTila = "Päällä";
            }

            return nykyinenTila;
        }

        public void KiuasOnOff(bool a)


        {
            Tila = a;
            Console.Write("Kiuas on nyt " + NäytäTila() + "\n");
        }

        public void MuutaLämpötilaa(int uusLämpötila)
        {
            if (Tila == false)


            {
                Console.WriteLine("Kiuas ei ole päällä, lämpötilaa ei voi muuttaa\n");
                return;
            }

            Lämpötila = uusLämpötila;


            Console.WriteLine("Lämpötila on muutettu. Uusi lämpötila: " + Lämpötila + " celsius\n");
        }

        public void MuutaKosteutta(int uusiKosteus)
        {
            if (Tila == false)

            {
                Console.WriteLine("Kiuas ei ole päällä, kosteutta ei voi muuttaa\n");
                return;
            }
            
               

            Kosteus = uusiKosteus;

            Console.WriteLine("Kosteus muutettu. Uusi kosteus: " + Kosteus + "%\n");
        }
    }
}
