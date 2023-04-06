using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olio_esimerkki
{
    class koira
    {
        public string Nimi { get; set; }
        public string Rotu { get; set; }
        public int Ikä { get; set; }
        public string Väri { get; set; }
        public float paino { get; set; }

        //Tällä metodilla noudatetaan olemassa olevevan Koira - olion tiedot

        public string HaeTiedot()
        {
            string KoiranTiedot = "Nimi: " + Nimi + ". Rotu: " + Rotu + ". Ikä: " + Ikä.ToString() + ". Väri: " + Väri + ". Paino: " + paino.ToString();
            return KoiranTiedot;
        }

        //kun tätä kutsutaan, kirjoitetaan konsoliin "woof woof"

        public void Hauku()
        {
            Console.WriteLine("Woof Woof");
        }
    }
}
