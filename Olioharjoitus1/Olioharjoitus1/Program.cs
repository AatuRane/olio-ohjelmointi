﻿using Harjoitus1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Program
{
    private static void Main(string[] args)
    {
        Ajoneuvo Ajo = new Ajoneuvo();

        Ajo.nimi = "Ferrari F430";
        Ajo.nopeus = 350;
        Ajo.renkaat = 4;

        Console.WriteLine(Ajo.TulostaData());
    }
}
