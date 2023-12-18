namespace Struct
{
    class Program
    {
        static void Main()
        {
            Bil bil1;
            bil1.Farve = "Blå";
            bil1.Km = 50000;
            bil1.Hk = 150;

            Bil bil2 = new Bil("Rød", 70000, 200);

            Console.WriteLine("Bil 1:");
            bil1.Udskriv();

            Console.WriteLine("\nBil 2:");
            bil2.Udskriv();

            Bil bil3 = bil1;

            bil1.Farve = "Grøn";

            Console.WriteLine("\nEfter ændring af farven på Bil 1:");
            Console.WriteLine("Bil 1:");
            bil1.Udskriv();

            Console.WriteLine("\nBil 3 (kopieret fra Bil 1):");
            bil3.Udskriv();
        }
    }

}
