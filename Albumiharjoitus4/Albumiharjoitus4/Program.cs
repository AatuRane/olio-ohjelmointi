using Tehtävä4;

internal class Program
{
    private static void Main(string[] args)
    {
        Albumi albumi = new Albumi();
        albumi.Artisti = "Eminem";
        albumi.Nimi = "Is this love";
        albumi.Genre = "Rap";
        albumi.Kappalemäärä = 5;
        albumi.Hinta = 5;


        albumi.Kappalelisäys(" From D2 The LBC");


        albumi.Kappalelisäys(" Rap God");


        albumi.Kappalelisäys(" Cinderella man");


        albumi.Kappalelisäys(" The King and I");


        albumi.Kappalelisäys(" Last one standing");

        albumi.albumitulostus();
        albumi.biisitulostus();
    }
}