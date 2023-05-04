using Harjoitus_10;
class Program
{
    static void Main(string[] args)
    {
        Kala ahven = new Kala("ahven", 256, "glup");

        ahven.Swim();
        ahven.MakeASound();


        Sorsa sorsa = new Sorsa("sorsa", 180, 369);

        sorsa.MakeASound();
        sorsa.Swim();
        sorsa.MakeASound();
        sorsa.Fly();
    }
}
