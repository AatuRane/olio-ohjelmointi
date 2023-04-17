using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus66
{
    abstract class Eläin
    {
        public int maxIkä;
        public abstract int MaxIkä { get; set; }

        private string nimi;
        public string Nimi { get; set; }


        private int ikä;
        public virtual int Ikä

        {
            get { return ikä; }
            set
            {
                if (value < 5)

                {
                    Console.WriteLine("Annettu ikä on pienempi kuin 5 joten eläimen iäksi on asetettu 0");

                    value = 0;
                }
                else if (value > MaxIkä)

                {

                    Console.WriteLine(Nimi + " Antamasi ikä ylittää 10, joten iäksi laitetaan 0 ", MaxIkä, MaxIkä - 1);
                    value = MaxIkä - 1;

                }

                ikä = value;
            }
        }

        private static int määrä = 0;

        public Eläin()
        {
            määrä++;
        }

        public static void Määrä()

        {
            Console.WriteLine("Eläimiä on yhteensä  " + määrä + " kappaletta");
        }
        public abstract void Ääni();
    }
}