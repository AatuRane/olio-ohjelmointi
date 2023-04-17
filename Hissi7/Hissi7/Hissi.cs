using System;
using System.Collections.Generic;
using System.Text;

namespace Hissi7
{
    class Hissi
    {
        private int kerros;

        private int minKerros;
        private int maxKerros;

        public int Kerros
        {
            set
            {
                if (value < minKerros)


                {
                    Console.WriteLine("Tätä kerrosta ei ole. Annettu arvo " + value + " on pienempi kuin " + minKerros);
                }
                else if (value > maxKerros)


                {
                    Console.WriteLine("Tätä kerrosta ei ole. Annettu arvo " + value + " on suurempi kuin " + maxKerros);
                }
                else


                {
                    kerros = value;
                }
            }
        }

        public Hissi(int _minKerros, int _maxKerros)


        {
            minKerros = _minKerros;
            maxKerros = _maxKerros;
        }

        public void TulostaNykyinenKerros()


        {
            Console.WriteLine("Tämän hetkinen kerroksesi " + kerros);
        }

        public string PalautaMinMax()


        {
            return minKerros.ToString() + "-" + maxKerros.ToString();
        }
    }
}

